using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyFinancialCrm.Models;

namespace MyFinancialCrm
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //For go to the Sign Up Screen
            FrmSignup frm = new FrmSignup();
            frm.Show();
            this.Close();
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Get data from TextBoxes
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Empty field control
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter email and password.");
                return;
            }

            // Email verification
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format.");
                return;
            }

            // SQL connection settings
            string connectionString = "Server=DESKTOP-C9I95FE\\SQLEXPRESS;Database=FinancialCrmDb;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Access control query
                string query = "SELECT COUNT(*) FROM users WHERE Email = @Email AND Password = @Password";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Password", password);// Add hashed password if required
                command.Parameters.AddWithValue("@Email", email);
                

                try
                {
                    connection.Open();
                    int userExists = (int)command.ExecuteScalar(); // Get number of users

                    if (userExists == 1 )
                    {
                        MessageBox.Show("Login successful! You are directed to the bank screen.");

                        // Open bank screen
                        FrmBanks bankForm = new FrmBanks();
                        bankForm.Show();

                        // Close current form
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Email or password is incorrect.");
                    }
                }
                catch (Exception ex)
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

