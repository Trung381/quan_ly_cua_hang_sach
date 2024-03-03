namespace quan_ly_cua_hang_sach
{
    partial class FrmQLSP
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
            this.dgvQLSP = new System.Windows.Forms.DataGridView();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.lbCategory = new System.Windows.Forms.Label();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.cbbAuthor = new System.Windows.Forms.ComboBox();
            this.lbNXB = new System.Windows.Forms.Label();
            this.cbbNXB = new System.Windows.Forms.ComboBox();
            this.btQLTL = new System.Windows.Forms.Button();
            this.btQLTG = new System.Windows.Forms.Button();
            this.btQLNXB = new System.Windows.Forms.Button();
            this.lbMa = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbSL = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.tbMa = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSL = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.lbForDGV_SP = new System.Windows.Forms.Label();
            this.btAddSach = new System.Windows.Forms.Button();
            this.btDelSach = new System.Windows.Forms.Button();
            this.btEditSach = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLSP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQLSP
            // 
            this.dgvQLSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLSP.Location = new System.Drawing.Point(16, 397);
            this.dgvQLSP.Name = "dgvQLSP";
            this.dgvQLSP.RowHeadersWidth = 62;
            this.dgvQLSP.RowTemplate.Height = 28;
            this.dgvQLSP.Size = new System.Drawing.Size(1191, 300);
            this.dgvQLSP.TabIndex = 0;
            this.dgvQLSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVQLSP_CellClick);
            // 
            // cbbCategory
            // 
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(811, 33);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(239, 28);
            this.cbbCategory.TabIndex = 1;
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Location = new System.Drawing.Point(681, 36);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(102, 20);
            this.lbCategory.TabIndex = 2;
            this.lbCategory.Text = "Thể loại sách";
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Location = new System.Drawing.Point(681, 107);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(60, 20);
            this.lbAuthor.TabIndex = 4;
            this.lbAuthor.Text = "Tác giả";
            // 
            // cbbAuthor
            // 
            this.cbbAuthor.FormattingEnabled = true;
            this.cbbAuthor.Location = new System.Drawing.Point(811, 104);
            this.cbbAuthor.Name = "cbbAuthor";
            this.cbbAuthor.Size = new System.Drawing.Size(239, 28);
            this.cbbAuthor.TabIndex = 3;
            // 
            // lbNXB
            // 
            this.lbNXB.AutoSize = true;
            this.lbNXB.Location = new System.Drawing.Point(681, 207);
            this.lbNXB.Name = "lbNXB";
            this.lbNXB.Size = new System.Drawing.Size(103, 20);
            this.lbNXB.TabIndex = 6;
            this.lbNXB.Text = "Nhà xuất bản";
            // 
            // cbbNXB
            // 
            this.cbbNXB.FormattingEnabled = true;
            this.cbbNXB.Location = new System.Drawing.Point(820, 201);
            this.cbbNXB.Name = "cbbNXB";
            this.cbbNXB.Size = new System.Drawing.Size(239, 28);
            this.cbbNXB.TabIndex = 5;
            // 
            // btQLTL
            // 
            this.btQLTL.Location = new System.Drawing.Point(1087, 35);
            this.btQLTL.Name = "btQLTL";
            this.btQLTL.Size = new System.Drawing.Size(129, 23);
            this.btQLTL.TabIndex = 16;
            this.btQLTL.Text = "Quản lý thể loại";
            this.btQLTL.UseVisualStyleBackColor = true;
            this.btQLTL.Click += new System.EventHandler(this.btQLTL_Click);
            // 
            // btQLTG
            // 
            this.btQLTG.Location = new System.Drawing.Point(1097, 109);
            this.btQLTG.Name = "btQLTG";
            this.btQLTG.Size = new System.Drawing.Size(129, 23);
            this.btQLTG.TabIndex = 17;
            this.btQLTG.Text = "Quản lý tác giả";
            this.btQLTG.UseVisualStyleBackColor = true;
            this.btQLTG.Click += new System.EventHandler(this.btQLTG_Click);
            // 
            // btQLNXB
            // 
            this.btQLNXB.Location = new System.Drawing.Point(1087, 207);
            this.btQLNXB.Name = "btQLNXB";
            this.btQLNXB.Size = new System.Drawing.Size(129, 23);
            this.btQLNXB.TabIndex = 18;
            this.btQLNXB.Text = "Quản lý nxb";
            this.btQLNXB.UseVisualStyleBackColor = true;
            this.btQLNXB.Click += new System.EventHandler(this.btQLNXB_Click);
            // 
            // lbMa
            // 
            this.lbMa.AutoSize = true;
            this.lbMa.Location = new System.Drawing.Point(12, 33);
            this.lbMa.Name = "lbMa";
            this.lbMa.Size = new System.Drawing.Size(69, 20);
            this.lbMa.TabIndex = 19;
            this.lbMa.Text = "Mã sách";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(12, 87);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(74, 20);
            this.lbName.TabIndex = 20;
            this.lbName.Text = "Tên sách";
            // 
            // lbSL
            // 
            this.lbSL.AutoSize = true;
            this.lbSL.Location = new System.Drawing.Point(11, 141);
            this.lbSL.Name = "lbSL";
            this.lbSL.Size = new System.Drawing.Size(72, 20);
            this.lbSL.TabIndex = 21;
            this.lbSL.Text = "Số lượng";
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Location = new System.Drawing.Point(11, 204);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(107, 20);
            this.lbYear.TabIndex = 22;
            this.lbYear.Text = "Năm xuất bản";
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Location = new System.Drawing.Point(11, 265);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(65, 20);
            this.lbAmount.TabIndex = 23;
            this.lbAmount.Text = "Giá bán";
            // 
            // tbMa
            // 
            this.tbMa.Location = new System.Drawing.Point(133, 31);
            this.tbMa.Name = "tbMa";
            this.tbMa.Size = new System.Drawing.Size(310, 26);
            this.tbMa.TabIndex = 24;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(133, 84);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(310, 26);
            this.tbName.TabIndex = 25;
            // 
            // tbSL
            // 
            this.tbSL.Location = new System.Drawing.Point(133, 141);
            this.tbSL.Name = "tbSL";
            this.tbSL.Size = new System.Drawing.Size(310, 26);
            this.tbSL.TabIndex = 26;
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(133, 201);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(310, 26);
            this.tbYear.TabIndex = 27;
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(133, 259);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(310, 26);
            this.tbAmount.TabIndex = 28;
            // 
            // lbForDGV_SP
            // 
            this.lbForDGV_SP.AutoSize = true;
            this.lbForDGV_SP.Location = new System.Drawing.Point(16, 352);
            this.lbForDGV_SP.Name = "lbForDGV_SP";
            this.lbForDGV_SP.Size = new System.Drawing.Size(143, 20);
            this.lbForDGV_SP.TabIndex = 29;
            this.lbForDGV_SP.Text = "Thống kê kho sách";
            // 
            // btAddSach
            // 
            this.btAddSach.Location = new System.Drawing.Point(778, 316);
            this.btAddSach.Name = "btAddSach";
            this.btAddSach.Size = new System.Drawing.Size(75, 23);
            this.btAddSach.TabIndex = 30;
            this.btAddSach.Text = "Thêm sách";
            this.btAddSach.UseVisualStyleBackColor = true;
            // 
            // btDelSach
            // 
            this.btDelSach.Location = new System.Drawing.Point(1065, 335);
            this.btDelSach.Name = "btDelSach";
            this.btDelSach.Size = new System.Drawing.Size(75, 23);
            this.btDelSach.TabIndex = 32;
            this.btDelSach.Text = "Xóa sách";
            this.btDelSach.UseVisualStyleBackColor = true;
            // 
            // btEditSach
            // 
            this.btEditSach.Location = new System.Drawing.Point(925, 316);
            this.btEditSach.Name = "btEditSach";
            this.btEditSach.Size = new System.Drawing.Size(75, 23);
            this.btEditSach.TabIndex = 33;
            this.btEditSach.Text = "Sửa thông tin sách";
            this.btEditSach.UseVisualStyleBackColor = true;
            // 
            // FrmQLSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 709);
            this.Controls.Add(this.btEditSach);
            this.Controls.Add(this.btDelSach);
            this.Controls.Add(this.btAddSach);
            this.Controls.Add(this.lbForDGV_SP);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.tbSL);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbMa);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.lbYear);
            this.Controls.Add(this.lbSL);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbMa);
            this.Controls.Add(this.btQLNXB);
            this.Controls.Add(this.btQLTG);
            this.Controls.Add(this.btQLTL);
            this.Controls.Add(this.lbNXB);
            this.Controls.Add(this.cbbNXB);
            this.Controls.Add(this.lbAuthor);
            this.Controls.Add(this.cbbAuthor);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.cbbCategory);
            this.Controls.Add(this.dgvQLSP);
            this.Name = "FrmQLSP";
            this.Text = "FrmQLSP";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQLSP;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.ComboBox cbbAuthor;
        private System.Windows.Forms.Label lbNXB;
        private System.Windows.Forms.ComboBox cbbNXB;
        private System.Windows.Forms.Button btQLTL;
        private System.Windows.Forms.Button btQLTG;
        private System.Windows.Forms.Button btQLNXB;
        private System.Windows.Forms.Label lbMa;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbSL;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.TextBox tbMa;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSL;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label lbForDGV_SP;
        private System.Windows.Forms.Button btAddSach;
        private System.Windows.Forms.Button btDelSach;
        private System.Windows.Forms.Button btEditSach;
    }
}