namespace quan_ly_cua_hang_sach
{
    partial class FrmQLTG
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
            this.bt_del_author = new System.Windows.Forms.Button();
            this.bt_edit_author = new System.Windows.Forms.Button();
            this.bt_add_author = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_del_author
            // 
            this.bt_del_author.Location = new System.Drawing.Point(474, 212);
            this.bt_del_author.Name = "bt_del_author";
            this.bt_del_author.Size = new System.Drawing.Size(135, 34);
            this.bt_del_author.TabIndex = 15;
            this.bt_del_author.Text = "Xóa tác giả";
            this.bt_del_author.UseVisualStyleBackColor = true;
            // 
            // bt_edit_author
            // 
            this.bt_edit_author.Location = new System.Drawing.Point(333, 205);
            this.bt_edit_author.Name = "bt_edit_author";
            this.bt_edit_author.Size = new System.Drawing.Size(135, 34);
            this.bt_edit_author.TabIndex = 14;
            this.bt_edit_author.Text = "Sửa tác giả";
            this.bt_edit_author.UseVisualStyleBackColor = true;
            // 
            // bt_add_author
            // 
            this.bt_add_author.Location = new System.Drawing.Point(192, 205);
            this.bt_add_author.Name = "bt_add_author";
            this.bt_add_author.Size = new System.Drawing.Size(135, 34);
            this.bt_add_author.TabIndex = 13;
            this.bt_add_author.Text = "Thêm tác giả";
            this.bt_add_author.UseVisualStyleBackColor = true;
            // 
            // FrmQLTG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_del_author);
            this.Controls.Add(this.bt_edit_author);
            this.Controls.Add(this.bt_add_author);
            this.Name = "FrmQLTG";
            this.Text = "QLTG";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_del_author;
        private System.Windows.Forms.Button bt_edit_author;
        private System.Windows.Forms.Button bt_add_author;
    }
}