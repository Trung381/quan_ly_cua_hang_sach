namespace quan_ly_cua_hang_sach
{
    partial class FrmQLBH
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
            this.dgvQLBH_cur = new System.Windows.Forms.DataGridView();
            this.dgvGLBH_Bill = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLBH_cur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGLBH_Bill)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQLBH_cur
            // 
            this.dgvQLBH_cur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLBH_cur.Location = new System.Drawing.Point(12, 354);
            this.dgvQLBH_cur.Name = "dgvQLBH_cur";
            this.dgvQLBH_cur.RowHeadersWidth = 62;
            this.dgvQLBH_cur.RowTemplate.Height = 28;
            this.dgvQLBH_cur.Size = new System.Drawing.Size(494, 219);
            this.dgvQLBH_cur.TabIndex = 0;
            // 
            // dgvGLBH_Bill
            // 
            this.dgvGLBH_Bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGLBH_Bill.Location = new System.Drawing.Point(805, 367);
            this.dgvGLBH_Bill.Name = "dgvGLBH_Bill";
            this.dgvGLBH_Bill.RowHeadersWidth = 62;
            this.dgvGLBH_Bill.RowTemplate.Height = 28;
            this.dgvGLBH_Bill.Size = new System.Drawing.Size(496, 206);
            this.dgvGLBH_Bill.TabIndex = 1;
            // 
            // FrmQLBH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 585);
            this.Controls.Add(this.dgvGLBH_Bill);
            this.Controls.Add(this.dgvQLBH_cur);
            this.Name = "FrmQLBH";
            this.Text = "FrmQLBH";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLBH_cur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGLBH_Bill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQLBH_cur;
        private System.Windows.Forms.DataGridView dgvGLBH_Bill;
    }
}