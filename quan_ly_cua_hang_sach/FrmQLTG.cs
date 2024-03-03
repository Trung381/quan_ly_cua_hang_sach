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
    public partial class FrmQLTG : Form
    {
        SqlConnection conn = DBUtils.GetDBConnection();
        public FrmQLTG()
        {
            InitializeComponent();

            String sqlTG = "Select * from Author";
            Helper.UploadData_To_DataGridView(sqlTG, dGVQLTG);
        }

        private void delete_data_control_TG()
        {
            tbMaAuthor.Clear();
            tbNameAuthor.Clear();


            dGVQLTG.ClearSelection();
        }

        private void dGVQLTG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            // bản ko trống
            if (index != -1)
            {
                tbMaAuthor.Text = dGVQLTG.Rows[index].Cells[0].Value.ToString().Trim();
                tbNameAuthor.Text = dGVQLTG.Rows[index].Cells[1].Value.ToString();
            }
            else
            {
                delete_data_control_TG();
            }
        }

        //Kiểm tra dữ liệu trong control (trogn quản lý kho sách)
        private bool checkData_Control_ks()
        {
            try
            {
                //if (tbMaNXB.Text.Trim() == "" || tbNameNXB.Text.Trim() == "")
                //{
                //    MessageBox.Show("Bạn chưa nhập đủ thông tin !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return false;
                //}
                if (tbNameAuthor.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (tbMaAuthor.Text.Trim().Length > 5)
                {
                    MessageBox.Show("Mã NXB chỉ bao gồm 5 kí tự!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (tbNameAuthor.Text.Trim().Length > 50)
                {
                    MessageBox.Show("Tên NXB chỉ gồm 50 kí tự!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void bt_add_author_Click(object sender, EventArgs e)
        {
            if (checkData_Control_ks())
            {
                //Kiểm tra mã sách có bị trùng hay không
                string sqlquery_command = "select* from Author where (Ma_Author = '" + tbMaAuthor.Text + "')";

                if (check_for_duplicate_information(sqlquery_command) == false)     //nếu mã sách chưa có thì thực hiện thêm dữ liệu sách mới vào CSDL
                {
                    //thêm dữ liệu
                    conn.Open();
                    string data_insert = "insert into NXB values('" + tbNameAuthor.Text.Trim() + "')";
                    //Console.WriteLine(data_insert);
                    SqlCommand cmd = new SqlCommand(data_insert, conn);
                    cmd.ExecuteNonQuery();

                    Helper.UploadData_To_DataGridView("select * from NXB", dGVQLTG);
                    delete_data_control_TG();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Mã NXB đã tồn tại!!!\nVui lòng chọn mã sách khác", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
