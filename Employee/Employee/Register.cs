using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Employee
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        SqlConnection c = new SqlConnection(@"Data Source=DESKTOP-F3UNILV\SQLEXPRESS;Initial Catalog=Employee_Database;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert Into Accounts(Username, Password) Values('"+textBox1.Text+"', '"+textBox2.Text+"')", c);
            c.Open();
            cmd.ExecuteNonQuery();
            c.Close();
            this.Hide();
            Login f = new Login();
            f.Show();
        }
    }
}
