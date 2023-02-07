namespace Chat_Avenue
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtxtLog = new System.Windows.Forms.RichTextBox();
            this.lblFiles = new System.Windows.Forms.Label();
            this.lblAcc = new System.Windows.Forms.Label();
            this.lblProx = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblChan = new System.Windows.Forms.Label();
            this.chAdult = new System.Windows.Forms.CheckBox();
            this.chSex = new System.Windows.Forms.CheckBox();
            this.chGeneral = new System.Windows.Forms.CheckBox();
            this.chDating = new System.Windows.Forms.CheckBox();
            this.chSingle = new System.Windows.Forms.CheckBox();
            this.chCollege = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.btnDir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxtLog
            // 
            this.rtxtLog.BackColor = System.Drawing.Color.Black;
            this.rtxtLog.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtxtLog.ForeColor = System.Drawing.Color.Lime;
            this.rtxtLog.Location = new System.Drawing.Point(10, 10);
            this.rtxtLog.Name = "rtxtLog";
            this.rtxtLog.Size = new System.Drawing.Size(500, 255);
            this.rtxtLog.TabIndex = 0;
            this.rtxtLog.Text = "";
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblFiles.ForeColor = System.Drawing.Color.Black;
            this.lblFiles.Location = new System.Drawing.Point(525, 10);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(109, 14);
            this.lblFiles.TabIndex = 1;
            this.lblFiles.Text = "Uploaded Files:";
            // 
            // lblAcc
            // 
            this.lblAcc.AutoSize = true;
            this.lblAcc.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAcc.ForeColor = System.Drawing.Color.Red;
            this.lblAcc.Location = new System.Drawing.Point(530, 35);
            this.lblAcc.Name = "lblAcc";
            this.lblAcc.Size = new System.Drawing.Size(63, 14);
            this.lblAcc.TabIndex = 2;
            this.lblAcc.Text = "Accounts";
            // 
            // lblProx
            // 
            this.lblProx.AutoSize = true;
            this.lblProx.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProx.ForeColor = System.Drawing.Color.Red;
            this.lblProx.Location = new System.Drawing.Point(530, 55);
            this.lblProx.Name = "lblProx";
            this.lblProx.Size = new System.Drawing.Size(53, 14);
            this.lblProx.TabIndex = 3;
            this.lblProx.Text = "Proxies";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(525, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 2);
            this.panel1.TabIndex = 7;
            // 
            // lblChan
            // 
            this.lblChan.AutoSize = true;
            this.lblChan.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblChan.ForeColor = System.Drawing.Color.Black;
            this.lblChan.Location = new System.Drawing.Point(525, 95);
            this.lblChan.Name = "lblChan";
            this.lblChan.Size = new System.Drawing.Size(75, 14);
            this.lblChan.TabIndex = 8;
            this.lblChan.Text = "Channels:";
            // 
            // chAdult
            // 
            this.chAdult.AutoSize = true;
            this.chAdult.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chAdult.ForeColor = System.Drawing.Color.Red;
            this.chAdult.Location = new System.Drawing.Point(530, 120);
            this.chAdult.Name = "chAdult";
            this.chAdult.Size = new System.Drawing.Size(92, 18);
            this.chAdult.TabIndex = 9;
            this.chAdult.Text = "Adult Chat";
            this.chAdult.UseVisualStyleBackColor = true;
            this.chAdult.CheckedChanged += new System.EventHandler(this.chAdult_CheckedChanged);
            // 
            // chSex
            // 
            this.chSex.AutoSize = true;
            this.chSex.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chSex.ForeColor = System.Drawing.Color.Red;
            this.chSex.Location = new System.Drawing.Point(635, 170);
            this.chSex.Name = "chSex";
            this.chSex.Size = new System.Drawing.Size(49, 18);
            this.chSex.TabIndex = 10;
            this.chSex.Text = "Sex";
            this.chSex.UseVisualStyleBackColor = true;
            this.chSex.CheckedChanged += new System.EventHandler(this.chSex_CheckedChanged);
            // 
            // chGeneral
            // 
            this.chGeneral.AutoSize = true;
            this.chGeneral.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chGeneral.ForeColor = System.Drawing.Color.Red;
            this.chGeneral.Location = new System.Drawing.Point(635, 145);
            this.chGeneral.Name = "chGeneral";
            this.chGeneral.Size = new System.Drawing.Size(75, 18);
            this.chGeneral.TabIndex = 11;
            this.chGeneral.Text = "General";
            this.chGeneral.UseVisualStyleBackColor = true;
            this.chGeneral.CheckedChanged += new System.EventHandler(this.chGeneral_CheckedChanged);
            // 
            // chDating
            // 
            this.chDating.AutoSize = true;
            this.chDating.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chDating.ForeColor = System.Drawing.Color.Red;
            this.chDating.Location = new System.Drawing.Point(635, 120);
            this.chDating.Name = "chDating";
            this.chDating.Size = new System.Drawing.Size(67, 18);
            this.chDating.TabIndex = 12;
            this.chDating.Text = "Dating";
            this.chDating.UseVisualStyleBackColor = true;
            this.chDating.CheckedChanged += new System.EventHandler(this.chDating_CheckedChanged);
            // 
            // chSingle
            // 
            this.chSingle.AutoSize = true;
            this.chSingle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chSingle.ForeColor = System.Drawing.Color.Red;
            this.chSingle.Location = new System.Drawing.Point(530, 170);
            this.chSingle.Name = "chSingle";
            this.chSingle.Size = new System.Drawing.Size(64, 18);
            this.chSingle.TabIndex = 13;
            this.chSingle.Text = "Single";
            this.chSingle.UseVisualStyleBackColor = true;
            this.chSingle.CheckedChanged += new System.EventHandler(this.chSingle_CheckedChanged);
            // 
            // chCollege
            // 
            this.chCollege.AutoSize = true;
            this.chCollege.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chCollege.ForeColor = System.Drawing.Color.Red;
            this.chCollege.Location = new System.Drawing.Point(530, 145);
            this.chCollege.Name = "chCollege";
            this.chCollege.Size = new System.Drawing.Size(73, 18);
            this.chCollege.TabIndex = 14;
            this.chCollege.Text = "College";
            this.chCollege.UseVisualStyleBackColor = true;
            this.chCollege.CheckedChanged += new System.EventHandler(this.chCollege_CheckedChanged);
            // 
            // btnStart
            // 
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStart.Location = new System.Drawing.Point(525, 210);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(90, 35);
            this.btnStart.TabIndex = 15;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStop.Location = new System.Drawing.Point(625, 210);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(90, 35);
            this.btnStop.TabIndex = 16;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(525, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 2);
            this.panel2.TabIndex = 8;
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(10, 275);
            this.txtDir.Name = "txtDir";
            this.txtDir.PlaceholderText = "Choose strDir...";
            this.txtDir.ReadOnly = true;
            this.txtDir.Size = new System.Drawing.Size(420, 23);
            this.txtDir.TabIndex = 17;
            // 
            // btnDir
            // 
            this.btnDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDir.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDir.Location = new System.Drawing.Point(440, 275);
            this.btnDir.Name = "btnDir";
            this.btnDir.Size = new System.Drawing.Size(70, 23);
            this.btnDir.TabIndex = 18;
            this.btnDir.Text = "Directory";
            this.btnDir.UseVisualStyleBackColor = true;
            this.btnDir.Click += new System.EventHandler(this.btnDir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(726, 306);
            this.Controls.Add(this.btnDir);
            this.Controls.Add(this.txtDir);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.chCollege);
            this.Controls.Add(this.chSingle);
            this.Controls.Add(this.chDating);
            this.Controls.Add(this.chGeneral);
            this.Controls.Add(this.chSex);
            this.Controls.Add(this.chAdult);
            this.Controls.Add(this.lblChan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblProx);
            this.Controls.Add(this.lblAcc);
            this.Controls.Add(this.lblFiles);
            this.Controls.Add(this.rtxtLog);
            this.Name = "Form1";
            this.Text = "Chat Avenue";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblFiles;
        private Label lblAcc;
        private Label lblProx;
        private Panel panel1;
        private Label lblChan;
        private CheckBox chAdult;
        private CheckBox chSex;
        private CheckBox chGeneral;
        private CheckBox chDating;
        private CheckBox chSingle;
        private CheckBox chCollege;
        private Button btnStart;
        private Button btnStop;
        private Panel panel2;
        private TextBox txtDir;
        private Button btnDir;
        public RichTextBox rtxtLog;
    }
}