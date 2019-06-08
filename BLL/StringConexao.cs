using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class StringConexao
    {
        public string stringDeConexao = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\moc\Documents\SistemaHotel.mdf; Integrated Security = True; Connect Timeout = 30";

        public string getStringConexao()
        {
            return this.stringDeConexao;
        }
    }
}
