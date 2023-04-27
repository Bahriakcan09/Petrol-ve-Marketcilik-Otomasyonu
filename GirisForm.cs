using Firebase.Auth.Providers;
using Firebase.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petrol_ve_Marketcilik_Otomasyonu
{
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        private async void LoginBtn_Click(object sender, EventArgs e)
        {
            if (!internetKontrol.internet())
            {
                MessageBox.Show("Internet Baglantısı Yok.");
                return;
            };
            bool login = await loginAsync();
            if (login)
            {
                GenelForm genelForm = new GenelForm();
                genelForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giris Basarisiz");
            }
        }

        private async Task<bool> loginAsync()
        {
            object userCredential;
            var config = new FirebaseAuthConfig
            {
                ApiKey = "AIzaSyBPP5gvm8JvBT43dAsqUYlOXxy_GUcMyAU",
                AuthDomain = "petrol-ve-marketcilik.firebaseapp.com",
                Providers = new FirebaseAuthProvider[]
                {
                    new GoogleProvider().AddScopes("email"),
                    new EmailProvider()

                },
            };

            var client = new FirebaseAuthClient(config);
            try
            {
                userCredential = await client.SignInWithEmailAndPasswordAsync(usernameTxt.Text, passwordTxt.Text);
            }
            catch (Exception)
            {
                return false;
            }
            return userCredential != null;

        }

    }
}
