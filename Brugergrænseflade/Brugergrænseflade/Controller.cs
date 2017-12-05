using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Brugergrænseflade
{
    class Controller
    {
        string strconnGlobal;
        SqlConnection connGlobal;
        Connection database = new Connection();

        public void Kald (string strconn, SqlConnection conn )
        {
            database.SqlAdgang(strconn, conn);
            strconnGlobal = strconn;
            connGlobal = conn;
        }
    }
}
