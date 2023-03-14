using System;

namespace ClassLibrary
{
    public class clsStock
    {
        private Int32 mProductId;
        private DateTime mDateAdded;
        private Boolean mAvailableInStore;
        private Int32 mStockLevel;
        private float mPrice;
        private string mName;
        private string mDescription;
        public bool AvailableInStore
        {
            get
            {
                return mAvailableInStore;
            }
            set
            {
                mAvailableInStore = value;
            }
        }
        public DateTime DateAdded 
        { 
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        } 
        public Int32 ProductId 
        { 
            get
            {
                return mProductId;
            }
            set
            {
                mProductId = value;
            }
        }
        public Int32 StockLevel
        {
            get
            {
                return mStockLevel;
            }
            set
            {
                mStockLevel = value;
            }
        }
        public float Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }
        public string Description
        {
            get
            {
                return mDescription;
            }
            set
            {
                mDescription = value;
            }
        }
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

        public bool Find(int productId)
        {
            mProductId = 21;
            mDateAdded = Convert.ToDateTime(1 / 01 / 2023);
            mAvailableInStore = true;
            mStockLevel = 21;
            mName = "Iphone";
            mDescription = "new iphone";
            mPrice = 900;
            return true;
        }
    }
}