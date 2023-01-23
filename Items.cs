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
    public partial class Items : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAP-NR\NRSQLSERVER;Initial Catalog=New Electro;Integrated Security=True");
        private SqlDataAdapter da;
        private DataTable dt;
        public Items()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Items_Load(object sender, EventArgs e)
        {
            con.Open();
            string displaysql = "select * from Items";
            da = new SqlDataAdapter(displaysql, con);
            dt = new DataTable();
            da.Fill(dt);
            dat1.DataSource = dt;

            con.Close();

            txtdate3.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnpay_Click(object sender, EventArgs e)
        {

            
        }

        private void btnstore_Click(object sender, EventArgs e)
        { 
                    SqlCommand cmdinsert = new SqlCommand("Insert into Items values( ' " + txtdate3.Text + " ',' " + txtitmid3.Text + " ',' " + txtitmnme3.Text + " ',' " + txtsupid3.Text + " ',' " + txtunprice3.Text + " ',' " + txtstore3.Text + " '   )", con);
                    con.Open();
                    cmdinsert.CommandType = CommandType.Text;
                    cmdinsert.ExecuteNonQuery();
                    con.Close();

                    DialogResult respond;
                    respond = MessageBox.Show("Succesfully Added Stock", "New Stock", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    if (respond == DialogResult.OK)
                    {
                        txtstore3.Text = "";
                        txtdate3.Text = "";
                        txtitmnme3.Text = "";
                        txtitmid3.Text = "";
                        txtunprice3.Text = "";
                        txtsupid3.Text = "";
                    }
        }
    }
}
