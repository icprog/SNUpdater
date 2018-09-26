namespace SNUpdater
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelSN = new System.Windows.Forms.Label();
            this.textBoxSN = new System.Windows.Forms.TextBox();
            this.buttonWriteSN = new System.Windows.Forms.Button();
            this.groupBoxSN = new System.Windows.Forms.GroupBox();
            this.labelFail = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxAlarm = new System.Windows.Forms.GroupBox();
            this.labelLSN = new System.Windows.Forms.Label();
            this.textBoxLSN = new System.Windows.Forms.TextBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.groupBoxLSN = new System.Windows.Forms.GroupBox();
            this.groupBoxSN.SuspendLayout();
            this.groupBoxAlarm.SuspendLayout();
            this.groupBoxLSN.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSN
            // 
            this.labelSN.AutoSize = true;
            this.labelSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelSN.Location = new System.Drawing.Point(171, 33);
            this.labelSN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSN.Name = "labelSN";
            this.labelSN.Size = new System.Drawing.Size(57, 36);
            this.labelSN.TabIndex = 6;
            this.labelSN.Text = "SN";
            // 
            // textBoxSN
            // 
            this.textBoxSN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxSN.Enabled = false;
            this.textBoxSN.Font = new System.Drawing.Font("Arial", 18F);
            this.textBoxSN.Location = new System.Drawing.Point(241, 32);
            this.textBoxSN.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSN.Name = "textBoxSN";
            this.textBoxSN.Size = new System.Drawing.Size(275, 42);
            this.textBoxSN.TabIndex = 3;
            // 
            // buttonWriteSN
            // 
            this.buttonWriteSN.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.buttonWriteSN.Location = new System.Drawing.Point(541, 20);
            this.buttonWriteSN.Margin = new System.Windows.Forms.Padding(4);
            this.buttonWriteSN.Name = "buttonWriteSN";
            this.buttonWriteSN.Size = new System.Drawing.Size(200, 67);
            this.buttonWriteSN.TabIndex = 6;
            this.buttonWriteSN.Text = "Write";
            this.buttonWriteSN.UseVisualStyleBackColor = true;
            this.buttonWriteSN.Visible = false;
            this.buttonWriteSN.Click += new System.EventHandler(this.buttonWriteSN_Click);
            // 
            // groupBoxSN
            // 
            this.groupBoxSN.Controls.Add(this.labelSN);
            this.groupBoxSN.Controls.Add(this.textBoxSN);
            this.groupBoxSN.Controls.Add(this.buttonWriteSN);
            this.groupBoxSN.Font = new System.Drawing.Font("Arial", 14F);
            this.groupBoxSN.Location = new System.Drawing.Point(97, 153);
            this.groupBoxSN.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxSN.Name = "groupBoxSN";
            this.groupBoxSN.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxSN.Size = new System.Drawing.Size(747, 93);
            this.groupBoxSN.TabIndex = 153;
            this.groupBoxSN.TabStop = false;
            this.groupBoxSN.Text = "Serial Number";
            // 
            // labelFail
            // 
            this.labelFail.AutoSize = true;
            this.labelFail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFail.ForeColor = System.Drawing.Color.Red;
            this.labelFail.Location = new System.Drawing.Point(5, 85);
            this.labelFail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFail.Name = "labelFail";
            this.labelFail.Size = new System.Drawing.Size(549, 36);
            this.labelFail.TabIndex = 11;
            this.labelFail.Text = "Reach write limit, please update BIOS";
            this.labelFail.Visible = false;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.ForeColor = System.Drawing.Color.Green;
            this.labelResult.Location = new System.Drawing.Point(5, 39);
            this.labelResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(430, 36);
            this.labelResult.TabIndex = 9;
            this.labelResult.Text = "Write Serial Number Success";
            this.labelResult.Visible = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 28F);
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTitle.Location = new System.Drawing.Point(155, -87);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(321, 53);
            this.labelTitle.TabIndex = 159;
            this.labelTitle.Text = "Serial Number";
            // 
            // groupBoxAlarm
            // 
            this.groupBoxAlarm.Controls.Add(this.labelFail);
            this.groupBoxAlarm.Controls.Add(this.labelResult);
            this.groupBoxAlarm.Font = new System.Drawing.Font("Arial", 14F);
            this.groupBoxAlarm.Location = new System.Drawing.Point(97, 274);
            this.groupBoxAlarm.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxAlarm.Name = "groupBoxAlarm";
            this.groupBoxAlarm.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxAlarm.Size = new System.Drawing.Size(747, 147);
            this.groupBoxAlarm.TabIndex = 158;
            this.groupBoxAlarm.TabStop = false;
            this.groupBoxAlarm.Text = "Result";
            // 
            // labelLSN
            // 
            this.labelLSN.AutoSize = true;
            this.labelLSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelLSN.Location = new System.Drawing.Point(152, 33);
            this.labelLSN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLSN.Name = "labelLSN";
            this.labelLSN.Size = new System.Drawing.Size(74, 36);
            this.labelLSN.TabIndex = 6;
            this.labelLSN.Text = "LSN";
            // 
            // textBoxLSN
            // 
            this.textBoxLSN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxLSN.Font = new System.Drawing.Font("Arial", 18F);
            this.textBoxLSN.Location = new System.Drawing.Point(241, 32);
            this.textBoxLSN.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLSN.Name = "textBoxLSN";
            this.textBoxLSN.Size = new System.Drawing.Size(275, 42);
            this.textBoxLSN.TabIndex = 1;
            // 
            // buttonRun
            // 
            this.buttonRun.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.buttonRun.Location = new System.Drawing.Point(541, 20);
            this.buttonRun.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(200, 67);
            this.buttonRun.TabIndex = 4;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.EnabledChanged += new System.EventHandler(this.buttonRun_EnabledChanged);
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // groupBoxLSN
            // 
            this.groupBoxLSN.Controls.Add(this.labelLSN);
            this.groupBoxLSN.Controls.Add(this.textBoxLSN);
            this.groupBoxLSN.Controls.Add(this.buttonRun);
            this.groupBoxLSN.Font = new System.Drawing.Font("Arial", 14F);
            this.groupBoxLSN.Location = new System.Drawing.Point(97, 25);
            this.groupBoxLSN.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxLSN.Name = "groupBoxLSN";
            this.groupBoxLSN.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxLSN.Size = new System.Drawing.Size(747, 93);
            this.groupBoxLSN.TabIndex = 151;
            this.groupBoxLSN.TabStop = false;
            this.groupBoxLSN.Text = "LSN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 489);
            this.Controls.Add(this.groupBoxSN);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.groupBoxAlarm);
            this.Controls.Add(this.groupBoxLSN);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.groupBoxSN.ResumeLayout(false);
            this.groupBoxSN.PerformLayout();
            this.groupBoxAlarm.ResumeLayout(false);
            this.groupBoxAlarm.PerformLayout();
            this.groupBoxLSN.ResumeLayout(false);
            this.groupBoxLSN.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelSN;
        public System.Windows.Forms.TextBox textBoxSN;
        public System.Windows.Forms.Button buttonWriteSN;
        private System.Windows.Forms.GroupBox groupBoxSN;
        private System.Windows.Forms.Label labelFail;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBoxAlarm;
        private System.Windows.Forms.Label labelLSN;
        public System.Windows.Forms.TextBox textBoxLSN;
        public System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.GroupBox groupBoxLSN;
    }
}

