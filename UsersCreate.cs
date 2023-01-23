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
    public partial class UsersCreate : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAP-NR\NRSQLSERVER;Initial Catalog=New Electro;Integrated Security=True");
        public UsersCreate()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmdinsert = new SqlCommand("Insert into Users values( ' " + txtdate.Text + " ',' " + txtnme.Text + " ',' " + txtusrnme.Text + " ',' " + txtpass.Text + " '   )", con);
            con.Open();
            cmdinsert.CommandType = CommandType.Text;
            cmdinsert.ExecuteNonQuery();
            con.Close();

            DialogResult respond;
            respond = MessageBox.Show("Succesfully Created New User", "New User", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (respond == DialogResult.OK)
            {
                txtdate.Text = "";
                txtnme.Text = "";
                txtusrnme.Text = "";
                txtpass.Text = "";
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open) { con.Close(); }
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From Users where Username=' " + textBox8.Text + " ' ", con);

            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txtdate.Text = dr[0].ToString();
                txtnme.Text = dr[1].ToString();
                txtusrnme.Text = dr[2].ToString();
                txtpass.Text = dr[3].ToString();
            }
            else
            {
                txtdate.Text = "";
                txtnme.Text = "";
                txtusrnme.Text = "";
                txtpass.Text = "";
            }
            dr.Close();
        }

        private void UsersCreate_Load(object sender, EventArgs e)
        {
            txtdate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open) { con.Close(); }
            con.Open();
            SqlCommand cmdupdate = new SqlCommand("Update Users SET Date=' " + txtdate.Text + " ',Name=' " + txtnme.Text + " ' ,Username=' " + txtusrnme.Text + " ',Password=' " + txtpass.Text + "'", con);
            cmdupdate.CommandType = CommandType.Text;
            cmdupdate.ExecuteNonQuery();
            con.Close();
            DialogResult respond;
            respond = MessageBox.Show("Succesfully Updated User", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (respond==DialogResult.OK)
            {
                txtdate.Text = "";
                txtnme.Text = "";
                txtusrnme.Text = "";
                txtpass.Text = "";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult respond1 = new DialogResult();
            respond1 = MessageBox.Show("Do you want to terminate the user", "Confirm Termination", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (respond1 == DialogResult.Yes)
            {
                if (con.State == ConnectionState.Open) { con.Close(); }
                con.Open();
                SqlCommand cmddel = new SqlCommand("Delete Users where Username=' " + textBox8.Text + " ' ", con);
                cmddel.CommandType = CommandType.Text;
                cmddel.ExecuteNonQuery();
                con.Close();
                DialogResult respond;
                respond = MessageBox.Show("Succesfully Terminated User", "Terminate User", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (respond == DialogResult.OK)
                {
                    txtdate.Text = "";
                    txtnme.Text = "";
                    txtusrnme.Text = "";
                    txtpass.Text = "";
                }
            }
        }
    }
}
