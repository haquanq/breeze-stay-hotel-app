
namespace HotelManagement.WinformApp.Views.Amenity
{
    partial class AmenityView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAmenityCreateViewOpen = new System.Windows.Forms.Button();
            this.grvAmenity = new System.Windows.Forms.DataGridView();
            this.AmenityId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAmenityUpdateViewOpen = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.cbbAmenityStatus = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAmenitySearch = new System.Windows.Forms.Button();
            this.txtAmenitySearch = new System.Windows.Forms.TextBox();
            this.cbbAmenitySearchField = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.pgnAmenityView = new HotelManagement.WinformApp.Controls.PaginationControl();
            this.cbbAmenityPageSize = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grvAmenity)).BeginInit();
            this.panel12.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAmenityCreateViewOpen
            // 
            this.btnAmenityCreateViewOpen.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAmenityCreateViewOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAmenityCreateViewOpen.FlatAppearance.BorderSize = 0;
            this.btnAmenityCreateViewOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmenityCreateViewOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnAmenityCreateViewOpen.ForeColor = System.Drawing.Color.White;
            this.btnAmenityCreateViewOpen.Location = new System.Drawing.Point(228, 0);
            this.btnAmenityCreateViewOpen.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnAmenityCreateViewOpen.Name = "btnAmenityCreateViewOpen";
            this.btnAmenityCreateViewOpen.Size = new System.Drawing.Size(250, 24);
            this.btnAmenityCreateViewOpen.TabIndex = 14;
            this.btnAmenityCreateViewOpen.Text = "Add amenity";
            this.btnAmenityCreateViewOpen.UseVisualStyleBackColor = false;
            // 
            // grvAmenity
            // 
            this.grvAmenity.AllowUserToAddRows = false;
            this.grvAmenity.AllowUserToDeleteRows = false;
            this.grvAmenity.AllowUserToResizeColumns = false;
            this.grvAmenity.AllowUserToResizeRows = false;
            this.grvAmenity.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grvAmenity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvAmenity.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvAmenity.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvAmenity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvAmenity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AmenityId,
            this.Title,
            this.Price,
            this.CreatedAt,
            this.UpdatedAt,
            this.Detail,
            this.Status});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvAmenity.DefaultCellStyle = dataGridViewCellStyle2;
            this.grvAmenity.GridColor = System.Drawing.Color.Gainsboro;
            this.grvAmenity.Location = new System.Drawing.Point(24, 169);
            this.grvAmenity.Margin = new System.Windows.Forms.Padding(0);
            this.grvAmenity.Name = "grvAmenity";
            this.grvAmenity.ReadOnly = true;
            this.grvAmenity.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grvAmenity.RowHeadersWidth = 40;
            this.grvAmenity.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grvAmenity.RowTemplate.Height = 30;
            this.grvAmenity.RowTemplate.ReadOnly = true;
            this.grvAmenity.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grvAmenity.Size = new System.Drawing.Size(1063, 382);
            this.grvAmenity.TabIndex = 114;
            // 
            // AmenityId
            // 
            this.AmenityId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AmenityId.DataPropertyName = "AmenityId";
            this.AmenityId.HeaderText = "ID";
            this.AmenityId.Name = "AmenityId";
            this.AmenityId.ReadOnly = true;
            this.AmenityId.Width = 53;
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
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 71;
            // 
            // CreatedAt
            // 
            this.CreatedAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CreatedAt.DataPropertyName = "CreatedAt";
            this.CreatedAt.HeaderText = "Created at";
            this.CreatedAt.Name = "CreatedAt";
            this.CreatedAt.ReadOnly = true;
            this.CreatedAt.Width = 102;
            // 
            // UpdatedAt
            // 
            this.UpdatedAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UpdatedAt.DataPropertyName = "UpdatedAt";
            this.UpdatedAt.HeaderText = "Updated at";
            this.UpdatedAt.Name = "UpdatedAt";
            this.UpdatedAt.ReadOnly = true;
            this.UpdatedAt.Width = 107;
            // 
            // Detail
            // 
            this.Detail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Detail.DataPropertyName = "Detail";
            this.Detail.HeaderText = "Detail";
            this.Detail.Name = "Detail";
            this.Detail.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 77;
            // 
            // btnAmenityUpdateViewOpen
            // 
            this.btnAmenityUpdateViewOpen.BackColor = System.Drawing.Color.LightGray;
            this.btnAmenityUpdateViewOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAmenityUpdateViewOpen.FlatAppearance.BorderSize = 0;
            this.btnAmenityUpdateViewOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmenityUpdateViewOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnAmenityUpdateViewOpen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnAmenityUpdateViewOpen.Location = new System.Drawing.Point(0, 0);
            this.btnAmenityUpdateViewOpen.Margin = new System.Windows.Forms.Padding(0);
            this.btnAmenityUpdateViewOpen.Name = "btnAmenityUpdateViewOpen";
            this.btnAmenityUpdateViewOpen.Size = new System.Drawing.Size(200, 24);
            this.btnAmenityUpdateViewOpen.TabIndex = 127;
            this.btnAmenityUpdateViewOpen.Text = "Update";
            this.btnAmenityUpdateViewOpen.UseVisualStyleBackColor = false;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.SteelBlue;
            this.panel12.Controls.Add(this.label16);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(24, 24);
            this.panel12.Margin = new System.Windows.Forms.Padding(0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1063, 35);
            this.panel12.TabIndex = 129;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(10, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 21);
            this.label16.TabIndex = 43;
            this.label16.Text = "Amenities";
            // 
            // cbbAmenityStatus
            // 
            this.cbbAmenityStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbAmenityStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbAmenityStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbAmenityStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAmenityStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbbAmenityStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.cbbAmenityStatus.FormattingEnabled = true;
            this.cbbAmenityStatus.Location = new System.Drawing.Point(24, 80);
            this.cbbAmenityStatus.Margin = new System.Windows.Forms.Padding(0);
            this.cbbAmenityStatus.Name = "cbbAmenityStatus";
            this.cbbAmenityStatus.Size = new System.Drawing.Size(200, 24);
            this.cbbAmenityStatus.TabIndex = 144;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAmenityCreateViewOpen);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(585, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(478, 24);
            this.flowLayoutPanel1.TabIndex = 157;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnAmenitySearch);
            this.flowLayoutPanel2.Controls.Add(this.txtAmenitySearch);
            this.flowLayoutPanel2.Controls.Add(this.cbbAmenitySearchField);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(265, 79);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 20, 0, 12);
            this.flowLayoutPanel2.MaximumSize = new System.Drawing.Size(2000, 24);
            this.flowLayoutPanel2.MinimumSize = new System.Drawing.Size(800, 24);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(822, 24);
            this.flowLayoutPanel2.TabIndex = 162;
            // 
            // btnAmenitySearch
            // 
            this.btnAmenitySearch.BackColor = System.Drawing.Color.LightGray;
            this.btnAmenitySearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAmenitySearch.FlatAppearance.BorderSize = 0;
            this.btnAmenitySearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmenitySearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnAmenitySearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnAmenitySearch.Location = new System.Drawing.Point(722, 0);
            this.btnAmenitySearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnAmenitySearch.Name = "btnAmenitySearch";
            this.btnAmenitySearch.Size = new System.Drawing.Size(100, 24);
            this.btnAmenitySearch.TabIndex = 124;
            this.btnAmenitySearch.Text = "Search";
            this.btnAmenitySearch.UseVisualStyleBackColor = false;
            // 
            // txtAmenitySearch
            // 
            this.txtAmenitySearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAmenitySearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtAmenitySearch.Location = new System.Drawing.Point(222, 0);
            this.txtAmenitySearch.Margin = new System.Windows.Forms.Padding(0);
            this.txtAmenitySearch.Multiline = true;
            this.txtAmenitySearch.Name = "txtAmenitySearch";
            this.txtAmenitySearch.Size = new System.Drawing.Size(500, 24);
            this.txtAmenitySearch.TabIndex = 122;
            // 
            // cbbAmenitySearchField
            // 
            this.cbbAmenitySearchField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAmenitySearchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbbAmenitySearchField.FormattingEnabled = true;
            this.cbbAmenitySearchField.Location = new System.Drawing.Point(22, 0);
            this.cbbAmenitySearchField.Margin = new System.Windows.Forms.Padding(0);
            this.cbbAmenitySearchField.Name = "cbbAmenitySearchField";
            this.cbbAmenitySearchField.Size = new System.Drawing.Size(200, 24);
            this.cbbAmenitySearchField.TabIndex = 123;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel3);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(24, 563);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 24);
            this.panel1.TabIndex = 163;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btnAmenityUpdateViewOpen);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(318, 24);
            this.flowLayoutPanel3.TabIndex = 164;
            // 
            // pgnAmenityView
            // 
            this.pgnAmenityView.AutoSize = true;
            this.pgnAmenityView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pgnAmenityView.CurrentPage = 1;
            this.pgnAmenityView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pgnAmenityView.Location = new System.Drawing.Point(24, 602);
            this.pgnAmenityView.MaximumSize = new System.Drawing.Size(2000, 32);
            this.pgnAmenityView.MinimumSize = new System.Drawing.Size(700, 32);
            this.pgnAmenityView.Name = "pgnAmenityView";
            this.pgnAmenityView.Size = new System.Drawing.Size(1063, 32);
            this.pgnAmenityView.TabIndex = 164;
            this.pgnAmenityView.TotalPages = 1;
            // 
            // cbbAmenityPageSize
            // 
            this.cbbAmenityPageSize.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbAmenityPageSize.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbAmenityPageSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbAmenityPageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAmenityPageSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbbAmenityPageSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.cbbAmenityPageSize.FormattingEnabled = true;
            this.cbbAmenityPageSize.Location = new System.Drawing.Point(24, 125);
            this.cbbAmenityPageSize.Margin = new System.Windows.Forms.Padding(0);
            this.cbbAmenityPageSize.Name = "cbbAmenityPageSize";
            this.cbbAmenityPageSize.Size = new System.Drawing.Size(200, 24);
            this.cbbAmenityPageSize.TabIndex = 165;
            // 
            // AmenityView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 658);
            this.Controls.Add(this.cbbAmenityPageSize);
            this.Controls.Add(this.pgnAmenityView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.cbbAmenityStatus);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.grvAmenity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1127, 661);
            this.Name = "AmenityView";
            this.Padding = new System.Windows.Forms.Padding(24);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amenities";
            ((System.ComponentModel.ISupportInitialize)(this.grvAmenity)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAmenityCreateViewOpen;
        private System.Windows.Forms.DataGridView grvAmenity;
        private System.Windows.Forms.Button btnAmenityUpdateViewOpen;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbbAmenityStatus;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnAmenitySearch;
        private System.Windows.Forms.TextBox txtAmenitySearch;
        private System.Windows.Forms.ComboBox cbbAmenitySearchField;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmenityId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private Controls.PaginationControl pgnAmenityView;
        private System.Windows.Forms.ComboBox cbbAmenityPageSize;
    }
}