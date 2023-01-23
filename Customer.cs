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
    public partial class Customer : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAP-NR\NRSQLSERVER;Initial Catalog=New Electro;Integrated Security=True");

        public Customer()
        {
            InitializeComponent();
        }

        private void txttot_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txtamnt_TextChanged(object sender, EventArgs e)
        {
            if (txtamnt.Text == "")
            {

            }
            else
            {
                int tot = 0;
                tot = (int.Parse(txtprice.Text) * int.Parse(txtamnt.Text));
                txtsubtot.Text = tot.ToString();

            }
        }

        private void txtdisc_TextChanged(object sender, EventArgs e)
        {
            if (txtdisc.Text == "")
            {

            }
            else
            {
                int tot = 0;
                tot = (int.Parse(txtprice.Text) * int.Parse(txtamnt.Text)) - ((int.Parse(txtprice.Text) * int.Parse(txtamnt.Text) * int.Parse(txtdisc.Text) / 100));
                txtsubtot.Text = tot.ToString();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtdate.Text == "" || txtbill.Text == "" || txtcusname.Text == "" || txtcno.Text == "" || txtaddr.Text == "" || txtprice.Text == "" || txtamnt.Text == "" || txtsubtot.Text == "")
                {
                    MessageBox.Show("All fields are compulsory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    if (con.State == ConnectionState.Open) { con.Close(); }
                    con.Open();
                    DataTable dt = new DataTable();
                    SqlCommand cmdinsert = new SqlCommand("Insert into ReadyCash values( ' " + txtdate.Text + " ',' " + txtbill.Text + " ',' " + txtcusname.Text + " ',' " + txtcno.Text + " ',' " + txtaddr.Text + " ',' " + txtitmnme2.Text + " ',' " + txtitmid2.Text + " ',' " + txtprice.Text + " ',' " + txtamnt.Text + " ','" + txtdisc.Text + "' ,'" + txtsubtot.Text + "' ,'" + txtnettot.Text + "','" + txtwar.Text + "'   )", con);
                    cmdinsert.CommandType = CommandType.Text;
                    cmdinsert.ExecuteNonQuery();
                    con.Close();

                    DialogResult respond;
                    respond = MessageBox.Show("Payment Succesfull", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                    if (respond == DialogResult.OK)
                    {
                        txtdate.Text = "";
                        txtbill.Text = "";
                        txtcusname.Text = "";
                        txtcno.Text = "";
                        txtaddr.Text = "";
                        txtitmid2.Text = "";
                        txtitmnme2.Text = "";
                        txtprice.Text = "0";
                        txtamnt.Text = "0";
                        txtdisc.Text = "0";
                        txtsubtot.Text = "0";
                        txtnettot.Text = "0";
                    }

                }

            }

            catch
            {
                MessageBox.Show("Payment Unsuccessfull");
            }
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            button4.Enabled = false;
            txtdate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtwar.Text = DateTime.Now.ToString("dd/MM/");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                txtdate2.Text = DateTime.Now.ToString("dd/MM/yyyy");
                txtwar2.Text = DateTime.Now.ToString("dd/MM/");
                label19.Enabled = false;
                label18.Enabled = false;
                label20.Enabled = false;
                label17.Enabled = false;
                label16.Enabled = false;
                label15.Enabled = false;
                label14.Enabled = false;
                label13.Enabled = false;
                label12.Enabled = false;
                label22.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                txtcusnme.ReadOnly = true;
                txtcno2.ReadOnly = true;
                txtcusid.ReadOnly = true;
                txtaddr2.ReadOnly = true;
                txtprice2.ReadOnly = true;
                txtamnt2.ReadOnly = true;
                txttot2.ReadOnly = true;
                txtwar2.ReadOnly = true;
                txtdisc2.ReadOnly = true;
                txtitmid.ReadOnly = true;
                txtitmnme.ReadOnly = true;
                txtdownpay.ReadOnly = true;
                txtrempay.ReadOnly = true;
                txtdur.ReadOnly = true;
                button1.Enabled = false;
                button4.Enabled = true;
                button7.Enabled = false;

                txtdate2.Text = DateTime.Now.ToString("dd/MM/yyyy"); ;
                txtcusid.Text = "";
                txtbid.Text = "";
                txtcusnme.Text = "";
                txtcno2.Text = "";
                txtaddr2.Text = "";
                txtprice2.Text = "0";
                txtamnt2.Text = "0";
                txtdisc2.Text = "0";
                txttot2.Text = "0";
                txtwar2.Text = DateTime.Now.ToString("dd/MM/");
                txtdownpay.Text = "0";
                txtrempay.Text = "0";
                txtdur.Text = "";
                txtmnthly.Text = "";
                txtitmid.Text = "";
                txtitmnme.Text = "";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

                {
                    SqlCommand cmdinsert = new SqlCommand("Insert into Installment values( ' " + txtdate2.Text + " ',' " + txtbid.Text + " ',' " + txtcusid.Text + " ',' " + txtcusnme.Text + " ',' " + txtcno2.Text + " ',' " + txtaddr2.Text + " ',' " + txtitmnme.Text + " ',' " + txtitmid.Text + " ',' " + txtprice2.Text + " ',' " + txtamnt2.Text + " ','" + txtdisc2.Text + "' ,'" + txttot2.Text + "' ,'" + txtwar2.Text + "','" + txtdownpay.Text + "',' " + txtrempay.Text + " ',' " + txtdur.Text + " ',' " + txtmnthly.Text + " ' )", con);
                    con.Open();
                    cmdinsert.CommandType = CommandType.Text;
                    cmdinsert.ExecuteNonQuery();
                    con.Close();

                    DialogResult respond;
                    respond = MessageBox.Show("Payment Succesfull", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    if (respond == DialogResult.OK)
                    {
                        txtdate2.Text = DateTime.Now.ToString("dd/MM/yyyy"); ;
                        txtcusid.Text = "";
                        txtbid.Text = "";
                        txtcusnme.Text = "";
                        txtcno2.Text = "";
                        txtaddr2.Text = "";
                        txtprice2.Text = "0";
                        txtamnt2.Text = "0";
                        txtdisc2.Text = "0";
                        txttot2.Text = "0";
                        txtwar2.Text = DateTime.Now.ToString("dd/MM/");
                        txtdownpay.Text = "0";
                        txtrempay.Text = "0";
                        txtdur.Text = "0";
                        txtmnthly.Text = "0";
                        txtitmid.Text = "";
                        txtitmnme.Text = "";

                    }

                }
        }

        private void txtdisc2_TextChanged(object sender, EventArgs e)
        {
            if (txtdisc2.Text == "")
            {

            }
            else
            {
                int tot = 0;
                tot = (int.Parse(txtprice2.Text) * int.Parse(txtamnt2.Text)) - ((int.Parse(txtprice2.Text) * int.Parse(txtamnt2.Text) * int.Parse(txtdisc2.Text) / 100));
                txttot2.Text = tot.ToString();
            }
        }

        private void txtamnt2_TextChanged(object sender, EventArgs e)
        {
            if (txtamnt2.Text == "")
            {
                txttot2.Text = "";
            }
            else
            {
                int tot = 0;
                tot = (int.Parse(txtprice2.Text) * int.Parse(txtamnt2.Text));
                txttot2.Text = tot.ToString();
            }
        }

        private void txtdownpay_TextChanged(object sender, EventArgs e)
        {
            if (txtdownpay.Text == "")
            {
                txtdownpay.Text = "";
            }
            else
            {
                int tot = 0;
                tot = (int.Parse(txttot2.Text) - int.Parse(txtdownpay.Text));
                txtrempay.Text = tot.ToString();
            }
        }

        private void txtdur_TextChanged(object sender, EventArgs e)
        {
            if (txtdur.Text == "")
            {
                txtdur.Text = "";
            }
            else
            {
                int tot = 0;
                tot = (int.Parse(txtrempay.Text) / int.Parse(txtdur.Text));
                txtmnthly.Text = tot.ToString();
            }
        }

        private void txtcusid_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (txtcusid.Text == "")
            {
                MessageBox.Show("Enter User Id To Update");
            }
            else
            {
                if (con.State == ConnectionState.Open) { con.Close(); }
                con.Open();

                int tot = 0;
                tot = (int.Parse(txtrempay.Text) - int.Parse(txtmnthly.Text));
                txtrempay.Text = tot.ToString();

                SqlCommand cmdupdate = new SqlCommand("Update Installment SET Remaining_Payment='" + txtrempay.Text + "' where Bill_ID=' " + txtbid.Text + " '", con);
                cmdupdate.CommandType = CommandType.Text;
                cmdupdate.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Data Updated");
            }

        }

        private void txtmnthly_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmnthly_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        public void Data()
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            int tot = 0;
            tot = (int.Parse(txtsubtot.Text) + int.Parse(txtnettot.Text));
            txtnettot.Text = tot.ToString();


            {
                    if (con.State == ConnectionState.Open) { con.Close(); }
                    con.Open();
                    DataTable dt = new DataTable();
                    SqlCommand cmdinsert = new SqlCommand("Insert into ReadyCash values( ' " + txtdate.Text + " ',' " + txtbill.Text + " ',' " + txtcusname.Text + " ',' " + txtcno.Text + " ',' " + txtaddr.Text + " ',' " + txtitmnme2.Text + " ',' " + txtitmid2.Text + " ',' " + txtprice.Text + " ',' " + txtamnt.Text + " ','" + txtdisc.Text + "' ,'" + txtsubtot.Text + "' ,'" + txtnettot.Text + "','" + txtwar.Text + "'   )", con);
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
                    label7.Enabled = false;
                    label8.Enabled = false;

                    txtdate.ReadOnly = true;
                    txtbill.ReadOnly = true;
                    txtcusname.ReadOnly = true;
                    txtcno.ReadOnly = true;
                    txtaddr.ReadOnly = true;

                    txtitmnme2.Text = "";
                    txtitmid2.Text = "";
                    txtprice.Text = "0";
                    txtamnt.Text = "0";
                    txtsubtot.Text = "0";
                    txtdisc.Text = "0";
                    txtwar.Text = DateTime.Now.ToString("dd/MM/");

                }

            }
        }

        private void txtdisc_MouseEnter(object sender, EventArgs e)
        {
            int totx = 0;
            totx = (int.Parse(txthide.Text) - int.Parse(txtamnt.Text));
            txthide2.Text = totx.ToString();
        }

        private void txtwar_MouseEnter(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open) { con.Close(); }
            con.Open();
            SqlCommand cmdupdate = new SqlCommand("Update Items SET Store_Amount=' " + txthide2.Text + " ' where Item_ID = ' " + txtitmid2.Text + " ' ", con);
            cmdupdate.CommandType = CommandType.Text;
            cmdupdate.ExecuteNonQuery();
            con.Close();
        }

        private void txtdate_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtitmid2_TextChanged(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open) { con.Close(); }
            con.Open();

            SqlCommand cmdserch = new SqlCommand("Select Store_Amount,Unit_Price From Items where Item_ID=' " + txtitmid2.Text + " ' ", con);
            cmdserch.CommandType = CommandType.Text;
            SqlDataReader dr = cmdserch.ExecuteReader();
            if (dr.Read())
            {
                txtprice.Text = dr[1].ToString();
                txthide.Text = dr[0].ToString();

            }
            dr.Close();
            con.Close();


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtdate2.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtwar2.Text = DateTime.Now.ToString("dd/MM/");
            label19.Enabled = true;
            label18.Enabled = true;
            label17.Enabled = true;
            label16.Enabled = true;
            label15.Enabled = true;
            label14.Enabled = true;
            label13.Enabled = true;
            label12.Enabled = true;
            label22.Enabled = true;
            label24.Enabled = true;
            label28.Enabled = true;
            label29.Enabled = true;
            label20.Enabled = true;
            label25.Enabled = true;
            txtcusnme.ReadOnly = false;
            txtdur.ReadOnly = false;
            txtcno2.ReadOnly = false;
            txtaddr2.ReadOnly = false;
            txtprice2.ReadOnly = false;
            txtamnt2.ReadOnly = false;
            txttot2.ReadOnly = true;
            txtwar2.ReadOnly = false;
            txtdisc2.ReadOnly = false;
            txtdownpay.ReadOnly = false;
            txtrempay.ReadOnly = true;
            txtmnthly.ReadOnly = false;
            txtitmid.ReadOnly = false;
            txtitmnme.ReadOnly = false;
            txtcusid.ReadOnly = false;
            button1.Enabled = true;
            button4.Enabled = false;

            txtdate2.Text = DateTime.Now.ToString("dd/MM/yyyy"); ;
            txtcusid.Text = "";
            txtbid.Text = "";
            txtcusnme.Text = "";
            txtcno2.Text = "";
            txtaddr2.Text = "";
            txtprice2.Text = "0";
            txtamnt2.Text = "0";
            txtdisc2.Text = "0";
            txttot2.Text = "0";
            txtwar2.Text = DateTime.Now.ToString("dd/MM/");
            txtdownpay.Text = "0";
            txtrempay.Text = "0";
            txtdur.Text = "";
            txtmnthly.Text = "";
            txtitmid.Text = "";
            txtitmnme.Text = "";

        }

        private void txtrempay_TextChanged(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int toty = 0;
            toty = (int.Parse(txtsubtot.Text) + int.Parse(txtnettot.Text));
            txtnettot.Text = toty.ToString();


            {
                if (con.State == ConnectionState.Open) { con.Close(); }
                con.Open();
                DataTable dt = new DataTable();
                SqlCommand cmdinsert = new SqlCommand("Insert into Installment values( ' " + txtdate2.Text + " ',' " + txtbid.Text + " ',' " + txtcusid.Text + " ',' " + txtcusnme.Text + " ',' " + txtcno2.Text + " ',' " + txtaddr2.Text + " ',' " + txtitmnme.Text + " ',' " + txtitmid.Text + " ',' " + txtprice2.Text + " ',' " + txtamnt2.Text + " ','" + txtdisc2.Text + "' ,'" + txttot2.Text + "' ,'" + txtwar2.Text + "','" + txtdownpay.Text + "',' " + txtrempay.Text + " ',' " + txtdur.Text + " ',' " + txtmnthly.Text + " ')", con);
                cmdinsert.CommandType = CommandType.Text;
                cmdinsert.ExecuteNonQuery();

                con.Close();

                DialogResult respond;
                respond = MessageBox.Show("Added to Cart", "Cart", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (respond == DialogResult.OK)
                {

                    label21.Enabled = false;
                    label20.Enabled = false;
                    label19.Enabled = false;
                    label18.Enabled = false;
                    label17.Enabled = false;

                    txtdate2.ReadOnly = true;
                    txtcusid.ReadOnly = true;
                    txtcusnme.ReadOnly = true;
                    txtcno2.ReadOnly = true;
                    txtaddr2.ReadOnly = true;

                    txtitmnme.Text = "";
                    txtitmid.Text = "";
                    txtprice2.Text = "0";
                    txtamnt2.Text = "0";
                    txttot2.Text = "0";
                    txtdisc2.Text = "0";
                    txtdownpay.Text = "0";
                    txtrempay.Text = "0";
                    txtdur.Text = "0";
                    txtmnthly.Text = "0";
                    txtwar2.Text = DateTime.Now.ToString("dd/MM/");

                }

            }
        }

        private void txtbid_TextChanged(object sender, EventArgs e)
        {
            {
                if (con.State == ConnectionState.Open) { con.Close(); }
                con.Open();


                SqlCommand cmdserch2 = new SqlCommand("Select * From Installment where Bill_ID = ' " + txtbid.Text + " ' ", con);
                cmdserch2.CommandType = CommandType.Text;
                SqlDataReader dr = cmdserch2.ExecuteReader();

                if (dr.Read())
                {
                    txtcusid.Text = dr[1].ToString();
                    txtcusid.Text = dr[2].ToString();
                    txtcusnme.Text = dr[3].ToString();
                    txtcno2.Text = dr[4].ToString();
                    txtaddr2.Text = dr[5].ToString();
                    txtitmnme.Text = dr[6].ToString();
                    txtitmid.Text = dr[7].ToString();
                    txtprice2.Text = dr[12].ToString();
                    


                }
                dr.Close();
                con.Close();
            }
        }

        private void txtitmid_TextChanged(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open) { con.Close(); }
            con.Open();

            SqlCommand cmdserch = new SqlCommand("Select Store_Amount,Unit_Price From Items where Item_ID=' " + txtitmid.Text + " ' ", con);
            cmdserch.CommandType = CommandType.Text;
            SqlDataReader dr = cmdserch.ExecuteReader();
            if (dr.Read())
            {
                txtprice2.Text = dr[1].ToString();
                txthide3.Text = dr[0].ToString();

            }
            dr.Close();
            con.Close();
        }

        private void txtdisc2_MouseEnter(object sender, EventArgs e)
        {
            int totx = 0;
            totx = (int.Parse(txthide3.Text) - int.Parse(txtamnt2.Text));
            txthide4.Text = totx.ToString();
        }

        private void txtwar2_MouseEnter(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open) { con.Close(); }
            con.Open();
            SqlCommand cmdupdate = new SqlCommand("Update Items SET Store_Amount=' " + txthide4.Text + " ' where Item_ID = ' " + txtitmid.Text + " ' ", con);
            cmdupdate.CommandType = CommandType.Text;
            cmdupdate.ExecuteNonQuery();
            con.Close();
        }
    }
}
