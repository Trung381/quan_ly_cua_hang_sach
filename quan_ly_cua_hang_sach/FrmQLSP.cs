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
        static SqlConnection conn = DBUtils.GetDBConnection();
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

        //xóa dữ liệu trong control (trong quản lý sản phẩm)
        private void delete_data_control_ks()
        {
            tbMa.Clear();
            tbName.Clear();
            tbYear.Clear();
            tbSL.Clear();
            tbAmount.Clear();
            cbbCategory.Text = "";
            cbbAuthor.Text = "";
            cbbNXB.Text = "";


            dGVQLSP.ClearSelection();
        }

        private void dGVQLSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            // bản ko trống
            if (index != -1)
            {
                tbMa.Text = dGVQLSP.Rows[index].Cells[0].Value.ToString().Trim();
                tbName.Text = dGVQLSP.Rows[index].Cells[1].Value.ToString();
                tbYear.Text = dGVQLSP.Rows[index].Cells[2].Value.ToString();
                tbSL.Text = dGVQLSP.Rows[index].Cells[3].Value.ToString();
                tbAmount.Text = dGVQLSP.Rows[index].Cells[4].Value.ToString();
                cbbCategory.Text = dGVQLSP.Rows[index].Cells[5].Value.ToString();
                cbbNXB.Text = dGVQLSP.Rows[index].Cells[6].Value.ToString();
            }
            else
            {
                delete_data_control_ks();
            }
        }

        //Kiểm tra dữ liệu trong control (trogn quản lý kho sách)
        private bool checkData_Control_ks()
        {
            try
            {
                if (tbMa.Text.Trim() == "" || tbName.Text.Trim() == "" || tbSL.Text.Trim() == "" || tbYear.Text.Trim() == "" || cbbAuthor.Text.Trim() == "" || tbAmount.Text.Trim() == "" || cbbCategory.Text.Trim() == "" || cbbNXB.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin của sách!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (tbMa.Text.Trim().Length > 5)
                {
                    MessageBox.Show("Mã sách chỉ bao gồm 5 kí tự!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (tbName.Text.Trim().Length > 150)
                {
                    MessageBox.Show("Tên sách chỉ gồm 150 kí tự!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (cbbAuthor.Text.Trim().Length > 50)
                {
                    MessageBox.Show("Tên tác giả chỉ bao gồm 50 kí tự!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (cbbNXB.Text.Trim().Length > 100)
                {
                    MessageBox.Show("Tên nhà xuất bản chỉ bao gồm 100 kí tự!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (Convert.ToSingle(tbAmount.Text) <= 0)
                {
                    MessageBox.Show("Giá bán sách phải >0 !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (Convert.ToInt32(tbSL.Text) < 0)
                {
                    MessageBox.Show("Số lượng sách phải >=0 !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if(Convert.ToInt32(tbYear.Text) > 2024)
                {
                    MessageBox.Show("DDm sachs toiws tuwf tuowng lai af !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (cbbCategory.Text.Trim().Length > 50)
                {
                    MessageBox.Show("Tên thể loại chỉ bao gồm 50 kí tự!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("-Số lượng sản phẩn phải là số nguyên >=0\n-Giá bán phải có kiểu float và >0!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //kiểm tra dữ liệu có tồn tại hay không(vd: mã sách, mã hóa đơn,...)
        private bool check_for_duplicate_information(string sqlquery_command)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlquery_command, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }


        //thêm sách
        //private void btAddSach_Click(object sender, EventArgs e)
        //{
        //    if (checkData_Control_ks())
        //    {
        //        //Kiểm tra mã sách có bị trùng hay không
        //        string sqlquery_command = "select* from Sach where (maSach = '" + tbMa.Text + "')";

        //        if (check_for_duplicate_information(sqlquery_command) == false)     //nếu mã sách chưa có thì thực hiện thêm dữ liệu sách mới vào CSDL
        //        {
        //            //thêm dữ liệu
        //            conn.Open();
        //            string giaBan = tbAmount.Text.Trim().Replace(",", ".");
        //            string data_insert = "insert into Sach values('" + tbMa.Text.Trim() + "', N'" + tbName.Text.Trim() + "', N'" + tbSL.Text.Trim() +
        //                                                          "', N'" + tbYear.Text.Trim() + "', N'" + tb.Text.Trim() + "'," + giaBan +
        //                                                          ", " + txt_ks_soLuong.Text.Trim() + ")";
        //            SqlCommand cmd = new SqlCommand(data_insert, conn);
        //            cmd.ExecuteNonQuery();

        //            UploadData_To_DataGridView("select * from Sach", dataGridView1);
        //            delete_data_control_ks();
        //            conn.Close();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Mã sách đã tồn tại!!!\nVui lòng chọn mã sách khác", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //}
    }
}
