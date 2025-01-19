using MyFinancialCrm.Models;
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

namespace MyFinancialCrm.Forms
{
    public partial class FrmBankTransactions : Form
    {
        public FrmBankTransactions()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void BankTransactions_Load(object sender, EventArgs e)
        {
            //Bank Transactions
            try
            {
                var bankProcess1 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).FirstOrDefault();
                lblBankProcess1.Text = bankProcess1 != null
                    ? "| " + bankProcess1.Description + " = " + bankProcess1.Amount + " $" + " | " + "Transfer Date = " + bankProcess1.ProcessDate.ToString() + " |"
                    : "No data available";

                var bankProcess2 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(2).Skip(1).FirstOrDefault();
                lblBankProcess2.Text = bankProcess2 != null
                    ? "| " + bankProcess2.Description + " = " + bankProcess2.Amount + " $" + " | " + "Transfer Date = " + bankProcess2.ProcessDate.ToString() + " |"
                    : "No data available";

                var bankProcess3 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(3).Skip(2).FirstOrDefault();
                lblBankProcess3.Text = bankProcess3 != null
                    ? "| " + bankProcess3.Description + " = " + bankProcess3.Amount + " $" + " | " + "Transfer Date = " + bankProcess3.ProcessDate.ToString() + " |"
                    : "No data available";

                var bankProcess4 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(4).Skip(3).FirstOrDefault();
                lblBankProcess4.Text = bankProcess4 != null
                    ? "| " + bankProcess4.Description + " = " + bankProcess4.Amount + " $" + " | " + "Transfer Date = " + bankProcess4.ProcessDate.ToString() + " |"
                    : "No data available";

                var bankProcess5 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(5).Skip(4).FirstOrDefault();
                lblBankProcess5.Text = bankProcess5 != null
                    ? "| " + bankProcess5.Description + " = " + bankProcess5.Amount + " $" + " | " + "Transfer Date = " + bankProcess5.ProcessDate.ToString() + " |"
                    : "No data available";

                var bankProcess6 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(6).FirstOrDefault();
                lblBankProcess6.Text = bankProcess6 != null
                    ? "| " + bankProcess6.Description + " = " + bankProcess6.Amount + " $" + " | " + "Transfer Date = " + bankProcess6.ProcessDate.ToString() + " |"
                    : "No data available";

                var bankProcess7 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(7).Skip(6).FirstOrDefault();
                lblBankProcess7.Text = bankProcess7 != null
                    ? "| " + bankProcess7.Description + " = " + bankProcess7.Amount + " $" + " | " + "Transfer Date = " + bankProcess7.ProcessDate.ToString() + " |"
                    : "No data available";

                var bankProcess8 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(8).Skip(7).FirstOrDefault();
                lblBankProcess8.Text = bankProcess8 != null
                    ? "| " + bankProcess8.Description + " = " + bankProcess8.Amount + " $" + " | " + "Transfer Date = " + bankProcess8.ProcessDate.ToString() + " |"
                    : "No data available";

                var bankProcess9 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(9).Skip(8).FirstOrDefault();
                lblBankProcess9.Text = bankProcess9 != null
                    ? "| " + bankProcess9.Description + " = " + bankProcess9.Amount + " $" + " | " + "Transfer Date = " + bankProcess9.ProcessDate.ToString() + " |"
                    : "No data available";

                var bankProcess10 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(10).Skip(9).FirstOrDefault();
                lblBankProcess10.Text = bankProcess10 != null
                    ? "| " + bankProcess10.Description + " = " + bankProcess10.Amount + " $" + " | " + "Transfer Date = " + bankProcess10.ProcessDate.ToString() + " |"
                    : "No data available";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }

       

       

      

        private void btnBanksfrm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Close();
        }

        private void btnDashboardFrm_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void btnCategoriesFrm_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            frm.Show();
            this.Close();
        }

        private void btnExpensesFrm_Click(object sender, EventArgs e)
        {
            FrmExpenses frm = new FrmExpenses();
            frm.Show();
            this.Close();

        }

      
        private void btnInvoicesFrm_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Close();

        }

        private void btnSettingsFrm_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.Show();
            this.Close();
        }
    }
}
