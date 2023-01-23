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
    public partial class CustomerServices : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAP-NR\NRSQLSERVER;Initial Catalog=New Electro;Integrated Security=True");
        private SqlDataAdapter da;
        private DataTable dt;
        public CustomerServices()
        {
            InitializeComponent();
        }

        private void CustomerServices_Load(object sender, EventArgs e)
        {
            con.Open();
            string displaysql = "select * from Installment ";
            da = new SqlDataAdapter(displaysql, con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;

            string displaysql2 = "select * from ReadyCash ";
            da = new SqlDataAdapter(displaysql2, con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();

            txtdate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtret.Text = DateTime.Now.ToString("  /  /yyyy");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand cmdinsert = new SqlCommand("Insert into CService values( ' " + txtdate.Text + " ',' " + txtbid.Text + " ',' " + txtcusnme.Text + " ',' " + txtitmid.Text + " ',' " + txtitmnme.Text + " ',' " + cmboserv.Text + " ',' " + txtcon.Text + " ',' " + txtret.Text + " ' )", con);
            con.Open();
            cmdinsert.CommandType = CommandType.Text;
            cmdinsert.ExecuteNonQuery();
            con.Close();

            DialogResult respond;
            respond = MessageBox.Show("Service Bill Successfull", "New Supplier", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void txtbid_TextChanged(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open) { con.Close(); }
            con.Open();


            SqlCommand cmdserch = new SqlCommand("Select * From Installment where Bill_ID = ' " + txtbid.Text + " ' ", con);
            cmdserch.CommandType = CommandType.Text;
            SqlDataReader dr = cmdserch.ExecuteReader();

            if (dr.Read())
            {
                txtcusnme.Text = dr[3].ToString();
                txtitmnme.Text = dr[4].ToString();
                txtitmid.Text = dr[5].ToString();
                txtcon.Text = dr[6].ToString();
            }
            dr.Close();
            con.Close();
        }

        private void txtbid_KeyDown(object sender, KeyEventArgs e)
        {
            if (con.State == ConnectionState.Open) { con.Close(); }
            con.Open();


            SqlCommand cmdserch = new SqlCommand("Select * From ReadyCash where Bill_ID = ' " + txtbid.Text + " ' ", con);
            cmdserch.CommandType = CommandType.Text;
            SqlDataReader dr = cmdserch.ExecuteReader();

            if (dr.Read())
            {
                txtcusnme.Text = dr[2].ToString();
                txtitmnme.Text = dr[5].ToString();
                txtitmid.Text = dr[4].ToString();
                txtcon.Text = dr[3].ToString();
            }
            dr.Close();
            con.Close();
        }
    }
}
