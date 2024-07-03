using Google.Authenticator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtpAuthApp
{

 
    public partial class MainForm : Form
    {
        readonly string SIssuer = "OtpTestApp";
        readonly string SUserTitle = Totp.Normalize("developer");
        readonly string SUserSecretKey = Totp.Normalize("A5BE90E5-C46B-4CD7-9504-9C4272058F18"); 
 
        /* event handlers */
        void AnyClick(object sender, EventArgs e)
        {
            if (btnSetup == sender)
            {
                Setup();
            }
            else if (btnValidateOtp == sender)
            {
                ValidateOtp();
            }
        }
        void edtOTP_TextChanged(object sender, EventArgs e)
        {
            ValidateOtp();
        }

        /* private */
        void FormInitialize()
        {
            btnSetup.Click += AnyClick;
            btnValidateOtp.Click += AnyClick;

            edtOTP.TextChanged += edtOTP_TextChanged;

            edtIssuer.Text = SIssuer;
            edtUserTitle.Text = SUserTitle;
            edtSecretKey.Text = SUserSecretKey;

            Setup();
        }
        void Setup()
        {
            string Issuer = edtIssuer.Text;
            string UserTitle = Totp.Normalize(edtUserTitle.Text.Trim());
            string SecretKey = Totp.Normalize(edtSecretKey.Text.Trim());

            SetupCode Setup = Totp.CreateSetup(Issuer, UserTitle, SecretKey);
            picQRCode.Image = Setup.QrAsImage();

            StringBuilder SB = new StringBuilder();
            SB.AppendLine($"Issuer: {Issuer}");
            SB.AppendLine($"User: {UserTitle}");
            SB.AppendLine($"Secret Key: {SecretKey}");
            SB.AppendLine($"Encoded Key: {Setup.ManualEntryKey}");

            AppendLine(SB.ToString());
        }
        void ValidateOtp()
        {
            string sOTP = edtOTP.Text.Trim();
            int OTP;
            if (!string.IsNullOrWhiteSpace(sOTP) && sOTP.Length == 6 && int.TryParse(sOTP, out OTP))
            {
                string SecretKey = Totp.Normalize(edtSecretKey.Text.Trim());

                bool Flag = Totp.ValidateOtp(SecretKey, sOTP);

                if (Flag)
                    AppendLine($"Validation succeeded: {sOTP}");
                else
                    AppendLine($"Validation FAILED: {sOTP}");

                edtOTP.Clear();
            }
        }

        void AppendLine(string Text)
        {
            if (!string.IsNullOrWhiteSpace(Text))
            {
                Text = Text.Trim();
                edtLog.AppendText(Text + Environment.NewLine + Environment.NewLine); 
                edtLog.ScrollToCaret();
            }
        }

        /* overrides */
        protected override void OnShown(EventArgs e)
        {
            if (!DesignMode)
                FormInitialize();
            base.OnShown(e);
        }
 
        /* construction */
        public MainForm()
        {
            InitializeComponent();
        }
    }
}
