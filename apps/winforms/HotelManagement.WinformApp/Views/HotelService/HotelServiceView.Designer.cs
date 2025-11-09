namespace HotelManagement.WinformApp.Views.HotelService
{
    partial class HotelServiceView
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
            this.btnHotelServiceAddViewOpen = new System.Windows.Forms.Button();
            this.grvHotelService = new System.Windows.Forms.DataGridView();
            this.HotelServiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHotelServiceUpdateViewOpen = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHotelServiceSearch = new System.Windows.Forms.Button();
            this.txtHotelServiceSearch = new System.Windows.Forms.TextBox();
            this.cbbHotelServiceSearchField = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pgnHotelServiceView = new HotelManagement.WinformApp.Controls.PaginationControl();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbHotelServicePageSize = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grvHotelService)).BeginInit();
            this.panel12.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHotelServiceAddViewOpen
            // 
            this.btnHotelServiceAddViewOpen.BackColor = System.Drawing.Color.SteelBlue;
            this.btnHotelServiceAddViewOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHotelServiceAddViewOpen.FlatAppearance.BorderSize = 0;
            this.btnHotelServiceAddViewOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHotelServiceAddViewOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnHotelServiceAddViewOpen.ForeColor = System.Drawing.Color.White;
            this.btnHotelServiceAddViewOpen.Location = new System.Drawing.Point(166, 0);
            this.btnHotelServiceAddViewOpen.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnHotelServiceAddViewOpen.Name = "btnHotelServiceAddViewOpen";
            this.btnHotelServiceAddViewOpen.Size = new System.Drawing.Size(200, 24);
            this.btnHotelServiceAddViewOpen.TabIndex = 14;
            this.btnHotelServiceAddViewOpen.Text = "Add service";
            this.btnHotelServiceAddViewOpen.UseVisualStyleBackColor = false;
            // 
            // grvHotelService
            // 
            this.grvHotelService.AllowUserToAddRows = false;
            this.grvHotelService.AllowUserToDeleteRows = false;
            this.grvHotelService.AllowUserToResizeColumns = false;
            this.grvHotelService.AllowUserToResizeRows = false;
            this.grvHotelService.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grvHotelService.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvHotelService.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvHotelService.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvHotelService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvHotelService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HotelServiceId,
            this.title,
            this.detail});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvHotelService.DefaultCellStyle = dataGridViewCellStyle2;
            this.grvHotelService.GridColor = System.Drawing.Color.Gainsboro;
            this.grvHotelService.Location = new System.Drawing.Point(24, 226);
            this.grvHotelService.Margin = new System.Windows.Forms.Padding(0);
            this.grvHotelService.Name = "grvHotelService";
            this.grvHotelService.ReadOnly = true;
            this.grvHotelService.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grvHotelService.RowHeadersWidth = 45;
            this.grvHotelService.RowTemplate.Height = 30;
            this.grvHotelService.RowTemplate.ReadOnly = true;
            this.grvHotelService.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grvHotelService.Size = new System.Drawing.Size(1063, 328);
            this.grvHotelService.TabIndex = 114;
            // 
            // HotelServiceId
            // 
            this.HotelServiceId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.HotelServiceId.DataPropertyName = "HotelServiceId";
            this.HotelServiceId.HeaderText = "ID";
            this.HotelServiceId.Name = "HotelServiceId";
            this.HotelServiceId.ReadOnly = true;
            this.HotelServiceId.Width = 53;
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
            // detail
            // 
            this.detail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.detail.DataPropertyName = "detail";
            this.detail.HeaderText = "Detail";
            this.detail.Name = "detail";
            this.detail.ReadOnly = true;
            // 
            // btnHotelServiceUpdateViewOpen
            // 
            this.btnHotelServiceUpdateViewOpen.BackColor = System.Drawing.Color.LightGray;
            this.btnHotelServiceUpdateViewOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHotelServiceUpdateViewOpen.FlatAppearance.BorderSize = 0;
            this.btnHotelServiceUpdateViewOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHotelServiceUpdateViewOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnHotelServiceUpdateViewOpen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnHotelServiceUpdateViewOpen.Location = new System.Drawing.Point(0, 0);
            this.btnHotelServiceUpdateViewOpen.Margin = new System.Windows.Forms.Padding(0);
            this.btnHotelServiceUpdateViewOpen.Name = "btnHotelServiceUpdateViewOpen";
            this.btnHotelServiceUpdateViewOpen.Size = new System.Drawing.Size(200, 24);
            this.btnHotelServiceUpdateViewOpen.TabIndex = 127;
            this.btnHotelServiceUpdateViewOpen.Text = "Update";
            this.btnHotelServiceUpdateViewOpen.UseVisualStyleBackColor = false;
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
            this.label16.Size = new System.Drawing.Size(119, 21);
            this.label16.TabIndex = 43;
            this.label16.Text = "Hotel Services";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnHotelServiceSearch);
            this.flowLayoutPanel2.Controls.Add(this.txtHotelServiceSearch);
            this.flowLayoutPanel2.Controls.Add(this.cbbHotelServiceSearchField);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(265, 79);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 20, 0, 12);
            this.flowLayoutPanel2.MaximumSize = new System.Drawing.Size(2000, 24);
            this.flowLayoutPanel2.MinimumSize = new System.Drawing.Size(800, 24);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(822, 24);
            this.flowLayoutPanel2.TabIndex = 163;
            // 
            // btnHotelServiceSearch
            // 
            this.btnHotelServiceSearch.BackColor = System.Drawing.Color.LightGray;
            this.btnHotelServiceSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHotelServiceSearch.FlatAppearance.BorderSize = 0;
            this.btnHotelServiceSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHotelServiceSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnHotelServiceSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnHotelServiceSearch.Location = new System.Drawing.Point(722, 0);
            this.btnHotelServiceSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnHotelServiceSearch.Name = "btnHotelServiceSearch";
            this.btnHotelServiceSearch.Size = new System.Drawing.Size(100, 24);
            this.btnHotelServiceSearch.TabIndex = 124;
            this.btnHotelServiceSearch.Text = "Search";
            this.btnHotelServiceSearch.UseVisualStyleBackColor = false;
            // 
            // txtHotelServiceSearch
            // 
            this.txtHotelServiceSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtHotelServiceSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtHotelServiceSearch.Location = new System.Drawing.Point(222, 0);
            this.txtHotelServiceSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txtHotelServiceSearch.Multiline = true;
            this.txtHotelServiceSearch.Name = "txtHotelServiceSearch";
            this.txtHotelServiceSearch.Size = new System.Drawing.Size(500, 24);
            this.txtHotelServiceSearch.TabIndex = 122;
            // 
            // cbbHotelServiceSearchField
            // 
            this.cbbHotelServiceSearchField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbHotelServiceSearchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbbHotelServiceSearchField.FormattingEnabled = true;
            this.cbbHotelServiceSearchField.Location = new System.Drawing.Point(22, 0);
            this.cbbHotelServiceSearchField.Margin = new System.Windows.Forms.Padding(0);
            this.cbbHotelServiceSearchField.Name = "cbbHotelServiceSearchField";
            this.cbbHotelServiceSearchField.Size = new System.Drawing.Size(200, 24);
            this.cbbHotelServiceSearchField.TabIndex = 123;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnHotelServiceAddViewOpen);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(697, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(366, 24);
            this.flowLayoutPanel1.TabIndex = 164;
            // 
            // pgnHotelServiceView
            // 
            this.pgnHotelServiceView.Location = new System.Drawing.Point(24, 602);
            this.pgnHotelServiceView.Margin = new System.Windows.Forms.Padding(0);
            this.pgnHotelServiceView.MaximumSize = new System.Drawing.Size(2000, 32);
            this.pgnHotelServiceView.MinimumSize = new System.Drawing.Size(700, 32);
            this.pgnHotelServiceView.Name = "pgnHotelServiceView";
            this.pgnHotelServiceView.TotalPages = 1;
            this.pgnHotelServiceView.CurrentPage = 1;
            this.pgnHotelServiceView.Size = new System.Drawing.Size(1063, 32);
            this.pgnHotelServiceView.TabIndex = 165;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btnHotelServiceUpdateViewOpen);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(310, 24);
            this.flowLayoutPanel3.TabIndex = 166;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel3);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(24, 566);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 24);
            this.panel1.TabIndex = 167;
            // 
            // cbbHotelServicePageSize
            // 
            this.cbbHotelServicePageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbHotelServicePageSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbbHotelServicePageSize.FormattingEnabled = true;
            this.cbbHotelServicePageSize.Location = new System.Drawing.Point(265, 167);
            this.cbbHotelServicePageSize.Margin = new System.Windows.Forms.Padding(0);
            this.cbbHotelServicePageSize.Name = "cbbHotelServicePageSize";
            this.cbbHotelServicePageSize.Size = new System.Drawing.Size(200, 24);
            this.cbbHotelServicePageSize.TabIndex = 168;
            // 
            // HotelServiceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 658);
            this.Controls.Add(this.cbbHotelServicePageSize);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pgnHotelServiceView);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.grvHotelService);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1127, 661);
            this.Name = "HotelServiceView";
            this.Padding = new System.Windows.Forms.Padding(24);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage hotel services";
            ((System.ComponentModel.ISupportInitialize)(this.grvHotelService)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnHotelServiceAddViewOpen;
        private System.Windows.Forms.DataGridView grvHotelService;
        private System.Windows.Forms.Button btnHotelServiceUpdateViewOpen;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnHotelServiceSearch;
        private System.Windows.Forms.TextBox txtHotelServiceSearch;
        private System.Windows.Forms.ComboBox cbbHotelServiceSearchField;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotelServiceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn detail;
        private Controls.PaginationControl pgnHotelServiceView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbHotelServicePageSize;
    }
}