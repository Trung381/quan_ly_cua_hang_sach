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
            this.dgvQLTG = new System.Windows.Forms.DataGridView();
            this.tbNameAuthor = new System.Windows.Forms.TextBox();
            this.tbMaAuthor = new System.Windows.Forms.TextBox();
            this.lbNameAuthor = new System.Windows.Forms.Label();
            this.lbMaAuthor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLTG)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_del_author
            // 
            this.bt_del_author.Location = new System.Drawing.Point(538, 182);
            this.bt_del_author.Name = "bt_del_author";
            this.bt_del_author.Size = new System.Drawing.Size(135, 34);
            this.bt_del_author.TabIndex = 15;
            this.bt_del_author.Text = "Xóa tác giả";
            this.bt_del_author.UseVisualStyleBackColor = true;
            // 
            // bt_edit_author
            // 
            this.bt_edit_author.Location = new System.Drawing.Point(528, 108);
            this.bt_edit_author.Name = "bt_edit_author";
            this.bt_edit_author.Size = new System.Drawing.Size(135, 34);
            this.bt_edit_author.TabIndex = 14;
            this.bt_edit_author.Text = "Sửa tác giả";
            this.bt_edit_author.UseVisualStyleBackColor = true;
            // 
            // bt_add_author
            // 
            this.bt_add_author.Location = new System.Drawing.Point(528, 39);
            this.bt_add_author.Name = "bt_add_author";
            this.bt_add_author.Size = new System.Drawing.Size(135, 34);
            this.bt_add_author.TabIndex = 13;
            this.bt_add_author.Text = "Thêm tác giả";
            this.bt_add_author.UseVisualStyleBackColor = true;
            this.bt_add_author.Click += new System.EventHandler(this.bt_add_author_Click);
            // 
            // dgvQLTG
            // 
            this.dgvQLTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLTG.Location = new System.Drawing.Point(12, 285);
            this.dgvQLTG.Name = "dgvQLTG";
            this.dgvQLTG.RowHeadersWidth = 62;
            this.dgvQLTG.RowTemplate.Height = 28;
            this.dgvQLTG.Size = new System.Drawing.Size(776, 153);
            this.dgvQLTG.TabIndex = 16;
            this.dgvQLTG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVQLTG_CellClick);
            // 
            // tbNameAuthor
            // 
            this.tbNameAuthor.Location = new System.Drawing.Point(166, 98);
            this.tbNameAuthor.Name = "tbNameAuthor";
            this.tbNameAuthor.Size = new System.Drawing.Size(100, 26);
            this.tbNameAuthor.TabIndex = 29;
            // 
            // tbMaAuthor
            // 
            this.tbMaAuthor.Location = new System.Drawing.Point(166, 37);
            this.tbMaAuthor.Name = "tbMaAuthor";
            this.tbMaAuthor.Size = new System.Drawing.Size(100, 26);
            this.tbMaAuthor.TabIndex = 28;
            // 
            // lbNameAuthor
            // 
            this.lbNameAuthor.AutoSize = true;
            this.lbNameAuthor.Location = new System.Drawing.Point(49, 86);
            this.lbNameAuthor.Name = "lbNameAuthor";
            this.lbNameAuthor.Size = new System.Drawing.Size(87, 20);
            this.lbNameAuthor.TabIndex = 27;
            this.lbNameAuthor.Text = "Tên tác giả";
            // 
            // lbMaAuthor
            // 
            this.lbMaAuthor.AutoSize = true;
            this.lbMaAuthor.Location = new System.Drawing.Point(49, 37);
            this.lbMaAuthor.Name = "lbMaAuthor";
            this.lbMaAuthor.Size = new System.Drawing.Size(82, 20);
            this.lbMaAuthor.TabIndex = 26;
            this.lbMaAuthor.Text = "Mã tác giả";
            // 
            // FrmQLTG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbNameAuthor);
            this.Controls.Add(this.tbMaAuthor);
            this.Controls.Add(this.lbNameAuthor);
            this.Controls.Add(this.lbMaAuthor);
            this.Controls.Add(this.dgvQLTG);
            this.Controls.Add(this.bt_del_author);
            this.Controls.Add(this.bt_edit_author);
            this.Controls.Add(this.bt_add_author);
            this.Name = "FrmQLTG";
            this.Text = "QLTG";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLTG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_del_author;
        private System.Windows.Forms.Button bt_edit_author;
        private System.Windows.Forms.Button bt_add_author;
        private System.Windows.Forms.DataGridView dgvQLTG;
        private System.Windows.Forms.TextBox tbNameAuthor;
        private System.Windows.Forms.TextBox tbMaAuthor;
        private System.Windows.Forms.Label lbNameAuthor;
        private System.Windows.Forms.Label lbMaAuthor;
    }
}