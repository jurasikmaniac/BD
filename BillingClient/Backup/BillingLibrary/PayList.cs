using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace BillingLibrary
{
    class PayList : List<Pay>
    {
        public static PayList GetSimPayList(int SimID)
        {
            try
            {
                PayList PList = new PayList();

                string _connection = "Data Source=DARKNESS;Initial Catalog=BillingDB;Integrated Security=True";
                using (SqlConnection cn = new SqlConnection(_connection))
                {
                    cn.Open();
                    SqlCommand cm = cn.CreateCommand();
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.CommandText = "GetSimPayList";
                    cm.Parameters.AddWithValue("@SimID", SimID);
                    SqlDataReader dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        Pay P = new Pay();
                        P.PayID = (int)dr["PayID"];
                        P.PayMoney = (int)dr["PayMoney"];
                        P.PayDateTime = (DateTime)dr["PayDateTime"];
                        PList.Add(P);
                    }
                    return PList;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

