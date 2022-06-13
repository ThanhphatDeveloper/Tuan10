namespace Baitap
{
    partial class frmQLSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLSV));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimMSSV = new System.Windows.Forms.Button();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.btnTimHoTen = new System.Windows.Forms.Button();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.radLop = new System.Windows.Forms.RadioButton();
            this.radMSSV = new System.Windows.Forms.RadioButton();
            this.radHoTen = new System.Windows.Forms.RadioButton();
            this.radTatCa = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvDSSV = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLopHoc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLuu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(221, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTimMSSV);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.btnTimHoTen);
            this.groupBox1.Controls.Add(this.cboLop);
            this.groupBox1.Controls.Add(this.txtMSSV);
            this.groupBox1.Controls.Add(this.radLop);
            this.groupBox1.Controls.Add(this.radMSSV);
            this.groupBox1.Controls.Add(this.radHoTen);
            this.groupBox1.Controls.Add(this.radTatCa);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(147, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 120);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // btnTimMSSV
            // 
            this.btnTimMSSV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimMSSV.BackgroundImage")));
            this.btnTimMSSV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimMSSV.Location = new System.Drawing.Point(232, 73);
            this.btnTimMSSV.Name = "btnTimMSSV";
            this.btnTimMSSV.Size = new System.Drawing.Size(29, 27);
            this.btnTimMSSV.TabIndex = 10;
            this.btnTimMSSV.UseVisualStyleBackColor = true;
            this.btnTimMSSV.Click += new System.EventHandler(this.btnTimMSSV_Click);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(396, 31);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(124, 26);
            this.txtHoTen.TabIndex = 9;
            // 
            // btnTimHoTen
            // 
            this.btnTimHoTen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimHoTen.BackgroundImage")));
            this.btnTimHoTen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimHoTen.Location = new System.Drawing.Point(526, 31);
            this.btnTimHoTen.Name = "btnTimHoTen";
            this.btnTimHoTen.Size = new System.Drawing.Size(29, 26);
            this.btnTimHoTen.TabIndex = 8;
            this.btnTimHoTen.UseVisualStyleBackColor = true;
            this.btnTimHoTen.Click += new System.EventHandler(this.btnTimHoTen_Click);
            // 
            // cboLop
            // 
            this.cboLop.DisplayMember = "0";
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(396, 74);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(124, 27);
            this.cboLop.TabIndex = 6;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(102, 73);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(124, 26);
            this.txtMSSV.TabIndex = 4;
            // 
            // radLop
            // 
            this.radLop.AutoSize = true;
            this.radLop.Location = new System.Drawing.Point(314, 76);
            this.radLop.Name = "radLop";
            this.radLop.Size = new System.Drawing.Size(59, 23);
            this.radLop.TabIndex = 3;
            this.radLop.Text = "Lớp:";
            this.radLop.UseVisualStyleBackColor = true;
            // 
            // radMSSV
            // 
            this.radMSSV.AutoSize = true;
            this.radMSSV.Location = new System.Drawing.Point(24, 76);
            this.radMSSV.Name = "radMSSV";
            this.radMSSV.Size = new System.Drawing.Size(76, 23);
            this.radMSSV.TabIndex = 2;
            this.radMSSV.Text = "MSSV:";
            this.radMSSV.UseVisualStyleBackColor = true;
            this.radMSSV.CheckedChanged += new System.EventHandler(this.radMSSV_CheckedChanged);
            // 
            // radHoTen
            // 
            this.radHoTen.AutoSize = true;
            this.radHoTen.Location = new System.Drawing.Point(314, 33);
            this.radHoTen.Name = "radHoTen";
            this.radHoTen.Size = new System.Drawing.Size(82, 23);
            this.radHoTen.TabIndex = 1;
            this.radHoTen.Text = "Họ Tên:";
            this.radHoTen.UseVisualStyleBackColor = true;
            this.radHoTen.CheckedChanged += new System.EventHandler(this.radHoTen_CheckedChanged);
            // 
            // radTatCa
            // 
            this.radTatCa.AutoSize = true;
            this.radTatCa.Checked = true;
            this.radTatCa.Location = new System.Drawing.Point(24, 34);
            this.radTatCa.Name = "radTatCa";
            this.radTatCa.Size = new System.Drawing.Size(69, 23);
            this.radTatCa.TabIndex = 0;
            this.radTatCa.TabStop = true;
            this.radTatCa.Text = "Tất cả";
            this.radTatCa.UseVisualStyleBackColor = true;
            this.radTatCa.CheckedChanged += new System.EventHandler(this.radTatCa_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 141);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // dgvDSSV
            // 
            this.dgvDSSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colMSSV,
            this.colHo,
            this.colTen,
            this.colNgaySinh,
            this.colLopHoc,
            this.colDiaChi});
            this.dgvDSSV.Location = new System.Drawing.Point(12, 169);
            this.dgvDSSV.Name = "dgvDSSV";
            this.dgvDSSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSSV.Size = new System.Drawing.Size(708, 230);
            this.dgvDSSV.TabIndex = 4;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colMSSV
            // 
            this.colMSSV.DataPropertyName = "MSSV";
            this.colMSSV.HeaderText = "MSSV";
            this.colMSSV.Name = "colMSSV";
            // 
            // colHo
            // 
            this.colHo.DataPropertyName = "Ho";
            this.colHo.HeaderText = "Họ";
            this.colHo.Name = "colHo";
            // 
            // colTen
            // 
            this.colTen.DataPropertyName = "Ten";
            this.colTen.HeaderText = "Tên";
            this.colTen.Name = "colTen";
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.DataPropertyName = "NgaySinh";
            this.colNgaySinh.HeaderText = "Ngày Sinh";
            this.colNgaySinh.Name = "colNgaySinh";
            // 
            // colLopHoc
            // 
            this.colLopHoc.DataPropertyName = "MaLop";
            this.colLopHoc.HeaderText = "Lớp Học";
            this.colLopHoc.Name = "colLopHoc";
            // 
            // colDiaChi
            // 
            this.colDiaChi.DataPropertyName = "DiaChi";
            this.colDiaChi.HeaderText = "Địa Chỉ";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDiaChi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnLuu
            // 
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(637, 405);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLuu.Size = new System.Drawing.Size(83, 47);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmQLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 455);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dgvDSSV);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQLSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.frmQLSV_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTimMSSV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Button btnTimHoTen;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.RadioButton radLop;
        private System.Windows.Forms.RadioButton radMSSV;
        private System.Windows.Forms.RadioButton radHoTen;
        private System.Windows.Forms.RadioButton radTatCa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvDSSV;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewComboBoxColumn colLopHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
    }
}

