using System;
using System.ComponentModel;
using System.Windows.Forms;
using WillBank.Core;
using WillBank.Model;

namespace WillBank
{
    public partial class RegisterScreen : Form
    {
        public RegisterScreen()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {


            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                User user = new User();
                UserProfile userProfile = new UserProfile();
                UserRepository userRepository = new UserRepository();

                user.Email = txtEmail.Text;
                userProfile.FirstName = txtFirstName.Text;
                userProfile.LastName = txtLastName.Text;
                userProfile.Email = txtEmail.Text;
                bool result = userRepository.RegisterCustomer(user, userProfile, txtPassword.Text);
                if (result == true)
                {
                    MessageBox.Show("Successfully registered, login");
                    LoginScreen loginScreen = new LoginScreen();
                    loginScreen.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Email already registered, use another!");
                }
               

            }
            else
            {
                MessageBox.Show("Oops! something went wrong");
            }


        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (Shared.Validations.IsValidText(txtFirstName.Text) == false)
            {
                e.Cancel = true;
                txtFirstName.Focus();
                errorProvider1.SetError(txtFirstName, "First Name should not be left blank and must not contain special characters and numbers!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFirstName, "");
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (Shared.Validations.IsValidText(txtLastName.Text) == false)
            {
                e.Cancel = true;
                txtLastName.Focus();
                errorProvider1.SetError(txtLastName, "First Name should not be left blank and must not contain special characters and numbers!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtLastName, "");
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (Shared.Validations.IsValidEmail(txtEmail.Text) == false)
            {
                e.Cancel = true;
                txtEmail.Focus();
                errorProvider1.SetError(txtEmail, "Email not in the correct format");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmail, "");
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {

            if (Shared.Validations.IsValidPassword(txtPassword.Text) == false)
            {
                e.Cancel = true;
                txtPassword.Focus();
                errorProvider1.SetError(txtPassword, "Password must contain atleast one upper and lower character and must be atleast 6 characters");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPassword, "");
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (Shared.Validations.IsValidPassword(txtConfirmPassword.Text) == false && Shared.Validations.ConfirmPassword(txtPassword.Text, txtConfirmPassword.Text) == false)
            {
                e.Cancel = true;
                txtPassword.Focus();
                errorProvider1.SetError(txtConfirmPassword, "Password does not match");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtConfirmPassword, "");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtdont_Click(object sender, EventArgs e)
        {

        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }


        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FirstName_Click(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginSideFrame_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SideLogo_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
