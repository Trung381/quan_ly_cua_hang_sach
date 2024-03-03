using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace quan_ly_cua_hang_sach
{
    internal class Helper
    {
        static SqlConnection conn = DBUtils.GetDBConnection();
        public static void UploadData_To_DataGridView(string queryCommand, DataGridView dataGridView_n)
        {
            //khởi tạo dataAdapter lấy dữ liệu truy vấn từ dataBase                                                                         
            SqlDataAdapter adapter = new SqlDataAdapter(queryCommand, conn);

            // khởi tạo 1 bảng "dtSach" trong dataSet () (khởi tại bảng để chứa dữ liệu)
            DataTable table = new DataTable();

            // đổ dữ liệu truy vấn được vào bảng(thêm các dòng trong dataSet sao cho khớp với các hàng trong dataGridView1)
            adapter.Fill(table);

            // hiển thị dữ liệu từ bảng lên giao diện (hiểu thị vào dataGridView) thông qua dataTable
            dataGridView_n.DataSource = table;
            dataGridView_n.ClearSelection();
        }

    }

}
