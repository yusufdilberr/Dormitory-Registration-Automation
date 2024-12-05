using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace YurtOgrenciTakip
{
    public class SqlBaglantim
    {
        public SqlConnection baglantim()
        {
            SqlConnection baglan =  new SqlConnection(@"Data Source = DILBER\SQLEXPRESS; Initial Catalog = YurtOgrenciTakip; Integrated Security = True");
            baglan.Open();
            return baglan;
        }
    }
}
