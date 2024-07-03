using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Google.Authenticator;
using QRCoder;

namespace OtpAuthApp
{
    static public class Totp
    {
        static TwoFactorAuthenticator TFA = new TwoFactorAuthenticator();

        /* public */
        static public string Normalize(string Text)
        {
            if (!string.IsNullOrWhiteSpace(Text))
            {
                Text = Text.Trim();
                Text = Text.Replace("-", "");
                Text = Text.Replace(" ", "");
            }

            return Text;
        }
        static public SetupCode CreateSetup(string Issuer, string UserTitle, string UserSecretKey)
        {
            if (string.IsNullOrWhiteSpace(Issuer) && string.IsNullOrWhiteSpace(UserTitle) && string.IsNullOrWhiteSpace(UserSecretKey))
                throw new ApplicationException("Cannot create OTP Setup with null or empty values");

            UserTitle = Totp.Normalize(UserTitle);
            UserSecretKey = Totp.Normalize(UserSecretKey);
            return TFA.GenerateSetupCode(Issuer, UserTitle, UserSecretKey, false, 3);
        }
        static public bool ValidateOtp(string UserSecretKey, string OTP)
        {
            UserSecretKey = Totp.Normalize(UserSecretKey);
            return TFA.ValidateTwoFactorPIN(UserSecretKey, OTP, false);
        }

        /* public - helpers */
        static public string QrAsDataUrl(this SetupCode Setup)
        {
            return Setup.QrCodeSetupImageUrl;
        }
        static public string QrAsBase64(this SetupCode Setup)
        {
            return Setup.QrCodeSetupImageUrl.Replace("data:image/png;base64,", "");
        }
        static public Image QrAsImage(this SetupCode Setup)
        {
            string Base64 = Setup.QrCodeSetupImageUrl.Replace("data:image/png;base64,", "");
            using (MemoryStream MS = new MemoryStream(Convert.FromBase64String(Base64)))
                return Image.FromStream(MS);
        }
    }
    
}
