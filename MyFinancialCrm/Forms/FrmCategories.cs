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

namespace MyFinancialCrm
{
    public partial class FrmCategories : Form
    {
        
        public FrmCategories()
        {
            InitializeComponent();

        }
        
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        int count = 0;

        private void FrmCategories_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count % 6 == 1)
            {
                var invoices = db.Categories.Where(x => x.CategoryName == "Invoices").Select(y => y.Expense).FirstOrDefault();
                lblCategoryName.Text = "Invoices";
                lblExpense.Text = invoices.ToString() + "$";
                lblTitle.Text = "Where is my money going to?";
                

            }
             if (count % 6 == 2)
            {
                var foodDrink = db.Categories.Where(x => x.CategoryName == "Food-Drink").Select(y => y.Expense).FirstOrDefault();
                lblCategoryName.Text = "Food-Drink";
                lblExpense.Text = foodDrink.ToString() + "$";
                lblTitle.Text = "Why im so broke?";
                


            }
            if (count % 6 == 3)
            {
                var sport = db.Categories.Where(x => x.CategoryName == "Sport").Select(y => y.Expense).FirstOrDefault();
                lblCategoryName.Text = "Sport";
                lblExpense.Text = sport.ToString() + "$";
                lblTitle.Text = "I have to economize it!";
                

            }
            if (count % 6 == 4)
            {
                var school = db.Categories.Where(x => x.CategoryName == "School").Select(y => y.Expense).FirstOrDefault();
                lblCategoryName.Text = "School";
                lblExpense.Text = school.ToString() + "$";
                lblTitle.Text = "I will never be a rich man!";
                

            }
            if (count % 6 == 5)
            {
                var rent = db.Categories.Where(x => x.CategoryName == "Rent").Select(y => y.Expense).FirstOrDefault();
                lblCategoryName.Text = "Rent";
                lblExpense.Text = rent.ToString() + "$";
                lblTitle.Text = "Life is so hard!";
                this.BackColor = Color.Red;
                

            }
             if (count % 6 == 0)
            {
                var transport = db.Categories.Where(x => x.CategoryName == "Transport").Select(y => y.Expense).FirstOrDefault();
                lblCategoryName.Text = "Transport";
                lblExpense.Text = transport.ToString() + "$";
                lblTitle.Text = "Just kidding who cares :D!";
                this.BackColor = Color.SkyBlue;
                

            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDashboardFrm_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            this.Hide();
            frm.Show();
        }

        private void btnBanksfrm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            this.Hide();
            frm.Show();
        }

        private void btnBillsForm_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            this.Hide();
            frm.Show();
        }
    }
}
