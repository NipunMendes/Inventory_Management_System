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

    public partial class Sellers : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAP-NR\NRSQLSERVER;Initial Catalog=New Electro;Integrated Security=True");
        private DataTable dt;
        private SqlDataAdapter da;
        public Sellers()
        {
            InitializeComponent();
        }

        private void Sellers_Load(object sender, EventArgs e)
        {
            con.Open();
            string displaysql = "select * from Sellers";
            da = new SqlDataAdapter(displaysql, con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }
    }
}
