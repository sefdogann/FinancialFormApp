namespace MyFinancialCrm.Forms
{
    partial class FrmExpenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExpenses));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInvoicesFrm = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSettingsFrm = new System.Windows.Forms.Button();
            this.btnDashboardFrm = new System.Windows.Forms.Button();
            this.btnBankTransectionsFrm = new System.Windows.Forms.Button();
            this.btnBanksFrm = new System.Windows.Forms.Button();
            this.btnCategoriesFrm = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdateExpense = new System.Windows.Forms.Button();
            this.btnDeleteExpense = new System.Windows.Forms.Button();
            this.btnNewExpense = new System.Windows.Forms.Button();
            this.btnExpenseList = new System.Windows.Forms.Button();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.txtExpenseDate = new System.Windows.Forms.TextBox();
            this.txtExpenseAmount = new System.Windows.Forms.TextBox();
            this.txtExpenseTitle = new System.Windows.Forms.TextBox();
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.txtExpenseId = new System.Windows.Forms.TextBox();
            this.lblExpenseDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel1.Controls.Add(this.btnInvoicesFrm);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnSettingsFrm);
            this.panel1.Controls.Add(this.btnDashboardFrm);
            this.panel1.Controls.Add(this.btnBankTransectionsFrm);
            this.panel1.Controls.Add(this.btnBanksFrm);
            this.panel1.Controls.Add(this.btnCategoriesFrm);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 456);
            this.panel1.TabIndex = 2;
            // 
            // btnInvoicesFrm
            // 
            this.btnInvoicesFrm.FlatAppearance.BorderSize = 3;
            this.btnInvoicesFrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoicesFrm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoicesFrm.ForeColor = System.Drawing.Color.Transparent;
            this.btnInvoicesFrm.Location = new System.Drawing.Point(31, 133);
            this.btnInvoicesFrm.Name = "btnInvoicesFrm";
            this.btnInvoicesFrm.Size = new System.Drawing.Size(154, 37);
            this.btnInvoicesFrm.TabIndex = 3;
            this.btnInvoicesFrm.Text = "Invoices";
            this.btnInvoicesFrm.UseVisualStyleBackColor = true;
            this.btnInvoicesFrm.Click += new System.EventHandler(this.btnInvoicesFrm_Click);
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
            // btnBankTransectionsFrm
            // 
            this.btnBankTransectionsFrm.FlatAppearance.BorderSize = 3;
            this.btnBankTransectionsFrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBankTransectionsFrm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBankTransectionsFrm.ForeColor = System.Drawing.Color.Transparent;
            this.btnBankTransectionsFrm.Location = new System.Drawing.Point(31, 176);
            this.btnBankTransectionsFrm.Name = "btnBankTransectionsFrm";
            this.btnBankTransectionsFrm.Size = new System.Drawing.Size(154, 37);
            this.btnBankTransectionsFrm.TabIndex = 0;
            this.btnBankTransectionsFrm.Text = "Bank Transactions";
            this.btnBankTransectionsFrm.UseVisualStyleBackColor = true;
            this.btnBankTransectionsFrm.Click += new System.EventHandler(this.btnBankTransectionsFrm_Click);
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
            this.btnBanksFrm.TabIndex = 0;
            this.btnBanksFrm.Text = "Banks";
            this.btnBanksFrm.UseVisualStyleBackColor = true;
            this.btnBanksFrm.Click += new System.EventHandler(this.btnBanksFrm_Click);
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
            this.btnCategoriesFrm.TabIndex = 0;
            this.btnCategoriesFrm.Text = "Categories";
            this.btnCategoriesFrm.UseVisualStyleBackColor = true;
            this.btnCategoriesFrm.Click += new System.EventHandler(this.btnCategoriesFrm_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.btnUpdateExpense);
            this.panel2.Controls.Add(this.btnDeleteExpense);
            this.panel2.Controls.Add(this.btnNewExpense);
            this.panel2.Controls.Add(this.btnExpenseList);
            this.panel2.Controls.Add(this.txtCategoryID);
            this.panel2.Controls.Add(this.txtExpenseDate);
            this.panel2.Controls.Add(this.txtExpenseAmount);
            this.panel2.Controls.Add(this.txtExpenseTitle);
            this.panel2.Controls.Add(this.lblCategoryId);
            this.panel2.Controls.Add(this.txtExpenseId);
            this.panel2.Controls.Add(this.lblExpenseDate);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(192, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(609, 213);
            this.panel2.TabIndex = 3;
            // 
            // btnUpdateExpense
            // 
            this.btnUpdateExpense.FlatAppearance.BorderSize = 3;
            this.btnUpdateExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateExpense.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateExpense.ForeColor = System.Drawing.Color.Transparent;
            this.btnUpdateExpense.Location = new System.Drawing.Point(461, 168);
            this.btnUpdateExpense.Name = "btnUpdateExpense";
            this.btnUpdateExpense.Size = new System.Drawing.Size(137, 37);
            this.btnUpdateExpense.TabIndex = 2;
            this.btnUpdateExpense.Text = "Update Expense";
            this.btnUpdateExpense.UseVisualStyleBackColor = true;
            this.btnUpdateExpense.Click += new System.EventHandler(this.btnUpdateExpense_Click);
            // 
            // btnDeleteExpense
            // 
            this.btnDeleteExpense.FlatAppearance.BorderSize = 3;
            this.btnDeleteExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteExpense.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteExpense.ForeColor = System.Drawing.Color.Transparent;
            this.btnDeleteExpense.Location = new System.Drawing.Point(318, 168);
            this.btnDeleteExpense.Name = "btnDeleteExpense";
            this.btnDeleteExpense.Size = new System.Drawing.Size(137, 37);
            this.btnDeleteExpense.TabIndex = 2;
            this.btnDeleteExpense.Text = "Delete Expense";
            this.btnDeleteExpense.UseVisualStyleBackColor = true;
            this.btnDeleteExpense.Click += new System.EventHandler(this.btnDeleteExpense_Click);
            // 
            // btnNewExpense
            // 
            this.btnNewExpense.FlatAppearance.BorderSize = 3;
            this.btnNewExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewExpense.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewExpense.ForeColor = System.Drawing.Color.Transparent;
            this.btnNewExpense.Location = new System.Drawing.Point(175, 168);
            this.btnNewExpense.Name = "btnNewExpense";
            this.btnNewExpense.Size = new System.Drawing.Size(137, 37);
            this.btnNewExpense.TabIndex = 2;
            this.btnNewExpense.Text = "New Expense";
            this.btnNewExpense.UseVisualStyleBackColor = true;
            this.btnNewExpense.Click += new System.EventHandler(this.btnNewExpense_Click);
            // 
            // btnExpenseList
            // 
            this.btnExpenseList.FlatAppearance.BorderSize = 3;
            this.btnExpenseList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpenseList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpenseList.ForeColor = System.Drawing.Color.Transparent;
            this.btnExpenseList.Location = new System.Drawing.Point(32, 168);
            this.btnExpenseList.Name = "btnExpenseList";
            this.btnExpenseList.Size = new System.Drawing.Size(137, 37);
            this.btnExpenseList.TabIndex = 2;
            this.btnExpenseList.Text = "Expenses List";
            this.btnExpenseList.UseVisualStyleBackColor = true;
            this.btnExpenseList.Click += new System.EventHandler(this.btnExpenseList_Click);
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Location = new System.Drawing.Point(255, 123);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.Size = new System.Drawing.Size(113, 20);
            this.txtCategoryID.TabIndex = 1;
            // 
            // txtExpenseDate
            // 
            this.txtExpenseDate.Location = new System.Drawing.Point(255, 97);
            this.txtExpenseDate.Name = "txtExpenseDate";
            this.txtExpenseDate.Size = new System.Drawing.Size(113, 20);
            this.txtExpenseDate.TabIndex = 1;
            // 
            // txtExpenseAmount
            // 
            this.txtExpenseAmount.Location = new System.Drawing.Point(255, 70);
            this.txtExpenseAmount.Name = "txtExpenseAmount";
            this.txtExpenseAmount.Size = new System.Drawing.Size(113, 20);
            this.txtExpenseAmount.TabIndex = 1;
            // 
            // txtExpenseTitle
            // 
            this.txtExpenseTitle.Location = new System.Drawing.Point(255, 42);
            this.txtExpenseTitle.Name = "txtExpenseTitle";
            this.txtExpenseTitle.Size = new System.Drawing.Size(113, 20);
            this.txtExpenseTitle.TabIndex = 1;
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryId.Location = new System.Drawing.Point(154, 124);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(92, 19);
            this.lblCategoryId.TabIndex = 0;
            this.lblCategoryId.Text = "CategoryID :";
            // 
            // txtExpenseId
            // 
            this.txtExpenseId.Location = new System.Drawing.Point(255, 11);
            this.txtExpenseId.Name = "txtExpenseId";
            this.txtExpenseId.Size = new System.Drawing.Size(113, 20);
            this.txtExpenseId.TabIndex = 1;
            // 
            // lblExpenseDate
            // 
            this.lblExpenseDate.AutoSize = true;
            this.lblExpenseDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpenseDate.Location = new System.Drawing.Point(138, 99);
            this.lblExpenseDate.Name = "lblExpenseDate";
            this.lblExpenseDate.Size = new System.Drawing.Size(108, 19);
            this.lblExpenseDate.TabIndex = 0;
            this.lblExpenseDate.Text = "Expense Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Amount :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Title : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ExpenseID :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(192, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(516, 244);
            this.dataGridView1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(707, 212);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FrmExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmExpenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expenses";
            this.Load += new System.EventHandler(this.FrmExpenses_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSettingsFrm;
        private System.Windows.Forms.Button btnDashboardFrm;
        private System.Windows.Forms.Button btnBankTransectionsFrm;
        private System.Windows.Forms.Button btnBanksFrm;
        private System.Windows.Forms.Button btnCategoriesFrm;
        private System.Windows.Forms.Button btnInvoicesFrm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUpdateExpense;
        private System.Windows.Forms.Button btnDeleteExpense;
        private System.Windows.Forms.Button btnNewExpense;
        private System.Windows.Forms.Button btnExpenseList;
        private System.Windows.Forms.TextBox txtExpenseAmount;
        private System.Windows.Forms.TextBox txtExpenseTitle;
        private System.Windows.Forms.TextBox txtExpenseId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.TextBox txtExpenseDate;
        private System.Windows.Forms.Label lblCategoryId;
        private System.Windows.Forms.Label lblExpenseDate;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}