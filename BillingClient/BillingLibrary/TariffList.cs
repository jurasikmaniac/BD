using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BillingLibrary
{
    public class TariffList : List<Tariff>
    {
        public static TariffList GetTariffList()
        {
            try
            {
                TariffList TList = new TariffList();

                string _connection = "Data Source=ZIZA-GAME;Initial Catalog=BillingDB;Integrated Security=True";
                using (SqlConnection cn = new SqlConnection(_connection))
                {
                    cn.Open();
                    SqlCommand cm = cn.CreateCommand();
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.CommandText = "GetTariffList";
                    SqlDataReader dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        Tariff T = new Tariff();
                        T.TariffID = (int)dr["TariffID"];
                        T.TariffName = dr["TariffName"].ToString();
                        T.TariffSecCost = (int)dr["TariffSecCost"];
                        T.SimCount = (int)dr["SimCount"];
                        TList.Add(T);
                    }
                    return TList;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
