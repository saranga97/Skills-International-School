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

namespace SkillsInternational
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Replace with your actual connection string
            string connectionString = "Data Source=your_server_name;Initial Catalog=Student;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT COUNT(1) FROM Logins WHERE username=@username AND password=@password";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            connection.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();

            if (count == 1)
            {
                this.Hide();
                RegistrationForm regForm = new RegistrationForm();
                regForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid Login credentials, please check Username and Password and try again", "Invalid Login Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure, Do you really want to Exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

