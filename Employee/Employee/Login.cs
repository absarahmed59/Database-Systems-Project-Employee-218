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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection c = new SqlConnection(@"Data Source=DESKTOP-F3UNILV\SQLEXPRESS;Initial Catalog=Employee_Database;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register f = new Register();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * FROM Accounts WHERE Username='"+textBox1.Text+"' AND Password = '"+textBox2.Text+"'", c);
            c.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                this.Hide();
                Add_Employee f = new Add_Employee();
                f.Show();
            }
            c.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
