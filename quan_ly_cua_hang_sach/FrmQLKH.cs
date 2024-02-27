using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace quan_ly_cua_hang_sach
{
    public partial class FrmQLKH : Form
    {
        public FrmQLKH()
        {
            InitializeComponent();


            String sqlKH = "Select * from KhachHang";
            Helper.UploadData_To_DataGridView(sqlKH, dGVQLKH);
        }
    }
}
