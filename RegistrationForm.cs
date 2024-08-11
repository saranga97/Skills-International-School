using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace SkillsInternational
{
    public partial class RegistrationForm : Form
    {
        private string connectionString;

        public RegistrationForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["StudentDBConnectionString"].ConnectionString;
            LoadRegNos();
        }

        private void LoadRegNos()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT regNo FROM Registration";
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbRegNo.Items.Add(reader["regNo"].ToString());
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Registration (regNo, firstName, lastName, dateOfBirth, gender, address, email, mobilePhone, homePhone, parentName, nic, contactNo) " +
                               "VALUES (@regNo, @firstName, @lastName, @dateOfBirth, @gender, @address, @email, @mobilePhone, @homePhone, @parentName, @nic, @contactNo)";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@regNo", cmbRegNo.Text);
                cmd.Parameters.AddWithValue("@firstName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@lastName", txtLastName.Text);
                cmd.Parameters.AddWithValue("@dateOfBirth", dtpDateOfBirth.Value);
                cmd.Parameters.AddWithValue("@gender", rdbMale.Checked ? "Male" : "Female");
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@mobilePhone", txtMobilePhone.Text);
                cmd.Parameters.AddWithValue("@homePhone", txtHomePhone.Text);
                cmd.Parameters.AddWithValue("@parentName", txtParentName.Text);
                cmd.Parameters.AddWithValue("@nic", txtNIC.Text);
                cmd.Parameters.AddWithValue("@contactNo", txtContactNo.Text);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Record Added Successfully", "Register Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Registration SET firstName=@firstName, lastName=@lastName, dateOfBirth=@dateOfBirth, gender=@gender, address=@address, email=@email, mobilePhone=@mobilePhone, homePhone=@homePhone, parentName=@parentName, nic=@nic, contactNo=@contactNo WHERE regNo=@regNo";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@regNo", cmbRegNo.Text);
                cmd.Parameters.AddWithValue("@firstName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@lastName", txtLastName.Text);
                cmd.Parameters.AddWithValue("@dateOfBirth", dtpDateOfBirth.Value);
                cmd.Parameters.AddWithValue("@gender", rdbMale.Checked ? "Male" : "Female");
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@mobilePhone", txtMobilePhone.Text);
                cmd.Parameters.AddWithValue("@homePhone", txtHomePhone.Text);
                cmd.Parameters.AddWithValue("@parentName", txtParentName.Text);
                cmd.Parameters.AddWithValue("@nic", txtNIC.Text);
                cmd.Parameters.AddWithValue("@contactNo", txtContactNo.Text);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Record Updated Successfully", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure, Do you really want to Delete this Record...?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Registration WHERE regNo=@regNo";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@regNo", cmbRegNo.Text);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Record Deleted Successfully", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            cmbRegNo.Text = string.Empty;
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtMobilePhone.Clear();
            txtHomePhone.Clear();
            txtParentName.Clear();
            txtNIC.Clear();
            txtContactNo.Clear();
            rdbMale.Checked = false;
            rdbFemale.Checked = false;
            dtpDateOfBirth.Value = DateTime.Now;
        }

        private void cmbRegNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Registration WHERE regNo=@regNo";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@regNo", cmbRegNo.Text);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtFirstName.Text = reader["firstName"].ToString();
                    txtLastName.Text = reader["lastName"].ToString();
                    dtpDateOfBirth.Value = Convert.ToDateTime(reader["dateOfBirth"]);
                    if (reader["gender"].ToString() == "Male")
                    {
                        rdbMale.Checked = true;
                    }
                    else
                    {
                        rdbFemale.Checked = true;
                    }
                    txtAddress.Text = reader["address"].ToString();
                    txtEmail.Text = reader["email"].ToString();
                    txtMobilePhone.Text = reader["mobilePhone"].ToString();
                    txtHomePhone.Text = reader["homePhone"].ToString();
                    txtParentName.Text = reader["parentName"].ToString();
                    txtNIC.Text = reader["nic"].ToString();
                    txtContactNo.Text = reader["contactNo"].ToString();
                }
                reader.Close();
            }
        }

        private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void linkExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Are you sure, Do you really want to Exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBoxParentDetails_Enter(object sender, EventArgs e)
        {

        }
    }
}

