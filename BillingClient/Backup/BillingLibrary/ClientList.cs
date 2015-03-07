using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BillingLibrary
{
    public class ClientList : List<Client>
    {
        public static ClientList GetClientList()
        {
            ClientList CList = new ClientList();
            try
            {
                string _connection = "Data Source=DARKNESS;Initial Catalog=BillingDB;Integrated Security=True";
                using (SqlConnection cn = new SqlConnection(_connection))
                {
                    cn.Open();
                    SqlCommand cm = cn.CreateCommand();
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.CommandText = "GetClientList";
                    SqlDataReader dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        Client C = new Client();
                        C.ClientID = (int)dr["ClientID"];
                        C.ClientName = dr["ClientName"].ToString();
                        C.ClientPasNumber = (int)dr["ClientPasNumber"];
                        C.ClientEmail = dr["ClientEmail"].ToString();
                        CList.Add(C);
                    }
                }
                
            }
            catch (Exception)
            {
                
            }
            return CList;
        }
    }
}
