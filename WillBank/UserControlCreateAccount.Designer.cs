
namespace WillBank
{
    partial class UserControlCreateAccount
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGetAccount = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridAccountView = new System.Windows.Forms.DataGridView();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.comboBoxAccountType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInitialDeposit = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAccountView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnGetAccount);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dataGridAccountView);
            this.panel1.Controls.Add(this.btnCreateAccount);
            this.panel1.Controls.Add(this.comboBoxAccountType);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtInitialDeposit);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(122, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 527);
            this.panel1.TabIndex = 0;
            // 
            // btnGetAccount
            // 
            this.btnGetAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(244)))), ((int)(((byte)(198)))));
            this.btnGetAccount.FlatAppearance.BorderSize = 0;
            this.btnGetAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetAccount.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGetAccount.Location = new System.Drawing.Point(470, 266);
            this.btnGetAccount.Name = "btnGetAccount";
            this.btnGetAccount.Size = new System.Drawing.Size(133, 36);
            this.btnGetAccount.TabIndex = 16;
            this.btnGetAccount.Text = "Get Account";
            this.btnGetAccount.UseVisualStyleBackColor = false;
            this.btnGetAccount.Click += new System.EventHandler(this.btnGetAccount_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(58, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "My Accounts";
            // 
            // dataGridAccountView
            // 
            this.dataGridAccountView.AllowUserToAddRows = false;
            this.dataGridAccountView.AllowUserToDeleteRows = false;
            this.dataGridAccountView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridAccountView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAccountView.Location = new System.Drawing.Point(58, 318);
            this.dataGridAccountView.Name = "dataGridAccountView";
            this.dataGridAccountView.ReadOnly = true;
            this.dataGridAccountView.RowTemplate.Height = 25;
            this.dataGridAccountView.Size = new System.Drawing.Size(545, 150);
            this.dataGridAccountView.TabIndex = 14;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(244)))), ((int)(((byte)(198)))));
            this.btnCreateAccount.FlatAppearance.BorderSize = 0;
            this.btnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAccount.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateAccount.Location = new System.Drawing.Point(194, 189);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(284, 50);
            this.btnCreateAccount.TabIndex = 13;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // comboBoxAccountType
            // 
            this.comboBoxAccountType.FormattingEnabled = true;
            this.comboBoxAccountType.Location = new System.Drawing.Point(147, 76);
            this.comboBoxAccountType.Name = "comboBoxAccountType";
            this.comboBoxAccountType.Size = new System.Drawing.Size(377, 23);
            this.comboBoxAccountType.TabIndex = 7;
            this.comboBoxAccountType.Text = "  Select Type of Account";
            this.comboBoxAccountType.SelectedIndexChanged += new System.EventHandler(this.comboBoxAccountType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(147, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Initial Deposit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(147, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Account Type";
            // 
            // txtInitialDeposit
            // 
            this.txtInitialDeposit.Location = new System.Drawing.Point(147, 137);
            this.txtInitialDeposit.Multiline = true;
            this.txtInitialDeposit.Name = "txtInitialDeposit";
            this.txtInitialDeposit.Size = new System.Drawing.Size(377, 42);
            this.txtInitialDeposit.TabIndex = 9;
            this.txtInitialDeposit.Text = "0.00";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Location = new System.Drawing.Point(49, 306);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(566, 169);
            this.panel2.TabIndex = 17;
            // 
            // UserControlCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.Controls.Add(this.panel1);
            this.Name = "UserControlCreateAccount";
            this.Size = new System.Drawing.Size(900, 658);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAccountView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.ComboBox comboBoxAccountType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInitialDeposit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridAccountView;
        private System.Windows.Forms.Button btnGetAccount;
        private System.Windows.Forms.Panel panel2;
    }
}
