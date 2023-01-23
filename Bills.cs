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
    public partial class Bills : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAP-NR\NRSQLSERVER;Initial Catalog=New Electro;Integrated Security=True");
        private DataTable dt;
        private SqlDataAdapter da;

        public Bills()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtdate.Text == "" || txtbillno.Text == "" || txtsupid.Text == "" || txtsupnme.Text == "" || txtcmpny.Text == "" || txtitmid.Text == "" || txtitmnme.Text == "" || txttot.Text == "" || combostats.Text == "")
                {
                    MessageBox.Show("All fields are compulsory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    if (con.State == ConnectionState.Open) { con.Close(); }
                    con.Open();
                    SqlCommand cmdinsert = new SqlCommand("Insert into Billing values( ' " + txtdate.Text + " ',' " + txtbillno.Text + " ',' " + txtsupid.Text + " ',' " + txtsupnme.Text + " ',' " + txtcmpny.Text + " ',' " + txtitmid.Text + " ',' " + txtitmnme.Text + " ',' " + txttot.Text + " ','" + combostats.Text + "')", con);
                    cmdinsert.CommandType = CommandType.Text;
                    cmdinsert.ExecuteNonQuery();
                    con.Close();

                    DialogResult respond;
                    respond = MessageBox.Show("Bill Payment Succesfull", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    if (respond == DialogResult.OK)
                    {
                        txtdate.Text = "";
                        txtbillno.Text = "";
                        txtsupid.Text = "";
                        txtsupnme.Text = "";
                        txtcmpny.Text = "";
                        txtitmid.Text = "";
                        txtitmnme.Text = "";
                        txttot.Text = "";
                        combostats.Text = "";
                    }

                }

            }

            catch
            {
                MessageBox.Show("Payment Unsuccessfull");
            }
                
        }

        private void combostats_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combostats.SelectedItem == "Payed")
            {
                btnstore.Enabled = false;
                btnpay.Enabled = true;
            }
              else
            {
                btnpay.Enabled = false;
                btnstore.Enabled = true;
            }
        }

        private void Bills_Load(object sender, EventArgs e)
        {
             con.Open();
            string displaysql = "select * from Billing";
            da = new SqlDataAdapter(displaysql, con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void txtbillno_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtbillno.Text == "")
                {
                    MessageBox.Show("Enter User Id To Search");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("Select * From Billing where Bill_No=' " + txtbillno.Text + " ' ", con);
                    con.Open();

                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        txtbillno.Text = dr[1].ToString();
                        txtsupid.Text = dr[2].ToString();
                        txtsupnme.Text = dr[3].ToString();
                        txtcmpny.Text = dr[4].ToString();
                        txtitmid.Text = dr[5].ToString();
                        txtitmnme.Text = dr[6].ToString();
                        txttot.Text = dr[7].ToString();
                        combostats.Text = dr[8].ToString();
                    }
                    dr.Close();

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
