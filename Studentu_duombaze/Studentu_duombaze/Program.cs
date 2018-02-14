using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentu_duombaze
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string conectio_string = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\drentelis\Documents\Visual Studio 2015\Projects\Studentu_duombaze\Studentu_duombaze\Studentu_duombaze.mdf; Integrated Security = True";
                SqlConnection sql = new SqlConnection(conectio_string);
                sql.Open();
                Console.WriteLine("Prisijungiau");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Neprisijungiau");
            }
            Console.ReadKey();
        }
    }
}
