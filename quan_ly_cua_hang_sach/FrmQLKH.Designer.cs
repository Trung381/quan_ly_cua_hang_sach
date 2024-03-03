namespace quan_ly_cua_hang_sach
{
    partial class FrmQLKH
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
            this.dGVQLKH = new System.Windows.Forms.DataGridView();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.lbNameKH = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.tbMaKH = new System.Windows.Forms.TextBox();
            this.tbNgaySinh = new System.Windows.Forms.TextBox();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.tbNameKH = new System.Windows.Forms.TextBox();
            this.btAddKH = new System.Windows.Forms.Button();
            this.btEditKH = new System.Windows.Forms.Button();
            this.btDelKH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVQLKH)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVQLKH
            // 
            this.dGVQLKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVQLKH.Location = new System.Drawing.Point(12, 432);
            this.dGVQLKH.Name = "dGVQLKH";
            this.dGVQLKH.RowHeadersWidth = 62;
            this.dGVQLKH.RowTemplate.Height = 28;
            this.dGVQLKH.Size = new System.Drawing.Size(1267, 241);
            this.dGVQLKH.TabIndex = 0;
            this.dGVQLKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVQLKH_CellClick);
            // 
            // lbMaKH
            // 
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Location = new System.Drawing.Point(44, 34);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(118, 20);
            this.lbMaKH.TabIndex = 1;
            this.lbMaKH.Text = "Mã khách hàng";
            // 
            // lbNameKH
            // 
            this.lbNameKH.AutoSize = true;
            this.lbNameKH.Location = new System.Drawing.Point(44, 93);
            this.lbNameKH.Name = "lbNameKH";
            this.lbNameKH.Size = new System.Drawing.Size(123, 20);
            this.lbNameKH.TabIndex = 2;
            this.lbNameKH.Text = "Tên khách hàng";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Location = new System.Drawing.Point(44, 151);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(102, 20);
            this.lbSDT.TabIndex = 3;
            this.lbSDT.Text = "Số điện thoại";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Location = new System.Drawing.Point(44, 208);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(78, 20);
            this.lbNgaySinh.TabIndex = 4;
            this.lbNgaySinh.Text = "Ngày sinh";
            // 
            // tbMaKH
            // 
            this.tbMaKH.Location = new System.Drawing.Point(195, 31);
            this.tbMaKH.Name = "tbMaKH";
            this.tbMaKH.Size = new System.Drawing.Size(291, 26);
            this.tbMaKH.TabIndex = 5;
            // 
            // tbNgaySinh
            // 
            this.tbNgaySinh.Location = new System.Drawing.Point(195, 208);
            this.tbNgaySinh.Name = "tbNgaySinh";
            this.tbNgaySinh.Size = new System.Drawing.Size(291, 26);
            this.tbNgaySinh.TabIndex = 7;
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(195, 151);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(291, 26);
            this.tbSDT.TabIndex = 8;
            // 
            // tbNameKH
            // 
            this.tbNameKH.Location = new System.Drawing.Point(195, 90);
            this.tbNameKH.Name = "tbNameKH";
            this.tbNameKH.Size = new System.Drawing.Size(291, 26);
            this.tbNameKH.TabIndex = 9;
            // 
            // btAddKH
            // 
            this.btAddKH.Location = new System.Drawing.Point(725, 70);
            this.btAddKH.Name = "btAddKH";
            this.btAddKH.Size = new System.Drawing.Size(218, 23);
            this.btAddKH.TabIndex = 10;
            this.btAddKH.Text = "Thêm khách hàng";
            this.btAddKH.UseVisualStyleBackColor = true;
            // 
            // btEditKH
            // 
            this.btEditKH.Location = new System.Drawing.Point(725, 154);
            this.btEditKH.Name = "btEditKH";
            this.btEditKH.Size = new System.Drawing.Size(187, 23);
            this.btEditKH.TabIndex = 11;
            this.btEditKH.Text = "Sửa thông tin ";
            this.btEditKH.UseVisualStyleBackColor = true;
            // 
            // btDelKH
            // 
            this.btDelKH.Location = new System.Drawing.Point(725, 222);
            this.btDelKH.Name = "btDelKH";
            this.btDelKH.Size = new System.Drawing.Size(203, 23);
            this.btDelKH.TabIndex = 12;
            this.btDelKH.Text = "Xóa khách hàng";
            this.btDelKH.UseVisualStyleBackColor = true;
            // 
            // FrmQLKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 694);
            this.Controls.Add(this.btDelKH);
            this.Controls.Add(this.btEditKH);
            this.Controls.Add(this.btAddKH);
            this.Controls.Add(this.tbNameKH);
            this.Controls.Add(this.tbSDT);
            this.Controls.Add(this.tbNgaySinh);
            this.Controls.Add(this.tbMaKH);
            this.Controls.Add(this.lbNgaySinh);
            this.Controls.Add(this.lbSDT);
            this.Controls.Add(this.lbNameKH);
            this.Controls.Add(this.lbMaKH);
            this.Controls.Add(this.dGVQLKH);
            this.Name = "FrmQLKH";
            this.Text = "FrmQLKH";
            ((System.ComponentModel.ISupportInitialize)(this.dGVQLKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVQLKH;
        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.Label lbNameKH;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.TextBox tbMaKH;
        private System.Windows.Forms.TextBox tbNgaySinh;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.TextBox tbNameKH;
        private System.Windows.Forms.Button btAddKH;
        private System.Windows.Forms.Button btEditKH;
        private System.Windows.Forms.Button btDelKH;
    }
}