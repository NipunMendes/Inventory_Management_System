namespace WinAppDevelop
{
    partial class Bills
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtbillno = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.combostats = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnstore = new System.Windows.Forms.Button();
            this.btnpay = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txttot = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtitmnme = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtitmid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcmpny = new System.Windows.Forms.TextBox();
            this.txtsupnme = new System.Windows.Forms.TextBox();
            this.txtsupid = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "BILLING DETAILS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1082, 219);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SUPPLIER DETAILS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Bill ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 20);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(215, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(861, 194);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtbillno);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.combostats);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.btnstore);
            this.groupBox2.Controls.Add(this.btnpay);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txttot);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtitmnme);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtitmid);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtcmpny);
            this.groupBox2.Controls.Add(this.txtsupnme);
            this.groupBox2.Controls.Add(this.txtsupid);
            this.groupBox2.Controls.Add(this.txtdate);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 293);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(603, 264);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PAY BILLS";
            // 
            // txtbillno
            // 
            this.txtbillno.Location = new System.Drawing.Point(105, 80);
            this.txtbillno.Name = "txtbillno";
            this.txtbillno.Size = new System.Drawing.Size(117, 20);
            this.txtbillno.TabIndex = 30;
            this.txtbillno.TextChanged += new System.EventHandler(this.txtbillno_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Bill No:";
            // 
            // combostats
            // 
            this.combostats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combostats.FormattingEnabled = true;
            this.combostats.Items.AddRange(new object[] {
            "Payed",
            "Not Payed"});
            this.combostats.Location = new System.Drawing.Point(396, 175);
            this.combostats.Name = "combostats";
            this.combostats.Size = new System.Drawing.Size(117, 21);
            this.combostats.TabIndex = 28;
            this.combostats.SelectedIndexChanged += new System.EventHandler(this.combostats_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(519, 230);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 20);
            this.button4.TabIndex = 27;
            this.button4.Text = "Print";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnstore
            // 
            this.btnstore.Location = new System.Drawing.Point(438, 230);
            this.btnstore.Name = "btnstore";
            this.btnstore.Size = new System.Drawing.Size(75, 20);
            this.btnstore.TabIndex = 26;
            this.btnstore.Text = "Store";
            this.btnstore.UseVisualStyleBackColor = true;
            // 
            // btnpay
            // 
            this.btnpay.Location = new System.Drawing.Point(357, 229);
            this.btnpay.Name = "btnpay";
            this.btnpay.Size = new System.Drawing.Size(75, 20);
            this.btnpay.TabIndex = 4;
            this.btnpay.Text = "Pay";
            this.btnpay.UseVisualStyleBackColor = true;
            this.btnpay.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(282, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Status:";
            // 
            // txttot
            // 
            this.txttot.Location = new System.Drawing.Point(396, 129);
            this.txttot.Name = "txttot";
            this.txttot.Size = new System.Drawing.Size(117, 20);
            this.txttot.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(282, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Total Amount:";
            // 
            // txtitmnme
            // 
            this.txtitmnme.Location = new System.Drawing.Point(396, 81);
            this.txtitmnme.Name = "txtitmnme";
            this.txtitmnme.Size = new System.Drawing.Size(117, 20);
            this.txtitmnme.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(282, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Item Name:";
            // 
            // txtitmid
            // 
            this.txtitmid.Location = new System.Drawing.Point(396, 33);
            this.txtitmid.Name = "txtitmid";
            this.txtitmid.Size = new System.Drawing.Size(117, 20);
            this.txtitmid.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(282, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Item ID:";
            // 
            // txtcmpny
            // 
            this.txtcmpny.Location = new System.Drawing.Point(105, 220);
            this.txtcmpny.Name = "txtcmpny";
            this.txtcmpny.Size = new System.Drawing.Size(117, 20);
            this.txtcmpny.TabIndex = 17;
            // 
            // txtsupnme
            // 
            this.txtsupnme.Location = new System.Drawing.Point(105, 172);
            this.txtsupnme.Name = "txtsupnme";
            this.txtsupnme.Size = new System.Drawing.Size(117, 20);
            this.txtsupnme.TabIndex = 16;
            // 
            // txtsupid
            // 
            this.txtsupid.Location = new System.Drawing.Point(105, 124);
            this.txtsupid.Name = "txtsupid";
            this.txtsupid.Size = new System.Drawing.Size(117, 20);
            this.txtsupid.TabIndex = 15;
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(105, 32);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(117, 20);
            this.txtdate.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Company:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Supplier Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Supplier ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Date:";
            // 
            // Bills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 608);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bills";
            this.Text = "Bills";
            this.Load += new System.EventHandler(this.Bills_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtitmid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcmpny;
        private System.Windows.Forms.TextBox txtsupnme;
        private System.Windows.Forms.TextBox txtsupid;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnstore;
        private System.Windows.Forms.Button btnpay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txttot;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtitmnme;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox combostats;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtbillno;
        private System.Windows.Forms.Label label11;
    }
}