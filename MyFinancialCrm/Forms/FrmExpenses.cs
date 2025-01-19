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
    public partial class FrmExpenses : Form
    {
        public FrmExpenses()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void btnExpenseList_Click(object sender, EventArgs e)
        {
            var values = db.Spending.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnNewExpense_Click(object sender, EventArgs e)
        {
            string title = txtExpenseTitle.Text;
            decimal amount = decimal.Parse(txtExpenseAmount.Text);
            DateTime expenseDate = DateTime.Parse(txtExpenseDate.Text.Trim());
            int categoryid =int.Parse( txtCategoryID.Text);


            Spending spending = new Spending();
            try
            {
                spending.SpendingDate = expenseDate;
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid date format. Please enter a valid date (e.g., yyyy-MM-dd).");
            }
            spending.CategoryId = categoryid;
            spending.SpendingAmount =amount;
            spending.SpendingTitle = title;
            db.Spending.Add(spending);
            db.SaveChanges();
            MessageBox.Show("Expense succesfully added to System!", " Expense & Spending", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDeleteExpense_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtExpenseId.Text);
            var removeValue = db.Spending.Find(id);
            db.Spending.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Expense succesfully Deleted From System!", " Expense & Spending", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdateExpense_Click(object sender, EventArgs e)
        {
            string title = txtExpenseTitle.Text;
            decimal amount = decimal.Parse(txtExpenseAmount.Text); 
            int id = int.Parse(txtExpenseId.Text);
            DateTime expenseDate = DateTime.Parse(txtExpenseDate.Text.Trim());
            int categoryid = int.Parse(txtCategoryID.Text);
            var values = db.Spending.Find(id);
            values.CategoryId = categoryid;
            values.SpendingTitle = title;
            values.SpendingAmount = amount;
            values.SpendingDate = expenseDate;
            db.SaveChanges();
            MessageBox.Show("Expense succesfully Updated on System!", " Expense & Spending", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
