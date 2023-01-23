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
    public partial class Distribute : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAP-NR\NRSQLSERVER;Initial Catalog=New Electro;Integrated Security=True");
        private DataTable dt;
        private SqlDataAdapter da;


        public Distribute()
        {
            InitializeComponent();
        }

        private void txtquant_TextChanged(object sender, EventArgs e)
        {
            if (txtquant.Text == "")
            {

            }
            else
            {
                int tot = 0;
                tot = (int.Parse(txtprice.Text) * int.Parse(txtquant.Text));
                txtsub.Text = tot.ToString();


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int tot = 0;
            tot = (int.Parse(txtsub.Text) + int.Parse(txtnet.Text));
            txtnet.Text = tot.ToString();
            txthide.Text = tot.ToString();
            {
                if (con.State == ConnectionState.Open) { con.Close(); }
                con.Open();
                DataTable dt = new DataTable();
                SqlCommand cmdinsert = new SqlCommand("Insert into Distribute values( ' " + txtdate.Text + " ',' " + txtdisid.Text + " ',' " + txtshpnme.Text + " ',' " + txtshpid.Text + " ',' " + txtconpers.Text + " ',' " + txtconnum.Text + " ',' " + txtprod.Text + " ',' " + txtprdid.Text + " ',' " + txtprice.Text + " ',' " + txtquant.Text + " ','" + txtsub.Text + "')", con);
                
                cmdinsert.CommandType = CommandType.Text;
                cmdinsert.ExecuteNonQuery();
                con.Close();

                DialogResult respond;
                respond = MessageBox.Show("Added to Cart", "Cart", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (respond == DialogResult.OK)
                {

                    label3.Enabled = false;
                    label4.Enabled = false;
                    label5.Enabled = false;
                    label6.Enabled = false;
                    label7.Enabled = false;
                    label8.Enabled = false;

                    txtdate.ReadOnly = true;
                    txtdisid.ReadOnly = true;
                    txtshpnme.ReadOnly = true;
                    txtshpid.ReadOnly = true;
                    txtconpers.ReadOnly = true;
                    txtconnum.ReadOnly = true;

                    txtprod.Text = "";
                    txtprice.Text = "";
                    txtsub.Text = "";
                    txtquant.Text = "";
                    txtprdid.Text = "";
                }


            }
        }

        private void Distribute_Load(object sender, EventArgs e)
        {
            con.Open();
            string displaysql = "select * from Distribute";
            da = new SqlDataAdapter(displaysql, con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();

            txtdate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnpay_Click(object sender, EventArgs e)
        {
            int tot = 0;
            tot = (int.Parse(txtsub.Text) + int.Parse(txtnet.Text));
            txtnet.Text = tot.ToString();
            txthide.Text = tot.ToString();

            {

                int totx = 0;
                totx = (int.Parse(txtnet.Text) + int.Parse(txthide.Text));
                txthide2.Text = totx.ToString();
                {
                    if (con.State == ConnectionState.Open) { con.Close(); }
                    con.Open();

                    SqlCommand cmdinsert = new SqlCommand("Insert into Distribute values( ' " + txtdate.Text + " ',' " + txtdisid.Text + " ',' " + txtshpnme.Text + " ',' " + txtshpid.Text + " ',' " + txtconpers.Text + " ',' " + txtconnum.Text + " ',' " + txtprod.Text + " ',' " + txtprdid.Text + " ',' " + txtprice.Text + " ',' " + txtquant.Text + " ','" + txtsub.Text + "')", con);
                    SqlCommand cmdinsert2 = new SqlCommand("Insert into Sellers values( ' " + txtdate.Text + " ',' " + txtshpid.Text + " ',' " + txtshpnme.Text + " ',' " + txtconpers.Text + " ',' " + txtconnum.Text + " ','" + txthide2.Text + "')", con);
                    SqlCommand cmdupdate = new SqlCommand("Update Sellers SET Date=' " + txtdate.Text + "',Shop_ID=' " + txtshpid.Text + "',Shop_Name=' " + txtshpnme.Text + "',Contact_Person=' " + txtconpers.Text + "',Contact_Number=' " + txtconnum.Text + "',Net_Amount=' " + txthide2.Text+ "' where Shop_ID=' " + txtshpid.Text + " ' ", con);

                    cmdinsert.CommandType = CommandType.Text;
                    cmdinsert.ExecuteNonQuery();
                    cmdinsert2.CommandType = CommandType.Text;
                    cmdinsert2.ExecuteNonQuery();
                    cmdupdate.CommandType = CommandType.Text;
                    cmdupdate.ExecuteNonQuery();
                    con.Close();


                    DialogResult respond;
                    respond = MessageBox.Show("Payment Successful", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    if (respond == DialogResult.OK)
                    {
                        txtprod.Text = "";
                        txtprice.Text = "";
                        txtsub.Text = "";
                        txtquant.Text = "";
                        txtprdid.Text = "";
                        txtdate.Text = "";
                        txtshpnme.Text = "";
                        txtshpid.Text = "";
                        txtconpers.Text = "";
                        txtconnum.Text = "";
                        txtnet.Text = "";
                        txtdisid.Text = "";
                    }
                }
            }
        }

        private void txtshpid_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtshpid_TextChanged_1(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open) { con.Close(); }
            con.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Select Shop_Name,Contact_Person,Contact_Number,Net_Amount From Sellers where Shop_ID=' " + txtshpid.Text + " ' ", con);

            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txtshpnme.Text = dr[0].ToString();
                txtconpers.Text = dr[1].ToString();
                txtconnum.Text = dr[2].ToString();
                txthide.Text = dr[3].ToString();

                con.Close();
                dr.Close();
            }
        }
    }
}
