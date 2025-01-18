using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MyFinancialCrm.Models;

namespace MyFinancialCrm
{
    public partial class FrmSignup : Form
    {
        public FrmSignup()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //For go to the Log in Screen
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Hide();
        }
        private void btnSignup_Click(object sender, EventArgs e)
        {
            // Get data from textboxes
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Empty field control
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // E-mail verification
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format.");
                return;
            }

            // SQL connection string
            string connectionString = "Server=DESKTOP-C9I95FE\\SQLEXPRESS; Database=FinancialCrmDb; Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Check if user already exists
                    string checkQuery = "SELECT COUNT(*) FROM users WHERE Username = @username OR Email = @email";
                    SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                    checkCommand.Parameters.AddWithValue("@username", username);
                    checkCommand.Parameters.AddWithValue("@email", email);

                    connection.Open();
                    int exists = (int)checkCommand.ExecuteScalar();
                    connection.Close();

                    if (exists > 0)
                    {
                        MessageBox.Show("This username or email is already in use.");
                        return;
                    }

                    // Add user query
                    string query = "INSERT INTO users (Username, Password, Email) VALUES (@username,@password,@email)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@email", email);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Registration successful! You are directed to the login screen.");

                    // Open login form
                    FrmLogin loginForm = new FrmLogin();
                    loginForm.Show();

                    // Hide current form
                    this.Hide();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        // E-mail validation function
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

      
    }
}
