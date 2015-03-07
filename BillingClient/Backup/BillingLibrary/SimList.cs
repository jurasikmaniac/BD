using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BillingLibrary
{
    public class SimList : List<Sim>
    {
        public static SimList GetSimList(int ClientID)
        {
            SimList SList = new SimList();
            try
            {
                string _connection = "Data Source=DARKNESS;Initial Catalog=BillingDB;Integrated Security=True";
                using (SqlConnection cn = new SqlConnection(_connection))
                {
                    cn.Open();
                    SqlCommand cm = cn.CreateCommand();
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.CommandText = "GetClientCurrentSimList";
                    cm.Parameters.AddWithValue("@ClientID", ClientID);
                    SqlDataReader dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        Sim S = new Sim();
                        S.SimID = (int)dr["SimID"];
                        S.SimCode = (int)dr["SimCode"];
                        S.SimPhoneNumber = (int)dr["SimPhoneNumber"];
                        S.SimBill = (int)dr["SimBill"];
                        S.SimClientID = (int)dr["SimClientID"];
                        S.ClientName = dr["ClientName"].ToString();
                        S.ClientPasNumber = (int)dr["ClientPasNumber"];
                        S.ClientEmail = dr["ClientEmail"].ToString();
                        S.TariffName = dr["TariffName"].ToString();
                        S.TariffID = (int)dr["TariffID"];

                        SList.Add(S);
                    }
                }
            }
            catch (Exception)
            {
                
            }
            return SList;
        }
    }
}
