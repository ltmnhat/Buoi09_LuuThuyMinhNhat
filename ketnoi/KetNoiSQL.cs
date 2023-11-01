using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
namespace ketnoi
{
    public class KetNoiSQL
    {
        public SqlConnection connect;
        public KetNoiSQL()
        {
            connect = new SqlConnection("Data Source=A209PC02;Initial Catalog=QL_KHOA; Integrated Security=True");
        }
        public KetNoiSQL(string strcn)
        {
            connect = new SqlConnection(strcn);
        }
    }
}
