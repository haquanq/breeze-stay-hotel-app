
namespace HotelManagement.WinformApp.Views.Room
{
    partial class RoomAddView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRoomAdd = new System.Windows.Forms.Button();
            this.txtRoomCode = new System.Windows.Forms.TextBox();
            this.cbbRoomType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtRoomFloorNumber = new System.Windows.Forms.NumericUpDown();
            this.grvRoomAmenity = new System.Windows.Forms.DataGridView();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmenityId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRoomAmenityAdd = new System.Windows.Forms.Button();
            this.btnRoomAmenityRemove = new System.Windows.Forms.Button();
            this.lblRoomAmenityCount = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoomFloorNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvRoomAmenity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightGray;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnCancel.Location = new System.Drawing.Point(900, 660);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(260, 32);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnRoomAdd
            // 
            this.btnRoomAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRoomAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoomAdd.FlatAppearance.BorderSize = 0;
            this.btnRoomAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnRoomAdd.ForeColor = System.Drawing.Color.White;
            this.btnRoomAdd.Location = new System.Drawing.Point(632, 660);
            this.btnRoomAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnRoomAdd.Name = "btnRoomAdd";
            this.btnRoomAdd.Size = new System.Drawing.Size(260, 32);
            this.btnRoomAdd.TabIndex = 14;
            this.btnRoomAdd.Text = "Add";
            this.btnRoomAdd.UseVisualStyleBackColor = false;
            // 
            // txtRoomCode
            // 
            this.txtRoomCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRoomCode.ForeColor = System.Drawing.Color.Black;
            this.txtRoomCode.Location = new System.Drawing.Point(27, 81);
            this.txtRoomCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 8);
            this.txtRoomCode.Name = "txtRoomCode";
            this.txtRoomCode.Size = new System.Drawing.Size(260, 22);
            this.txtRoomCode.TabIndex = 163;
            // 
            // cbbRoomType
            // 
            this.cbbRoomType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbRoomType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbRoomType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbbRoomType.FormattingEnabled = true;
            this.cbbRoomType.Items.AddRange(new object[] {
            "Book genre",
            "Book author"});
            this.cbbRoomType.Location = new System.Drawing.Point(295, 79);
            this.cbbRoomType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 8);
            this.cbbRoomType.Name = "cbbRoomType";
            this.cbbRoomType.Size = new System.Drawing.Size(260, 24);
            this.cbbRoomType.TabIndex = 172;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label3.Location = new System.Drawing.Point(292, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 174;
            this.label3.Text = "Room type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label1.Location = new System.Drawing.Point(25, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 175;
            this.label1.Text = "Room code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label2.Location = new System.Drawing.Point(25, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 176;
            this.label2.Text = "Floor number";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label13.Location = new System.Drawing.Point(24, 24);
            this.label13.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(150, 19);
            this.label13.TabIndex = 177;
            this.label13.Text = "Room information";
            // 
            // txtRoomFloorNumber
            // 
            this.txtRoomFloorNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRoomFloorNumber.Location = new System.Drawing.Point(28, 129);
            this.txtRoomFloorNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 8);
            this.txtRoomFloorNumber.Name = "txtRoomFloorNumber";
            this.txtRoomFloorNumber.Size = new System.Drawing.Size(259, 22);
            this.txtRoomFloorNumber.TabIndex = 185;
            // 
            // grvRoomAmenity
            // 
            this.grvRoomAmenity.AllowUserToAddRows = false;
            this.grvRoomAmenity.AllowUserToDeleteRows = false;
            this.grvRoomAmenity.AllowUserToResizeColumns = false;
            this.grvRoomAmenity.AllowUserToResizeRows = false;
            this.grvRoomAmenity.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grvRoomAmenity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvRoomAmenity.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvRoomAmenity.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvRoomAmenity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvRoomAmenity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Status,
            this.AmenityId,
            this.Title,
            this.Price,
            this.Detail});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvRoomAmenity.DefaultCellStyle = dataGridViewCellStyle2;
            this.grvRoomAmenity.GridColor = System.Drawing.Color.Gainsboro;
            this.grvRoomAmenity.Location = new System.Drawing.Point(28, 210);
            this.grvRoomAmenity.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.grvRoomAmenity.Name = "grvRoomAmenity";
            this.grvRoomAmenity.ReadOnly = true;
            this.grvRoomAmenity.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grvRoomAmenity.RowHeadersVisible = false;
            this.grvRoomAmenity.RowHeadersWidth = 45;
            this.grvRoomAmenity.RowTemplate.Height = 30;
            this.grvRoomAmenity.RowTemplate.ReadOnly = true;
            this.grvRoomAmenity.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grvRoomAmenity.Size = new System.Drawing.Size(527, 324);
            this.grvRoomAmenity.TabIndex = 186;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 77;
            // 
            // AmenityId
            // 
            this.AmenityId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AmenityId.DataPropertyName = "AmenityId";
            this.AmenityId.HeaderText = "ID";
            this.AmenityId.MinimumWidth = 8;
            this.AmenityId.Name = "AmenityId";
            this.AmenityId.ReadOnly = true;
            this.AmenityId.Width = 53;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 8;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 66;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 71;
            // 
            // Detail
            // 
            this.Detail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Detail.DataPropertyName = "Detail";
            this.Detail.HeaderText = "Detail";
            this.Detail.MinimumWidth = 8;
            this.Detail.Name = "Detail";
            this.Detail.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label4.Location = new System.Drawing.Point(24, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 19);
            this.label4.TabIndex = 187;
            this.label4.Text = "Room amenities";
            // 
            // btnRoomAmenityAdd
            // 
            this.btnRoomAmenityAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRoomAmenityAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoomAmenityAdd.FlatAppearance.BorderSize = 0;
            this.btnRoomAmenityAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomAmenityAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnRoomAmenityAdd.ForeColor = System.Drawing.Color.White;
            this.btnRoomAmenityAdd.Location = new System.Drawing.Point(960, 546);
            this.btnRoomAmenityAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnRoomAmenityAdd.Name = "btnRoomAmenityAdd";
            this.btnRoomAmenityAdd.Size = new System.Drawing.Size(200, 24);
            this.btnRoomAmenityAdd.TabIndex = 124;
            this.btnRoomAmenityAdd.Text = "Add";
            this.btnRoomAmenityAdd.UseVisualStyleBackColor = false;
            // 
            // btnRoomAmenityRemove
            // 
            this.btnRoomAmenityRemove.BackColor = System.Drawing.Color.LightGray;
            this.btnRoomAmenityRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoomAmenityRemove.FlatAppearance.BorderSize = 0;
            this.btnRoomAmenityRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomAmenityRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnRoomAmenityRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnRoomAmenityRemove.Location = new System.Drawing.Point(355, 546);
            this.btnRoomAmenityRemove.Margin = new System.Windows.Forms.Padding(0);
            this.btnRoomAmenityRemove.Name = "btnRoomAmenityRemove";
            this.btnRoomAmenityRemove.Size = new System.Drawing.Size(200, 24);
            this.btnRoomAmenityRemove.TabIndex = 189;
            this.btnRoomAmenityRemove.Text = "Remove";
            this.btnRoomAmenityRemove.UseVisualStyleBackColor = false;
            // 
            // lblRoomAmenityCount
            // 
            this.lblRoomAmenityCount.BackColor = System.Drawing.Color.Gainsboro;
            this.lblRoomAmenityCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRoomAmenityCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblRoomAmenityCount.Location = new System.Drawing.Point(28, 546);
            this.lblRoomAmenityCount.Margin = new System.Windows.Forms.Padding(0);
            this.lblRoomAmenityCount.Name = "lblRoomAmenityCount";
            this.lblRoomAmenityCount.Size = new System.Drawing.Size(171, 24);
            this.lblRoomAmenityCount.TabIndex = 265;
            this.lblRoomAmenityCount.Text = "ex";
            this.lblRoomAmenityCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.Location = new System.Drawing.Point(585, 61);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(12, 12, 0, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 45;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.Size = new System.Drawing.Size(575, 473);
            this.dataGridView1.TabIndex = 266;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn1.HeaderText = "Status";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 77;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AmenityId";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 53;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn3.HeaderText = "Title";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 66;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 71;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Detail";
            this.dataGridViewTextBoxColumn5.HeaderText = "Detail";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label5.Location = new System.Drawing.Point(581, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 19);
            this.label5.TabIndex = 267;
            this.label5.Text = "Available amenities";
            // 
            // RoomAddView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 726);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRoomAmenityAdd);
            this.Controls.Add(this.lblRoomAmenityCount);
            this.Controls.Add(this.btnRoomAmenityRemove);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grvRoomAmenity);
            this.Controls.Add(this.txtRoomFloorNumber);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbRoomType);
            this.Controls.Add(this.txtRoomCode);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRoomAdd);
            this.MaximizeBox = false;
            this.Name = "RoomAddView";
            this.Padding = new System.Windows.Forms.Padding(24, 24, 24, 30);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new room";
            ((System.ComponentModel.ISupportInitialize)(this.txtRoomFloorNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvRoomAmenity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRoomAdd;
        private System.Windows.Forms.TextBox txtRoomCode;
        private System.Windows.Forms.ComboBox cbbRoomType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown txtRoomFloorNumber;
        private System.Windows.Forms.DataGridView grvRoomAmenity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRoomAmenityAdd;
        private System.Windows.Forms.Button btnRoomAmenityRemove;
        private System.Windows.Forms.Label lblRoomAmenityCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmenityId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detail;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label5;
    }
}