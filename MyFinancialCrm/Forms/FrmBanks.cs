﻿using MyFinancialCrm.Forms;
using MyFinancialCrm.Models;
using System.Linq;
using System.Windows.Forms;

namespace MyFinancialCrm
{
    public partial class FrmBanks : Form
    {
        
        public FrmBanks()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FrmBanks_Load(object sender, System.EventArgs e)
        {
            //Bank Balance
            var ZiraatBankBalance = db.Banks.Where(x=>x.BankTitle == "ZiraatBank").Select(y=>y.BankBalance).FirstOrDefault();
            var VakifBankBalance = db.Banks.Where(x => x.BankTitle == "VakıfBank").Select(y => y.BankBalance).FirstOrDefault();
            var IsBankBalance = db.Banks.Where(x => x.BankTitle == "IsBank").Select(y => y.BankBalance).FirstOrDefault();

            lblIsBankBalance.Text = IsBankBalance.ToString() + "$";
            lblVakifBankBalance.Text = VakifBankBalance.ToString() + "$";
            lblZiraatBankBalance.Text = ZiraatBankBalance.ToString() + "$";

            //Bank Transactions

            var bankProcess1 = db.BankProcesses.OrderByDescending(x=>x.BankProcessId).Take(1).FirstOrDefault();
            lblBankProcess1.Text = "| "+bankProcess1.Description + " = " + bankProcess1.Amount + " $" + " | "+"Transfer Date = "+bankProcess1.ProcessDate.ToString()+" |";

            var bankProcess2 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(2).Skip(1).FirstOrDefault();
            lblBankProcess2.Text = "| " + bankProcess2.Description + " = " + bankProcess2.Amount + " $" + " | " + "Transfer Date = " + bankProcess2.ProcessDate.ToString() + " |";

            var bankProcess3 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(3).Skip(2).FirstOrDefault();
            lblBankProcess3.Text = "| " + bankProcess3.Description + " = " + bankProcess3.Amount + " $" + " | " + "Transfer Date = " + bankProcess3.ProcessDate.ToString() + " |";

            var bankProcess4 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(4).Skip(3).FirstOrDefault();
            lblBankProcess4.Text = "| " + bankProcess4.Description + " = " + bankProcess4.Amount + " $" + " | " + "Transfer Date = " + bankProcess4.ProcessDate.ToString() + " |";

            var bankProcess5 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(5).Skip(4).FirstOrDefault();
            lblBankProcess5.Text = "| " + bankProcess5.Description + " = " + bankProcess5.Amount + " $" + " | " + "Transfer Date = " + bankProcess5.ProcessDate.ToString() + " |";
        }

        

        private void btnDashboardFrm_Click(object sender, System.EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

       

        private void btnSettingsFrm_Click(object sender, System.EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.Show();
            this.Hide();
        }


        private void btnCategoriesFrm_Click(object sender, System.EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            frm.Show();
            this.Close();
        }

        

        private void btnExpensesFrm_Click(object sender, System.EventArgs e)
        {
            FrmExpenses frm = new FrmExpenses();
            frm.Show();
            this.Close();
        }

        private void btnInvoicesFrm_Click(object sender, System.EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Close();
        }

        private void btnBankTransactionsFrm_Click(object sender, System.EventArgs e)
        {
            FrmBankTransactions frm = new FrmBankTransactions();
            frm.Show();
            this.Close();

        }
    }
}
