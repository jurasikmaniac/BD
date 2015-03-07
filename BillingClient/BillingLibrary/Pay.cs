using System;
using System.Collections.Generic;
using System.Text;

namespace BillingLibrary
{
    public class Pay
    {
        private int _PayID;
        private DateTime _PayDateTime;
        private int _PayMoney;
        public int PayID
        {
            get
            {
                return _PayID;
            }
            set
            {
                _PayID = value;
            }
        }
        public DateTime PayDateTime
        {
            get
            {
                return _PayDateTime;
            }
            set
            {
                _PayDateTime = value;
            }
        }
        public int PayMoney
        {
            get
            {
                return _PayMoney;
            }
            set
            {
                _PayMoney = value;
            }
        }
    }
}
