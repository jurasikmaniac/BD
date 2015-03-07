using System;
using System.Collections.Generic;
using System.Text;

namespace BillingLibrary
{
    public class Call
    {
        private int _callID;
        private int _callLength;
        private bool _inc;
        private int _callPrice;
        private int _phoneNumber;
        private DateTime _callDateTime;
        private int _simID;
        private int _tariffID;
        private string _tariffName;

        public int CallID
        {
            get
            {
                return _callID;
            }
            set
            {
                _callID = value;
            }
        }
        public int CallLength
        {
            get
            {
                return _callLength;
            }
            set
            {
                _callLength = value;
            }
        }
        public bool Inc
        {
            get
            {
                return _inc;
            }
            set
            {
                _inc = value;
            }
        }
        public int CallPrice
        {
            get
            {
                return _callPrice;
            }
            set
            {
                _callPrice = value;
            }
        }
        public int PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                _phoneNumber = value;
            }
        }
        public DateTime CallDateTime
        {
            get
            {
                return _callDateTime;
            }
            set
            {
                _callDateTime = value;
            }
        }
        public int SimID
        {
            get
            {
                return _simID;
            }
            set
            {
                _simID = value;
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


    }
}
