using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LKS_Trip
{
    class Utils
    {
        public static string conn = @"Data Source=desktop-00eposj;Initial Catalog=LKS_Trip;Integrated Security=True";
    }

    class Model
    {
        public static int id { set; get; }
        public static string name { set; get; }
        public static int jobId { set; get; }

    }

    class Encrypt
    {
        public static string enc(string data)
        {
            using(SHA256Managed managed = new SHA256Managed())
            {
                return Convert.ToBase64String(managed.ComputeHash(Encoding.UTF8.GetBytes(data)));
            }
        }

        public static byte[] encode(Image image)
        {
            ImageConverter converter = new ImageConverter();
            byte[] b = (byte[])converter.ConvertTo(image, typeof(byte[]));
            return b;
        }
    }

    class Command
    {
        public static DataTable getdata(string com)
        {
            DataTable data = new DataTable();
            SqlConnection connection = new SqlConnection(Utils.conn);
            SqlDataAdapter adapter = new SqlDataAdapter(com, connection);
            adapter.Fill(data);
            return data;
        }

        public static void exec(string com)
        {
            SqlConnection connection = new SqlConnection(Utils.conn);
            SqlCommand command = new SqlCommand(com, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
