using MySql.Data.MySqlClient;
using System.Data;

namespace CS_Employee_Payroll
{
    public partial class Form1 : Form
    {
        MySqlConnection sqlConn = new MySqlConnection();
        MySqlCommand sqlCmd = new MySqlCommand();
        MySqlDataAdapter sqlDtA = new MySqlDataAdapter();
        DataTable sqlDT = new DataTable();
        MySqlDataReader sqlRd;
        DataSet DS = new DataSet();

        String server = "localhost";
        String username = "root";
        String password = "root";
        String database = "employeedb";

        private void uploadData()
        {
            sqlConn.ConnectionString = "server=" + server + ";" + "user id =" + username + ";" + "password = " + password + ";" + "database = " + database;
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "select * from employeedb";

            sqlRd = sqlCmd.ExecuteReader();
            sqlDT.Load(sqlRd);
            sqlRd.Close();
            sqlConn.Close();
            dataGridView1.DataSource = sqlDT;
        }

        private void Refreshdb()
        {
            try
            {


                sqlConn.ConnectionString = "server=" + server + ";" + "user id =" + username + ";" + "password = " + password + ";" + "database = " + database;

                sqlCmd.Connection = sqlConn;

                MySqlDataAdapter sqlDtA = new MySqlDataAdapter("select * from employeedb", sqlConn);
                DataTable sqlDT = new DataTable();

                sqlDtA.Fill(sqlDT);
                dataGridView1.DataSource = sqlDT;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Employee System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        public Form1()
        {
            InitializeComponent();
            uploadData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2(object sender, EventArgs e)
        {

        }

        private void txtFirstName(object sender, EventArgs e)
        {

        }

        private void txtfirstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OtherPay_Click(object sender, EventArgs e)
        {

        }

        private void txtOtherPayment_MouseClick(object sender, MouseEventArgs e)
        {
            txtOtherPayment.Text = "";
            txtOtherPayment.Focus();
        }

        private void txtOtherPayment_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                txtRef.Text = "";
                txtFirstname.Text = "";
                txtLastName.Text = "";
                txtBasicSalary.Text = "";
                txtOverTime.Text = "";
                txtRef.Text = "";
                cobGender.Text = "";
                dateTimePicker1.ResetText();
                txtMobile.Text = "";
                txtAddress.Text = "";

                txtBasicSalary.Text = "";
                txtOverTime.Text = "";
                txtOtherPayment.Text = "0.0";
                txtTax.Text = "";
                txtNetPay.Text = "";
                txtGrossPay.Text = "";
                txtDeductions.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Employee System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                System.Drawing.Font fntString = new System.Drawing.Font("Arial", 16, FontStyle.Regular);
                e.Graphics.DrawString(rtPaySlip.Text, fntString, Brushes.Black, 120, 120);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Employee System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialog1.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Employee System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;
                iExit = MessageBox.Show("Confirm if you want to exit", "Employee System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Employee System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refreshdb();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConn.ConnectionString = "server=" + server + ";" + "user id =" + username + ";" + "password = " + password + ";" + "database = " + database;
                sqlCmd.Connection = sqlConn;
                String ID = txtRef.Text;

                sqlCmd.CommandText = "delete from employeedb where RefID=" + ID + "";
                sqlConn.Open();
                sqlRd = sqlCmd.ExecuteReader();
                MessageBox.Show("Record Deleted", "Employee System", MessageBoxButtons.OK, MessageBoxIcon.Information);

                sqlConn.Close();
                Refreshdb();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Employee System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConn.ConnectionString = "server=" + server + ";" + "user id =" + username + ";" + "password = " + password + ";" + "database = " + database;
                sqlCmd.Connection = sqlConn;
                String ID = txtRef.Text;
                String Firstname = txtFirstname.Text;
                String LastName = txtLastName.Text;
                String BS = txtBasicSalary.Text;
                String Overtime = txtOverTime.Text;
                String Gender = cobGender.Text;
                String paydate = dateTimePicker1.Text;
                String mobile = txtMobile.Text;
                String add = txtAddress.Text;

                String other = txtOtherPayment.Text;
                String tax = txtTax.Text;
                String NP = txtNetPay.Text;
                String GP = txtGrossPay.Text;
                String deduct = txtDeductions.Text;

                sqlCmd.CommandText = "Update employeedb set RefID ='" + ID + "', Firstname ='" + Firstname + "', Lastname = '" + LastName + "', Address = '" + add + "', Gender = '" + Gender + "' ,Mobile = '" + mobile + "', Salary = '" + BS + "', OverTime = '" + Overtime + "',OtherPay = '" + other + "',Tax = '" + tax + "',Deductions = '" + deduct + "',NetPay = '" + NP + "',GrossPay = '" + GP + "', PayDate = '" + paydate + "' where RefID = " + ID + "";


                sqlConn.Open();
                sqlRd = sqlCmd.ExecuteReader();

                MessageBox.Show("Record Updated", "Employee System", MessageBoxButtons.OK, MessageBoxIcon.Information);

                sqlConn.Close();
                Refreshdb();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Employee System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqlConn.Close();

            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (Char)13)
                {
                    DataView dv = sqlDT.DefaultView;
                    dv.RowFilter = string.Format("Firstname like '%{0}%", txtSearch.Text);
                    dataGridView1.DataSource = dv.ToTable();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Employee System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                DataView dv = sqlDT.DefaultView;
                dv.RowFilter = string.Format("Firstname like '%{0}%'", txtSearch.Text);
                dataGridView1.DataSource = dv.ToTable();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Employee System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            try
            {
                double GrossPay, Deductions, NetPay, OtherPay;
                double BasicPay, OverTime, Tax;

                BasicPay = Double.Parse(txtBasicSalary.Text);
                OverTime = Double.Parse(txtOverTime.Text);
                OtherPay = Double.Parse(txtOtherPayment.Text);
                GrossPay = BasicPay + OverTime + OtherPay;
                txtGrossPay.Text = String.Format("{0:C2}", GrossPay);

                Tax = (GrossPay * 10) / 100;

                txtTax.Text = String.Format("{0:C2}", Tax);

                Deductions = Tax;
                txtDeductions.Text = String.Format("{0:C2}", Deductions);

                NetPay = GrossPay - Deductions;
                txtNetPay.Text = String.Format("{0:C2}", NetPay);

                //===============================================================================
                sqlConn.ConnectionString = "server=" + server + ";" + "user id =" + username + ";" + "password = " + password + ";" + "database = " + database;
                sqlConn.Open();
                sqlCmd.Connection = sqlConn;
                sqlCmd.CommandText = "insert into employeedb(RefID, Firstname, Lastname, Address, Gender, Mobile, Salary, OtherPay, OverTime, Tax, Deductions, NetPay, GrossPay, PayDate)" + "values('" + txtRef.Text + "',' " + txtFirstname.Text + "',' " + txtLastName.Text + "',' " + txtAddress.Text + "',' " + cobGender.Text + "',' " + txtMobile.Text + "',' " + txtBasicSalary.Text + "',' " + txtOtherPayment.Text + "',' " + txtOverTime.Text + "',' " + txtTax.Text + "',' " + txtDeductions.Text + "',' " + txtNetPay.Text + "',' " + txtGrossPay.Text + "',' " + dateTimePicker1.Text + "') ";
                sqlCmd.ExecuteNonQuery();
                sqlConn.Close();
                Refreshdb();

                //===============================================================================
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Employee System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }

        private void txtGrossPay_Click(object sender, EventArgs e)
        {

        }

        private void txtOtherPayment_MouseLeave(object sender, EventArgs e)
        {
            if (txtOtherPayment.Text == "")
            {
                txtOtherPayment.Text = "0.0";

            }
        }

        private void btnPayslip_Click(object sender, EventArgs e)
        {
            rtPaySlip.Clear();
            rtPaySlip.AppendText("\t\t" + "Pay Slip" + "\t\t" + "\n");
            rtPaySlip.AppendText("---------------------------------------------------" + "\n");
            rtPaySlip.AppendText("Employee ID" + "\t\t " + txtRef.Text + "\n");
            rtPaySlip.AppendText("Pay Date" + "\t\t " + dateTimePicker1.Text + "\n");
            rtPaySlip.AppendText("First  Name" + "\t\t " + txtFirstname.Text + "\n");
            rtPaySlip.AppendText("Last Name" + "\t\t " + txtLastName.Text + "\n");
            rtPaySlip.AppendText("Address" + "\t\t " + txtAddress.Text + "\n");
            rtPaySlip.AppendText("Gender" + "\t\t " + cobGender.Text + "\n");
            rtPaySlip.AppendText("Mobile number" + "\t\t " + txtMobile.Text + "\n");
            rtPaySlip.AppendText("Basic Salary" + "\t\t " + txtBasicSalary.Text + "\n");
            rtPaySlip.AppendText("Other Pay" + "\t\t " + txtOtherPayment.Text + "\n");
            rtPaySlip.AppendText("Overtime" + "\t\t " + txtOverTime.Text + "\n");
            rtPaySlip.AppendText("Tax" + "\t\t " + txtTax.Text + "\n");
            rtPaySlip.AppendText("Deductions" + "\t\t " + txtDeductions.Text + "\n");
            rtPaySlip.AppendText("Gross Pay" + "\t\t " + txtGrossPay.Text + "\n");
            rtPaySlip.AppendText("Net Pay" + "\t\t " + txtNetPay.Text + "\n");

        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtRef.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtFirstname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtLastName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtAddress.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                cobGender.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                txtMobile.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                txtBasicSalary.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                txtOverTime.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                txtOtherPayment.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                txtTax.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                txtDeductions.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                txtNetPay.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
                txtGrossPay.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
                dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Employee System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Gender_Click(object sender, EventArgs e)
        {

        }

        private void Gender_Dropdown(object sender, EventArgs e)
        {

        }

        private void txtBasicSalary_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
