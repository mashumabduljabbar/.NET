using System;
using System.Data;
using System.Data.SqlClient;

namespace Example
{
    class Program
    {
        static DataTable GetOrderDetails(string fakturKode)
        {
            string connectionString = "Data Source=DESKTOP-O645BQG\\SQLEXPRESS;Initial Catalog=TOKO;User ID=;Password=;";
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT b.NAME as NAMA, b.PRICE, od.QTY, (b.PRICE * od.QTY) as AMOUNT " +
                                   "FROM ORDER_HEADER oh " +
                                   "JOIN ORDER_DETAIL od ON oh.ORD_KODE = od.ORD_KODE " +
                                   "JOIN BARANG b ON od.KODE = b.KODE " +
                                   "WHERE oh.ORD_KODE = @fakturKode";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@fakturKode", fakturKode);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return dataTable;
        }

        static string ConvertDataTableToHtml(DataTable dt)
        {
            string html = "<table border='1'>";
            //add header row
            html += "<tr>";
            foreach (DataColumn column in dt.Columns)
            {
                html += "<th>" + column.ColumnName + "</th>";
            }
            html += "</tr>";
            //add rows
            foreach (DataRow row in dt.Rows)
            {
                html += "<tr>";
                foreach (DataColumn column in dt.Columns)
                {
                    html += "<td>" + row[column.ColumnName].ToString() + "</td>";
                }
                html += "</tr>";
            }
            html += "</table>";
            return html;
        }

        static void Main(string[] args)
        {
            string fakturKode = "ORD1";
            DataTable result = GetOrderDetails(fakturKode);
            string htmlResult = ConvertDataTableToHtml(result);
            Console.WriteLine(htmlResult);
        }
    }

}
