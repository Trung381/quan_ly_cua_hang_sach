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
            this.dGVQLBH_cur = new System.Windows.Forms.DataGridView();
            this.dGVGLBH_Bill = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVQLBH_cur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVGLBH_Bill)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVQLBH_cur
            // 
            this.dGVQLBH_cur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVQLBH_cur.Location = new System.Drawing.Point(12, 354);
            this.dGVQLBH_cur.Name = "dGVQLBH_cur";
            this.dGVQLBH_cur.RowHeadersWidth = 62;
            this.dGVQLBH_cur.RowTemplate.Height = 28;
            this.dGVQLBH_cur.Size = new System.Drawing.Size(494, 219);
            this.dGVQLBH_cur.TabIndex = 0;
            // 
            // dGVGLBH_Bill
            // 
            this.dGVGLBH_Bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVGLBH_Bill.Location = new System.Drawing.Point(805, 367);
            this.dGVGLBH_Bill.Name = "dGVGLBH_Bill";
            this.dGVGLBH_Bill.RowHeadersWidth = 62;
            this.dGVGLBH_Bill.RowTemplate.Height = 28;
            this.dGVGLBH_Bill.Size = new System.Drawing.Size(496, 206);
            this.dGVGLBH_Bill.TabIndex = 1;
            // 
            // FrmQLBH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 585);
            this.Controls.Add(this.dGVGLBH_Bill);
            this.Controls.Add(this.dGVQLBH_cur);
            this.Name = "FrmQLBH";
            this.Text = "FrmQLBH";
            ((System.ComponentModel.ISupportInitialize)(this.dGVQLBH_cur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVGLBH_Bill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVQLBH_cur;
        private System.Windows.Forms.DataGridView dGVGLBH_Bill;
    }
}