﻿namespace MyFinancialCrm
{
    partial class FrmCategories
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDashboardFrm = new System.Windows.Forms.Button();
            this.btnExpensesFrm = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSettingFrm = new System.Windows.Forms.Button();
            this.btnBankTransactionsFrm = new System.Windows.Forms.Button();
            this.btnBanksfrm = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblExpense = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnInvoicesFrm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.btnInvoicesFrm);
            this.panel1.Controls.Add(this.btnDashboardFrm);
            this.panel1.Controls.Add(this.btnExpensesFrm);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnSettingFrm);
            this.panel1.Controls.Add(this.btnBankTransactionsFrm);
            this.panel1.Controls.Add(this.btnBanksfrm);
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 424);
            this.panel1.TabIndex = 4;
            // 
            // btnDashboardFrm
            // 
            this.btnDashboardFrm.FlatAppearance.BorderSize = 3;
            this.btnDashboardFrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboardFrm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboardFrm.ForeColor = System.Drawing.Color.Transparent;
            this.btnDashboardFrm.Location = new System.Drawing.Point(26, 44);
            this.btnDashboardFrm.Name = "btnDashboardFrm";
            this.btnDashboardFrm.Size = new System.Drawing.Size(151, 37);
            this.btnDashboardFrm.TabIndex = 5;
            this.btnDashboardFrm.Text = "Dashboard";
            this.btnDashboardFrm.UseVisualStyleBackColor = true;
            this.btnDashboardFrm.Click += new System.EventHandler(this.btnDashboardFrm_Click);
            // 
            // btnExpensesFrm
            // 
            this.btnExpensesFrm.FlatAppearance.BorderSize = 3;
            this.btnExpensesFrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpensesFrm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpensesFrm.ForeColor = System.Drawing.Color.Transparent;
            this.btnExpensesFrm.Location = new System.Drawing.Point(26, 130);
            this.btnExpensesFrm.Name = "btnExpensesFrm";
            this.btnExpensesFrm.Size = new System.Drawing.Size(150, 37);
            this.btnExpensesFrm.TabIndex = 1;
            this.btnExpensesFrm.Text = "Expenses";
            this.btnExpensesFrm.UseVisualStyleBackColor = true;
            this.btnExpensesFrm.Click += new System.EventHandler(this.btnExpensesFrm_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.BorderSize = 3;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(26, 302);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 37);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSettingFrm
            // 
            this.btnSettingFrm.FlatAppearance.BorderSize = 3;
            this.btnSettingFrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingFrm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettingFrm.ForeColor = System.Drawing.Color.Transparent;
            this.btnSettingFrm.Location = new System.Drawing.Point(26, 259);
            this.btnSettingFrm.Name = "btnSettingFrm";
            this.btnSettingFrm.Size = new System.Drawing.Size(150, 37);
            this.btnSettingFrm.TabIndex = 0;
            this.btnSettingFrm.Text = "Settings";
            this.btnSettingFrm.UseVisualStyleBackColor = true;
            this.btnSettingFrm.Click += new System.EventHandler(this.btnSettingFrm_Click);
            // 
            // btnBankTransactionsFrm
            // 
            this.btnBankTransactionsFrm.FlatAppearance.BorderSize = 3;
            this.btnBankTransactionsFrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBankTransactionsFrm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBankTransactionsFrm.ForeColor = System.Drawing.Color.Transparent;
            this.btnBankTransactionsFrm.Location = new System.Drawing.Point(26, 216);
            this.btnBankTransactionsFrm.Name = "btnBankTransactionsFrm";
            this.btnBankTransactionsFrm.Size = new System.Drawing.Size(150, 37);
            this.btnBankTransactionsFrm.TabIndex = 0;
            this.btnBankTransactionsFrm.Text = "Bank Transactions";
            this.btnBankTransactionsFrm.UseVisualStyleBackColor = true;
            this.btnBankTransactionsFrm.Click += new System.EventHandler(this.btnBankTransactionsFrm_Click);
            // 
            // btnBanksfrm
            // 
            this.btnBanksfrm.FlatAppearance.BorderSize = 3;
            this.btnBanksfrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanksfrm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanksfrm.ForeColor = System.Drawing.Color.Transparent;
            this.btnBanksfrm.Location = new System.Drawing.Point(26, 87);
            this.btnBanksfrm.Name = "btnBanksfrm";
            this.btnBanksfrm.Size = new System.Drawing.Size(150, 37);
            this.btnBanksfrm.TabIndex = 0;
            this.btnBanksfrm.Text = "Banks";
            this.btnBanksfrm.UseVisualStyleBackColor = true;
            this.btnBanksfrm.Click += new System.EventHandler(this.btnBanksfrm_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 48);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categories / Overview";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblCategoryName);
            this.panel3.Location = new System.Drawing.Point(247, 143);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 6;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryName.Location = new System.Drawing.Point(14, 30);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(183, 33);
            this.lblCategoryName.TabIndex = 0;
            this.lblCategoryName.Text = "CategoryName";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblExpense);
            this.panel5.Location = new System.Drawing.Point(549, 143);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 100);
            this.panel5.TabIndex = 6;
            // 
            // lblExpense
            // 
            this.lblExpense.AutoSize = true;
            this.lblExpense.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpense.Location = new System.Drawing.Point(51, 30);
            this.lblExpense.Name = "lblExpense";
            this.lblExpense.Size = new System.Drawing.Size(105, 33);
            this.lblExpense.TabIndex = 0;
            this.lblExpense.Text = "Expense";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Ravie", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(215, 62);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(411, 36);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Funny Description :D";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.DarkBlue;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(348, 259);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.YValuesPerPoint = 2;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(300, 188);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // btnInvoicesFrm
            // 
            this.btnInvoicesFrm.FlatAppearance.BorderSize = 3;
            this.btnInvoicesFrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoicesFrm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoicesFrm.ForeColor = System.Drawing.Color.Transparent;
            this.btnInvoicesFrm.Location = new System.Drawing.Point(27, 173);
            this.btnInvoicesFrm.Name = "btnInvoicesFrm";
            this.btnInvoicesFrm.Size = new System.Drawing.Size(150, 37);
            this.btnInvoicesFrm.TabIndex = 6;
            this.btnInvoicesFrm.Text = "Invoices";
            this.btnInvoicesFrm.UseVisualStyleBackColor = true;
            this.btnInvoicesFrm.Click += new System.EventHandler(this.btnInvoicesFrm_Click);
            // 
            // FrmCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.FrmCategories_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExpensesFrm;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSettingFrm;
        private System.Windows.Forms.Button btnBankTransactionsFrm;
        private System.Windows.Forms.Button btnBanksfrm;
        private System.Windows.Forms.Button btnDashboardFrm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Label lblExpense;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnInvoicesFrm;
    }
}