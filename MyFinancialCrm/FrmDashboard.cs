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
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        int count = 0;
        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            var totalBalance =db.Banks.Sum(x=>x.BankBalance);
            lblTotalBalance.Text = totalBalance.ToString() + "$";

            var lastBankProcessAmount = db.BankProcesses.OrderByDescending(x=>x.BankProcessId).Take(1).Select(y=>y.Amount).FirstOrDefault();
            lblLastTransferAmount.Text = lastBankProcessAmount.ToString() + "$";

            //Chart 1 codes
            var bankData = db.Banks.Select(x => new
            {
                x.BankTitle,
                x.BankBalance
            }).ToList();

            chart1.Series.Clear();
            var series = chart1.Series.Add("Series1");
            foreach (var item in bankData) 
            {
                series.Points.AddXY(item.BankTitle, item.BankBalance);

            }

            //Chart 2 Codes

            var billData = db.Bills.Select(x=> new 
            {
                x.BillTitle,
                x.BillAmount

            }).ToList();
            chart2.Series.Clear();
            var series2 = chart2.Series.Add("Invoices");

            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            foreach (var item in billData)
            {
                series2.Points.AddXY(item.BillTitle, item.BillAmount);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count % 4 == 1)
            {
                var electiricty = db.Bills.Where(x=>x.BillTitle=="Electricity").Select(y=>y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Electricity";
                lblBillAmount.Text = electiricty.ToString() + "$";
            }
            if (count % 4 == 2)
            {
                var gas = db.Bills.Where(x => x.BillTitle == "Gas").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Gas";
                lblBillAmount.Text = gas.ToString() + "$";
            }
            if (count % 4 == 3)
            {
                var water = db.Bills.Where(x => x.BillTitle == "Water").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Water";
                lblBillAmount.Text = water.ToString() + "$";
            }
            if (count % 4 == 0)
            {
                var internet = db.Bills.Where(x => x.BillTitle == "Internet").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Internet";
                lblBillAmount.Text = internet.ToString() + "$";
            }
        }
    }
}
