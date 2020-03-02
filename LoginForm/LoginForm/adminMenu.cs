using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace LoginForm
{
    public partial class adminMenu : Form
    {
        new int errorCounter = 0;
        public adminMenu()
        {
            InitializeComponent();
        }

        private void EmployeeData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet1.role' table. You can move, or remove it, as needed.
            this.roleTableAdapter.Fill(this.databaseDataSet1.role);
            // TODO: This line of code loads data into the 'databaseDataSet1.department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.databaseDataSet1.department);
            // TODO: This line of code loads data into the 'databaseDataSet.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.databaseDataSet.employee);
            // TODO: This line of code loads data into the 'databaseDataSet1.employeeData' table. You can move, or remove it, as needed.
            //this.employeeDataTableAdapter.Fill(this.databaseDataSet1.employeeData);
            gridviewRefresh();
        }

        public void validation()
        {
            if (txtEmployeeId.Text == "")
            {
                MessageBox.Show("Please enter a value for the Employee ID");
                errorCounter++;
            }
            else if (txtFirstName.Text == "")
            {
                MessageBox.Show("Please enter a value for the Employee Name");
                errorCounter++;
            }
            else if (txtLastName.Text == "")
            {
                MessageBox.Show("Please enter a value for the Employee Email");
                errorCounter++;
            }
        }

        public void gridviewRefresh()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=I:\LoginForm\LoginForm\Database.mdf;Integrated Security=True");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM employee", con);
            DataSet data = new DataSet();
            da.Fill(data, "insertData");
            dataGridView1.DataSource = data;
            dataGridView1.DataMember = "insertData";
            dataGridView2.DataSource = data;
            dataGridView2.DataMember = "insertData";
            con.Close();
        }
        public void gridviewRefresh1()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=I:\LoginForm\LoginForm\Database.mdf;Integrated Security=True");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT employeeId,firstName,lastName FROM employee", con);
            DataSet data = new DataSet();
            da.Fill(data, "insertData");
            dataGridView3.DataSource = data;
            dataGridView3.DataMember = "insertData";
            con.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            validation();
            if (errorCounter == 0)
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=I:\LoginForm\LoginForm\Database.mdf;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO employee(firstName,lastName,joinDate,dateOfBirth) VALUES('" + txtFirstName.Text + "','" + txtLastName.Text + "','" + dtJoinDate.Text + "','" + dtDateOfBirth.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Added");
                gridviewRefresh();
            }     
            else
            {
                MessageBox.Show("Please correct errors before continuing");
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=I:\LoginForm\LoginForm\Database.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"UPDATE employee
            SET             firstName ='" + txtFirstName.Text + "',lastName ='" + txtLastName.Text + "',joinDate ='" + dtJoinDate.Text + "',dateOfBirth ='" + dtDateOfBirth.Text + "' WHERE (employeeId = '" + txtEmployeeId.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated");
            gridviewRefresh();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtEmployeeId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=I:\LoginForm\LoginForm\Database.mdf;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM employee WHERE (employeeId = '" + txtEmployeeId.Text + "')", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    txtEmployeeId.Text = dt.Rows[0]["employeeId"].ToString();
                    txtFirstName.Text = dt.Rows[0]["firstName"].ToString();
                    txtLastName.Text = dt.Rows[0]["lastName"].ToString();
                    dtJoinDate.Text = dt.Rows[0]["joinDate"].ToString();
                    dtDateOfBirth.Text = dt.Rows[0]["dateOfBirth"].ToString();
                }
                else
                {
                    gridviewRefresh();
                }
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=I:\LoginForm\LoginForm\Database.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"DELETE FROM employee WHERE (employeeId = '" + txtEmployeeId.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Deleted");
            gridviewRefresh();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtEmployeeId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            dtJoinDate.Value = System.DateTime.Now;
            dtDateOfBirth.Value = System.DateTime.Now;
        }

        private void AddEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAssignLogin.Hide();
            pnlAssignEmployee.Hide();
            pnlViewEmployees.Hide();
            btnDelete.Hide();
            btnUpdate.Hide();
            lblEmployeeId.Hide();
            txtEmployeeId.Hide();
            pnlEmployee.Show();
            btnAdd.Show();
            gridviewRefresh();
        }

        private void AdminMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void UpdateEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAssignLogin.Hide();
            pnlAssignEmployee.Hide();
            pnlViewEmployees.Hide();
            btnAdd.Hide();
            btnDelete.Hide();
            lblEmployeeId.Show();
            txtEmployeeId.Show();
            pnlEmployee.Show();
            btnUpdate.Show();
            gridviewRefresh();
        }

        private void DeleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAssignLogin.Hide();
            pnlAssignEmployee.Hide();
            pnlViewEmployees.Hide();
            btnAdd.Hide();
            btnUpdate.Hide();
            pnlEmployee.Show();
            lblEmployeeId.Show();
            txtEmployeeId.Show();
            btnDelete.Show();
            gridviewRefresh();
        }

        private void AssignEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlEmployee.Hide();
            pnlViewEmployees.Hide();
            pnlAssignLogin.Hide();
            pnlAssignEmployee.Show();
            gridviewRefresh1();
        }

        private void ViewEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridviewRefresh();
            pnlAssignLogin.Hide();
            pnlAssignEmployee.Hide();
            pnlEmployee.Hide();
            pnlViewEmployees.Show();
            
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=I:\LoginForm\LoginForm\Database.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO departmentRole(roleId,departmentId,employeeId) VALUES('" + comboRole.SelectedValue + "','" + comboDepartment.SelectedValue + "','" + comboEmpId.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            gridviewRefresh1();
        }

        private void TxtSearchFN_TextChanged(object sender, EventArgs e)
        {
            DataView dv = this.databaseDataSet.employee.DefaultView;
            dv.RowFilter = string.Format("firstName LIKE '%{0}%'", txtSearchFN.Text);
            dataGridView2.DataSource = dv.ToTable();
        }

        private void TxtSearchLN_TextChanged(object sender, EventArgs e)
        {
            DataView dv = this.databaseDataSet.employee.DefaultView;
            dv.RowFilter = string.Format("lastName LIKE '%{0}%'", txtSearchLN.Text);
            dataGridView2.DataSource = dv.ToTable();
        }

        private void AssignUserLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAssignEmployee.Hide();
            pnlEmployee.Hide();
            pnlViewEmployees.Hide();
            pnlAssignLogin.Show();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (radioAdmin.Checked == true)
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=I:\LoginForm\LoginForm\Database.mdf;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO users(employeeId,email,password,isAdmin) VALUES('" + comboEmployeeId.Text + "','" + txtEmail.Text + "','" + txtPassword.Text + "','" + "True" + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("New Admin Created");
            }
            else if (radioUser.Checked == true)
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=I:\LoginForm\LoginForm\Database.mdf;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO users(employeeId,email,password,isAdmin) VALUES('" + comboEmployeeId.Text + "','" + txtEmail.Text + "','" + txtPassword.Text + "','" + "False" + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("New User Created");
            }
            
        }

        private void ComboEmployeeId_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=I:\LoginForm\LoginForm\Database.mdf;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM employee WHERE (employeeId = '" + comboEmployeeId.Text + "')", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                lblFirstName.Visible = true;
                lblLastName.Visible = true;
                lblFirstName.Text = dt.Rows[0]["firstName"].ToString();
                lblLastName.Text = dt.Rows[0]["lastName"].ToString();
            }
            else
            {
                MessageBox.Show("");
            }
        }

        private void CheckBookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
