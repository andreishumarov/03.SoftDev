using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Console_database
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con;
            string str;
            string name;
            int age;
            try
            {
                str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""F:\11A - andrei\03 SoftDev\2riSrok\Console_database\Console_database\Database1.mdf"";Integrated Security=True";
                con = new SqlConnection(str);
                con.Open();
                Console.WriteLine("Database connection");
                Console.WriteLine("\n Enter Your Name :");
                name = Console.ReadLine();
                Console.WriteLine("\n Enter Your Age :");
                age = int.Parse(Console.ReadLine());
                string query = "INSERT  INTO  details (user_name, user_age) VALUES('" + name + "'," + age + ")";
                SqlCommand ins = new SqlCommand(query, con);
                ins.ExecuteNonQuery();
                Console.WriteLine("\n Data Stored Into Database");
            }
            catch(SqlException x)
            {
                Console.WriteLine(x.Message);
            }
            Console.ReadLine();
        }
    }
}
