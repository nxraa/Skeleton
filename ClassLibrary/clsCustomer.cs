using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private string mName;
        private Int32 mID;

        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public string Name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }
        public string Email { get; set; }
        public string Pass { get; set; }

        public int ID
        {
            get
            {
                return mID;
            }
            set
            {
                mID = value;
            }
        }

        public bool Find(string Name)
        {
            mName = "Aaron";
            return true;
        }

        public bool Find(int iD)
        {
            mID = 4;
            return true;
            
        }
    }
}