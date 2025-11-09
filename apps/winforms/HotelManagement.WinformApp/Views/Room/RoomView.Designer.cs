namespace HotelManagement.WinformApp.Views.Room
{
    partial class RoomView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grvRoom = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floor_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room_type_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_per_night = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updated_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room_type_detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room_type_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRoomAdd = new System.Windows.Forms.Button();
            this.btnRoomDetail = new System.Windows.Forms.Button();
            this.cbbRoomTypeFilter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbRoomStatusFilter = new System.Windows.Forms.ComboBox();
            this.btnRoomUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRoomSearch = new System.Windows.Forms.Button();
            this.txtRoomSearch = new System.Windows.Forms.TextBox();
            this.cbbRoomSearchField = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.pgnRoomView = new HotelManagement.WinformApp.Controls.PaginationControl();
            this.cbbRoomPageSize = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grvRoom)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // grvRoom
            // 
            this.grvRoom.AllowUserToAddRows = false;
            this.grvRoom.AllowUserToDeleteRows = false;
            this.grvRoom.AllowUserToResizeColumns = false;
            this.grvRoom.AllowUserToResizeRows = false;
            this.grvRoom.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grvRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvRoom.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.room_code,
            this.floor_number,
            this.room_type_title,
            this.price_per_night,
            this.created_at,
            this.updated_at,
            this.status,
            this.room_type_detail,
            this.room_type_id});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvRoom.DefaultCellStyle = dataGridViewCellStyle6;
            this.grvRoom.GridColor = System.Drawing.Color.Gainsboro;
            this.grvRoom.Location = new System.Drawing.Point(24, 260);
            this.grvRoom.Margin = new System.Windows.Forms.Padding(0);
            this.grvRoom.Name = "grvRoom";
            this.grvRoom.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grvRoom.RowHeadersWidth = 36;
            this.grvRoom.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grvRoom.RowTemplate.Height = 30;
            this.grvRoom.RowTemplate.ReadOnly = true;
            this.grvRoom.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grvRoom.Size = new System.Drawing.Size(1079, 297);
            this.grvRoom.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 53;
            // 
            // room_code
            // 
            this.room_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.room_code.DataPropertyName = "room_code";
            this.room_code.HeaderText = "Room code";
            this.room_code.Name = "room_code";
            this.room_code.Width = 111;
            // 
            // floor_number
            // 
            this.floor_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.floor_number.DataPropertyName = "floor_number";
            this.floor_number.HeaderText = "Floor number";
            this.floor_number.Name = "floor_number";
            this.floor_number.Width = 119;
            // 
            // room_type_title
            // 
            this.room_type_title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.room_type_title.DataPropertyName = "room_type_title";
            this.room_type_title.HeaderText = "Room type";
            this.room_type_title.Name = "room_type_title";
            this.room_type_title.Width = 106;
            // 
            // price_per_night
            // 
            this.price_per_night.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.price_per_night.DataPropertyName = "price_per_night";
            this.price_per_night.HeaderText = "Price";
            this.price_per_night.Name = "price_per_night";
            this.price_per_night.Width = 71;
            // 
            // created_at
            // 
            this.created_at.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.created_at.DataPropertyName = "created_at";
            this.created_at.HeaderText = "Created at";
            this.created_at.Name = "created_at";
            this.created_at.Width = 102;
            // 
            // updated_at
            // 
            this.updated_at.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.updated_at.DataPropertyName = "updated_at";
            this.updated_at.HeaderText = "Updated at";
            this.updated_at.Name = "updated_at";
            this.updated_at.Width = 107;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.status.DataPropertyName = "status";
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.status.DefaultCellStyle = dataGridViewCellStyle5;
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.Width = 77;
            // 
            // room_type_detail
            // 
            this.room_type_detail.DataPropertyName = "room_type_detail";
            this.room_type_detail.HeaderText = "Column1";
            this.room_type_detail.Name = "room_type_detail";
            this.room_type_detail.Visible = false;
            // 
            // room_type_id
            // 
            this.room_type_id.DataPropertyName = "room_type_id";
            this.room_type_id.HeaderText = "Column1";
            this.room_type_id.Name = "room_type_id";
            this.room_type_id.Visible = false;
            // 
            // btnRoomAdd
            // 
            this.btnRoomAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRoomAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoomAdd.FlatAppearance.BorderSize = 0;
            this.btnRoomAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnRoomAdd.ForeColor = System.Drawing.Color.White;
            this.btnRoomAdd.Location = new System.Drawing.Point(171, 0);
            this.btnRoomAdd.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnRoomAdd.Name = "btnRoomAdd";
            this.btnRoomAdd.Size = new System.Drawing.Size(200, 24);
            this.btnRoomAdd.TabIndex = 36;
            this.btnRoomAdd.Text = "Add room";
            this.btnRoomAdd.UseVisualStyleBackColor = false;
            // 
            // btnRoomDetail
            // 
            this.btnRoomDetail.BackColor = System.Drawing.Color.LightGray;
            this.btnRoomDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoomDetail.FlatAppearance.BorderSize = 0;
            this.btnRoomDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnRoomDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnRoomDetail.Location = new System.Drawing.Point(0, 0);
            this.btnRoomDetail.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnRoomDetail.Name = "btnRoomDetail";
            this.btnRoomDetail.Size = new System.Drawing.Size(200, 24);
            this.btnRoomDetail.TabIndex = 37;
            this.btnRoomDetail.Text = "Mode info";
            this.btnRoomDetail.UseVisualStyleBackColor = false;
            // 
            // cbbRoomTypeFilter
            // 
            this.cbbRoomTypeFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbRoomTypeFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbRoomTypeFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbRoomTypeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRoomTypeFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbbRoomTypeFilter.FormattingEnabled = true;
            this.cbbRoomTypeFilter.Items.AddRange(new object[] {
            "Book genre",
            "Book author"});
            this.cbbRoomTypeFilter.Location = new System.Drawing.Point(541, 0);
            this.cbbRoomTypeFilter.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.cbbRoomTypeFilter.Name = "cbbRoomTypeFilter";
            this.cbbRoomTypeFilter.Size = new System.Drawing.Size(300, 24);
            this.cbbRoomTypeFilter.TabIndex = 115;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(255, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 118;
            // 
            // cbbRoomStatusFilter
            // 
            this.cbbRoomStatusFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbRoomStatusFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbRoomStatusFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbRoomStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRoomStatusFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbbRoomStatusFilter.FormattingEnabled = true;
            this.cbbRoomStatusFilter.Location = new System.Drawing.Point(849, 0);
            this.cbbRoomStatusFilter.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.cbbRoomStatusFilter.Name = "cbbRoomStatusFilter";
            this.cbbRoomStatusFilter.Size = new System.Drawing.Size(227, 24);
            this.cbbRoomStatusFilter.TabIndex = 117;
            // 
            // btnRoomUpdate
            // 
            this.btnRoomUpdate.BackColor = System.Drawing.Color.LightGray;
            this.btnRoomUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoomUpdate.FlatAppearance.BorderSize = 0;
            this.btnRoomUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnRoomUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnRoomUpdate.Location = new System.Drawing.Point(208, 0);
            this.btnRoomUpdate.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnRoomUpdate.Name = "btnRoomUpdate";
            this.btnRoomUpdate.Size = new System.Drawing.Size(200, 24);
            this.btnRoomUpdate.TabIndex = 129;
            this.btnRoomUpdate.Text = "Update";
            this.btnRoomUpdate.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 43;
            this.label1.Text = "Rooms";
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnRoomAdd);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(708, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(371, 24);
            this.flowLayoutPanel1.TabIndex = 132;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnRoomSearch);
            this.flowLayoutPanel2.Controls.Add(this.txtRoomSearch);
            this.flowLayoutPanel2.Controls.Add(this.cbbRoomSearchField);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(24, 107);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.flowLayoutPanel2.MaximumSize = new System.Drawing.Size(2000, 24);
            this.flowLayoutPanel2.MinimumSize = new System.Drawing.Size(800, 24);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1079, 24);
            this.flowLayoutPanel2.TabIndex = 163;
            // 
            // btnRoomSearch
            // 
            this.btnRoomSearch.BackColor = System.Drawing.Color.LightGray;
            this.btnRoomSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoomSearch.FlatAppearance.BorderSize = 0;
            this.btnRoomSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnRoomSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnRoomSearch.Location = new System.Drawing.Point(979, 0);
            this.btnRoomSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnRoomSearch.Name = "btnRoomSearch";
            this.btnRoomSearch.Size = new System.Drawing.Size(100, 24);
            this.btnRoomSearch.TabIndex = 124;
            this.btnRoomSearch.Text = "Search";
            this.btnRoomSearch.UseVisualStyleBackColor = false;
            // 
            // txtRoomSearch
            // 
            this.txtRoomSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRoomSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtRoomSearch.Location = new System.Drawing.Point(458, 0);
            this.txtRoomSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txtRoomSearch.Multiline = true;
            this.txtRoomSearch.Name = "txtRoomSearch";
            this.txtRoomSearch.Size = new System.Drawing.Size(521, 24);
            this.txtRoomSearch.TabIndex = 122;
            // 
            // cbbRoomSearchField
            // 
            this.cbbRoomSearchField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRoomSearchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbbRoomSearchField.FormattingEnabled = true;
            this.cbbRoomSearchField.Location = new System.Drawing.Point(258, 0);
            this.cbbRoomSearchField.Margin = new System.Windows.Forms.Padding(0);
            this.cbbRoomSearchField.Name = "cbbRoomSearchField";
            this.cbbRoomSearchField.Size = new System.Drawing.Size(200, 24);
            this.cbbRoomSearchField.TabIndex = 123;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btnRoomDetail);
            this.flowLayoutPanel3.Controls.Add(this.btnRoomUpdate);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(458, 24);
            this.flowLayoutPanel3.TabIndex = 165;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel3);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Location = new System.Drawing.Point(24, 569);
            this.panel2.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1079, 24);
            this.panel2.TabIndex = 166;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.cbbRoomStatusFilter);
            this.flowLayoutPanel4.Controls.Add(this.cbbRoomTypeFilter);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(24, 71);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel4.Size = new System.Drawing.Size(1076, 24);
            this.flowLayoutPanel4.TabIndex = 167;
            // 
            // pgnRoomView
            // 
            this.pgnRoomView.Location = new System.Drawing.Point(24, 608);
            this.pgnRoomView.MaximumSize = new System.Drawing.Size(2000, 32);
            this.pgnRoomView.MinimumSize = new System.Drawing.Size(700, 32);
            this.pgnRoomView.Name = "pgnRoomView";
            this.pgnRoomView.TotalPages = 0;
            this.pgnRoomView.CurrentPage = 1;
            this.pgnRoomView.Size = new System.Drawing.Size(1079, 32);
            this.pgnRoomView.TabIndex = 168;
            // 
            // cbbRoomPageSize
            // 
            this.cbbRoomPageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRoomPageSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbbRoomPageSize.FormattingEnabled = true;
            this.cbbRoomPageSize.Location = new System.Drawing.Point(271, 186);
            this.cbbRoomPageSize.Margin = new System.Windows.Forms.Padding(0);
            this.cbbRoomPageSize.Name = "cbbRoomPageSize";
            this.cbbRoomPageSize.Size = new System.Drawing.Size(200, 24);
            this.cbbRoomPageSize.TabIndex = 123;
            // 
            // RoomView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 661);
            this.Controls.Add(this.pgnRoomView);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.cbbRoomPageSize);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grvRoom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1127, 661);
            this.MinimumSize = new System.Drawing.Size(1127, 661);
            this.Name = "RoomView";
            this.Padding = new System.Windows.Forms.Padding(24);
            this.Text = "j";
            ((System.ComponentModel.ISupportInitialize)(this.grvRoom)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grvRoom;
        private System.Windows.Forms.Button btnRoomAdd;
        private System.Windows.Forms.Button btnRoomDetail;
        private System.Windows.Forms.ComboBox cbbRoomTypeFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbRoomStatusFilter;
        private System.Windows.Forms.Button btnRoomUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn floor_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_type_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_per_night;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn updated_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_type_detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_type_id;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnRoomSearch;
        private System.Windows.Forms.TextBox txtRoomSearch;
        private System.Windows.Forms.ComboBox cbbRoomSearchField;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private Controls.PaginationControl pgnRoomView;
        private System.Windows.Forms.ComboBox cbbRoomPageSize;
    }
}