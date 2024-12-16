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
    public partial class Add_Employee : Form
    {
        public Add_Employee()
        {
            InitializeComponent();
        }
        SqlConnection c = new SqlConnection(@"Data Source=DESKTOP-F3UNILV\SQLEXPRESS;Initial Catalog=Employee_Database;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f = new Login();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashBoard f = new DashBoard();
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert Into Employee(First_Name, Last_Name, ID, Contact, Education, Role, Experience, Address, Gender) Values('"+textBox2.Text+"', '"+textBox3.Text+"', '"+Convert.ToInt16(textBox1.Text)+"', '"+textBox4.Text+"', '"+textBox9.Text+"', '"+textBox8.Text+"', '"+Convert.ToInt16(textBox7.Text)+"', '"+textBox5.Text+"', '"+textBox6.Text+"')", c);
            c.Open();
            cmd.ExecuteNonQuery();
            c.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update Employee Set First_Name ='" + textBox2.Text + "', Last_Name ='" + textBox3.Text + "', Contact='" + textBox4.Text + "', Education='" + textBox9.Text + "', Role='" + textBox8.Text + "', Experience='" + Convert.ToInt16(textBox7.Text) + "', Address='" + textBox5.Text + "', Gender='" + textBox6.Text + "' WHERE ID='" + Convert.ToInt16(textBox1.Text) + "'", c);
            c.Open();
            cmd.ExecuteNonQuery();
            c.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete From Employee WHERE ID= '" + Convert.ToInt16(textBox1.Text) + "'", c);
            c.Open();
            cmd.ExecuteNonQuery();
            c.Close();
        }

        private void Add_Employee_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
