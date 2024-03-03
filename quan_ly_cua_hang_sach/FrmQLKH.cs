using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace quan_ly_cua_hang_sach
{
    public partial class FrmQLKH : Form
    {
        public FrmQLKH()
        {
            InitializeComponent();


            String sqlKH = "Select * from KhachHang";
            Helper.UploadData_To_DataGridView(sqlKH, dgvQLKH);
        }

        //xóa dữ liệu trong control (trong quản lý KH)
        private void delete_data_control_kh()
        {
            tbMaKH.Clear();
            tbNameKH.Clear();
            tbSDT.Clear();
            tbNgaySinh.Clear();

            dgvQLKH.ClearSelection();
        }


        private void dGVQLKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            // bản ko trống
            if (index != -1)
            {
                tbMaKH.Text = dgvQLKH.Rows[index].Cells[0].Value.ToString().Trim();
                tbNameKH.Text = dgvQLKH.Rows[index].Cells[1].Value.ToString();
                tbSDT.Text = dgvQLKH.Rows[index].Cells[2].Value.ToString();
                tbNgaySinh.Text = dgvQLKH.Rows[index].Cells[3].Value.ToString();
            }
            else
            {
                delete_data_control_kh();
            }
        }
    }
}
