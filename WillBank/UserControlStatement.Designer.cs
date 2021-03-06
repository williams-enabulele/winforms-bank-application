
namespace WillBank
{
    partial class UserControlStatement
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
            this.comboBoxUserAccountNo = new System.Windows.Forms.ComboBox();
            this.btnStatement = new System.Windows.Forms.Button();
            this.dataGridStatementView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStatementView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.comboBoxUserAccountNo);
            this.panel1.Controls.Add(this.btnStatement);
            this.panel1.Controls.Add(this.dataGridStatementView);
            this.panel1.Location = new System.Drawing.Point(117, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 498);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxUserAccountNo
            // 
            this.comboBoxUserAccountNo.FormattingEnabled = true;
            this.comboBoxUserAccountNo.Location = new System.Drawing.Point(71, 66);
            this.comboBoxUserAccountNo.Name = "comboBoxUserAccountNo";
            this.comboBoxUserAccountNo.Size = new System.Drawing.Size(367, 23);
            this.comboBoxUserAccountNo.TabIndex = 2;
            this.comboBoxUserAccountNo.Text = "  Select Account";
            // 
            // btnStatement
            // 
            this.btnStatement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(244)))), ((int)(((byte)(198)))));
            this.btnStatement.FlatAppearance.BorderSize = 0;
            this.btnStatement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatement.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStatement.Location = new System.Drawing.Point(479, 66);
            this.btnStatement.Name = "btnStatement";
            this.btnStatement.Size = new System.Drawing.Size(122, 37);
            this.btnStatement.TabIndex = 1;
            this.btnStatement.Text = "Get Statement";
            this.btnStatement.UseVisualStyleBackColor = false;
            this.btnStatement.Click += new System.EventHandler(this.btnStatement_Click);
            // 
            // dataGridStatementView
            // 
            this.dataGridStatementView.AllowUserToAddRows = false;
            this.dataGridStatementView.AllowUserToDeleteRows = false;
            this.dataGridStatementView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStatementView.Location = new System.Drawing.Point(71, 109);
            this.dataGridStatementView.Name = "dataGridStatementView";
            this.dataGridStatementView.ReadOnly = true;
            this.dataGridStatementView.RowTemplate.Height = 25;
            this.dataGridStatementView.Size = new System.Drawing.Size(530, 349);
            this.dataGridStatementView.TabIndex = 0;
            // 
            // UserControlStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.Controls.Add(this.panel1);
            this.Name = "UserControlStatement";
            this.Size = new System.Drawing.Size(913, 574);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStatementView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStatement;
        private System.Windows.Forms.DataGridView dataGridStatementView;
        private System.Windows.Forms.ComboBox comboBoxUserAccountNo;
    }
}
