namespace MyFinancialCrm
{
    partial class FrmDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblLastTransferAmount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblBillAmount = new System.Windows.Forms.Label();
            this.lblBillTitle = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTotalBalance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnBillsForm = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.chart2);
            this.panel3.Controls.Add(this.chart1);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(177, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(662, 417);
            this.panel3.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(126)))), ((int)(((byte)(176)))));
            this.panel6.Controls.Add(this.lblLastTransferAmount);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(428, 10);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 100);
            this.panel6.TabIndex = 0;
            // 
            // lblLastTransferAmount
            // 
            this.lblLastTransferAmount.AutoSize = true;
            this.lblLastTransferAmount.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastTransferAmount.ForeColor = System.Drawing.Color.Transparent;
            this.lblLastTransferAmount.Location = new System.Drawing.Point(67, 59);
            this.lblLastTransferAmount.Name = "lblLastTransferAmount";
            this.lblLastTransferAmount.Size = new System.Drawing.Size(62, 26);
            this.lblLastTransferAmount.TabIndex = 1;
            this.lblLastTransferAmount.Text = "0.00$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(13, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Last Incoming Transfer";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
            this.panel5.Controls.Add(this.lblBillAmount);
            this.panel5.Controls.Add(this.lblBillTitle);
            this.panel5.Location = new System.Drawing.Point(222, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 100);
            this.panel5.TabIndex = 0;
            // 
            // lblBillAmount
            // 
            this.lblBillAmount.AutoSize = true;
            this.lblBillAmount.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillAmount.ForeColor = System.Drawing.Color.Transparent;
            this.lblBillAmount.Location = new System.Drawing.Point(67, 59);
            this.lblBillAmount.Name = "lblBillAmount";
            this.lblBillAmount.Size = new System.Drawing.Size(62, 26);
            this.lblBillAmount.TabIndex = 1;
            this.lblBillAmount.Text = "0.00$";
            // 
            // lblBillTitle
            // 
            this.lblBillTitle.AutoSize = true;
            this.lblBillTitle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillTitle.ForeColor = System.Drawing.Color.Black;
            this.lblBillTitle.Location = new System.Drawing.Point(53, 16);
            this.lblBillTitle.Name = "lblBillTitle";
            this.lblBillTitle.Size = new System.Drawing.Size(107, 23);
            this.lblBillTitle.TabIndex = 1;
            this.lblBillTitle.Text = "Invoice Title";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.lblTotalBalance);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(16, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 0;
            // 
            // lblTotalBalance
            // 
            this.lblTotalBalance.AutoSize = true;
            this.lblTotalBalance.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBalance.ForeColor = System.Drawing.Color.Transparent;
            this.lblTotalBalance.Location = new System.Drawing.Point(67, 59);
            this.lblTotalBalance.Name = "lblTotalBalance";
            this.lblTotalBalance.Size = new System.Drawing.Size(62, 26);
            this.lblTotalBalance.TabIndex = 1;
            this.lblTotalBalance.Text = "0.00$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(53, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Balance";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btnBillsForm);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-39, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 414);
            this.panel1.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 3;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(64, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 37);
            this.button3.TabIndex = 1;
            this.button3.Text = "Invoices";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button8.FlatAppearance.BorderSize = 3;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Transparent;
            this.button8.Location = new System.Drawing.Point(64, 321);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(137, 37);
            this.button8.TabIndex = 0;
            this.button8.Text = "Exit";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 3;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Transparent;
            this.button7.Location = new System.Drawing.Point(64, 278);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(137, 37);
            this.button7.TabIndex = 0;
            this.button7.Text = "Settings";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 3;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Transparent;
            this.button6.Location = new System.Drawing.Point(64, 235);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(137, 37);
            this.button6.TabIndex = 0;
            this.button6.Text = "Dashboard";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 3;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Transparent;
            this.button5.Location = new System.Drawing.Point(64, 192);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(137, 37);
            this.button5.TabIndex = 0;
            this.button5.Text = "Bank Transactions";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnBillsForm
            // 
            this.btnBillsForm.FlatAppearance.BorderSize = 3;
            this.btnBillsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillsForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillsForm.ForeColor = System.Drawing.Color.Transparent;
            this.btnBillsForm.Location = new System.Drawing.Point(64, 149);
            this.btnBillsForm.Name = "btnBillsForm";
            this.btnBillsForm.Size = new System.Drawing.Size(137, 37);
            this.btnBillsForm.TabIndex = 0;
            this.btnBillsForm.Text = "Expenses";
            this.btnBillsForm.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(64, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 37);
            this.button2.TabIndex = 0;
            this.button2.Text = "Banks";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(64, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Categories";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-39, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(878, 40);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(38, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard / Overview";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(16, 168);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(300, 212);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(328, 168);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Invoices";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(300, 212);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart1";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel7.Controls.Add(this.label3);
            this.panel7.Location = new System.Drawing.Point(17, 117);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(299, 45);
            this.panel7.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel8.Controls.Add(this.label4);
            this.panel8.Location = new System.Drawing.Point(329, 117);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(299, 45);
            this.panel8.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "You can access the banks and the amount of money \r\nin the banks from the chart be" +
    "low.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "You can see the paid and payable invoice amounts\r\n from the chart below.";
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 444);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblLastTransferAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblBillAmount;
        private System.Windows.Forms.Label lblBillTitle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTotalBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnBillsForm;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}