
namespace WillBank
{
    partial class LoginScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.SideLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNextRegister = new System.Windows.Forms.Button();
            this.txtdont = new System.Windows.Forms.Label();
            this.btnMainLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginSideFrame = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SideLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.LoginSideFrame.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // SideLogo
            // 
            this.SideLogo.Image = ((System.Drawing.Image)(resources.GetObject("SideLogo.Image")));
            this.SideLogo.Location = new System.Drawing.Point(94, 228);
            this.SideLogo.Margin = new System.Windows.Forms.Padding(2);
            this.SideLogo.Name = "SideLogo";
            this.SideLogo.Size = new System.Drawing.Size(94, 80);
            this.SideLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SideLogo.TabIndex = 0;
            this.SideLogo.TabStop = false;
            this.SideLogo.Click += new System.EventHandler(this.SideLogo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WillBank.Properties.Resources.arrow_right;
            this.pictureBox1.Location = new System.Drawing.Point(359, 559);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btnNextRegister
            // 
            this.btnNextRegister.FlatAppearance.BorderSize = 0;
            this.btnNextRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextRegister.Location = new System.Drawing.Point(305, 559);
            this.btnNextRegister.Name = "btnNextRegister";
            this.btnNextRegister.Size = new System.Drawing.Size(97, 23);
            this.btnNextRegister.TabIndex = 20;
            this.btnNextRegister.Text = "Register";
            this.btnNextRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNextRegister.UseVisualStyleBackColor = true;
            this.btnNextRegister.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtdont
            // 
            this.txtdont.AutoSize = true;
            this.txtdont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtdont.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtdont.Location = new System.Drawing.Point(81, 565);
            this.txtdont.Name = "txtdont";
            this.txtdont.Size = new System.Drawing.Size(147, 17);
            this.txtdont.TabIndex = 19;
            this.txtdont.Text = "Don\'t have an account ?";
            // 
            // btnMainLogin
            // 
            this.btnMainLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(244)))), ((int)(((byte)(198)))));
            this.btnMainLogin.FlatAppearance.BorderSize = 0;
            this.btnMainLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainLogin.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMainLogin.Location = new System.Drawing.Point(184, 434);
            this.btnMainLogin.Name = "btnMainLogin";
            this.btnMainLogin.Size = new System.Drawing.Size(123, 50);
            this.btnMainLogin.TabIndex = 18;
            this.btnMainLogin.Text = "Login";
            this.btnMainLogin.UseVisualStyleBackColor = false;
            this.btnMainLogin.Click += new System.EventHandler(this.btnMainLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(83, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password";
            // 
            // LoginSideFrame
            // 
            this.LoginSideFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(12)))), ((int)(((byte)(9)))));
            this.LoginSideFrame.Controls.Add(this.label1);
            this.LoginSideFrame.Controls.Add(this.SideLogo);
            this.LoginSideFrame.Dock = System.Windows.Forms.DockStyle.Left;
            this.LoginSideFrame.Location = new System.Drawing.Point(0, 0);
            this.LoginSideFrame.Margin = new System.Windows.Forms.Padding(2);
            this.LoginSideFrame.Name = "LoginSideFrame";
            this.LoginSideFrame.Size = new System.Drawing.Size(306, 681);
            this.LoginSideFrame.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(12, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 96);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(83, 325);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(325, 46);
            this.txtPassword.TabIndex = 14;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(83, 249);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(325, 46);
            this.txtEmail.TabIndex = 12;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 681);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.panel2.Controls.Add(this.panel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(939, 681);
            this.panel2.TabIndex = 0;
            // 
            // panel
            // 
            this.panel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.pictureBox2);
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.Controls.Add(this.btnNextRegister);
            this.panel.Controls.Add(this.txtdont);
            this.panel.Controls.Add(this.btnMainLogin);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.txtPassword);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.txtEmail);
            this.panel.Location = new System.Drawing.Point(404, 26);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(471, 627);
            this.panel.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(184, 82);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(101, 82);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(83, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Email";
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 681);
            this.Controls.Add(this.LoginSideFrame);
            this.Controls.Add(this.panel1);
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SideLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.LoginSideFrame.ResumeLayout(false);
            this.LoginSideFrame.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel LoginSideFrame;
        private System.Windows.Forms.PictureBox SideLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNextRegister;
        private System.Windows.Forms.Label txtdont;
        public System.Windows.Forms.Button btnMainLogin;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

