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
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLBH_cur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGLBH_Bill)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQLBH_cur
            // 
            this.dgvQLBH_cur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLBH_cur.Location = new System.Drawing.Point(16, 442);
            this.dgvQLBH_cur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvQLBH_cur.Name = "dgvQLBH_cur";
            this.dgvQLBH_cur.RowHeadersWidth = 62;
            this.dgvQLBH_cur.RowTemplate.Height = 28;
            this.dgvQLBH_cur.Size = new System.Drawing.Size(659, 274);
            this.dgvQLBH_cur.TabIndex = 0;
            // 
            // dgvGLBH_Bill
            // 
            this.dgvGLBH_Bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGLBH_Bill.Location = new System.Drawing.Point(1073, 459);
            this.dgvGLBH_Bill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvGLBH_Bill.Name = "dgvGLBH_Bill";
            this.dgvGLBH_Bill.RowHeadersWidth = 62;
            this.dgvGLBH_Bill.RowTemplate.Height = 28;
            this.dgvGLBH_Bill.Size = new System.Drawing.Size(661, 258);
            this.dgvGLBH_Bill.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(299, 273);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 31);
            this.textBox1.TabIndex = 2;
            // 
            // FrmQLBH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1751, 731);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvGLBH_Bill);
            this.Controls.Add(this.dgvQLBH_cur);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmQLBH";
            this.Text = "FrmQLBH";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLBH_cur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGLBH_Bill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQLBH_cur;
        private System.Windows.Forms.DataGridView dgvGLBH_Bill;
        private System.Windows.Forms.TextBox textBox1;
    }
}