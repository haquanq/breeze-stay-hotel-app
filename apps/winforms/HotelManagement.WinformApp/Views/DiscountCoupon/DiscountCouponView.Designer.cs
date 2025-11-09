
namespace HotelManagement.WinformApp.Views.DiscountCoupon
{
    partial class DiscountCouponView
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
            this.grvDiscountCoupon = new System.Windows.Forms.DataGridView();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountCouponId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CouponCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RatePercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsageLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiredAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.cbbDiscountCouponStatusFilter = new System.Windows.Forms.ComboBox();
            this.btnDiscountCouponCreateViewOpen = new System.Windows.Forms.Button();
            this.btnDiscountCouponUpdateViewOpen = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDiscountCouponSearch = new System.Windows.Forms.Button();
            this.txtDiscountCouponSearch = new System.Windows.Forms.TextBox();
            this.cbbDiscountCouponSearchField = new System.Windows.Forms.ComboBox();
            this.pgnDiscountCoupon = new HotelManagement.WinformApp.Controls.PaginationControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbbDiscountCouponPageSize = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grvDiscountCoupon)).BeginInit();
            this.panel12.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grvDiscountCoupon
            // 
            this.grvDiscountCoupon.AllowUserToAddRows = false;
            this.grvDiscountCoupon.AllowUserToDeleteRows = false;
            this.grvDiscountCoupon.AllowUserToResizeColumns = false;
            this.grvDiscountCoupon.AllowUserToResizeRows = false;
            this.grvDiscountCoupon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grvDiscountCoupon.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grvDiscountCoupon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvDiscountCoupon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvDiscountCoupon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvDiscountCoupon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvDiscountCoupon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Status,
            this.DiscountCouponId,
            this.CouponCode,
            this.Title,
            this.RatePercent,
            this.MinBalance,
            this.UsageLimit,
            this.ExpiredAt,
            this.CreatedAt,
            this.UpdatedAt,
            this.Detail});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvDiscountCoupon.DefaultCellStyle = dataGridViewCellStyle3;
            this.grvDiscountCoupon.GridColor = System.Drawing.Color.Gainsboro;
            this.grvDiscountCoupon.Location = new System.Drawing.Point(24, 188);
            this.grvDiscountCoupon.Margin = new System.Windows.Forms.Padding(0);
            this.grvDiscountCoupon.Name = "grvDiscountCoupon";
            this.grvDiscountCoupon.ReadOnly = true;
            this.grvDiscountCoupon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grvDiscountCoupon.RowHeadersVisible = false;
            this.grvDiscountCoupon.RowHeadersWidth = 45;
            this.grvDiscountCoupon.RowTemplate.Height = 30;
            this.grvDiscountCoupon.RowTemplate.ReadOnly = true;
            this.grvDiscountCoupon.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grvDiscountCoupon.Size = new System.Drawing.Size(1079, 369);
            this.grvDiscountCoupon.TabIndex = 114;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Status.DataPropertyName = "Status";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Status.DefaultCellStyle = dataGridViewCellStyle2;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 77;
            // 
            // DiscountCouponId
            // 
            this.DiscountCouponId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DiscountCouponId.DataPropertyName = "DiscountCouponId";
            this.DiscountCouponId.HeaderText = "ID";
            this.DiscountCouponId.Name = "DiscountCouponId";
            this.DiscountCouponId.ReadOnly = true;
            this.DiscountCouponId.Width = 53;
            // 
            // CouponCode
            // 
            this.CouponCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CouponCode.DataPropertyName = "CouponCode";
            this.CouponCode.HeaderText = "Code";
            this.CouponCode.Name = "CouponCode";
            this.CouponCode.ReadOnly = true;
            this.CouponCode.Width = 73;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 66;
            // 
            // RatePercent
            // 
            this.RatePercent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RatePercent.DataPropertyName = "RatePercent";
            this.RatePercent.HeaderText = "Rate (%)";
            this.RatePercent.Name = "RatePercent";
            this.RatePercent.ReadOnly = true;
            this.RatePercent.Width = 92;
            // 
            // MinBalance
            // 
            this.MinBalance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MinBalance.DataPropertyName = "MinBalance";
            this.MinBalance.HeaderText = "Min balance";
            this.MinBalance.Name = "MinBalance";
            this.MinBalance.ReadOnly = true;
            this.MinBalance.Width = 113;
            // 
            // UsageLimit
            // 
            this.UsageLimit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UsageLimit.DataPropertyName = "UsageLimit";
            this.UsageLimit.HeaderText = "Usage limit";
            this.UsageLimit.Name = "UsageLimit";
            this.UsageLimit.ReadOnly = true;
            this.UsageLimit.Width = 107;
            // 
            // ExpiredAt
            // 
            this.ExpiredAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ExpiredAt.DataPropertyName = "ExpiredAt";
            this.ExpiredAt.HeaderText = "Expired At";
            this.ExpiredAt.Name = "ExpiredAt";
            this.ExpiredAt.ReadOnly = true;
            this.ExpiredAt.Width = 101;
            // 
            // CreatedAt
            // 
            this.CreatedAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CreatedAt.DataPropertyName = "CreatedAt";
            this.CreatedAt.HeaderText = "Created At";
            this.CreatedAt.Name = "CreatedAt";
            this.CreatedAt.ReadOnly = true;
            this.CreatedAt.Width = 103;
            // 
            // UpdatedAt
            // 
            this.UpdatedAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UpdatedAt.DataPropertyName = "UpdatedAt";
            this.UpdatedAt.HeaderText = "Updated At";
            this.UpdatedAt.Name = "UpdatedAt";
            this.UpdatedAt.ReadOnly = true;
            this.UpdatedAt.Width = 108;
            // 
            // Detail
            // 
            this.Detail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Detail.DataPropertyName = "Detail";
            this.Detail.HeaderText = "Detail";
            this.Detail.Name = "Detail";
            this.Detail.ReadOnly = true;
            this.Detail.Width = 75;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.SteelBlue;
            this.panel12.Controls.Add(this.label16);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(24, 24);
            this.panel12.Margin = new System.Windows.Forms.Padding(0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1079, 35);
            this.panel12.TabIndex = 129;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(10, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(147, 21);
            this.label16.TabIndex = 43;
            this.label16.Text = "Discount coupons";
            // 
            // cbbDiscountCouponStatusFilter
            // 
            this.cbbDiscountCouponStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDiscountCouponStatusFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbbDiscountCouponStatusFilter.FormattingEnabled = true;
            this.cbbDiscountCouponStatusFilter.Location = new System.Drawing.Point(24, 79);
            this.cbbDiscountCouponStatusFilter.Name = "cbbDiscountCouponStatusFilter";
            this.cbbDiscountCouponStatusFilter.Size = new System.Drawing.Size(200, 24);
            this.cbbDiscountCouponStatusFilter.TabIndex = 145;
            // 
            // btnDiscountCouponCreateViewOpen
            // 
            this.btnDiscountCouponCreateViewOpen.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDiscountCouponCreateViewOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiscountCouponCreateViewOpen.FlatAppearance.BorderSize = 0;
            this.btnDiscountCouponCreateViewOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscountCouponCreateViewOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnDiscountCouponCreateViewOpen.ForeColor = System.Drawing.Color.White;
            this.btnDiscountCouponCreateViewOpen.Location = new System.Drawing.Point(184, 0);
            this.btnDiscountCouponCreateViewOpen.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnDiscountCouponCreateViewOpen.Name = "btnDiscountCouponCreateViewOpen";
            this.btnDiscountCouponCreateViewOpen.Size = new System.Drawing.Size(250, 24);
            this.btnDiscountCouponCreateViewOpen.TabIndex = 14;
            this.btnDiscountCouponCreateViewOpen.Text = "Add coupon";
            this.btnDiscountCouponCreateViewOpen.UseVisualStyleBackColor = false;
            // 
            // btnDiscountCouponUpdateViewOpen
            // 
            this.btnDiscountCouponUpdateViewOpen.BackColor = System.Drawing.Color.LightGray;
            this.btnDiscountCouponUpdateViewOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiscountCouponUpdateViewOpen.FlatAppearance.BorderSize = 0;
            this.btnDiscountCouponUpdateViewOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscountCouponUpdateViewOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnDiscountCouponUpdateViewOpen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnDiscountCouponUpdateViewOpen.Location = new System.Drawing.Point(0, 0);
            this.btnDiscountCouponUpdateViewOpen.Margin = new System.Windows.Forms.Padding(0);
            this.btnDiscountCouponUpdateViewOpen.Name = "btnDiscountCouponUpdateViewOpen";
            this.btnDiscountCouponUpdateViewOpen.Size = new System.Drawing.Size(200, 24);
            this.btnDiscountCouponUpdateViewOpen.TabIndex = 127;
            this.btnDiscountCouponUpdateViewOpen.Text = "Update";
            this.btnDiscountCouponUpdateViewOpen.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnDiscountCouponCreateViewOpen);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(645, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(434, 24);
            this.flowLayoutPanel1.TabIndex = 146;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnDiscountCouponSearch);
            this.flowLayoutPanel2.Controls.Add(this.txtDiscountCouponSearch);
            this.flowLayoutPanel2.Controls.Add(this.cbbDiscountCouponSearchField);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(281, 79);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 20, 0, 12);
            this.flowLayoutPanel2.MaximumSize = new System.Drawing.Size(2000, 24);
            this.flowLayoutPanel2.MinimumSize = new System.Drawing.Size(800, 24);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(822, 24);
            this.flowLayoutPanel2.TabIndex = 162;
            // 
            // btnDiscountCouponSearch
            // 
            this.btnDiscountCouponSearch.BackColor = System.Drawing.Color.LightGray;
            this.btnDiscountCouponSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiscountCouponSearch.FlatAppearance.BorderSize = 0;
            this.btnDiscountCouponSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscountCouponSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnDiscountCouponSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnDiscountCouponSearch.Location = new System.Drawing.Point(722, 0);
            this.btnDiscountCouponSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnDiscountCouponSearch.Name = "btnDiscountCouponSearch";
            this.btnDiscountCouponSearch.Size = new System.Drawing.Size(100, 24);
            this.btnDiscountCouponSearch.TabIndex = 124;
            this.btnDiscountCouponSearch.Text = "Search";
            this.btnDiscountCouponSearch.UseVisualStyleBackColor = false;
            // 
            // txtDiscountCouponSearch
            // 
            this.txtDiscountCouponSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDiscountCouponSearch.Location = new System.Drawing.Point(222, 0);
            this.txtDiscountCouponSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txtDiscountCouponSearch.Multiline = true;
            this.txtDiscountCouponSearch.Name = "txtDiscountCouponSearch";
            this.txtDiscountCouponSearch.Size = new System.Drawing.Size(500, 24);
            this.txtDiscountCouponSearch.TabIndex = 122;
            // 
            // cbbDiscountCouponSearchField
            // 
            this.cbbDiscountCouponSearchField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDiscountCouponSearchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbbDiscountCouponSearchField.FormattingEnabled = true;
            this.cbbDiscountCouponSearchField.Location = new System.Drawing.Point(22, 0);
            this.cbbDiscountCouponSearchField.Margin = new System.Windows.Forms.Padding(0);
            this.cbbDiscountCouponSearchField.Name = "cbbDiscountCouponSearchField";
            this.cbbDiscountCouponSearchField.Size = new System.Drawing.Size(200, 24);
            this.cbbDiscountCouponSearchField.TabIndex = 123;
            // 
            // pgnDiscountCoupon
            // 
            this.pgnDiscountCoupon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pgnDiscountCoupon.Location = new System.Drawing.Point(24, 605);
            this.pgnDiscountCoupon.MaximumSize = new System.Drawing.Size(2000, 32);
            this.pgnDiscountCoupon.MinimumSize = new System.Drawing.Size(700, 32);
            this.pgnDiscountCoupon.Name = "pgnDiscountCoupon";
            this.pgnDiscountCoupon.TotalPages = 1;
            this.pgnDiscountCoupon.CurrentPage = 1;
            this.pgnDiscountCoupon.Size = new System.Drawing.Size(1079, 32);
            this.pgnDiscountCoupon.TabIndex = 163;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.flowLayoutPanel3);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(24, 569);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 24);
            this.panel1.TabIndex = 164;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btnDiscountCouponUpdateViewOpen);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(434, 24);
            this.flowLayoutPanel3.TabIndex = 165;
            // 
            // cbbDiscountCouponPageSize
            // 
            this.cbbDiscountCouponPageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDiscountCouponPageSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbbDiscountCouponPageSize.FormattingEnabled = true;
            this.cbbDiscountCouponPageSize.Location = new System.Drawing.Point(183, 137);
            this.cbbDiscountCouponPageSize.Name = "cbbDiscountCouponPageSize";
            this.cbbDiscountCouponPageSize.Size = new System.Drawing.Size(200, 24);
            this.cbbDiscountCouponPageSize.TabIndex = 165;
            // 
            // DiscountCouponView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 661);
            this.Controls.Add(this.cbbDiscountCouponPageSize);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pgnDiscountCoupon);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.cbbDiscountCouponStatusFilter);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.grvDiscountCoupon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "DiscountCouponView";
            this.Padding = new System.Windows.Forms.Padding(24);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage discount coupons";
            ((System.ComponentModel.ISupportInitialize)(this.grvDiscountCoupon)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView grvDiscountCoupon;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbbDiscountCouponStatusFilter;
        private System.Windows.Forms.Button btnDiscountCouponCreateViewOpen;
        private System.Windows.Forms.Button btnDiscountCouponUpdateViewOpen;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnDiscountCouponSearch;
        private System.Windows.Forms.TextBox txtDiscountCouponSearch;
        private System.Windows.Forms.ComboBox cbbDiscountCouponSearchField;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountCouponId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CouponCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn RatePercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsageLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiredAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detail;
        private Controls.PaginationControl pgnDiscountCoupon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.ComboBox cbbDiscountCouponPageSize;
    }
}