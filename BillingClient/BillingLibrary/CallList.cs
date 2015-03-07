using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;

namespace BillingLibrary
{
    public class CallList : List<Call>
    {
        public static CallList GetCallList(int ID)
        {
            CallList CList = new CallList();
            //try
            //{
            string _connection = "Data Source=ZIZA-GAME;Initial Catalog=BillingDB;Integrated Security=True";
                using (SqlConnection cn = new SqlConnection(_connection))
                {
                    cn.Open();
                    SqlCommand cm = cn.CreateCommand();
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.CommandText = "GetSimCallList";
                    cm.Parameters.AddWithValue("@SimID", ID);
                    SqlDataReader dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        Call C = new Call();
                        C.SimID = ID;
                        C.CallID = (int)dr["CallID"];
                        C.CallLength = (int)dr["CallLength"];
                        C.Inc = (bool)dr["CallInc"];
                        C.CallPrice = (int)dr["CallPrice"];
                        C.PhoneNumber = (int)dr["CallPhoneNumber"];
                        C.CallDateTime = (DateTime)dr["CallDateTime"];
                        C.TariffName = dr["TariffName"].ToString();
                        C.CallPrice = (int)dr["CallPrice"];
                        CList.Add(C);
                    }
                }

            //}
            //catch (Exception)
            //{

            //}
            return CList;
        }
    }
}
