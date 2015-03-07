using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;

namespace BillingLibrary
{
    public class Tariff
    {
        private int _tariffID;
        private string _tariffName;
        private int _tariffSecCost;
        private int _simCount;
        private int _sumMoney;

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
        public string TariffName
        {
            get
            {
                return _tariffName;
            }
            set
            {
                _tariffName = value;
            }
        }
        public int TariffSecCost
        {
            get
            {
                return _tariffSecCost;
            }
            set
            {
                _tariffSecCost = value;
            }
        }
        public int SimCount
        {
            get
            {
                return _simCount;
            }
            set
            {
                _simCount = value;
            }
        }
        public int SumMoney
        {
            get
            {
                return _sumMoney;
            }
            set
            {
                _sumMoney = value;
            }
        }

        public void InsertTariff()
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
                        cm.CommandText = "InsertTariff";
                        cm.Parameters.AddWithValue("@TariffName", _tariffName);
                        cm.Parameters.AddWithValue("@TariffSecCost", _tariffSecCost);
                        cm.ExecuteNonQuery();
                    }
                    sc.Complete();
                }
            }
            catch (Exception)
            {

            }
        }

        public void DeleteTariff()
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
                        cm.CommandText = "DeleteTariff";
                        cm.Parameters.AddWithValue("@TariffID", _tariffID);
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

        public void UpdateTariff()
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
                        cm.CommandText = "UpdateTariff";
                        cm.Parameters.AddWithValue("@TariffID", _tariffID);
                        cm.Parameters.AddWithValue("@TariffName", _tariffName);
                        cm.Parameters.AddWithValue("@TariffSecCost", _tariffSecCost);
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
    }
}
