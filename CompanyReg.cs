using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppDevelop
{
    public partial class CompanyReg : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAP-NR\NRSQLSERVER;Initial Catalog=New Electro;Integrated Security=True");
        private SqlDataAdapter da;
        private DataTable dt;
        public CompanyReg()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open) { con.Close(); }
            con.Open();
            SqlCommand cmdinsert = new SqlCommand("Insert into CompanyReg values( ' " + textBox2.Text + " ',' " + textBox3.Text + " ',' " + textBox4.Text + " ',' " + textBox5.Text + " ',' " + textBox6.Text + " ',' " + textBox7.Text + " ',' " + textBox8.Text + " ',' " + textBox9.Text + " '   )", con);
            cmdinsert.CommandType = CommandType.Text;
            cmdinsert.ExecuteNonQuery();
            con.Close();

            DialogResult respond;
            respond = MessageBox.Show("Succesfully Created Company Profile", "New Company", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (respond == DialogResult.OK)
            {
                textBox2.Text = "";
                textBox8.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                display_data();
            }
        }

        private void display_data()
        {
            con.Open();
            string displaysql = "select * from CompanyReg";
            da = new SqlDataAdapter(displaysql, con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void CompanyReg_Load(object sender, EventArgs e)
        {
            display_data();

            textBox2.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
