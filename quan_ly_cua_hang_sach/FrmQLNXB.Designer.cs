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
            this.dGVQLNXB = new System.Windows.Forms.DataGridView();
            this.lbMaNXB = new System.Windows.Forms.Label();
            this.lbNameNXB = new System.Windows.Forms.Label();
            this.tbMaNXB = new System.Windows.Forms.TextBox();
            this.tbNameNXB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVQLNXB)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_del_nxb
            // 
            this.bt_del_nxb.Location = new System.Drawing.Point(569, 194);
            this.bt_del_nxb.Name = "bt_del_nxb";
            this.bt_del_nxb.Size = new System.Drawing.Size(135, 34);
            this.bt_del_nxb.TabIndex = 18;
            this.bt_del_nxb.Text = "Xóa nxb";
            this.bt_del_nxb.UseVisualStyleBackColor = true;
            // 
            // bt_edit_nxb
            // 
            this.bt_edit_nxb.Location = new System.Drawing.Point(569, 112);
            this.bt_edit_nxb.Name = "bt_edit_nxb";
            this.bt_edit_nxb.Size = new System.Drawing.Size(135, 34);
            this.bt_edit_nxb.TabIndex = 17;
            this.bt_edit_nxb.Text = "Sửa nxb";
            this.bt_edit_nxb.UseVisualStyleBackColor = true;
            // 
            // bt_add_nxb
            // 
            this.bt_add_nxb.Location = new System.Drawing.Point(569, 44);
            this.bt_add_nxb.Name = "bt_add_nxb";
            this.bt_add_nxb.Size = new System.Drawing.Size(135, 34);
            this.bt_add_nxb.TabIndex = 16;
            this.bt_add_nxb.Text = "Thêm nxb";
            this.bt_add_nxb.UseVisualStyleBackColor = true;
            this.bt_add_nxb.Click += new System.EventHandler(this.bt_add_nxb_Click);
            // 
            // dGVQLNXB
            // 
            this.dGVQLNXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVQLNXB.Location = new System.Drawing.Point(12, 321);
            this.dGVQLNXB.Name = "dGVQLNXB";
            this.dGVQLNXB.RowHeadersWidth = 62;
            this.dGVQLNXB.RowTemplate.Height = 28;
            this.dGVQLNXB.Size = new System.Drawing.Size(1134, 238);
            this.dGVQLNXB.TabIndex = 19;
            this.dGVQLNXB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVQLNXB_CellClick);
            // 
            // lbMaNXB
            // 
            this.lbMaNXB.AutoSize = true;
            this.lbMaNXB.Location = new System.Drawing.Point(34, 65);
            this.lbMaNXB.Name = "lbMaNXB";
            this.lbMaNXB.Size = new System.Drawing.Size(68, 20);
            this.lbMaNXB.TabIndex = 20;
            this.lbMaNXB.Text = "Mã NXB";
            // 
            // lbNameNXB
            // 
            this.lbNameNXB.AutoSize = true;
            this.lbNameNXB.Location = new System.Drawing.Point(34, 135);
            this.lbNameNXB.Name = "lbNameNXB";
            this.lbNameNXB.Size = new System.Drawing.Size(73, 20);
            this.lbNameNXB.TabIndex = 21;
            this.lbNameNXB.Text = "Tên NXB";
            // 
            // tbMaNXB
            // 
            this.tbMaNXB.Location = new System.Drawing.Point(151, 65);
            this.tbMaNXB.Name = "tbMaNXB";
            this.tbMaNXB.Size = new System.Drawing.Size(100, 26);
            this.tbMaNXB.TabIndex = 23;
            // 
            // tbNameNXB
            // 
            this.tbNameNXB.Location = new System.Drawing.Point(151, 129);
            this.tbNameNXB.Name = "tbNameNXB";
            this.tbNameNXB.Size = new System.Drawing.Size(100, 26);
            this.tbNameNXB.TabIndex = 25;
            // 
            // FrmQLNXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 571);
            this.Controls.Add(this.tbNameNXB);
            this.Controls.Add(this.tbMaNXB);
            this.Controls.Add(this.lbNameNXB);
            this.Controls.Add(this.lbMaNXB);
            this.Controls.Add(this.dGVQLNXB);
            this.Controls.Add(this.bt_del_nxb);
            this.Controls.Add(this.bt_edit_nxb);
            this.Controls.Add(this.bt_add_nxb);
            this.Name = "FrmQLNXB";
            this.Text = "QLNXB";
            ((System.ComponentModel.ISupportInitialize)(this.dGVQLNXB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_del_nxb;
        private System.Windows.Forms.Button bt_edit_nxb;
        private System.Windows.Forms.Button bt_add_nxb;
        private System.Windows.Forms.DataGridView dGVQLNXB;
        private System.Windows.Forms.Label lbMaNXB;
        private System.Windows.Forms.Label lbNameNXB;
        private System.Windows.Forms.TextBox tbMaNXB;
        private System.Windows.Forms.TextBox tbNameNXB;
    }
}