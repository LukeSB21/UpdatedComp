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
using System.Data;

namespace LoginForm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=I:\LoginForm\LoginForm\Database.mdf;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM users WHERE employeeId='" + txtEmployeeID.Text + "'and password='" + txtPassword.Text + "' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                if (dt.Rows[0][4].ToString() == "True")
                {
                    this.Hide();
                    adminMenu data = new adminMenu();
                    data.Show();
                }
                else
                {
                    MessageBox.Show("User does not have access to administrative rights");
                }
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password. Please Try Again.");
                txtPassword.Text = "";
            }
            
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
