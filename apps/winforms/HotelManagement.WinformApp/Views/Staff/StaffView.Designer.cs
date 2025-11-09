namespace HotelManagement.WinformApp.Views.Staff
{
    partial class EmployeeView

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
            this.grvStaff = new System.Windows.Forms.DataGridView();
            this.AccountStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnStaffAdd = new System.Windows.Forms.Button();
            this.cbbStaffRoleFilter = new System.Windows.Forms.ComboBox();
            this.btnStaffUpdate = new System.Windows.Forms.Button();
            this.cbbStaffStatusFilter = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnStaffSearch = new System.Windows.Forms.Button();
            this.txtStaffSearch = new System.Windows.Forms.TextBox();
            this.cbbStaffSearchField = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pgnStaffView = new HotelManagement.WinformApp.Controls.PaginationControl();
            this.cbbStaffPageSize = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grvStaff)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grvStaff
            // 
            this.grvStaff.AllowUserToAddRows = false;
            this.grvStaff.AllowUserToDeleteRows = false;
            this.grvStaff.AllowUserToResizeColumns = false;
            this.grvStaff.AllowUserToResizeRows = false;
            this.grvStaff.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grvStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvStaff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountStatus,
            this.StaffId,
            this.FullName,
            this.email,
            this.phone,
            this.dob,
            this.role,
            this.CreatedAt,
            this.UpdatedAt});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvStaff.DefaultCellStyle = dataGridViewCellStyle3;
            this.grvStaff.GridColor = System.Drawing.Color.Gainsboro;
            this.grvStaff.Location = new System.Drawing.Point(24, 254);
            this.grvStaff.Margin = new System.Windows.Forms.Padding(0);
            this.grvStaff.Name = "grvStaff";
            this.grvStaff.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grvStaff.RowHeadersWidth = 40;
            this.grvStaff.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grvStaff.RowTemplate.Height = 30;
            this.grvStaff.RowTemplate.ReadOnly = true;
            this.grvStaff.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grvStaff.Size = new System.Drawing.Size(1079, 303);
            this.grvStaff.TabIndex = 2;
            // 
            // AccountStatus
            // 
            this.AccountStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AccountStatus.DataPropertyName = "AccountStatus";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8);
            this.AccountStatus.DefaultCellStyle = dataGridViewCellStyle2;
            this.AccountStatus.HeaderText = "Account status";
            this.AccountStatus.Name = "AccountStatus";
            this.AccountStatus.Width = 126;
            // 
            // StaffId
            // 
            this.StaffId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StaffId.DataPropertyName = "StaffId";
            this.StaffId.HeaderText = "ID";
            this.StaffId.Name = "StaffId";
            this.StaffId.Width = 53;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Full name";
            this.FullName.Name = "FullName";
            this.FullName.Width = 98;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.Width = 74;
            // 
            // phone
            // 
            this.phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.phone.DataPropertyName = "Phone";
            this.phone.HeaderText = "Phone";
            this.phone.Name = "phone";
            this.phone.Width = 79;
            // 
            // dob
            // 
            this.dob.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dob.DataPropertyName = "Dob";
            this.dob.HeaderText = "Birth";
            this.dob.Name = "dob";
            this.dob.Width = 66;
            // 
            // role
            // 
            this.role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.role.DataPropertyName = "Role";
            this.role.HeaderText = "Role";
            this.role.Name = "role";
            this.role.Width = 69;
            // 
            // CreatedAt
            // 
            this.CreatedAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CreatedAt.DataPropertyName = "CreatedAt";
            this.CreatedAt.HeaderText = "Created at";
            this.CreatedAt.Name = "CreatedAt";
            this.CreatedAt.Width = 102;
            // 
            // UpdatedAt
            // 
            this.UpdatedAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UpdatedAt.DataPropertyName = "UpdatedAt";
            this.UpdatedAt.HeaderText = "Updated at";
            this.UpdatedAt.Name = "UpdatedAt";
            this.UpdatedAt.Width = 107;
            // 
            // btnStaffAdd
            // 
            this.btnStaffAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnStaffAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStaffAdd.FlatAppearance.BorderSize = 0;
            this.btnStaffAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnStaffAdd.ForeColor = System.Drawing.Color.White;
            this.btnStaffAdd.Location = new System.Drawing.Point(127, 0);
            this.btnStaffAdd.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnStaffAdd.Name = "btnStaffAdd";
            this.btnStaffAdd.Size = new System.Drawing.Size(250, 24);
            this.btnStaffAdd.TabIndex = 36;
            this.btnStaffAdd.Text = "Add staff";
            this.btnStaffAdd.UseVisualStyleBackColor = false;
            // 
            // cbbStaffRoleFilter
            // 
            this.cbbStaffRoleFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbStaffRoleFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbStaffRoleFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbStaffRoleFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStaffRoleFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbbStaffRoleFilter.FormattingEnabled = true;
            this.cbbStaffRoleFilter.Items.AddRange(new object[] {
            "Book genre",
            "Book author"});
            this.cbbStaffRoleFilter.Location = new System.Drawing.Point(84, 0);
            this.cbbStaffRoleFilter.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.cbbStaffRoleFilter.Name = "cbbStaffRoleFilter";
            this.cbbStaffRoleFilter.Size = new System.Drawing.Size(220, 24);
            this.cbbStaffRoleFilter.TabIndex = 115;
            // 
            // btnStaffUpdate
            // 
            this.btnStaffUpdate.BackColor = System.Drawing.Color.LightGray;
            this.btnStaffUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStaffUpdate.FlatAppearance.BorderSize = 0;
            this.btnStaffUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnStaffUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnStaffUpdate.Location = new System.Drawing.Point(0, 0);
            this.btnStaffUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.btnStaffUpdate.Name = "btnStaffUpdate";
            this.btnStaffUpdate.Size = new System.Drawing.Size(200, 24);
            this.btnStaffUpdate.TabIndex = 175;
            this.btnStaffUpdate.Text = "Update";
            this.btnStaffUpdate.UseVisualStyleBackColor = false;
            // 
            // cbbStaffStatusFilter
            // 
            this.cbbStaffStatusFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbStaffStatusFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbStaffStatusFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbStaffStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStaffStatusFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbbStaffStatusFilter.FormattingEnabled = true;
            this.cbbStaffStatusFilter.Items.AddRange(new object[] {
            "Book genre",
            "Book author"});
            this.cbbStaffStatusFilter.Location = new System.Drawing.Point(304, 0);
            this.cbbStaffStatusFilter.Margin = new System.Windows.Forms.Padding(0);
            this.cbbStaffStatusFilter.Name = "cbbStaffStatusFilter";
            this.cbbStaffStatusFilter.Size = new System.Drawing.Size(267, 24);
            this.cbbStaffStatusFilter.TabIndex = 179;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnStaffAdd);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(702, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(377, 24);
            this.flowLayoutPanel1.TabIndex = 181;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnStaffSearch);
            this.flowLayoutPanel2.Controls.Add(this.txtStaffSearch);
            this.flowLayoutPanel2.Controls.Add(this.cbbStaffSearchField);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(281, 115);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.flowLayoutPanel2.MaximumSize = new System.Drawing.Size(2000, 24);
            this.flowLayoutPanel2.MinimumSize = new System.Drawing.Size(800, 24);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(822, 24);
            this.flowLayoutPanel2.TabIndex = 182;
            // 
            // btnStaffSearch
            // 
            this.btnStaffSearch.BackColor = System.Drawing.Color.LightGray;
            this.btnStaffSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStaffSearch.FlatAppearance.BorderSize = 0;
            this.btnStaffSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnStaffSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnStaffSearch.Location = new System.Drawing.Point(722, 0);
            this.btnStaffSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnStaffSearch.Name = "btnStaffSearch";
            this.btnStaffSearch.Size = new System.Drawing.Size(100, 24);
            this.btnStaffSearch.TabIndex = 124;
            this.btnStaffSearch.Text = "Search";
            this.btnStaffSearch.UseVisualStyleBackColor = false;
            // 
            // txtStaffSearch
            // 
            this.txtStaffSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtStaffSearch.Location = new System.Drawing.Point(222, 0);
            this.txtStaffSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txtStaffSearch.Multiline = true;
            this.txtStaffSearch.Name = "txtStaffSearch";
            this.txtStaffSearch.Size = new System.Drawing.Size(500, 24);
            this.txtStaffSearch.TabIndex = 122;
            // 
            // cbbStaffSearchField
            // 
            this.cbbStaffSearchField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStaffSearchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbbStaffSearchField.FormattingEnabled = true;
            this.cbbStaffSearchField.Location = new System.Drawing.Point(22, 0);
            this.cbbStaffSearchField.Margin = new System.Windows.Forms.Padding(0);
            this.cbbStaffSearchField.Name = "cbbStaffSearchField";
            this.cbbStaffSearchField.Size = new System.Drawing.Size(200, 24);
            this.cbbStaffSearchField.TabIndex = 123;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.cbbStaffStatusFilter);
            this.flowLayoutPanel3.Controls.Add(this.cbbStaffRoleFilter);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(532, 79);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0, 20, 0, 12);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(571, 24);
            this.flowLayoutPanel3.TabIndex = 184;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 21);
            this.label1.TabIndex = 43;
            this.label1.Text = "Staff";
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
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.btnStaffUpdate);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(296, 24);
            this.flowLayoutPanel4.TabIndex = 185;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel4);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Location = new System.Drawing.Point(24, 569);
            this.panel2.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1079, 24);
            this.panel2.TabIndex = 186;
            // 
            // pgnStaffView
            // 
            this.pgnStaffView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pgnStaffView.Location = new System.Drawing.Point(24, 605);
            this.pgnStaffView.MaximumSize = new System.Drawing.Size(2000, 32);
            this.pgnStaffView.MinimumSize = new System.Drawing.Size(700, 32);
            this.pgnStaffView.Name = "pgnStaffView";
            this.pgnStaffView.TotalPages = 1;
            this.pgnStaffView.CurrentPage = 1;
            this.pgnStaffView.Size = new System.Drawing.Size(1079, 32);
            this.pgnStaffView.TabIndex = 187;
            // 
            // cbbStaffPageSize
            // 
            this.cbbStaffPageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStaffPageSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbbStaffPageSize.FormattingEnabled = true;
            this.cbbStaffPageSize.Location = new System.Drawing.Point(193, 199);
            this.cbbStaffPageSize.Margin = new System.Windows.Forms.Padding(0);
            this.cbbStaffPageSize.Name = "cbbStaffPageSize";
            this.cbbStaffPageSize.Size = new System.Drawing.Size(200, 24);
            this.cbbStaffPageSize.TabIndex = 123;
            // 
            // StaffView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 661);
            this.Controls.Add(this.pgnStaffView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cbbStaffPageSize);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grvStaff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1127, 661);
            this.MinimumSize = new System.Drawing.Size(1127, 661);
            this.Name = "StaffView";
            this.Padding = new System.Windows.Forms.Padding(24);
            this.Text = "Manage staff";
            ((System.ComponentModel.ISupportInitialize)(this.grvStaff)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView grvStaff;
        private System.Windows.Forms.Button btnStaffAdd;
        private System.Windows.Forms.ComboBox cbbStaffRoleFilter;
        private System.Windows.Forms.Button btnStaffUpdate;
        private System.Windows.Forms.ComboBox cbbStaffStatusFilter;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnStaffSearch;
        private System.Windows.Forms.TextBox txtStaffSearch;
        private System.Windows.Forms.ComboBox cbbStaffSearchField;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdatedAt;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Panel panel2;
        private Controls.PaginationControl pgnStaffView;
        private System.Windows.Forms.ComboBox cbbStaffPageSize;
    }
}