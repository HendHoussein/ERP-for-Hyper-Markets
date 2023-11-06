﻿namespace MarketSystem.Windows.UserControls
{
    partial class UC_SupplierActs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dgvClientBills = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBillNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBillType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientBills)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(600, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 85;
            this.label2.Text = "الفترة من";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(335, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(44, 24);
            this.label1.TabIndex = 84;
            this.label1.Text = "الى";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtTo
            // 
            this.dtTo.BorderColor = System.Drawing.Color.LightGray;
            this.dtTo.BorderRadius = 5;
            this.dtTo.BorderThickness = 1;
            this.dtTo.CheckedState.Parent = this.dtTo;
            this.dtTo.FillColor = System.Drawing.Color.White;
            this.dtTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtTo.HoverState.Parent = this.dtTo;
            this.dtTo.Location = new System.Drawing.Point(132, 11);
            this.dtTo.Margin = new System.Windows.Forms.Padding(2);
            this.dtTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtTo.Name = "dtTo";
            this.dtTo.ShadowDecoration.Parent = this.dtTo;
            this.dtTo.Size = new System.Drawing.Size(199, 29);
            this.dtTo.TabIndex = 83;
            this.dtTo.Value = new System.DateTime(2020, 11, 13, 14, 45, 29, 1);
            this.dtTo.ValueChanged += new System.EventHandler(this.dtTo_ValueChanged);
            // 
            // dtFrom
            // 
            this.dtFrom.BorderColor = System.Drawing.Color.LightGray;
            this.dtFrom.BorderRadius = 5;
            this.dtFrom.BorderThickness = 1;
            this.dtFrom.CheckedState.Parent = this.dtFrom;
            this.dtFrom.FillColor = System.Drawing.Color.White;
            this.dtFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtFrom.HoverState.Parent = this.dtFrom;
            this.dtFrom.Location = new System.Drawing.Point(397, 11);
            this.dtFrom.Margin = new System.Windows.Forms.Padding(2);
            this.dtFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.ShadowDecoration.Parent = this.dtFrom;
            this.dtFrom.Size = new System.Drawing.Size(198, 29);
            this.dtFrom.TabIndex = 82;
            this.dtFrom.Value = new System.DateTime(2020, 11, 13, 14, 45, 29, 1);
            this.dtFrom.ValueChanged += new System.EventHandler(this.dtFrom_ValueChanged);
            // 
            // dgvClientBills
            // 
            this.dgvClientBills.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvClientBills.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientBills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientBills.BackgroundColor = System.Drawing.Color.White;
            this.dgvClientBills.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientBills.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvClientBills.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientBills.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientBills.ColumnHeadersHeight = 35;
            this.dgvClientBills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colBillNum,
            this.colBillType,
            this.colItemTotal,
            this.colClient,
            this.colEmp,
            this.colPrice,
            this.colTotalPrice,
            this.colPaid,
            this.colDiscount,
            this.colDept,
            this.colProfit,
            this.colType,
            this.colAccount});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(88)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientBills.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClientBills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientBills.EnableHeadersVisualStyles = false;
            this.dgvClientBills.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(115)))), ((int)(((byte)(167)))));
            this.dgvClientBills.Location = new System.Drawing.Point(0, 49);
            this.dgvClientBills.Margin = new System.Windows.Forms.Padding(2);
            this.dgvClientBills.Name = "dgvClientBills";
            this.dgvClientBills.ReadOnly = true;
            this.dgvClientBills.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvClientBills.RowHeadersVisible = false;
            this.dgvClientBills.RowHeadersWidth = 51;
            this.dgvClientBills.RowTemplate.Height = 30;
            this.dgvClientBills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientBills.Size = new System.Drawing.Size(697, 384);
            this.dgvClientBills.TabIndex = 86;
            this.dgvClientBills.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvClientBills.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvClientBills.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvClientBills.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvClientBills.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.dgvClientBills.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvClientBills.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvClientBills.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(115)))), ((int)(((byte)(167)))));
            this.dgvClientBills.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.dgvClientBills.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvClientBills.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvClientBills.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvClientBills.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvClientBills.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvClientBills.ThemeStyle.ReadOnly = true;
            this.dgvClientBills.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvClientBills.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvClientBills.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvClientBills.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(88)))), ((int)(((byte)(140)))));
            this.dgvClientBills.ThemeStyle.RowsStyle.Height = 30;
            this.dgvClientBills.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.dgvClientBills.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvClientBills.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientBills_CellClick);
            this.dgvClientBills.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientBills_CellDoubleClick);
            // 
            // colDate
            // 
            this.colDate.DataPropertyName = "_date";
            this.colDate.FillWeight = 53.93858F;
            this.colDate.HeaderText = "التاريخ";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colBillNum
            // 
            this.colBillNum.DataPropertyName = "id";
            this.colBillNum.HeaderText = "كود الفاتورة";
            this.colBillNum.MinimumWidth = 6;
            this.colBillNum.Name = "colBillNum";
            this.colBillNum.ReadOnly = true;
            this.colBillNum.Visible = false;
            // 
            // colBillType
            // 
            this.colBillType.DataPropertyName = "id_in_day";
            this.colBillType.FillWeight = 5.768432F;
            this.colBillType.HeaderText = "رقم الفاتورة";
            this.colBillType.MinimumWidth = 6;
            this.colBillType.Name = "colBillType";
            this.colBillType.ReadOnly = true;
            // 
            // colItemTotal
            // 
            this.colItemTotal.DataPropertyName = "item_total_number";
            this.colItemTotal.FillWeight = 5.768432F;
            this.colItemTotal.HeaderText = "عدد الاصناف";
            this.colItemTotal.Name = "colItemTotal";
            this.colItemTotal.ReadOnly = true;
            // 
            // colClient
            // 
            this.colClient.DataPropertyName = "person";
            this.colClient.HeaderText = "العميل";
            this.colClient.Name = "colClient";
            this.colClient.ReadOnly = true;
            this.colClient.Visible = false;
            // 
            // colEmp
            // 
            this.colEmp.DataPropertyName = "employee";
            this.colEmp.HeaderText = "الموظف";
            this.colEmp.Name = "colEmp";
            this.colEmp.ReadOnly = true;
            this.colEmp.Visible = false;
            // 
            // colPrice
            // 
            this.colPrice.DataPropertyName = "price";
            this.colPrice.HeaderText = "المبلغ";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Visible = false;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.DataPropertyName = "totalPrice";
            this.colTotalPrice.FillWeight = 5.768432F;
            this.colTotalPrice.HeaderText = "الاجمالى";
            this.colTotalPrice.MinimumWidth = 6;
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.ReadOnly = true;
            // 
            // colPaid
            // 
            this.colPaid.DataPropertyName = "paid";
            this.colPaid.FillWeight = 5.768432F;
            this.colPaid.HeaderText = "المدفوع";
            this.colPaid.Name = "colPaid";
            this.colPaid.ReadOnly = true;
            // 
            // colDiscount
            // 
            this.colDiscount.DataPropertyName = "discount";
            this.colDiscount.FillWeight = 5.768432F;
            this.colDiscount.HeaderText = "الخصم";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.ReadOnly = true;
            // 
            // colDept
            // 
            this.colDept.DataPropertyName = "rest";
            this.colDept.FillWeight = 5.768432F;
            this.colDept.HeaderText = "الباقى";
            this.colDept.MinimumWidth = 6;
            this.colDept.Name = "colDept";
            this.colDept.ReadOnly = true;
            // 
            // colProfit
            // 
            this.colProfit.DataPropertyName = "profit";
            this.colProfit.HeaderText = "المكسب";
            this.colProfit.Name = "colProfit";
            this.colProfit.ReadOnly = true;
            this.colProfit.Visible = false;
            // 
            // colType
            // 
            this.colType.DataPropertyName = "type";
            this.colType.HeaderText = "النوع";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            this.colType.Visible = false;
            // 
            // colAccount
            // 
            this.colAccount.DataPropertyName = "account";
            this.colAccount.HeaderText = "اكونت";
            this.colAccount.Name = "colAccount";
            this.colAccount.ReadOnly = true;
            this.colAccount.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtTo);
            this.panel1.Controls.Add(this.dtFrom);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 49);
            this.panel1.TabIndex = 87;
            // 
            // UC_SupplierActs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvClientBills);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_SupplierActs";
            this.Size = new System.Drawing.Size(697, 433);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientBills)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtTo;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtFrom;
        private Guna.UI2.WinForms.Guna2DataGridView dgvClientBills;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBillNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBillType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDept;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProfit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccount;
        private System.Windows.Forms.Panel panel1;
    }
}
