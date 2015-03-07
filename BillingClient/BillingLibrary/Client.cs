using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;

namespace BillingLibrary
{
    public class Client
    {
        private int _ClientID;
        private string _ClientName;
        private int _ClientPasNumber;
        private string _ClientEmail;

        public int ClientID
        {
            get
            {
                return _ClientID;
            }
            set
            {
                _ClientID = value;
            }
        }
        public string ClientName
        {
            get
            {
                return _ClientName;
            }
            set
            {
                _ClientName = value;
            }
        }
        public int ClientPasNumber
        {
            get
            {
                return _ClientPasNumber;
            }
            set
            {
                _ClientPasNumber = value;
            }
        }
        public string ClientEmail
        {
            get
            {
                return _ClientEmail;
            }
            set
            {
                _ClientEmail = value;
            }
        }

        public void InsertClient()
        {
            try
            {
                using (TransactionScope sc = new TransactionScope())
                {
                    string _connection = "Data Source=ZIZA-GAME;Initial Catalog=BillingDB;Integrated Security=True";
                    using (SqlConnection cn = new SqlConnection(_connection))
                    {
                        cn.Open();
                        SqlCommand cm = cn.CreateCommand();
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.CommandText = "InsertClient";
                        cm.Parameters.AddWithValue("@ClientName", _ClientName);
                        cm.Parameters.AddWithValue("@ClientPasNumber", _ClientPasNumber);
                        cm.Parameters.AddWithValue("@ClientEmail", _ClientEmail);
                        cm.ExecuteNonQuery();
                    }
                    sc.Complete();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteClient()
        {
            try
            {
                using (TransactionScope sc = new TransactionScope())
                {
                    string _connection = "Data Source=ZIZA-GAME;Initial Catalog=BillingDB;Integrated Security=True";
                    using (SqlConnection cn = new SqlConnection(_connection))
                    {
                        cn.Open();
                        SqlCommand cm = cn.CreateCommand();
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.CommandText = "DeleteClient";
                        cm.Parameters.AddWithValue("@ClientID", _ClientID);
                        cm.ExecuteNonQuery();
                    }
                    sc.Complete();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UpdateClient()
        {
            try
            {
                using (TransactionScope sc = new TransactionScope())
                {
                    string _connection = "Data Source=ZIZA-GAME;Initial Catalog=BillingDB;Integrated Security=True";
                    using (SqlConnection cn = new SqlConnection(_connection))
                    {
                        cn.Open();
                        SqlCommand cm = cn.CreateCommand();
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.CommandText = "UpdateClient";
                        cm.Parameters.AddWithValue("@ClientID", _ClientID);
                        cm.Parameters.AddWithValue("@ClientName", _ClientName);
                        cm.Parameters.AddWithValue("@ClientPasNumber", _ClientPasNumber);
                        cm.Parameters.AddWithValue("@ClientEmail", _ClientEmail);
                        cm.ExecuteNonQuery();
                    }
                    sc.Complete();
                }
            }
            catch (Exception)
            {

            }
        }

        public static Client GetClient(int ID)
        {
            Client C = new Client();
            try
            {
                string _connection = "Data Source=ZIZA-GAME;Initial Catalog=BillingDB;Integrated Security=True";
                using (SqlConnection cn = new SqlConnection(_connection))
                {
                    cn.Open();
                    SqlCommand cm = cn.CreateCommand();
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.CommandText = "GetClient";
                    cm.Parameters.AddWithValue("@ClientID", ID);
                    SqlDataReader dr = cm.ExecuteReader();
                    if (dr.Read())
                    {
                        C.ClientID = ID;
                        C.ClientName = dr["ClientName"].ToString();
                        C.ClientPasNumber = (int)dr["ClientPasNumber"];
                        C.ClientEmail = dr["ClientEmail"].ToString();
                    }
                }
            }
            catch (Exception)
            {

            }
            return C;
        }
    }
}
