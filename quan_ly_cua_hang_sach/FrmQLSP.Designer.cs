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
            this.dGVQLSP = new System.Windows.Forms.DataGridView();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.lbCategory = new System.Windows.Forms.Label();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.cbbAuthor = new System.Windows.Forms.ComboBox();
            this.lbNXB = new System.Windows.Forms.Label();
            this.cbbNXB = new System.Windows.Forms.ComboBox();
            this.btQLTL = new System.Windows.Forms.Button();
            this.btQLTG = new System.Windows.Forms.Button();
            this.btQLNXB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVQLSP)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVQLSP
            // 
            this.dGVQLSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVQLSP.Location = new System.Drawing.Point(15, 546);
            this.dGVQLSP.Name = "dGVQLSP";
            this.dGVQLSP.RowHeadersWidth = 62;
            this.dGVQLSP.RowTemplate.Height = 28;
            this.dGVQLSP.Size = new System.Drawing.Size(1272, 151);
            this.dGVQLSP.TabIndex = 0;
            // 
            // cbbCategory
            // 
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(161, 33);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(239, 28);
            this.cbbCategory.TabIndex = 1;
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Location = new System.Drawing.Point(31, 36);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(114, 20);
            this.lbCategory.TabIndex = 2;
            this.lbCategory.Text = "Thể loại sách : ";
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Location = new System.Drawing.Point(31, 91);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(72, 20);
            this.lbAuthor.TabIndex = 4;
            this.lbAuthor.Text = "Tác giả : ";
            // 
            // cbbAuthor
            // 
            this.cbbAuthor.FormattingEnabled = true;
            this.cbbAuthor.Location = new System.Drawing.Point(161, 88);
            this.cbbAuthor.Name = "cbbAuthor";
            this.cbbAuthor.Size = new System.Drawing.Size(239, 28);
            this.cbbAuthor.TabIndex = 3;
            // 
            // lbNXB
            // 
            this.lbNXB.AutoSize = true;
            this.lbNXB.Location = new System.Drawing.Point(31, 143);
            this.lbNXB.Name = "lbNXB";
            this.lbNXB.Size = new System.Drawing.Size(115, 20);
            this.lbNXB.TabIndex = 6;
            this.lbNXB.Text = "Nhà xuất bản : ";
            // 
            // cbbNXB
            // 
            this.cbbNXB.FormattingEnabled = true;
            this.cbbNXB.Location = new System.Drawing.Point(161, 140);
            this.cbbNXB.Name = "cbbNXB";
            this.cbbNXB.Size = new System.Drawing.Size(239, 28);
            this.cbbNXB.TabIndex = 5;
            // 
            // btQLTL
            // 
            this.btQLTL.Location = new System.Drawing.Point(466, 37);
            this.btQLTL.Name = "btQLTL";
            this.btQLTL.Size = new System.Drawing.Size(129, 23);
            this.btQLTL.TabIndex = 16;
            this.btQLTL.Text = "Quản lý thể loại";
            this.btQLTL.UseVisualStyleBackColor = true;
            this.btQLTL.Click += new System.EventHandler(this.btQLTL_Click);
            // 
            // btQLTG
            // 
            this.btQLTG.Location = new System.Drawing.Point(466, 93);
            this.btQLTG.Name = "btQLTG";
            this.btQLTG.Size = new System.Drawing.Size(129, 23);
            this.btQLTG.TabIndex = 17;
            this.btQLTG.Text = "Quản lý tác giả";
            this.btQLTG.UseVisualStyleBackColor = true;
            this.btQLTG.Click += new System.EventHandler(this.btQLTG_Click);
            // 
            // btQLNXB
            // 
            this.btQLNXB.Location = new System.Drawing.Point(466, 145);
            this.btQLNXB.Name = "btQLNXB";
            this.btQLNXB.Size = new System.Drawing.Size(129, 23);
            this.btQLNXB.TabIndex = 18;
            this.btQLNXB.Text = "Quản lý nxb";
            this.btQLNXB.UseVisualStyleBackColor = true;
            this.btQLNXB.Click += new System.EventHandler(this.btQLNXB_Click);
            // 
            // FrmQLSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 709);
            this.Controls.Add(this.btQLNXB);
            this.Controls.Add(this.btQLTG);
            this.Controls.Add(this.btQLTL);
            this.Controls.Add(this.lbNXB);
            this.Controls.Add(this.cbbNXB);
            this.Controls.Add(this.lbAuthor);
            this.Controls.Add(this.cbbAuthor);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.cbbCategory);
            this.Controls.Add(this.dGVQLSP);
            this.Name = "FrmQLSP";
            this.Text = "FrmQLSP";
            ((System.ComponentModel.ISupportInitialize)(this.dGVQLSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVQLSP;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.ComboBox cbbAuthor;
        private System.Windows.Forms.Label lbNXB;
        private System.Windows.Forms.ComboBox cbbNXB;
        private System.Windows.Forms.Button btQLTL;
        private System.Windows.Forms.Button btQLTG;
        private System.Windows.Forms.Button btQLNXB;
    }
}