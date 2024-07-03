namespace OtpAuthApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnValidateOtp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSetup = new System.Windows.Forms.Button();
            this.edtSecretKey = new System.Windows.Forms.TextBox();
            this.edtUserTitle = new System.Windows.Forms.TextBox();
            this.edtIssuer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edtOTP = new System.Windows.Forms.TextBox();
            this.picQRCode = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.edtLog = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnValidateOtp);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.edtOTP);
            this.splitContainer1.Panel1.Controls.Add(this.picQRCode);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.edtLog);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 277;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnValidateOtp
            // 
            this.btnValidateOtp.Location = new System.Drawing.Point(500, 217);
            this.btnValidateOtp.Name = "btnValidateOtp";
            this.btnValidateOtp.Size = new System.Drawing.Size(120, 32);
            this.btnValidateOtp.TabIndex = 5;
            this.btnValidateOtp.Text = "Validate OTP";
            this.btnValidateOtp.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSetup);
            this.groupBox1.Controls.Add(this.edtSecretKey);
            this.groupBox1.Controls.Add(this.edtUserTitle);
            this.groupBox1.Controls.Add(this.edtIssuer);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(331, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 166);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setup";
            // 
            // btnSetup
            // 
            this.btnSetup.Location = new System.Drawing.Point(169, 114);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(120, 32);
            this.btnSetup.TabIndex = 6;
            this.btnSetup.Text = "Setup";
            this.btnSetup.UseVisualStyleBackColor = true;
            // 
            // edtSecretKey
            // 
            this.edtSecretKey.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtSecretKey.Location = new System.Drawing.Point(83, 71);
            this.edtSecretKey.Name = "edtSecretKey";
            this.edtSecretKey.ReadOnly = true;
            this.edtSecretKey.Size = new System.Drawing.Size(326, 20);
            this.edtSecretKey.TabIndex = 5;
            // 
            // edtUserTitle
            // 
            this.edtUserTitle.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtUserTitle.Location = new System.Drawing.Point(83, 45);
            this.edtUserTitle.Name = "edtUserTitle";
            this.edtUserTitle.Size = new System.Drawing.Size(326, 20);
            this.edtUserTitle.TabIndex = 4;
            // 
            // edtIssuer
            // 
            this.edtIssuer.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtIssuer.Location = new System.Drawing.Point(83, 19);
            this.edtIssuer.Name = "edtIssuer";
            this.edtIssuer.Size = new System.Drawing.Size(326, 20);
            this.edtIssuer.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Secret Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "User Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Issuer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "OTP";
            // 
            // edtOTP
            // 
            this.edtOTP.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.edtOTP.Location = new System.Drawing.Point(359, 215);
            this.edtOTP.Name = "edtOTP";
            this.edtOTP.Size = new System.Drawing.Size(100, 32);
            this.edtOTP.TabIndex = 2;
            // 
            // picQRCode
            // 
            this.picQRCode.Location = new System.Drawing.Point(34, 47);
            this.picQRCode.Name = "picQRCode";
            this.picQRCode.Size = new System.Drawing.Size(247, 215);
            this.picQRCode.TabIndex = 1;
            this.picQRCode.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please open your favorite Authenticator application in your cell phone and scan t" +
    "he following QRCode image.";
            // 
            // edtLog
            // 
            this.edtLog.BackColor = System.Drawing.Color.WhiteSmoke;
            this.edtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edtLog.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtLog.Location = new System.Drawing.Point(0, 0);
            this.edtLog.Name = "edtLog";
            this.edtLog.ReadOnly = true;
            this.edtLog.Size = new System.Drawing.Size(800, 169);
            this.edtLog.TabIndex = 0;
            this.edtLog.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time-based One-Time-Password (TOTP) Authentication";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox edtLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtOTP;
        private System.Windows.Forms.PictureBox picQRCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox edtSecretKey;
        private System.Windows.Forms.TextBox edtUserTitle;
        private System.Windows.Forms.TextBox edtIssuer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnValidateOtp;
        private System.Windows.Forms.Button btnSetup;
    }
}

