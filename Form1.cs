using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppDevelop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer();
            cus.TopLevel = false;
            content.Controls.Clear();
            content.Controls.Add(cus);
            cus.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Supplier sup = new Supplier();
            sup.TopLevel = false;
            content.Controls.Clear();
            content.Controls.Add(sup);
            sup.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult respond;
            respond = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if(respond==DialogResult.Yes)
            {
                Application.Exit();
            }
                else
            {
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult respond;
            respond = MessageBox.Show("Do you want to navigate Home?", "Navigate to Home", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (respond == DialogResult.Yes)
            {
                this.Hide();
                Form1 log = new Form1();
                log.ShowDialog();
                this.Close();
                
            }
            else
            {
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bills bil = new Bills();
            bil.TopLevel = false;
            content.Controls.Clear();
            content.Controls.Add(bil);
            bil.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Items itm = new Items();
            itm.TopLevel = false;
            content.Controls.Clear();
            content.Controls.Add(itm);
            itm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Distribute itm = new Distribute();
            itm.TopLevel = false;
            content.Controls.Clear();
            content.Controls.Add(itm);
            itm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Sellers bil = new Sellers();
            bil.TopLevel = false;
            content.Controls.Clear();
            content.Controls.Add(bil);
            bil.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CustomerServices bil = new CustomerServices();
            bil.TopLevel = false;
            content.Controls.Clear();
            content.Controls.Add(bil);
            bil.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            UsersCreate use = new UsersCreate();
            use.TopLevel = false;
            content.Controls.Clear();
            content.Controls.Add(use);
            use.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MonthlyBasis cus = new MonthlyBasis();
            cus.TopLevel = false;
            content.Controls.Clear();
            content.Controls.Add(cus);
            cus.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            CompanyReg cus = new CompanyReg();
            cus.TopLevel = false;
            content.Controls.Clear();
            content.Controls.Add(cus);
            cus.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Employee cus = new Employee();
            cus.TopLevel = false;
            content.Controls.Clear();
            content.Controls.Add(cus);
            cus.Show();
        }
    }
}
