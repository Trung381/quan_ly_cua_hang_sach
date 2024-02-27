namespace quan_ly_cua_hang_sach
{
    partial class FrmQLKH
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
            this.dGVQLKH = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVQLKH)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVQLKH
            // 
            this.dGVQLKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVQLKH.Location = new System.Drawing.Point(12, 432);
            this.dGVQLKH.Name = "dGVQLKH";
            this.dGVQLKH.RowHeadersWidth = 62;
            this.dGVQLKH.RowTemplate.Height = 28;
            this.dGVQLKH.Size = new System.Drawing.Size(1267, 241);
            this.dGVQLKH.TabIndex = 0;
            // 
            // FrmQLKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 694);
            this.Controls.Add(this.dGVQLKH);
            this.Name = "FrmQLKH";
            this.Text = "FrmQLKH";
            ((System.ComponentModel.ISupportInitialize)(this.dGVQLKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVQLKH;
    }
}