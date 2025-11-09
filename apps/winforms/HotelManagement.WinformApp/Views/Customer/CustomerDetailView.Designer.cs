namespace HotelManagement.WinformApp.Views.Customer
{
    partial class CustomerDetailView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grvReservation = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rooms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrival_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departure_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checked_in_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checked_out_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updated_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMoreDetail = new System.Windows.Forms.Button();
            this.cbbStatusFilter = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblRowCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbbSearchType = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.lblCustomerLastName = new System.Windows.Forms.Label();
            this.lblCustomerFirstName = new System.Windows.Forms.Label();
            this.lblCustomerPid = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCustomerUpdatedAt = new System.Windows.Forms.Label();
            this.lblCustomerCreatedAt = new System.Windows.Forms.Label();
            this.pnCustomerStatus = new System.Windows.Forms.Panel();
            this.lblCustomerStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvReservation)).BeginInit();
            this.panel6.SuspendLayout();
            this.pnCustomerStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // grvReservation
            // 
            this.grvReservation.AllowUserToAddRows = false;
            this.grvReservation.AllowUserToDeleteRows = false;
            this.grvReservation.AllowUserToResizeColumns = false;
            this.grvReservation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grvReservation.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grvReservation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvReservation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvReservation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvReservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.rooms,
            this.arrival_time,
            this.departure_time,
            this.checked_in_at,
            this.checked_out_at,
            this.created_at,
            this.updated_at,
            this.total_price,
            this.status});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvReservation.DefaultCellStyle = dataGridViewCellStyle4;
            this.grvReservation.GridColor = System.Drawing.Color.Gainsboro;
            this.grvReservation.Location = new System.Drawing.Point(325, 127);
            this.grvReservation.Margin = new System.Windows.Forms.Padding(0, 24, 0, 8);
            this.grvReservation.Name = "grvReservation";
            this.grvReservation.ReadOnly = true;
            this.grvReservation.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grvReservation.RowHeadersWidth = 45;
            this.grvReservation.RowTemplate.Height = 30;
            this.grvReservation.RowTemplate.ReadOnly = true;
            this.grvReservation.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grvReservation.Size = new System.Drawing.Size(1031, 409);
            this.grvReservation.TabIndex = 2;
            this.grvReservation.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.grvReservation_CellPainting);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 53;
            // 
            // rooms
            // 
            this.rooms.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rooms.DataPropertyName = "rooms";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rooms.DefaultCellStyle = dataGridViewCellStyle2;
            this.rooms.HeaderText = "Rooms";
            this.rooms.Name = "rooms";
            this.rooms.ReadOnly = true;
            this.rooms.Width = 84;
            // 
            // arrival_time
            // 
            this.arrival_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.arrival_time.DataPropertyName = "arrival_time";
            this.arrival_time.HeaderText = "Arrival Time";
            this.arrival_time.Name = "arrival_time";
            this.arrival_time.ReadOnly = true;
            this.arrival_time.Width = 112;
            // 
            // departure_time
            // 
            this.departure_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.departure_time.DataPropertyName = "departure_time";
            this.departure_time.HeaderText = "Departure Time";
            this.departure_time.Name = "departure_time";
            this.departure_time.ReadOnly = true;
            this.departure_time.Width = 134;
            // 
            // checked_in_at
            // 
            this.checked_in_at.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.checked_in_at.DataPropertyName = "checked_in_at";
            this.checked_in_at.HeaderText = "Checked In At";
            this.checked_in_at.Name = "checked_in_at";
            this.checked_in_at.ReadOnly = true;
            this.checked_in_at.Width = 122;
            // 
            // checked_out_at
            // 
            this.checked_out_at.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.checked_out_at.DataPropertyName = "checked_out_at";
            this.checked_out_at.HeaderText = "Checked Out At";
            this.checked_out_at.Name = "checked_out_at";
            this.checked_out_at.ReadOnly = true;
            this.checked_out_at.Width = 132;
            // 
            // created_at
            // 
            this.created_at.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.created_at.DataPropertyName = "created_at";
            this.created_at.HeaderText = "Created At";
            this.created_at.Name = "created_at";
            this.created_at.ReadOnly = true;
            this.created_at.Visible = false;
            // 
            // updated_at
            // 
            this.updated_at.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.updated_at.DataPropertyName = "updated_at";
            this.updated_at.HeaderText = "Updated At";
            this.updated_at.Name = "updated_at";
            this.updated_at.ReadOnly = true;
            this.updated_at.Visible = false;
            // 
            // total_price
            // 
            this.total_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.total_price.DataPropertyName = "total_price";
            this.total_price.HeaderText = "Balance";
            this.total_price.Name = "total_price";
            this.total_price.ReadOnly = true;
            this.total_price.Width = 90;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.status.DataPropertyName = "status";
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(8);
            this.status.DefaultCellStyle = dataGridViewCellStyle3;
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 77;
            // 
            // btnMoreDetail
            // 
            this.btnMoreDetail.BackColor = System.Drawing.Color.Silver;
            this.btnMoreDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoreDetail.FlatAppearance.BorderSize = 0;
            this.btnMoreDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoreDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnMoreDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnMoreDetail.Location = new System.Drawing.Point(1156, 548);
            this.btnMoreDetail.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.btnMoreDetail.Name = "btnMoreDetail";
            this.btnMoreDetail.Size = new System.Drawing.Size(200, 26);
            this.btnMoreDetail.TabIndex = 37;
            this.btnMoreDetail.Text = "Mode detail";
            this.btnMoreDetail.UseVisualStyleBackColor = false;
            // 
            // cbbStatusFilter
            // 
            this.cbbStatusFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbStatusFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbStatusFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStatusFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbbStatusFilter.FormattingEnabled = true;
            this.cbbStatusFilter.Items.AddRange(new object[] {
            "Book genre",
            "Book author"});
            this.cbbStatusFilter.Location = new System.Drawing.Point(325, 81);
            this.cbbStatusFilter.Margin = new System.Windows.Forms.Padding(2);
            this.cbbStatusFilter.Name = "cbbStatusFilter";
            this.cbbStatusFilter.Size = new System.Drawing.Size(167, 24);
            this.cbbStatusFilter.TabIndex = 117;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.lblRowCount);
            this.panel6.Location = new System.Drawing.Point(325, 548);
            this.panel6.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(262, 26);
            this.panel6.TabIndex = 119;
            // 
            // lblRowCount
            // 
            this.lblRowCount.AutoSize = true;
            this.lblRowCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRowCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRowCount.Location = new System.Drawing.Point(5, 6);
            this.lblRowCount.Margin = new System.Windows.Forms.Padding(4);
            this.lblRowCount.Name = "lblRowCount";
            this.lblRowCount.Size = new System.Drawing.Size(41, 16);
            this.lblRowCount.TabIndex = 48;
            this.lblRowCount.Text = "Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(322, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 120;
            this.label4.Text = "Status filter";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1262, 80);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 24);
            this.btnSearch.TabIndex = 128;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.Location = new System.Drawing.Point(957, 79);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(305, 24);
            this.txtSearch.TabIndex = 126;
            // 
            // cbbSearchType
            // 
            this.cbbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSearchType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbbSearchType.FormattingEnabled = true;
            this.cbbSearchType.Location = new System.Drawing.Point(804, 79);
            this.cbbSearchType.Margin = new System.Windows.Forms.Padding(0);
            this.cbbSearchType.Name = "cbbSearchType";
            this.cbbSearchType.Size = new System.Drawing.Size(153, 24);
            this.cbbSearchType.TabIndex = 127;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label14.Location = new System.Drawing.Point(801, 60);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 16);
            this.label14.TabIndex = 125;
            this.label14.Text = "Search by";
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCustomerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCustomerAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblCustomerAddress.Location = new System.Drawing.Point(27, 381);
            this.lblCustomerAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 8);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(260, 91);
            this.lblCustomerAddress.TabIndex = 275;
            this.lblCustomerAddress.Text = "ex";
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCustomerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCustomerEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblCustomerEmail.Location = new System.Drawing.Point(27, 331);
            this.lblCustomerEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 8);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(260, 24);
            this.lblCustomerEmail.TabIndex = 274;
            this.lblCustomerEmail.Text = "ex";
            this.lblCustomerEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCustomerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCustomerPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblCustomerPhone.Location = new System.Drawing.Point(27, 281);
            this.lblCustomerPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 8);
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.Size = new System.Drawing.Size(260, 24);
            this.lblCustomerPhone.TabIndex = 273;
            this.lblCustomerPhone.Text = "ex";
            this.lblCustomerPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomerLastName
            // 
            this.lblCustomerLastName.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCustomerLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCustomerLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblCustomerLastName.Location = new System.Drawing.Point(27, 231);
            this.lblCustomerLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 8);
            this.lblCustomerLastName.Name = "lblCustomerLastName";
            this.lblCustomerLastName.Size = new System.Drawing.Size(260, 24);
            this.lblCustomerLastName.TabIndex = 272;
            this.lblCustomerLastName.Text = "ex";
            this.lblCustomerLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomerFirstName
            // 
            this.lblCustomerFirstName.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCustomerFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCustomerFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblCustomerFirstName.Location = new System.Drawing.Point(27, 181);
            this.lblCustomerFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 8);
            this.lblCustomerFirstName.Name = "lblCustomerFirstName";
            this.lblCustomerFirstName.Size = new System.Drawing.Size(260, 24);
            this.lblCustomerFirstName.TabIndex = 271;
            this.lblCustomerFirstName.Text = "ex";
            this.lblCustomerFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomerPid
            // 
            this.lblCustomerPid.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCustomerPid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCustomerPid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblCustomerPid.Location = new System.Drawing.Point(27, 132);
            this.lblCustomerPid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 8);
            this.lblCustomerPid.Name = "lblCustomerPid";
            this.lblCustomerPid.Size = new System.Drawing.Size(260, 24);
            this.lblCustomerPid.TabIndex = 270;
            this.lblCustomerPid.Text = "ex";
            this.lblCustomerPid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label12.Location = new System.Drawing.Point(24, 363);
            this.label12.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 16);
            this.label12.TabIndex = 269;
            this.label12.Text = "Address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label11.Location = new System.Drawing.Point(24, 114);
            this.label11.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 16);
            this.label11.TabIndex = 268;
            this.label11.Text = "Identification Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label8.Location = new System.Drawing.Point(23, 313);
            this.label8.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 267;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label7.Location = new System.Drawing.Point(23, 263);
            this.label7.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 266;
            this.label7.Text = "Phone ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label6.Location = new System.Drawing.Point(23, 213);
            this.label6.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 265;
            this.label6.Text = "Last name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label2.Location = new System.Drawing.Point(24, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 264;
            this.label2.Text = "First name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label13.Location = new System.Drawing.Point(206, 24);
            this.label13.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 19);
            this.label13.TabIndex = 276;
            this.label13.Text = "Customer";
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCustomerId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblCustomerId.Location = new System.Drawing.Point(27, 82);
            this.lblCustomerId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 8);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(260, 24);
            this.lblCustomerId.TabIndex = 278;
            this.lblCustomerId.Text = "ex";
            this.lblCustomerId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label3.Location = new System.Drawing.Point(24, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 277;
            this.label3.Text = "Customer ID";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Silver;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnExit.Location = new System.Drawing.Point(1096, 601);
            this.btnExit.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(260, 32);
            this.btnExit.TabIndex = 280;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label9.Location = new System.Drawing.Point(321, 24);
            this.label9.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 19);
            this.label9.TabIndex = 281;
            this.label9.Text = "Reservation history";
            // 
            // lblCustomerUpdatedAt
            // 
            this.lblCustomerUpdatedAt.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCustomerUpdatedAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCustomerUpdatedAt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblCustomerUpdatedAt.Location = new System.Drawing.Point(27, 550);
            this.lblCustomerUpdatedAt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 8);
            this.lblCustomerUpdatedAt.Name = "lblCustomerUpdatedAt";
            this.lblCustomerUpdatedAt.Size = new System.Drawing.Size(260, 24);
            this.lblCustomerUpdatedAt.TabIndex = 285;
            this.lblCustomerUpdatedAt.Text = "ex";
            this.lblCustomerUpdatedAt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomerCreatedAt
            // 
            this.lblCustomerCreatedAt.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCustomerCreatedAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCustomerCreatedAt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblCustomerCreatedAt.Location = new System.Drawing.Point(27, 518);
            this.lblCustomerCreatedAt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 8);
            this.lblCustomerCreatedAt.Name = "lblCustomerCreatedAt";
            this.lblCustomerCreatedAt.Size = new System.Drawing.Size(260, 24);
            this.lblCustomerCreatedAt.TabIndex = 283;
            this.lblCustomerCreatedAt.Text = "ex";
            this.lblCustomerCreatedAt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnCustomerStatus
            // 
            this.pnCustomerStatus.Controls.Add(this.lblCustomerStatus);
            this.pnCustomerStatus.Location = new System.Drawing.Point(29, 21);
            this.pnCustomerStatus.Margin = new System.Windows.Forms.Padding(0);
            this.pnCustomerStatus.Name = "pnCustomerStatus";
            this.pnCustomerStatus.Padding = new System.Windows.Forms.Padding(1);
            this.pnCustomerStatus.Size = new System.Drawing.Size(170, 24);
            this.pnCustomerStatus.TabIndex = 298;
            // 
            // lblCustomerStatus
            // 
            this.lblCustomerStatus.BackColor = System.Drawing.Color.White;
            this.lblCustomerStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomerStatus.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblCustomerStatus.Location = new System.Drawing.Point(1, 1);
            this.lblCustomerStatus.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.lblCustomerStatus.Name = "lblCustomerStatus";
            this.lblCustomerStatus.Size = new System.Drawing.Size(168, 22);
            this.lblCustomerStatus.TabIndex = 293;
            this.lblCustomerStatus.Text = "STATUS";
            this.lblCustomerStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomerDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 661);
            this.Controls.Add(this.pnCustomerStatus);
            this.Controls.Add(this.lblCustomerUpdatedAt);
            this.Controls.Add(this.lblCustomerCreatedAt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblCustomerId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblCustomerAddress);
            this.Controls.Add(this.lblCustomerEmail);
            this.Controls.Add(this.lblCustomerPhone);
            this.Controls.Add(this.lblCustomerLastName);
            this.Controls.Add(this.lblCustomerFirstName);
            this.Controls.Add(this.lblCustomerPid);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cbbSearchType);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.cbbStatusFilter);
            this.Controls.Add(this.btnMoreDetail);
            this.Controls.Add(this.grvReservation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1400, 700);
            this.MinimumSize = new System.Drawing.Size(1400, 700);
            this.Name = "CustomerDetailView";
            this.Padding = new System.Windows.Forms.Padding(24);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer detail";
            ((System.ComponentModel.ISupportInitialize)(this.grvReservation)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.pnCustomerStatus.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grvReservation;
        private System.Windows.Forms.Button btnMoreDetail;
        private System.Windows.Forms.ComboBox cbbStatusFilter;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblRowCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbbSearchType;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.Label lblCustomerPhone;
        private System.Windows.Forms.Label lblCustomerLastName;
        private System.Windows.Forms.Label lblCustomerFirstName;
        private System.Windows.Forms.Label lblCustomerPid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCustomerUpdatedAt;
        private System.Windows.Forms.Label lblCustomerCreatedAt;
        private System.Windows.Forms.Panel pnCustomerStatus;
        private System.Windows.Forms.Label lblCustomerStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn rooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrival_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn departure_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn checked_in_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn checked_out_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn updated_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}