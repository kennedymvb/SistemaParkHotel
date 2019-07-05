using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StringConexao
    {
        private static string stringDeConexao = null;

        public static string GetStringConexao()
        {
            if (stringDeConexao == null)
            {
                stringDeConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\moc\Documents\parkHotel.mdf;Integrated Security=True;Connect Timeout=30";
                        //ConfigurationManager.ConnectionStrings["SqlConnectionServer"].ConnectionString;
            }
            return stringDeConexao;
        }
    }
}
