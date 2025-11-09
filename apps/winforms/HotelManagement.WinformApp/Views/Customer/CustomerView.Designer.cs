namespace HotelManagement.WinformApp.Views.Customer
{
    partial class CustomerView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grvCustomer = new System.Windows.Forms.DataGridView();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CitizenIdNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCustomerCreateViewOpen = new System.Windows.Forms.Button();
            this.btnCustomerDetailViewOpen = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbCustomerStatusFilter = new System.Windows.Forms.ComboBox();
            this.btnCustomerUpdateViewOpen = new System.Windows.Forms.Button();
            this.btnCustomerSearch = new System.Windows.Forms.Button();
            this.cbbCustomerSearchField = new System.Windows.Forms.ComboBox();
            this.txtCustomerSearch = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.pgnCustomer = new HotelManagement.WinformApp.Controls.PaginationControl();
            this.cbbCustomerPageSize = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grvCustomer)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grvCustomer
            // 
            this.grvCustomer.AllowUserToAddRows = false;
            this.grvCustomer.AllowUserToDeleteRows = false;
            this.grvCustomer.AllowUserToResizeColumns = false;
            this.grvCustomer.AllowUserToResizeRows = false;
            this.grvCustomer.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grvCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Status,
            this.CustomerId,
            this.FullName,
            this.Phone,
            this.Email,
            this.CitizenIdNumber,
            this.Address1,
            this.Address2,
            this.UpdatedAt,
            this.CreatedAt});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvCustomer.DefaultCellStyle = dataGridViewCellStyle3;
            this.grvCustomer.GridColor = System.Drawing.Color.Gainsboro;
            this.grvCustomer.Location = new System.Drawing.Point(24, 117);
            this.grvCustomer.Margin = new System.Windows.Forms.Padding(0);
            this.grvCustomer.Name = "grvCustomer";
            this.grvCustomer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grvCustomer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grvCustomer.RowHeadersWidth = 40;
            this.grvCustomer.RowTemplate.Height = 30;
            this.grvCustomer.RowTemplate.ReadOnly = true;
            this.grvCustomer.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grvCustomer.Size = new System.Drawing.Size(1079, 440);
            this.grvCustomer.TabIndex = 2;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Status.DataPropertyName = "Status";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Status.DefaultCellStyle = dataGridViewCellStyle2;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Width = 77;
            // 
            // CustomerId
            // 
            this.CustomerId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CustomerId.DataPropertyName = "CustomerId";
            this.CustomerId.HeaderText = "ID";
            this.CustomerId.MinimumWidth = 6;
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.Width = 53;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Full name";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.Width = 98;
            // 
            // Phone
            // 
            this.Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.Width = 79;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 74;
            // 
            // CitizenIdNumber
            // 
            this.CitizenIdNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CitizenIdNumber.DataPropertyName = "CitizenIdNumber";
            this.CitizenIdNumber.HeaderText = "Citizen ID";
            this.CitizenIdNumber.Name = "CitizenIdNumber";
            this.CitizenIdNumber.Width = 95;
            // 
            // Address1
            // 
            this.Address1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Address1.DataPropertyName = "Address1";
            this.Address1.HeaderText = "Address 1";
            this.Address1.Name = "Address1";
            this.Address1.Width = 101;
            // 
            // Address2
            // 
            this.Address2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Address2.DataPropertyName = "Address2";
            this.Address2.HeaderText = "Address 2";
            this.Address2.Name = "Address2";
            this.Address2.Width = 101;
            // 
            // UpdatedAt
            // 
            this.UpdatedAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UpdatedAt.DataPropertyName = "UpdatedAt";
            this.UpdatedAt.HeaderText = "Updated at";
            this.UpdatedAt.Name = "UpdatedAt";
            this.UpdatedAt.Width = 107;
            // 
            // CreatedAt
            // 
            this.CreatedAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CreatedAt.DataPropertyName = "CreatedAt";
            this.CreatedAt.HeaderText = "Created at";
            this.CreatedAt.Name = "CreatedAt";
            this.CreatedAt.Width = 102;
            // 
            // btnCustomerCreateViewOpen
            // 
            this.btnCustomerCreateViewOpen.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCustomerCreateViewOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomerCreateViewOpen.FlatAppearance.BorderSize = 0;
            this.btnCustomerCreateViewOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerCreateViewOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnCustomerCreateViewOpen.ForeColor = System.Drawing.Color.White;
            this.btnCustomerCreateViewOpen.Location = new System.Drawing.Point(210, 0);
            this.btnCustomerCreateViewOpen.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnCustomerCreateViewOpen.Name = "btnCustomerCreateViewOpen";
            this.btnCustomerCreateViewOpen.Size = new System.Drawing.Size(250, 24);
            this.btnCustomerCreateViewOpen.TabIndex = 36;
            this.btnCustomerCreateViewOpen.Text = "Add customer";
            this.btnCustomerCreateViewOpen.UseVisualStyleBackColor = false;
            // 
            // btnCustomerDetailViewOpen
            // 
            this.btnCustomerDetailViewOpen.BackColor = System.Drawing.Color.LightGray;
            this.btnCustomerDetailViewOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomerDetailViewOpen.FlatAppearance.BorderSize = 0;
            this.btnCustomerDetailViewOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerDetailViewOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnCustomerDetailViewOpen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnCustomerDetailViewOpen.Location = new System.Drawing.Point(0, 0);
            this.btnCustomerDetailViewOpen.Margin = new System.Windows.Forms.Padding(0);
            this.btnCustomerDetailViewOpen.Name = "btnCustomerDetailViewOpen";
            this.btnCustomerDetailViewOpen.Size = new System.Drawing.Size(200, 24);
            this.btnCustomerDetailViewOpen.TabIndex = 37;
            this.btnCustomerDetailViewOpen.Text = "More detail";
            this.btnCustomerDetailViewOpen.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(24, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 35);
            this.panel1.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 43;
            this.label1.Text = "Customers";
            // 
            // cbbCustomerStatusFilter
            // 
            this.cbbCustomerStatusFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbCustomerStatusFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbCustomerStatusFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbCustomerStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCustomerStatusFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbbCustomerStatusFilter.FormattingEnabled = true;
            this.cbbCustomerStatusFilter.Location = new System.Drawing.Point(24, 81);
            this.cbbCustomerStatusFilter.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.cbbCustomerStatusFilter.Name = "cbbCustomerStatusFilter";
            this.cbbCustomerStatusFilter.Size = new System.Drawing.Size(200, 24);
            this.cbbCustomerStatusFilter.TabIndex = 115;
            // 
            // btnCustomerUpdateViewOpen
            // 
            this.btnCustomerUpdateViewOpen.BackColor = System.Drawing.Color.LightGray;
            this.btnCustomerUpdateViewOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomerUpdateViewOpen.FlatAppearance.BorderSize = 0;
            this.btnCustomerUpdateViewOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerUpdateViewOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnCustomerUpdateViewOpen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnCustomerUpdateViewOpen.Location = new System.Drawing.Point(208, 0);
            this.btnCustomerUpdateViewOpen.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnCustomerUpdateViewOpen.Name = "btnCustomerUpdateViewOpen";
            this.btnCustomerUpdateViewOpen.Size = new System.Drawing.Size(200, 24);
            this.btnCustomerUpdateViewOpen.TabIndex = 120;
            this.btnCustomerUpdateViewOpen.Text = "Update";
            this.btnCustomerUpdateViewOpen.UseVisualStyleBackColor = false;
            // 
            // btnCustomerSearch
            // 
            this.btnCustomerSearch.BackColor = System.Drawing.Color.LightGray;
            this.btnCustomerSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomerSearch.FlatAppearance.BorderSize = 0;
            this.btnCustomerSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnCustomerSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnCustomerSearch.Location = new System.Drawing.Point(722, 0);
            this.btnCustomerSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnCustomerSearch.Name = "btnCustomerSearch";
            this.btnCustomerSearch.Size = new System.Drawing.Size(100, 24);
            this.btnCustomerSearch.TabIndex = 124;
            this.btnCustomerSearch.Text = "Search";
            this.btnCustomerSearch.UseVisualStyleBackColor = false;
            // 
            // cbbCustomerSearchField
            // 
            this.cbbCustomerSearchField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCustomerSearchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbbCustomerSearchField.FormattingEnabled = true;
            this.cbbCustomerSearchField.Location = new System.Drawing.Point(22, 0);
            this.cbbCustomerSearchField.Margin = new System.Windows.Forms.Padding(0);
            this.cbbCustomerSearchField.Name = "cbbCustomerSearchField";
            this.cbbCustomerSearchField.Size = new System.Drawing.Size(200, 24);
            this.cbbCustomerSearchField.TabIndex = 123;
            // 
            // txtCustomerSearch
            // 
            this.txtCustomerSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCustomerSearch.Location = new System.Drawing.Point(222, 0);
            this.txtCustomerSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txtCustomerSearch.Multiline = true;
            this.txtCustomerSearch.Name = "txtCustomerSearch";
            this.txtCustomerSearch.Size = new System.Drawing.Size(500, 24);
            this.txtCustomerSearch.TabIndex = 122;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCustomerCreateViewOpen);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(619, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(460, 24);
            this.flowLayoutPanel1.TabIndex = 126;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnCustomerSearch);
            this.flowLayoutPanel2.Controls.Add(this.txtCustomerSearch);
            this.flowLayoutPanel2.Controls.Add(this.cbbCustomerSearchField);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(281, 81);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.MaximumSize = new System.Drawing.Size(2000, 24);
            this.flowLayoutPanel2.MinimumSize = new System.Drawing.Size(800, 24);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(822, 24);
            this.flowLayoutPanel2.TabIndex = 161;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel3);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Location = new System.Drawing.Point(24, 569);
            this.panel2.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1079, 24);
            this.panel2.TabIndex = 162;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btnCustomerDetailViewOpen);
            this.flowLayoutPanel3.Controls.Add(this.btnCustomerUpdateViewOpen);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(532, 24);
            this.flowLayoutPanel3.TabIndex = 163;
            this.flowLayoutPanel3.WrapContents = false;
            // 
            // pgnCustomer
            // 
            this.pgnCustomer.AutoSize = true;
            this.pgnCustomer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pgnCustomer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pgnCustomer.Location = new System.Drawing.Point(24, 605);
            this.pgnCustomer.MaximumSize = new System.Drawing.Size(2000, 32);
            this.pgnCustomer.MinimumSize = new System.Drawing.Size(700, 32);
            this.pgnCustomer.Name = "pgnCustomer";
            this.pgnCustomer.TotalPages = 1;
            this.pgnCustomer.CurrentPage = 1;
            this.pgnCustomer.Size = new System.Drawing.Size(1079, 32);
            this.pgnCustomer.TabIndex = 163;
            // 
            // cbbCustomerPageSize
            // 
            this.cbbCustomerPageSize.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbCustomerPageSize.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbCustomerPageSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbCustomerPageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCustomerPageSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbbCustomerPageSize.FormattingEnabled = true;
            this.cbbCustomerPageSize.Location = new System.Drawing.Point(903, 617);
            this.cbbCustomerPageSize.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.cbbCustomerPageSize.Name = "cbbCustomerPageSize";
            this.cbbCustomerPageSize.Size = new System.Drawing.Size(200, 24);
            this.cbbCustomerPageSize.TabIndex = 164;
            // 
            // CustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 661);
            this.Controls.Add(this.cbbCustomerPageSize);
            this.Controls.Add(this.pgnCustomer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.cbbCustomerStatusFilter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grvCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1127, 661);
            this.MinimumSize = new System.Drawing.Size(1127, 661);
            this.Name = "CustomerView";
            this.Padding = new System.Windows.Forms.Padding(24);
            this.Text = "jj";
            ((System.ComponentModel.ISupportInitialize)(this.grvCustomer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grvCustomer;
        private System.Windows.Forms.Button btnCustomerCreateViewOpen;
        private System.Windows.Forms.Button btnCustomerDetailViewOpen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbCustomerStatusFilter;
        private System.Windows.Forms.Button btnCustomerUpdateViewOpen;
        private System.Windows.Forms.Button btnCustomerSearch;
        private System.Windows.Forms.ComboBox cbbCustomerSearchField;
        private System.Windows.Forms.TextBox txtCustomerSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn CitizenIdNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address2;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private Controls.PaginationControl pgnCustomer;
        private System.Windows.Forms.ComboBox cbbCustomerPageSize;
    }
}