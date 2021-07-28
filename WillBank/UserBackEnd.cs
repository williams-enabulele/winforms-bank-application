using System;
using System.Windows.Forms;

namespace WillBank
{
    public partial class UserBackEnd : Form
    {
        public UserBackEnd()
        {
            InitializeComponent();
            UserControlDashboard userControlDashboard = new UserControlDashboard();
            panelPlaceholder.Controls.Clear();
            panelPlaceholder.Controls.Add(userControlDashboard);

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            panelPlaceholder.Controls.Clear();
            UserControlDashboard userControlDashboard = new UserControlDashboard();
            panelPlaceholder.Controls.Add(userControlDashboard);
            
        }

        private void btnOpenAccount_Click(object sender, EventArgs e)
        {
            panelPlaceholder.Controls.Clear();
            UserControlCreateAccount userControlCreateAccount = new UserControlCreateAccount();
            panelPlaceholder.Controls.Add(userControlCreateAccount);
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            panelPlaceholder.Controls.Clear();
            UserControlDeposit userControlDeposit = new UserControlDeposit();
            panelPlaceholder.Controls.Add(userControlDeposit);

        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            panelPlaceholder.Controls.Clear();
            UserControlWithdraw userControlWithdraw = new UserControlWithdraw();
            panelPlaceholder.Controls.Add(userControlWithdraw);
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            panelPlaceholder.Controls.Clear();
            UserControlTransfer userControlTransfer = new UserControlTransfer();
            panelPlaceholder.Controls.Add(userControlTransfer);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelPlaceholder.Controls.Clear();
            UserControlStatement userControlStatement = new UserControlStatement();
            panelPlaceholder.Controls.Add(userControlStatement);

        }
    }
}
