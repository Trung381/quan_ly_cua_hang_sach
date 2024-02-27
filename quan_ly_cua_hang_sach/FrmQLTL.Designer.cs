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
            this.SuspendLayout();
            // 
            // bt_del_category
            // 
            this.bt_del_category.Location = new System.Drawing.Point(474, 207);
            this.bt_del_category.Name = "bt_del_category";
            this.bt_del_category.Size = new System.Drawing.Size(135, 34);
            this.bt_del_category.TabIndex = 12;
            this.bt_del_category.Text = "Xóa thể loại";
            this.bt_del_category.UseVisualStyleBackColor = true;
            // 
            // bt_edit_category
            // 
            this.bt_edit_category.Location = new System.Drawing.Point(333, 207);
            this.bt_edit_category.Name = "bt_edit_category";
            this.bt_edit_category.Size = new System.Drawing.Size(135, 34);
            this.bt_edit_category.TabIndex = 11;
            this.bt_edit_category.Text = "Sửa thể loại";
            this.bt_edit_category.UseVisualStyleBackColor = true;
            // 
            // bt_add_category
            // 
            this.bt_add_category.Location = new System.Drawing.Point(192, 209);
            this.bt_add_category.Name = "bt_add_category";
            this.bt_add_category.Size = new System.Drawing.Size(135, 34);
            this.bt_add_category.TabIndex = 10;
            this.bt_add_category.Text = "Thêm thể loại";
            this.bt_add_category.UseVisualStyleBackColor = true;
            // 
            // FrmQLTL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_del_category);
            this.Controls.Add(this.bt_edit_category);
            this.Controls.Add(this.bt_add_category);
            this.Name = "FrmQLTL";
            this.Text = "QLTL";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_del_category;
        private System.Windows.Forms.Button bt_edit_category;
        private System.Windows.Forms.Button bt_add_category;
    }
}