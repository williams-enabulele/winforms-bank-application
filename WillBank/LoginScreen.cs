using System.Windows.Forms;
using WillBank.Core;

namespace WillBank
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void SideLogo_Click(object sender, System.EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            RegisterScreen registerScreen = new RegisterScreen();
            registerScreen.Show();
            this.Hide();

        }

        private void txtEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Shared.Validations.IsValidEmail(txtEmail.Text) == false)
            {
                e.Cancel = true;
                txtEmail.Focus();
                errorProvider1.SetError(txtEmail, "Email not correct");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmail, "");
            }
        }

        private void txtPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Shared.Validations.IsValidPassword(txtPassword.Text) == false)
            {
                e.Cancel = true;
                txtPassword.Focus();
                errorProvider1.SetError(txtPassword, "Password must not correct");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPassword, "");
            }
        }

        private void btnMainLogin_Click(object sender, System.EventArgs e)
        {
            AuthenticationRepository authenticationRepository = new AuthenticationRepository();
            var result = authenticationRepository.Login(txtEmail.Text, txtPassword.Text);

            if (result == true)
            {
                UserBackEnd userBackEnd = new UserBackEnd();
                userBackEnd.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login failed, try again!");
            }
        }
    }
}
