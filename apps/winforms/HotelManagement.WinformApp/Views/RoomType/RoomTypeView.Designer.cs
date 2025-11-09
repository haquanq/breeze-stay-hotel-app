
namespace HotelManagement.WinformApp.Views.RoomType
{
    partial class RoomTypeView
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
            this.btnRoomTypeCreateViewOpen = new System.Windows.Forms.Button();
            this.grvRoomType = new System.Windows.Forms.DataGridView();
            this.RoomTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePerNight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRoomTypeUpdateViewOpen = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRoomTypeSearch = new System.Windows.Forms.Button();
            this.txtRoomTypeSearch = new System.Windows.Forms.TextBox();
            this.cbbRoomTypeSearchField = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.pgnRoomType = new HotelManagement.WinformApp.Controls.PaginationControl();
            this.cbbRoomTypePageSize = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grvRoomType)).BeginInit();
            this.panel12.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRoomTypeCreateViewOpen
            // 
            this.btnRoomTypeCreateViewOpen.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRoomTypeCreateViewOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoomTypeCreateViewOpen.FlatAppearance.BorderSize = 0;
            this.btnRoomTypeCreateViewOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomTypeCreateViewOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnRoomTypeCreateViewOpen.ForeColor = System.Drawing.Color.White;
            this.btnRoomTypeCreateViewOpen.Location = new System.Drawing.Point(47, 0);
            this.btnRoomTypeCreateViewOpen.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnRoomTypeCreateViewOpen.Name = "btnRoomTypeCreateViewOpen";
            this.btnRoomTypeCreateViewOpen.Size = new System.Drawing.Size(200, 24);
            this.btnRoomTypeCreateViewOpen.TabIndex = 14;
            this.btnRoomTypeCreateViewOpen.Text = "Add room type";
            this.btnRoomTypeCreateViewOpen.UseVisualStyleBackColor = false;
            // 
            // grvRoomType
            // 
            this.grvRoomType.AllowUserToAddRows = false;
            this.grvRoomType.AllowUserToDeleteRows = false;
            this.grvRoomType.AllowUserToResizeColumns = false;
            this.grvRoomType.AllowUserToResizeRows = false;
            this.grvRoomType.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grvRoomType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvRoomType.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvRoomType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvRoomType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvRoomType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomTypeId,
            this.title,
            this.PricePerNight,
            this.CreatedAt,
            this.UpdatedAt,
            this.detail});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvRoomType.DefaultCellStyle = dataGridViewCellStyle2;
            this.grvRoomType.GridColor = System.Drawing.Color.Gainsboro;
            this.grvRoomType.Location = new System.Drawing.Point(24, 228);
            this.grvRoomType.Margin = new System.Windows.Forms.Padding(0);
            this.grvRoomType.Name = "grvRoomType";
            this.grvRoomType.ReadOnly = true;
            this.grvRoomType.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grvRoomType.RowHeadersWidth = 40;
            this.grvRoomType.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grvRoomType.RowTemplate.Height = 30;
            this.grvRoomType.RowTemplate.ReadOnly = true;
            this.grvRoomType.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grvRoomType.Size = new System.Drawing.Size(1063, 288);
            this.grvRoomType.TabIndex = 114;
            // 
            // RoomTypeId
            // 
            this.RoomTypeId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RoomTypeId.DataPropertyName = "RoomTypeId";
            this.RoomTypeId.HeaderText = "ID";
            this.RoomTypeId.Name = "RoomTypeId";
            this.RoomTypeId.ReadOnly = true;
            this.RoomTypeId.Width = 53;
            // 
            // title
            // 
            this.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.title.DataPropertyName = "title";
            this.title.HeaderText = "Title";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Width = 66;
            // 
            // PricePerNight
            // 
            this.PricePerNight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PricePerNight.DataPropertyName = "PricePerNight";
            this.PricePerNight.HeaderText = "Price (Night)";
            this.PricePerNight.Name = "PricePerNight";
            this.PricePerNight.ReadOnly = true;
            this.PricePerNight.Width = 113;
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
            // detail
            // 
            this.detail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.detail.DataPropertyName = "detail";
            this.detail.HeaderText = "Detail";
            this.detail.Name = "detail";
            this.detail.ReadOnly = true;
            // 
            // btnRoomTypeUpdateViewOpen
            // 
            this.btnRoomTypeUpdateViewOpen.BackColor = System.Drawing.Color.LightGray;
            this.btnRoomTypeUpdateViewOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoomTypeUpdateViewOpen.FlatAppearance.BorderSize = 0;
            this.btnRoomTypeUpdateViewOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomTypeUpdateViewOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnRoomTypeUpdateViewOpen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnRoomTypeUpdateViewOpen.Location = new System.Drawing.Point(0, 0);
            this.btnRoomTypeUpdateViewOpen.Margin = new System.Windows.Forms.Padding(0);
            this.btnRoomTypeUpdateViewOpen.Name = "btnRoomTypeUpdateViewOpen";
            this.btnRoomTypeUpdateViewOpen.Size = new System.Drawing.Size(200, 24);
            this.btnRoomTypeUpdateViewOpen.TabIndex = 127;
            this.btnRoomTypeUpdateViewOpen.Text = "Update";
            this.btnRoomTypeUpdateViewOpen.UseVisualStyleBackColor = false;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.SteelBlue;
            this.panel12.Controls.Add(this.label16);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(24, 24);
            this.panel12.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
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
            this.label16.Size = new System.Drawing.Size(100, 21);
            this.label16.TabIndex = 43;
            this.label16.Text = "Room types";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnRoomTypeSearch);
            this.flowLayoutPanel2.Controls.Add(this.txtRoomTypeSearch);
            this.flowLayoutPanel2.Controls.Add(this.cbbRoomTypeSearchField);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(226, 79);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.flowLayoutPanel2.MaximumSize = new System.Drawing.Size(2000, 24);
            this.flowLayoutPanel2.MinimumSize = new System.Drawing.Size(800, 24);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(861, 24);
            this.flowLayoutPanel2.TabIndex = 162;
            // 
            // btnRoomTypeSearch
            // 
            this.btnRoomTypeSearch.BackColor = System.Drawing.Color.LightGray;
            this.btnRoomTypeSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoomTypeSearch.FlatAppearance.BorderSize = 0;
            this.btnRoomTypeSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomTypeSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnRoomTypeSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnRoomTypeSearch.Location = new System.Drawing.Point(761, 0);
            this.btnRoomTypeSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnRoomTypeSearch.Name = "btnRoomTypeSearch";
            this.btnRoomTypeSearch.Size = new System.Drawing.Size(100, 24);
            this.btnRoomTypeSearch.TabIndex = 124;
            this.btnRoomTypeSearch.Text = "Search";
            this.btnRoomTypeSearch.UseVisualStyleBackColor = false;
            // 
            // txtRoomTypeSearch
            // 
            this.txtRoomTypeSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRoomTypeSearch.Location = new System.Drawing.Point(261, 0);
            this.txtRoomTypeSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txtRoomTypeSearch.Multiline = true;
            this.txtRoomTypeSearch.Name = "txtRoomTypeSearch";
            this.txtRoomTypeSearch.Size = new System.Drawing.Size(500, 24);
            this.txtRoomTypeSearch.TabIndex = 122;
            // 
            // cbbRoomTypeSearchField
            // 
            this.cbbRoomTypeSearchField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRoomTypeSearchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbbRoomTypeSearchField.FormattingEnabled = true;
            this.cbbRoomTypeSearchField.Location = new System.Drawing.Point(61, 0);
            this.cbbRoomTypeSearchField.Margin = new System.Windows.Forms.Padding(0);
            this.cbbRoomTypeSearchField.Name = "cbbRoomTypeSearchField";
            this.cbbRoomTypeSearchField.Size = new System.Drawing.Size(200, 24);
            this.cbbRoomTypeSearchField.TabIndex = 123;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnRoomTypeCreateViewOpen);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(816, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(2000, 30);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(247, 26);
            this.flowLayoutPanel1.TabIndex = 163;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel3);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(24, 528);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 26);
            this.panel1.TabIndex = 165;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btnRoomTypeUpdateViewOpen);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(395, 26);
            this.flowLayoutPanel3.TabIndex = 164;
            // 
            // pgnRoomType
            // 
            this.pgnRoomType.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pgnRoomType.Location = new System.Drawing.Point(24, 566);
            this.pgnRoomType.MaximumSize = new System.Drawing.Size(2000, 32);
            this.pgnRoomType.MinimumSize = new System.Drawing.Size(800, 32);
            this.pgnRoomType.Name = "pgnRoomType";
            this.pgnRoomType.TotalPages = 0;
            this.pgnRoomType.CurrentPage = 1;
            this.pgnRoomType.Size = new System.Drawing.Size(1063, 32);
            this.pgnRoomType.TabIndex = 166;
            // 
            // cbbRoomTypePageSize
            // 
            this.cbbRoomTypePageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRoomTypePageSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbbRoomTypePageSize.FormattingEnabled = true;
            this.cbbRoomTypePageSize.Location = new System.Drawing.Point(298, 158);
            this.cbbRoomTypePageSize.Margin = new System.Windows.Forms.Padding(0);
            this.cbbRoomTypePageSize.Name = "cbbRoomTypePageSize";
            this.cbbRoomTypePageSize.Size = new System.Drawing.Size(200, 24);
            this.cbbRoomTypePageSize.TabIndex = 123;
            // 
            // RoomTypeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 622);
            this.Controls.Add(this.pgnRoomType);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbbRoomTypePageSize);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.grvRoomType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1127, 661);
            this.Name = "RoomTypeView";
            this.Padding = new System.Windows.Forms.Padding(24);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage room types";
            ((System.ComponentModel.ISupportInitialize)(this.grvRoomType)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRoomTypeCreateViewOpen;
        private System.Windows.Forms.DataGridView grvRoomType;
        private System.Windows.Forms.Button btnRoomTypeUpdateViewOpen;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnRoomTypeSearch;
        private System.Windows.Forms.TextBox txtRoomTypeSearch;
        private System.Windows.Forms.ComboBox cbbRoomTypeSearchField;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePerNight;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn detail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private Controls.PaginationControl pgnRoomType;
        private System.Windows.Forms.ComboBox cbbRoomTypePageSize;
    }
}