using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer aCustomer = new clsCustomer();
            Assert.IsNotNull(aCustomer);
        }
        [TestMethod]
        public void ActivePropertyOk()
        {
            clsCustomer aCustomer = new clsCustomer();
            Boolean TestData = true;
            aCustomer.Active = TestData;
            Assert.AreEqual(aCustomer.Active, TestData);
        }
        [TestMethod]
        public void DatePropertyOk()
        {
            clsCustomer aCustomer = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            aCustomer.DateAdded = TestData;
            Assert.AreEqual(aCustomer.DateAdded, TestData);
        }
        [TestMethod]
        public void NamePropertyOk()
        {
            clsCustomer aCustomer = new clsCustomer();
            string TestData = "Aaron";
            aCustomer.Name = TestData;
            Assert.AreEqual(aCustomer.Name, TestData);

        }
        [TestMethod]
        public void EmailProperytOk()
        {
            clsCustomer aCustomer = new clsCustomer();
            string TestData = "aaron2003@gmail.com";
            aCustomer.Email = TestData;
            Assert.AreEqual(aCustomer.Email, TestData);

        }
        [TestMethod]
        public void PasswordProperytOk()
        {
            clsCustomer aCustomer = new clsCustomer();
            string TestData = "happy200";
            aCustomer.Pass = TestData;
            Assert.AreEqual(aCustomer.Pass, TestData);

        }

        [TestMethod]
        public void IDProperytOk()
        {
            clsCustomer aCustomer = new clsCustomer();
            Int32 TestData = 1;
            aCustomer.ID = TestData;
            Assert.AreEqual(aCustomer.ID, TestData);

        }

        [TestMethod]

        public void FindMethodOK()
        {
            clsCustomer aCustomer = new clsCustomer();
            Boolean Found = false;
            string Name = "Aaron";
            Found = aCustomer.Find(Name);
            Assert.IsTrue(Found);
        }

        [TestMethod]

        public void TestNameFound()
        {
            clsCustomer aCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            string Name = "Aaron";
            Found = aCustomer.Find(Name);
            if(aCustomer.Name != "Aaron")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestCustomerIDFound()
        {
            clsCustomer aCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ID = 4;
            Found = aCustomer.Find(ID);
            if (aCustomer.ID != 4)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }


    }
}
