
namespace WillBank
{
    partial class UserControlDashboard
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
            this.balanceFrame = new System.Windows.Forms.Panel();
            this.txtAccountBalance = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtAccountNo = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPlaceholder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.balanceFrame.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // balanceFrame
            // 
            this.balanceFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(254)))), ((int)(((byte)(248)))));
            this.balanceFrame.Controls.Add(this.txtAccountBalance);
            this.balanceFrame.Controls.Add(this.txtBalance);
            this.balanceFrame.Location = new System.Drawing.Point(128, 118);
            this.balanceFrame.Name = "balanceFrame";
            this.balanceFrame.Size = new System.Drawing.Size(310, 100);
            this.balanceFrame.TabIndex = 0;
            // 
            // txtAccountBalance
            // 
            this.txtAccountBalance.AutoSize = true;
            this.txtAccountBalance.Font = new System.Drawing.Font("AvertaStd-Regular", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAccountBalance.Location = new System.Drawing.Point(197, 46);
            this.txtAccountBalance.Name = "txtAccountBalance";
            this.txtAccountBalance.Size = new System.Drawing.Size(70, 34);
            this.txtAccountBalance.TabIndex = 1;
            this.txtAccountBalance.Text = "0.00";
            this.txtAccountBalance.Click += new System.EventHandler(this.placeTxt1_Click);
            // 
            // txtBalance
            // 
            this.txtBalance.AutoSize = true;
            this.txtBalance.Font = new System.Drawing.Font("AvertaStd-Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBalance.Location = new System.Drawing.Point(12, 15);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(69, 20);
            this.txtBalance.TabIndex = 0;
            this.txtBalance.Text = "Balance";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.txtAccountNo);
            this.panel3.Controls.Add(this.txtAccount);
            this.panel3.Location = new System.Drawing.Point(479, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(310, 100);
            this.panel3.TabIndex = 2;
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.AutoSize = true;
            this.txtAccountNo.Font = new System.Drawing.Font("AvertaStd-Regular", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAccountNo.Location = new System.Drawing.Point(205, 46);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(70, 34);
            this.txtAccountNo.TabIndex = 2;
            this.txtAccountNo.Text = "0.00";
            // 
            // txtAccount
            // 
            this.txtAccount.AutoSize = true;
            this.txtAccount.Font = new System.Drawing.Font("AvertaStd-Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAccount.Location = new System.Drawing.Point(14, 15);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(70, 20);
            this.txtAccount.TabIndex = 1;
            this.txtAccount.Text = "Account";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.txtPlaceholder);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(79, 63);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(758, 456);
            this.panel4.TabIndex = 3;
            // 
            // txtPlaceholder
            // 
            this.txtPlaceholder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlaceholder.Location = new System.Drawing.Point(49, 273);
            this.txtPlaceholder.Multiline = true;
            this.txtPlaceholder.Name = "txtPlaceholder";
            this.txtPlaceholder.Size = new System.Drawing.Size(602, 31);
            this.txtPlaceholder.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("AvertaStd-Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(49, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Recent Transactions";
            // 
            // UserControlDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.balanceFrame);
            this.Controls.Add(this.panel4);
            this.Name = "UserControlDashboard";
            this.Size = new System.Drawing.Size(932, 571);
            this.balanceFrame.ResumeLayout(false);
            this.balanceFrame.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel balanceFrame;
        private System.Windows.Forms.Label txtAccountBalance;
        private System.Windows.Forms.Label txtBalance;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label txtAccountNo;
        private System.Windows.Forms.Label txtAccount;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlaceholder;
    }
}
