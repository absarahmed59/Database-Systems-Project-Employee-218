using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Employee f = new Add_Employee();
            f.Show();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employee_DatabaseDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.employee_DatabaseDataSet.Employee);

        }
    }
}
