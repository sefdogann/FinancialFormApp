using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyFinancialCrm.Models;
using MyFinancialCrm.Forms;
using MyFinancialCrm.Logs;

namespace MyFinancialCrm.Forms
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string currentUsername = LoggedInUser.Instance.UserName;
            string currentPassword = LoggedInUser.Instance.Password;

            if (txtUsername.Text == currentUsername && txtPassword.Text == currentPassword)
            {
                // Kullanıcı bilgilerini güncelle
                var user = db.Users.FirstOrDefault(x => x.UserId == LoggedInUser.Instance.UserId);

                if (user != null)
                {
                    user.UserName = txtNewUsername.Text;
                    user.Password = txtNewPassword.Text;

                    db.SaveChanges();
                    MessageBox.Show("The information has been updated successfully.");

                    // LoggedInUser bilgilerini güncelle
                    LoggedInUser.Instance.UserName = user.UserName;
                    LoggedInUser.Instance.Password = user.Password;

                    FrmBanks frm = new FrmBanks();
                    frm.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("The current username or password is incorrect.");
            }
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {

        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Close();
        }
    }

}
