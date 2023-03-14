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
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductId", productId);
            DB.Execute("sproc_tblAddress_FilterByProductId");
            if (DB.Count == 1) 
            {
                mProductId = Convert.ToInt32(DB.DataTable.Rows[0]["ProductId"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mAvailableInStore = Convert.ToBoolean(DB.DataTable.Rows[0]["AvailableInStore"]);
                mStockLevel = Convert.ToInt32(DB.DataTable.Rows[0]["StockLevel"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mDescription = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                mPrice = Convert.ToInt32(DB.DataTable.Rows[0]["ProductId"]);
                return true;
            }
        }
    }
}