namespace quan_ly_cua_hang_sach
{
    partial class FrmQLNXB
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
            this.bt_del_nxb = new System.Windows.Forms.Button();
            this.bt_edit_nxb = new System.Windows.Forms.Button();
            this.bt_add_nxb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_del_nxb
            // 
            this.bt_del_nxb.Location = new System.Drawing.Point(474, 211);
            this.bt_del_nxb.Name = "bt_del_nxb";
            this.bt_del_nxb.Size = new System.Drawing.Size(135, 34);
            this.bt_del_nxb.TabIndex = 18;
            this.bt_del_nxb.Text = "Xóa nxb";
            this.bt_del_nxb.UseVisualStyleBackColor = true;
            // 
            // bt_edit_nxb
            // 
            this.bt_edit_nxb.Location = new System.Drawing.Point(333, 207);
            this.bt_edit_nxb.Name = "bt_edit_nxb";
            this.bt_edit_nxb.Size = new System.Drawing.Size(135, 34);
            this.bt_edit_nxb.TabIndex = 17;
            this.bt_edit_nxb.Text = "Sửa nxb";
            this.bt_edit_nxb.UseVisualStyleBackColor = true;
            // 
            // bt_add_nxb
            // 
            this.bt_add_nxb.Location = new System.Drawing.Point(192, 205);
            this.bt_add_nxb.Name = "bt_add_nxb";
            this.bt_add_nxb.Size = new System.Drawing.Size(135, 34);
            this.bt_add_nxb.TabIndex = 16;
            this.bt_add_nxb.Text = "Thêm nxb";
            this.bt_add_nxb.UseVisualStyleBackColor = true;
            // 
            // FrmQLNXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_del_nxb);
            this.Controls.Add(this.bt_edit_nxb);
            this.Controls.Add(this.bt_add_nxb);
            this.Name = "FrmQLNXB";
            this.Text = "QLNXB";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_del_nxb;
        private System.Windows.Forms.Button bt_edit_nxb;
        private System.Windows.Forms.Button bt_add_nxb;
    }
}