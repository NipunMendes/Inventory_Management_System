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
   
    public partial class Supplier : Form
    {
         SqlConnection con = new SqlConnection(@"Data Source=LAP-NR\NRSQLSERVER;Initial Catalog=New Electro;Integrated Security=True");
        private SqlDataAdapter da;
        private DataTable dt;

        public Supplier()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
                {
                    MessageBox.Show("All Fields Are Compulsory");
                }
                else
                {
                    SqlCommand cmdinsert = new SqlCommand("Insert into CSuppliers values( ' " + textBox2.Text + " ',' " + textBox3.Text + " ',' " + textBox4.Text + " ',' " + textBox5.Text + " ',' " + textBox6.Text + " ',' " + textBox7.Text + " '   )", con);
                    con.Open();
                    cmdinsert.CommandType = CommandType.Text;
                    cmdinsert.ExecuteNonQuery();
                    con.Close();

                    DialogResult respond;
                    respond=MessageBox.Show("Succesfully Created New Supplier","New Supplier",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
                    if (respond==DialogResult.OK)
                    {
                        textBox2.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                        textBox7.Text = "";
                        display_data();
                    }
                    
                }

            }

            catch
            {
                MessageBox.Show("Record Inserted Fail");
            }
        }
        public void display_data()
        {
            con.Open();
            string displaysql = "select * from CSuppliers";
            da = new SqlDataAdapter(displaysql, con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox8.Text == "")
                {
                    MessageBox.Show("Enter User Id To Search");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("Select * From CSuppliers where Supplier_ID=' " + textBox8.Text + " ' ", con);
                    con.Open();

                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        textBox2.Text = dr[0].ToString();
                        textBox3.Text = dr[1].ToString();
                        textBox4.Text = dr[2].ToString();
                        textBox5.Text = dr[3].ToString();
                        textBox6.Text = dr[4].ToString();
                        textBox7.Text = dr[5].ToString();
                    }
                    else
                    {
                        textBox2.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                        textBox7.Text = "";
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox8.Text == "")
                {
                    MessageBox.Show("Enter User Id To Update");
                }
                else
                {
                    SqlCommand cmdupdate = new SqlCommand("Update CSuppliers SET Date=' " + textBox2.Text + " ',Supplier_Name=' " + textBox4.Text + " ' ,Company=' " + textBox5.Text + " ',Contact_Number=' " + textBox6.Text + " ',E_Mail=' " + textBox7.Text + " '  where Supplier_ID=' " + textBox8.Text + " ' ", con);
                    con.Open();
                    cmdupdate.CommandType = CommandType.Text;
                    cmdupdate.ExecuteNonQuery();
                    con.Close();
                    DialogResult respond;
                    respond = MessageBox.Show("Succesfully Updated Supplier", "Update Supplier", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    if (respond == DialogResult.OK)
                    display_data();
                }
            }
            catch
            {
                MessageBox.Show("Supplier Update Unsuccesful", "Update Supplier", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            con.Open();
            string displaysql = "select * from CSuppliers";
            da = new SqlDataAdapter(displaysql, con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();

            textBox2.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox8.Text == "")
                {
                    MessageBox.Show("Enter Supplier Id To Terminate");
                }
                else
                {
                    DialogResult respond1 = new DialogResult();
                    respond1 = MessageBox.Show("Do you want to terminate the supplier", "Confirm Termination", MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);

                    if (respond1 == DialogResult.Yes)
                    {
                        SqlCommand cmddel = new SqlCommand("Delete CSuppliers where Supplier_ID=' " + textBox8.Text + " ' ", con);
                        con.Open();
                        cmddel.CommandType = CommandType.Text;
                        cmddel.ExecuteNonQuery();
                        con.Close();
                        DialogResult respond;
                        respond = MessageBox.Show("Succesfully Terminated Supplier", "Terminate Supplier", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        if (respond == DialogResult.OK)
                            display_data();
                    }
                    else
                    {
                        textBox8.Focus();
                    }

                }
            }
            catch
            {
                MessageBox.Show("Supplier Termination Unsuccesful", "Terminate Supplier", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
