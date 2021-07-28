using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WillBank
{
    public partial class UserControlStatement : UserControl
    {
        public UserControlStatement()
        {
            InitializeComponent();
        }

        private void btnStatement_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable("Account Statement");
            DataColumn dataColumn = new DataColumn("Date" , typeof(DateTimeOffset));
            DataColumn dataColumn1 = new DataColumn("Amount", typeof(decimal));
            DataColumn dataColumn2 = new DataColumn("Balance", typeof(decimal));
            DataColumn dataColumn3 = new DataColumn("Note");
            DataColumn dataColumn4 = new DataColumn("Type");

            dataTable.Columns.Add(dataColumn);
            dataTable.Columns.Add(dataColumn1);
            dataTable.Columns.Add(dataColumn2);
            dataTable.Columns.Add(dataColumn3);
            dataTable.Columns.Add(dataColumn4);

            DataRow dataRow = dataTable.NewRow();
            // loop here
            dataRow["Date"] = "date";
            dataRow["Amount"] = "amount";
            dataRow["Balance"] = "0.00";
            dataRow["Note"] = "description";
            dataRow["Type"] = "Credit";
            // outside the loop
            dataTable.Rows.Add(dataRow);
            dataGridView1.DataSource = dataTable;
            // Sort Records
            // Dataview dataView = new DataView(dataTable)
            // dataView.Sort = "Date desc"

        }

       
    }
}
