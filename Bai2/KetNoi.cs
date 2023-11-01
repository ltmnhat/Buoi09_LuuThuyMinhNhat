using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
namespace Bai2
{
    class KetNoi
    {
          public SqlConnection connect;
        public KetNoi()
        {
            connect = new SqlConnection("Data Source=A209PC02;Initial Catalog=QL_KHOA; Integrated Security=True");
        }
        public KetNoi(string strcn)
        {
            connect = new SqlConnection(strcn);
        }
    }
}
