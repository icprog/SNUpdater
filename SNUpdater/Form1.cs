using Microsoft.Win32;
using SharpCompress.Archives;
using SharpCompress.Common;
using Syroot.Windows.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace SNUpdater
{
    public partial class Form1 : Form
    {
        string ReadBatch = "R.bat";
        string SNBatch = "S.bat";
        string quotes = string.Empty;
        string SN = string.Empty;
        string WriteOnce = "ERR_DMI_READ_ONLY";
        bool WriteProtect = false;
        HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
        }

        public void Error(object msg)
        {
            Trace.WriteLine(msg);
            Debug.WriteLine(msg);
            MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Environment.Exit(0);
        }

        public void Uncompress(string FileName, string WritePath)
        {
            try
            {
                var archive = ArchiveFactory.Open(FileName);

                foreach (var entry in archive.Entries)
                {
                    if (!entry.IsDirectory)
                    {
                        Trace.WriteLine("unzip: " + entry.Key);
                        entry.WriteToDirectory(WritePath, new ExtractionOptions() { ExtractFullPath = true, Overwrite = true });
                    }
                }
                archive.Dispose();
            }
            catch (Exception ex)
            {
                Error(ex);
            }
        }

        public List<string> FindFilePath(string directory, string FileName)
        {
            List<string> FilePath = null;
            try
            {
                FilePath = Directory.GetFiles(directory, FileName, SearchOption.AllDirectories).ToList();
            }
            catch (Exception ex)
            {
                Error(ex);
            }
            return FilePath;
        }

        public void Extract()
        {
            foreach (var v in FindFilePath(KnownFolders.Downloads.DefaultPath, "*.zip"))
            {
                Uncompress(v, KnownFolders.Downloads.DefaultPath);
            }
        }

        protected void ReadSN(string path)
        {
            try
            {
                using (var p = new Process())
                {
                    Trace.WriteLine(path);
                    p.StartInfo.FileName = path;
                    p.StartInfo.WorkingDirectory = Path.GetDirectoryName(path);
                    p.StartInfo.CreateNoWindow = true;
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.RedirectStandardInput = true;
                    p.StartInfo.RedirectStandardOutput = true;
                    p.StartInfo.RedirectStandardError = true;
                    p.Start();

                    var output = p.StandardOutput.ReadToEnd();
                    p.WaitForExit();

                    if (WriteProtect)
                        return;

                    string[] lines = output.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

                    foreach (var v in lines)
                    {
                        if (Regex.IsMatch(v, @"^\(/SS\)"))
                        {
                            var match = Regex.Match(v, "\"\\w*\"");
                            if (match.Success)
                            {
                                quotes = match.Value;
                                SN = quotes.Replace("\"", "");
                            }

                            Trace.WriteLine("SN: " + SN);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Error(ex);
            }
        }

        protected void WriteSN(string path,string sn)
        {
            try
            {
                using (var p = new Process())
                {
                    Trace.WriteLine(path);
                    p.StartInfo.FileName = path;
                    p.StartInfo.WorkingDirectory = Path.GetDirectoryName(path);
                    p.StartInfo.CreateNoWindow = true;
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.RedirectStandardInput = true;
                    p.StartInfo.RedirectStandardOutput = true;
                    p.StartInfo.RedirectStandardError = true;
                    p.Start();

                    using (var sw = new StreamWriter(p.StandardInput.BaseStream))
                    {
                        var command = sn;
                        sw.WriteLine(command);
                        // etc..                   
                    }

                    var output = p.StandardOutput.ReadToEnd();
                    p.WaitForExit();

                    if (output.Contains(WriteOnce))
                        WriteProtect = true;
                }
            }
            catch (Exception ex)
            {
                Error(ex);
            }
        }

        private void buttonWriteSN_Click(object sender, EventArgs e)
        {
            Extract();
            var FilePath = FindFilePath(KnownFolders.Downloads.DefaultPath, ReadBatch);
            if (!FilePath.Any())
                throw new Exception("SMBIOS tool not found");

            var folder = Path.GetDirectoryName(FilePath.FirstOrDefault());
            Trace.WriteLine(folder);
            var input = textBoxSN.Text;
            WriteSN(Path.Combine(folder, SNBatch), input);
            Thread.Sleep(1000);
            ReadSN(Path.Combine(folder, ReadBatch));

            if (string.Equals(input, SN))
            {
                labelResult.Visible = true;
                labelResult.Text = "Write Serial Number Success";
                labelResult.ForeColor = Color.Green;
            }
            else if (WriteProtect)
            {
                labelResult.Visible = true;
                labelResult.Text = "Write Serial Number FAIL";
                labelResult.ForeColor = Color.Red;
                labelFail.Visible = true;
                labelFail.Text = "Reach write limit, please update BIOS";
                return;
            }
            else
            {
                labelResult.Visible = true;
                labelResult.Text = "Write Serial Number FAIL";
                labelResult.ForeColor = Color.Red;
                return;
            }

            var task = client.GetStringAsync(string.Format("http://www1.winmate/PLMS/TestProgram/BurnIn_Chk.asp?LSN={0}&SN={1}", textBoxLSN.Text, SN));
            var ReturnString = task.Result;
            Trace.WriteLine(ReturnString);
            //if (!string.Equals(ReturnString, "PASS"))
            //{
            //    labelResult.Visible = true;
            //    labelResult.Text = "Online Check FAIL";
            //    labelResult.ForeColor = Color.Red;
            //}
        }

        void Reset()
        {
            labelFail.Text = string.Empty;
            labelResult.Text = string.Empty;
            textBoxSN.Text = string.Empty;
            SN = string.Empty;
            WriteProtect = false;
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            Reset();
            Thread.Sleep(500);
            buttonRun.Enabled = false;
            try
            {
                var task = client.GetStringAsync(string.Format("http://www1.winmate/PLMS/TestProgram/getSN.asp?LSN={0}&EmpId=we0570", textBoxLSN.Text));
                var ReturnString = task.Result;

                if (string.Equals(ReturnString, "LSN not exists!"))
                {
                    labelFail.Text = "LSN not exists!";
                    labelFail.Visible = true;
                    return;
                }

                var index = ReturnString.IndexOf('>');
                textBoxSN.Text = ReturnString.Substring(index + 1, 12);
                buttonWriteSN_Click(null, null);
                
            }
            catch(Exception ex)
            {
                Error(ex);
            }
            finally
            {
                buttonRun.Enabled = true;
            }
        }

        private void buttonRun_EnabledChanged(object sender, EventArgs e)
        {
                textBoxLSN.Enabled = buttonRun.Enabled;
        }
    }
}
