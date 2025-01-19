namespace MyFinancialCrm
{
    partial class FrmBilling
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSettingsFrm = new System.Windows.Forms.Button();
            this.btnDashboardFrm = new System.Windows.Forms.Button();
            this.btnBankTransactionsFrm = new System.Windows.Forms.Button();
            this.btnExpensesFrm = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdatePayment = new System.Windows.Forms.Button();
            this.btnDeletePayment = new System.Windows.Forms.Button();
            this.btnNewPayment = new System.Windows.Forms.Button();
            this.btnPaymentList = new System.Windows.Forms.Button();
            this.txtBillPeriod = new System.Windows.Forms.TextBox();
            this.txtBillAmount = new System.Windows.Forms.TextBox();
            this.txtBillTitle = new System.Windows.Forms.TextBox();
            this.txtBillId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCategoriesFrm = new System.Windows.Forms.Button();
            this.btnBanksFrm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel1.Controls.Add(this.btnBanksFrm);
            this.panel1.Controls.Add(this.btnCategoriesFrm);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnSettingsFrm);
            this.panel1.Controls.Add(this.btnDashboardFrm);
            this.panel1.Controls.Add(this.btnBankTransactionsFrm);
            this.panel1.Controls.Add(this.btnExpensesFrm);
            this.panel1.Location = new System.Drawing.Point(2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 456);
            this.panel1.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.BorderSize = 3;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(31, 305);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(154, 37);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSettingsFrm
            // 
            this.btnSettingsFrm.FlatAppearance.BorderSize = 3;
            this.btnSettingsFrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingsFrm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettingsFrm.ForeColor = System.Drawing.Color.Transparent;
            this.btnSettingsFrm.Location = new System.Drawing.Point(31, 262);
            this.btnSettingsFrm.Name = "btnSettingsFrm";
            this.btnSettingsFrm.Size = new System.Drawing.Size(154, 37);
            this.btnSettingsFrm.TabIndex = 0;
            this.btnSettingsFrm.Text = "Settings";
            this.btnSettingsFrm.UseVisualStyleBackColor = true;
            this.btnSettingsFrm.Click += new System.EventHandler(this.btnSettingsFrm_Click);
            // 
            // btnDashboardFrm
            // 
            this.btnDashboardFrm.FlatAppearance.BorderSize = 3;
            this.btnDashboardFrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboardFrm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboardFrm.ForeColor = System.Drawing.Color.Transparent;
            this.btnDashboardFrm.Location = new System.Drawing.Point(31, 219);
            this.btnDashboardFrm.Name = "btnDashboardFrm";
            this.btnDashboardFrm.Size = new System.Drawing.Size(154, 37);
            this.btnDashboardFrm.TabIndex = 0;
            this.btnDashboardFrm.Text = "Dashboard";
            this.btnDashboardFrm.UseVisualStyleBackColor = true;
            this.btnDashboardFrm.Click += new System.EventHandler(this.btnDashboardFrm_Click);
            // 
            // btnBankTransactionsFrm
            // 
            this.btnBankTransactionsFrm.FlatAppearance.BorderSize = 3;
            this.btnBankTransactionsFrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBankTransactionsFrm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBankTransactionsFrm.ForeColor = System.Drawing.Color.Transparent;
            this.btnBankTransactionsFrm.Location = new System.Drawing.Point(31, 176);
            this.btnBankTransactionsFrm.Name = "btnBankTransactionsFrm";
            this.btnBankTransactionsFrm.Size = new System.Drawing.Size(154, 37);
            this.btnBankTransactionsFrm.TabIndex = 0;
            this.btnBankTransactionsFrm.Text = "Bank Transactions";
            this.btnBankTransactionsFrm.UseVisualStyleBackColor = true;
            this.btnBankTransactionsFrm.Click += new System.EventHandler(this.btnBankTransactionsFrm_Click);
            // 
            // btnExpensesFrm
            // 
            this.btnExpensesFrm.FlatAppearance.BorderSize = 3;
            this.btnExpensesFrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpensesFrm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpensesFrm.ForeColor = System.Drawing.Color.Transparent;
            this.btnExpensesFrm.Location = new System.Drawing.Point(31, 133);
            this.btnExpensesFrm.Name = "btnExpensesFrm";
            this.btnExpensesFrm.Size = new System.Drawing.Size(154, 37);
            this.btnExpensesFrm.TabIndex = 0;
            this.btnExpensesFrm.Text = "Expenses";
            this.btnExpensesFrm.UseVisualStyleBackColor = true;
            this.btnExpensesFrm.Click += new System.EventHandler(this.btnExpensesFrm_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnUpdatePayment);
            this.panel2.Controls.Add(this.btnDeletePayment);
            this.panel2.Controls.Add(this.btnNewPayment);
            this.panel2.Controls.Add(this.btnPaymentList);
            this.panel2.Controls.Add(this.txtBillPeriod);
            this.panel2.Controls.Add(this.txtBillAmount);
            this.panel2.Controls.Add(this.txtBillTitle);
            this.panel2.Controls.Add(this.txtBillId);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(234, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(631, 186);
            this.panel2.TabIndex = 2;
            // 
            // btnUpdatePayment
            // 
            this.btnUpdatePayment.FlatAppearance.BorderSize = 3;
            this.btnUpdatePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatePayment.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePayment.ForeColor = System.Drawing.Color.Transparent;
            this.btnUpdatePayment.Location = new System.Drawing.Point(461, 146);
            this.btnUpdatePayment.Name = "btnUpdatePayment";
            this.btnUpdatePayment.Size = new System.Drawing.Size(137, 37);
            this.btnUpdatePayment.TabIndex = 2;
            this.btnUpdatePayment.Text = "Update Payment";
            this.btnUpdatePayment.UseVisualStyleBackColor = true;
            this.btnUpdatePayment.Click += new System.EventHandler(this.btnUpdatePayment_Click);
            // 
            // btnDeletePayment
            // 
            this.btnDeletePayment.FlatAppearance.BorderSize = 3;
            this.btnDeletePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePayment.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePayment.ForeColor = System.Drawing.Color.Transparent;
            this.btnDeletePayment.Location = new System.Drawing.Point(318, 146);
            this.btnDeletePayment.Name = "btnDeletePayment";
            this.btnDeletePayment.Size = new System.Drawing.Size(137, 37);
            this.btnDeletePayment.TabIndex = 2;
            this.btnDeletePayment.Text = "Delete Payment";
            this.btnDeletePayment.UseVisualStyleBackColor = true;
            this.btnDeletePayment.Click += new System.EventHandler(this.btnDeletePayment_Click);
            // 
            // btnNewPayment
            // 
            this.btnNewPayment.FlatAppearance.BorderSize = 3;
            this.btnNewPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewPayment.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPayment.ForeColor = System.Drawing.Color.Transparent;
            this.btnNewPayment.Location = new System.Drawing.Point(175, 146);
            this.btnNewPayment.Name = "btnNewPayment";
            this.btnNewPayment.Size = new System.Drawing.Size(137, 37);
            this.btnNewPayment.TabIndex = 2;
            this.btnNewPayment.Text = "New Payment";
            this.btnNewPayment.UseVisualStyleBackColor = true;
            this.btnNewPayment.Click += new System.EventHandler(this.btnNewPayment_Click);
            // 
            // btnPaymentList
            // 
            this.btnPaymentList.FlatAppearance.BorderSize = 3;
            this.btnPaymentList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentList.ForeColor = System.Drawing.Color.Transparent;
            this.btnPaymentList.Location = new System.Drawing.Point(32, 146);
            this.btnPaymentList.Name = "btnPaymentList";
            this.btnPaymentList.Size = new System.Drawing.Size(137, 37);
            this.btnPaymentList.TabIndex = 2;
            this.btnPaymentList.Text = "Payment List";
            this.btnPaymentList.UseVisualStyleBackColor = true;
            this.btnPaymentList.Click += new System.EventHandler(this.btnPaymentList_Click);
            // 
            // txtBillPeriod
            // 
            this.txtBillPeriod.Location = new System.Drawing.Point(85, 112);
            this.txtBillPeriod.Name = "txtBillPeriod";
            this.txtBillPeriod.Size = new System.Drawing.Size(113, 20);
            this.txtBillPeriod.TabIndex = 1;
            // 
            // txtBillAmount
            // 
            this.txtBillAmount.Location = new System.Drawing.Point(85, 79);
            this.txtBillAmount.Name = "txtBillAmount";
            this.txtBillAmount.Size = new System.Drawing.Size(113, 20);
            this.txtBillAmount.TabIndex = 1;
            // 
            // txtBillTitle
            // 
            this.txtBillTitle.Location = new System.Drawing.Point(85, 51);
            this.txtBillTitle.Name = "txtBillTitle";
            this.txtBillTitle.Size = new System.Drawing.Size(113, 20);
            this.txtBillTitle.TabIndex = 1;
            // 
            // txtBillId
            // 
            this.txtBillId.Location = new System.Drawing.Point(85, 19);
            this.txtBillId.Name = "txtBillId";
            this.txtBillId.Size = new System.Drawing.Size(113, 20);
            this.txtBillId.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Period :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Amount :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Title : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bill ID : ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(234, 196);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(631, 242);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(631, 242);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnCategoriesFrm
            // 
            this.btnCategoriesFrm.FlatAppearance.BorderSize = 3;
            this.btnCategoriesFrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoriesFrm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoriesFrm.ForeColor = System.Drawing.Color.Transparent;
            this.btnCategoriesFrm.Location = new System.Drawing.Point(31, 47);
            this.btnCategoriesFrm.Name = "btnCategoriesFrm";
            this.btnCategoriesFrm.Size = new System.Drawing.Size(154, 37);
            this.btnCategoriesFrm.TabIndex = 1;
            this.btnCategoriesFrm.Text = "Categories";
            this.btnCategoriesFrm.UseVisualStyleBackColor = true;
            this.btnCategoriesFrm.Click += new System.EventHandler(this.btnCategoriesFrm_Click);
            // 
            // btnBanksFrm
            // 
            this.btnBanksFrm.FlatAppearance.BorderSize = 3;
            this.btnBanksFrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanksFrm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanksFrm.ForeColor = System.Drawing.Color.Transparent;
            this.btnBanksFrm.Location = new System.Drawing.Point(31, 90);
            this.btnBanksFrm.Name = "btnBanksFrm";
            this.btnBanksFrm.Size = new System.Drawing.Size(154, 37);
            this.btnBanksFrm.TabIndex = 3;
            this.btnBanksFrm.Text = "Banks";
            this.btnBanksFrm.UseVisualStyleBackColor = true;
            this.btnBanksFrm.Click += new System.EventHandler(this.btnBanksFrm_Click);
            // 
            // FrmBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(877, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBilling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Screen";
            this.Load += new System.EventHandler(this.FrmBilling_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSettingsFrm;
        private System.Windows.Forms.Button btnDashboardFrm;
        private System.Windows.Forms.Button btnBankTransactionsFrm;
        private System.Windows.Forms.Button btnExpensesFrm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBillId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUpdatePayment;
        private System.Windows.Forms.Button btnDeletePayment;
        private System.Windows.Forms.Button btnNewPayment;
        private System.Windows.Forms.Button btnPaymentList;
        private System.Windows.Forms.TextBox txtBillPeriod;
        private System.Windows.Forms.TextBox txtBillAmount;
        private System.Windows.Forms.TextBox txtBillTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCategoriesFrm;
        private System.Windows.Forms.Button btnBanksFrm;
    }
}