namespace quan_ly_cua_hang_sach
{
    partial class FrmQLTL
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
            this.bt_del_category = new System.Windows.Forms.Button();
            this.bt_edit_category = new System.Windows.Forms.Button();
            this.bt_add_category = new System.Windows.Forms.Button();
            this.dGVQLTL = new System.Windows.Forms.DataGridView();
            this.tbNameTL = new System.Windows.Forms.TextBox();
            this.tbMaTL = new System.Windows.Forms.TextBox();
            this.lbNameTL = new System.Windows.Forms.Label();
            this.lbMaTL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVQLTL)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_del_category
            // 
            this.bt_del_category.Location = new System.Drawing.Point(456, 221);
            this.bt_del_category.Name = "bt_del_category";
            this.bt_del_category.Size = new System.Drawing.Size(135, 34);
            this.bt_del_category.TabIndex = 12;
            this.bt_del_category.Text = "Xóa thể loại";
            this.bt_del_category.UseVisualStyleBackColor = true;
            // 
            // bt_edit_category
            // 
            this.bt_edit_category.Location = new System.Drawing.Point(456, 135);
            this.bt_edit_category.Name = "bt_edit_category";
            this.bt_edit_category.Size = new System.Drawing.Size(135, 34);
            this.bt_edit_category.TabIndex = 11;
            this.bt_edit_category.Text = "Sửa thể loại";
            this.bt_edit_category.UseVisualStyleBackColor = true;
            // 
            // bt_add_category
            // 
            this.bt_add_category.Location = new System.Drawing.Point(456, 44);
            this.bt_add_category.Name = "bt_add_category";
            this.bt_add_category.Size = new System.Drawing.Size(135, 34);
            this.bt_add_category.TabIndex = 10;
            this.bt_add_category.Text = "Thêm thể loại";
            this.bt_add_category.UseVisualStyleBackColor = true;
            this.bt_add_category.Click += new System.EventHandler(this.bt_add_category_Click);
            // 
            // dGVQLTL
            // 
            this.dGVQLTL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVQLTL.Location = new System.Drawing.Point(12, 293);
            this.dGVQLTL.Name = "dGVQLTL";
            this.dGVQLTL.RowHeadersWidth = 62;
            this.dGVQLTL.RowTemplate.Height = 28;
            this.dGVQLTL.Size = new System.Drawing.Size(776, 145);
            this.dGVQLTL.TabIndex = 13;
            this.dGVQLTL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVQLTL_CellClick);
            // 
            // tbNameTL
            // 
            this.tbNameTL.Location = new System.Drawing.Point(145, 95);
            this.tbNameTL.Name = "tbNameTL";
            this.tbNameTL.Size = new System.Drawing.Size(100, 26);
            this.tbNameTL.TabIndex = 33;
            // 
            // tbMaTL
            // 
            this.tbMaTL.Location = new System.Drawing.Point(145, 34);
            this.tbMaTL.Name = "tbMaTL";
            this.tbMaTL.ReadOnly = true;
            this.tbMaTL.Size = new System.Drawing.Size(100, 26);
            this.tbMaTL.TabIndex = 32;
            // 
            // lbNameTL
            // 
            this.lbNameTL.AutoSize = true;
            this.lbNameTL.Location = new System.Drawing.Point(28, 83);
            this.lbNameTL.Name = "lbNameTL";
            this.lbNameTL.Size = new System.Drawing.Size(64, 20);
            this.lbNameTL.TabIndex = 31;
            this.lbNameTL.Text = "Thể loại";
            // 
            // lbMaTL
            // 
            this.lbMaTL.AutoSize = true;
            this.lbMaTL.Location = new System.Drawing.Point(28, 34);
            this.lbMaTL.Name = "lbMaTL";
            this.lbMaTL.Size = new System.Drawing.Size(86, 20);
            this.lbMaTL.TabIndex = 30;
            this.lbMaTL.Text = "Mã thể loại";
            // 
            // FrmQLTL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbNameTL);
            this.Controls.Add(this.tbMaTL);
            this.Controls.Add(this.lbNameTL);
            this.Controls.Add(this.lbMaTL);
            this.Controls.Add(this.dGVQLTL);
            this.Controls.Add(this.bt_del_category);
            this.Controls.Add(this.bt_edit_category);
            this.Controls.Add(this.bt_add_category);
            this.Name = "FrmQLTL";
            this.Text = "QLTL";
            ((System.ComponentModel.ISupportInitialize)(this.dGVQLTL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_del_category;
        private System.Windows.Forms.Button bt_edit_category;
        private System.Windows.Forms.Button bt_add_category;
        private System.Windows.Forms.DataGridView dGVQLTL;
        private System.Windows.Forms.TextBox tbNameTL;
        private System.Windows.Forms.TextBox tbMaTL;
        private System.Windows.Forms.Label lbNameTL;
        private System.Windows.Forms.Label lbMaTL;
    }
}