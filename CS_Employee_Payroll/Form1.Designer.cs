namespace CS_Employee_Payroll
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rtPaySlip = new System.Windows.Forms.RichTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.OtherPay = new System.Windows.Forms.Label();
            this.txtOtherPayment = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDeductions = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGrossPay = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNetPay = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOverTime = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBasicSalary = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.cobGender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnPayslip = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(29, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1327, 456);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.button7);
            this.panel6.Controls.Add(this.txtSearch);
            this.panel6.Controls.Add(this.rtPaySlip);
            this.panel6.Location = new System.Drawing.Point(991, 32);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(328, 416);
            this.panel6.TabIndex = 2;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(187, 10);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(93, 27);
            this.button7.TabIndex = 2;
            this.button7.Text = "Search";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(10, 10);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(171, 27);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // rtPaySlip
            // 
            this.rtPaySlip.Location = new System.Drawing.Point(5, 47);
            this.rtPaySlip.Name = "rtPaySlip";
            this.rtPaySlip.Size = new System.Drawing.Size(316, 373);
            this.rtPaySlip.TabIndex = 0;
            this.rtPaySlip.Text = "";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.OtherPay);
            this.panel5.Controls.Add(this.txtOtherPayment);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.txtDeductions);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.txtGrossPay);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.txtNetPay);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.txtTax);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.txtOverTime);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.txtBasicSalary);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.dateTimePicker1);
            this.panel5.Location = new System.Drawing.Point(646, 32);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(339, 405);
            this.panel5.TabIndex = 1;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // OtherPay
            // 
            this.OtherPay.AutoSize = true;
            this.OtherPay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OtherPay.Location = new System.Drawing.Point(28, 162);
            this.OtherPay.Name = "OtherPay";
            this.OtherPay.Size = new System.Drawing.Size(106, 28);
            this.OtherPay.TabIndex = 17;
            this.OtherPay.Text = "Other Pay";
            this.OtherPay.Click += new System.EventHandler(this.OtherPay_Click);
            // 
            // txtOtherPayment
            // 
            this.txtOtherPayment.Location = new System.Drawing.Point(201, 161);
            this.txtOtherPayment.Name = "txtOtherPayment";
            this.txtOtherPayment.Size = new System.Drawing.Size(119, 27);
            this.txtOtherPayment.TabIndex = 16;
            this.txtOtherPayment.Tag = "";
            this.txtOtherPayment.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtOtherPayment_MouseClick);
            this.txtOtherPayment.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtOtherPayment.MouseEnter += new System.EventHandler(this.txtOtherPayment_MouseEnter);
            this.txtOtherPayment.MouseLeave += new System.EventHandler(this.txtOtherPayment_MouseLeave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(28, 154);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 28);
            this.label14.TabIndex = 15;
            this.label14.Tag = "";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // txtDeductions
            // 
            this.txtDeductions.Location = new System.Drawing.Point(201, 231);
            this.txtDeductions.Name = "txtDeductions";
            this.txtDeductions.Size = new System.Drawing.Size(119, 27);
            this.txtDeductions.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(28, 227);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 28);
            this.label11.TabIndex = 13;
            this.label11.Text = "Deductions";
            // 
            // txtGrossPay
            // 
            this.txtGrossPay.Location = new System.Drawing.Point(201, 358);
            this.txtGrossPay.Name = "txtGrossPay";
            this.txtGrossPay.Size = new System.Drawing.Size(119, 27);
            this.txtGrossPay.TabIndex = 12;
            this.txtGrossPay.Click += new System.EventHandler(this.txtGrossPay_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(30, 357);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 28);
            this.label12.TabIndex = 11;
            this.label12.Text = "Gross Pay";
            // 
            // txtNetPay
            // 
            this.txtNetPay.Location = new System.Drawing.Point(201, 271);
            this.txtNetPay.Name = "txtNetPay";
            this.txtNetPay.Size = new System.Drawing.Size(119, 27);
            this.txtNetPay.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(28, 271);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 28);
            this.label13.TabIndex = 9;
            this.label13.Text = "Net Pay";
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(201, 194);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(119, 27);
            this.txtTax.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(28, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 28);
            this.label10.TabIndex = 7;
            this.label10.Text = "Tax";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtOverTime
            // 
            this.txtOverTime.Location = new System.Drawing.Point(201, 124);
            this.txtOverTime.Name = "txtOverTime";
            this.txtOverTime.Size = new System.Drawing.Size(119, 27);
            this.txtOverTime.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(28, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 28);
            this.label9.TabIndex = 5;
            this.label9.Text = "Overtime";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtBasicSalary
            // 
            this.txtBasicSalary.Location = new System.Drawing.Point(201, 86);
            this.txtBasicSalary.Name = "txtBasicSalary";
            this.txtBasicSalary.Size = new System.Drawing.Size(119, 27);
            this.txtBasicSalary.TabIndex = 4;
            this.txtBasicSalary.TextChanged += new System.EventHandler(this.txtBasicSalary_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(28, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 28);
            this.label8.TabIndex = 3;
            this.label8.Text = "Basic Salary";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(28, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 28);
            this.label7.TabIndex = 2;
            this.label7.Text = "Pay Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(28, 47);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(292, 27);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.txtFirstname);
            this.panel4.Controls.Add(this.cobGender);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txtMobile);
            this.panel4.Controls.Add(this.txtAddress);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtLastName);
            this.panel4.Controls.Add(this.txtRef);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(12, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(628, 405);
            this.panel4.TabIndex = 0;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(127, 79);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(456, 27);
            this.txtFirstname.TabIndex = 13;
            this.txtFirstname.TextChanged += new System.EventHandler(this.txtfirstname_TextChanged);
            // 
            // cobGender
            // 
            this.cobGender.FormattingEnabled = true;
            this.cobGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Non-Binary"});
            this.cobGender.Location = new System.Drawing.Point(127, 228);
            this.cobGender.Name = "cobGender";
            this.cobGender.Size = new System.Drawing.Size(155, 28);
            this.cobGender.TabIndex = 12;
            this.cobGender.DropDown += new System.EventHandler(this.Gender_Dropdown);
            this.cobGender.Click += new System.EventHandler(this.Gender_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(26, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mobile";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(26, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 28);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gender";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(127, 272);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(456, 27);
            this.txtMobile.TabIndex = 9;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(127, 178);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(456, 27);
            this.txtAddress.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(26, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(4, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "First Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(127, 125);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(456, 27);
            this.txtLastName.TabIndex = 3;
            // 
            // txtRef
            // 
            this.txtRef.Location = new System.Drawing.Point(127, 31);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(456, 27);
            this.txtRef.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = " Ref No.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(29, 496);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1327, 155);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1300, 127);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.btnPrint);
            this.panel3.Controls.Add(this.btnPayslip);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(29, 669);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1327, 60);
            this.panel3.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1139, 15);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(134, 34);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(977, 15);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(134, 34);
            this.button8.TabIndex = 6;
            this.button8.Text = "Reset";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(818, 15);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(134, 34);
            this.button6.TabIndex = 5;
            this.button6.Text = "Refresh";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(661, 15);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 34);
            this.button5.TabIndex = 4;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(506, 15);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(134, 34);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnPayslip
            // 
            this.btnPayslip.Location = new System.Drawing.Point(349, 15);
            this.btnPayslip.Name = "btnPayslip";
            this.btnPayslip.Size = new System.Drawing.Size(134, 34);
            this.btnPayslip.TabIndex = 2;
            this.btnPayslip.Text = "Pay Slip";
            this.btnPayslip.UseVisualStyleBackColor = true;
            this.btnPayslip.Click += new System.EventHandler(this.btnPayslip_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(188, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Total";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 741);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Panel panel1;
        private Panel panel4;
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private TextBox txtRef;
        private Label label1;
        private DataGridView dataGridView1;
        private Button button6;
        private Button button5;
        private Button btnPrint;
        private Button btnPayslip;
        private Button button2;
        private Button button1;
        private Panel panel6;
        private Label label4;
        private Label label5;
        private TextBox txtMobile;
        private TextBox txtAddress;
        private Label label6;
        private Label label3;
        private Label label2;
        private TextBox txtLastName;
        private TextBox txtOtherPayment;
        private RichTextBox rtPaySlip;
        private ComboBox cobGender;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private TextBox txtTax;
        private Label label10;
        private TextBox txtOverTime;
        private Label label9;
        private TextBox txtBasicSalary;
        private Label label8;
        private TextBox txtDeductions;
        private Label label11;
        private TextBox txtGrossPay;
        private Label label12;
        private TextBox txtNetPay;
        private Label label13;
        private Button button7;
        private TextBox txtSearch;
        private TextBox txtFirstname;
        private Label label14;
        private Label OtherPay;
        private Button btnExit;
        private Button button8;
    }
}