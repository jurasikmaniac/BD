using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;

namespace BillingLibrary
{
    public class Sim
    {
        private int _SimID;
        private int _SimCode;
        private int _SimPhoneNumber;
        private int _SimBill;
        private int _SimClientID;
        private string _ClientName;
        private int _ClientPasNumber;
        private string _ClientEmail;
        private string _TariffName;
        private int _tariffID;

        public int SimID
        {
            get
            {
                return _SimID;
            }
            set
            {
                _SimID = value;
            }
        }
        public int SimCode
        {
            get
            {
                return _SimCode;
            }
            set
            {
                _SimCode = value;
            }
        }
        public int SimPhoneNumber
        {
            get
            {
                return _SimPhoneNumber;
            }
            set
            {
                _SimPhoneNumber = value;
            }
        }
        public int SimBill
        {
            get
            {
                return _SimBill;
            }
            set
            {
                _SimBill = value;
            }
        }
        public int SimClientID
        {
            get
            {
                return _SimClientID;
            }
            set
            {
                _SimClientID = value;
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
        public string TariffName
        {
            get
            {
                return _TariffName;
            }
            set
            {
                _TariffName = value;
            }
        }
        public int TariffID
        {
            get
            {
                return _tariffID;
            }
            set
            {
                _tariffID = value;
            }
        }

        public void InsertSim()
        {
            try
            {
                using (TransactionScope sc = new TransactionScope())
                {
                    string _connection = "Data Source=DARKNESS;Initial Catalog=BillingDB;Integrated Security=True";
                    using (SqlConnection cn = new SqlConnection(_connection))
                    {
                        cn.Open();
                        SqlCommand cm = cn.CreateCommand();
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.CommandText = "InsertSim";
                        cm.Parameters.AddWithValue("@SimCode", _SimCode);
                        cm.Parameters.AddWithValue("@SimPhoneNumber", _SimPhoneNumber);
                        cm.Parameters.AddWithValue("@SimClientID", _SimClientID);
                        cm.Parameters.AddWithValue("@SimBill", _SimBill);
                        cm.Parameters.AddWithValue("@TariffID", _tariffID);
                        cm.ExecuteNonQuery();
                    }
                    sc.Complete();
                }
            }
            catch (Exception)
            {
            }
        }

        public void DeleteSim()
        {
            try
            {
                using (TransactionScope sc = new TransactionScope())
                {
                    string _connection = "Data Source=DARKNESS;Initial Catalog=BillingDB;Integrated Security=True";
                    using (SqlConnection cn = new SqlConnection(_connection))
                    {
                        cn.Open();
                        SqlCommand cm = cn.CreateCommand();
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.CommandText = "DeleteSim";
                        cm.Parameters.AddWithValue("@SimID", _SimID);
                        cm.ExecuteNonQuery();
                    }
                    sc.Complete();
                }
            }
            catch (Exception)
            {
            }
        }

        public void UpdateSim()
        {
            try
            {
                using (TransactionScope sc = new TransactionScope())
                {
                    string _connection = "Data Source=DARKNESS;Initial Catalog=BillingDB;Integrated Security=True";
                    using (SqlConnection cn = new SqlConnection(_connection))
                    {
                        cn.Open();
                        SqlCommand cm = cn.CreateCommand();
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.CommandText = "UpdateSim";
                        cm.Parameters.AddWithValue("@SimID", _SimID);
                        cm.Parameters.AddWithValue("@TariffID", _tariffID);
                        cm.Parameters.AddWithValue("@SimClientID", _SimClientID);
                        cm.ExecuteNonQuery();
                    }
                    sc.Complete();
                }
            }
            catch (Exception)
            {
            }
        }

        public void MakeCall(int CallLength, bool inc, int CallPhoneNumber, DateTime CallDateTime)
        {
            try
            {
                using (TransactionScope sc = new TransactionScope())
                {
                    string _connection = "Data Source=DARKNESS;Initial Catalog=BillingDB;Integrated Security=True";
                    using (SqlConnection cn = new SqlConnection(_connection))
                    {
                        cn.Open();
                        SqlCommand cm = cn.CreateCommand();
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.CommandText = "MakeCall";
                        cm.Parameters.AddWithValue("@CallLength", CallLength);
                        cm.Parameters.AddWithValue("@CallInc", inc);
                        cm.Parameters.AddWithValue("@CallPhoneNumber", CallPhoneNumber);
                        cm.Parameters.AddWithValue("@CallDateTime", CallDateTime);
                        cm.Parameters.AddWithValue("@SimID", _SimID);
                        cm.ExecuteNonQuery();
                    }
                    sc.Complete();
                }
            }
            catch (Exception)
            {
            }

        }

        public void MakePay(int PhoneNumber, DateTime PayDateTime, int PayMoney)
        {
            try
            {
                using (TransactionScope sc = new TransactionScope())
                {
                    string _connection = "Data Source=DARKNESS;Initial Catalog=BillingDB;Integrated Security=True";
                    using (SqlConnection cn = new SqlConnection(_connection))
                    {
                        cn.Open();
                        SqlCommand cm = cn.CreateCommand();
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.CommandText = "MakePay";
                        cm.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                        cm.Parameters.AddWithValue("@PayDateTime", PayDateTime);
                        cm.Parameters.AddWithValue("@PayMoney", PayMoney);
                        cm.ExecuteNonQuery();
                    }
                    sc.Complete();
                }

            }
            catch (Exception)
            {
            }
        }

        public static Sim GetSim(int ID)
        {
            Sim S = new Sim();
            try
            {
                string _connection = "Data Source=DARKNESS;Initial Catalog=BillingDB;Integrated Security=True";
                using (SqlConnection cn = new SqlConnection(_connection))
                {
                    cn.Open();
                    SqlCommand cm = cn.CreateCommand();
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.CommandText = "GetSim";
                    cm.Parameters.AddWithValue("@SimID", ID);
                    SqlDataReader dr = cm.ExecuteReader();
                    if (dr.Read())
                    {
                        S.SimID = ID;
                        S.SimCode = (int)dr["SimCode"];
                        S.SimClientID = (int)dr["SimClientID"];
                        S.SimPhoneNumber = (int)dr["SimPhoneNumber"];
                        S.TariffID = (int)dr["TariffID"];
                    }
                }
            }
            catch (Exception)
            {

            }
            return S;
        }
    }
}
