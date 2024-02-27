using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace quan_ly_cua_hang_sach
{
    public partial class FrmQLSP : Form
    {
        public FrmQLSP()
        {
            InitializeComponent();

            String sqlBook = "Select * from Book";
            Helper.UploadData_To_DataGridView(sqlBook, dGVQLSP);
        }

        private void btQLTL_Click(object sender, EventArgs e)
        {
            //Application.Run(new FrmQLTG());
            new FrmQLTL().ShowDialog();
        }

        private void btQLTG_Click(object sender, EventArgs e)
        {
            new FrmQLTG().ShowDialog();
        }

        private void btQLNXB_Click(object sender, EventArgs e)
        {
            new FrmQLNXB().ShowDialog();
        }

        //private void button2_Click(object sender, EventArgs e)
        //{

        //}

        //private void button1_Click(object sender, EventArgs e)
        //{

        //}

        //private void button8_Click(object sender, EventArgs e)
        //{

        //}

        //private void lbAuthor_Click(object sender, EventArgs e)
        //{

        //}
    }
}
