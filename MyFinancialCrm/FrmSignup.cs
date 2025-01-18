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

            // empty field control
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            // E-Mail verification
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Geçersiz e-posta formatı.");
                return;
            }


            // SQL Connection string
            string connectionString = "Server =DESKTOP-C9I95FE\\SQLEXPRESS; Database = FinancialCrmDb; Integrated Security = True;";// Sql Connection

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Add user query
                string query = "INSERT INTO users (Username,Password,Email) VALUES (@username, @email, @password)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password); // If you are hashing the password, add it here accordingly.
                command.Parameters.AddWithValue("@email", email);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Kayıt başarılı!");
                    // Clear Form
                    txtUsername.Clear();
                    txtEmail.Clear();
                    txtPassword.Clear();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627) // Unique constraint violation
                        MessageBox.Show("Bu kullanıcı adı veya e-posta zaten kullanılıyor.");
                    else
                        MessageBox.Show($"Hata: {ex.Message}");
                }

                try
                {

                    command.ExecuteNonQuery();

                    MessageBox.Show("Kayıt başarılı! Giriş ekranına yönlendiriliyorsunuz.");

                    
                    FrmLogin loginForm = new FrmLogin();
                    loginForm.Show();

                    
                    this.Hide();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627) // Unique constraint violation
                    {
                        MessageBox.Show("Bu kullanıcı adı veya e-posta zaten kullanılıyor.");
                    }
                    else
                    {
                        MessageBox.Show($"Hata: {ex.Message}");
                    }
                }



            }
        }
        

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; // E-posta formatını kontrol eden Regex
            return Regex.IsMatch(email, pattern);
        }

        

      
    }
}
