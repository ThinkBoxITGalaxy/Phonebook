using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Phonebook
{
    class Connz
    {
        public static SqlConnection sqlConnz
        {
            get
            {
                string constring = "Server=DESKTOP-UJBAK2U; user id=phonebook; password=123; database=phonebookdb";
                return new SqlConnection(constring);
            }
        }
    }
}
