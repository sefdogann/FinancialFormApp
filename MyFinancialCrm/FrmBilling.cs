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
    public partial class FrmBilling : Form
    {
        public FrmBilling()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmBilling_Load(object sender, EventArgs e)
        {
           
        }

        private void btnPaymentList_Click(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnNewPayment_Click(object sender, EventArgs e)
        {
            string title =txtBillTitle.Text;
            decimal amount = decimal.Parse(txtBillAmount.Text);
            string period = txtBillPeriod.Text;
            Bills bills = new Bills();
            bills.BillTitle = title;
            bills.BillAmount = amount;
            bills.BillPeriod = period;
            db.Bills.Add(bills);
            db.SaveChanges();
            MessageBox.Show("Payment succesfully added to System!"," Payment & Invoices",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDeletePayment_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBillId.Text);
            var removeValue = db.Bills.Find(id);
            db.Bills.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Payment succesfully Deleted From System!", " Payment & Invoices", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnUpdatePayment_Click(object sender, EventArgs e)
        {
            string title = txtBillTitle.Text;
            decimal amount = decimal.Parse(txtBillAmount.Text);
            string period = txtBillPeriod.Text;
            int id = int.Parse(txtBillId.Text);
            var values = db.Bills.Find(id);
            values.BillTitle = title;
            values.BillAmount = amount;
            values.BillPeriod = period;
            
            db.SaveChanges();
            MessageBox.Show("Payment succesfully Updated on System!", " Payment & Invoices", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e) //Banks Button 
        {
            
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();

        }
    }
}
