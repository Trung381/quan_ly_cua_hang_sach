using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace quan_ly_cua_hang_sach
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormMenu());
            Application.Run(new FrmQLNXB());





            //Console.WriteLine("Getting Connection ...");
            //SqlConnection conn = DBUtils.GetDBConnection();

            //try
            //{
            //    Console.WriteLine("Openning Connection ...");
            //    conn.Open();
            //    Console.WriteLine("Connection successful!");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Error: " + e.Message);
            //}


            //string sql = "SELECT * from Book";
            //// tao mot doi tuong command
            //SqlCommand cmd = new SqlCommand();
            //// liên hop command voi connection
            //cmd.Connection = conn;
            //cmd.CommandText = sql;

            //using (DbDataReader reader = cmd.ExecuteReader())
            //{
            //    if (reader.HasRows)
            //    {

            //        while (reader.Read())
            //        {

            //            //GetOrdinal("ten cot") de xem cot do co index nao
            //            // GetString(indexcot) lay noi dung cua cot theo tung hang

            //            //// Cột Emp_No có index = 1.
            //            int ID_Book = reader.GetInt32(0);
            //            String Ma_Sach = reader.GetString(1);
            //            String name = reader.GetString(2);
            //            int amount = reader.GetInt32(3);
            //            int year = reader.GetInt32(4);
            //            int status = reader.GetInt32(5);
            //            int quantity = reader.GetInt32(6);
            //            int ID_NXB = reader.GetInt32(7);
            //            Console.WriteLine("--------------------");
            //            //Console.WriteLine("ID_Book : " + reader.GetString(0));
            //            //Console.WriteLine("ID_Book : " + reader.GetInt32(0).ToString());
            //            Console.WriteLine("ID_Book : " + ID_Book.ToString());
            //            Console.WriteLine("Ma_Sach : " + Ma_Sach);
            //            Console.WriteLine("name : " + name);
            //            Console.WriteLine("amount : " + amount.ToString());
            //            Console.WriteLine("year : " + year.ToString());
            //            Console.WriteLine("status : " + status.ToString());
            //            Console.WriteLine("quantity : " + quantity.ToString());
            //            Console.WriteLine("ID_NXB : " + ID_NXB.ToString());
            //        }
            //        Console.Read();
            //    }
            //}


        }
    }
}
