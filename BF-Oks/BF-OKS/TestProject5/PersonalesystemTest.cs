using Controller;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject5
{
    
    
    /// <summary>
    ///This is a test class for PersonalesystemTest and is intended
    ///to contain all PersonalesystemTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PersonalesystemTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for OpretMedarbejder
        ///</summary>
        [TestMethod()]
        public void OpretMedarbejderTest()
        {
            Personalesystem target = new Personalesystem(); // TODO: Initialize to an appropriate value
            string navn = "Hans Hansen"; // TODO: Initialize to an appropriate value
            long cpr_nummer = 1245637810; // TODO: Initialize to an appropriate value
            string adresse = "Adressen 24"; // TODO: Initialize to an appropriate value
            int postnr = 5000; // TODO: Initialize to an appropriate value
            string by = "Odense C"; // TODO: Initialize to an appropriate value
            long tlf = 12345678; // TODO: Initialize to an appropriate value
            int afdelingsid = 1; // TODO: Initialize to an appropriate value
            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.OpretMedarbejder(navn, cpr_nummer, adresse, postnr, by, tlf, afdelingsid);
            Assert.AreEqual(expected, actual);
           // Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
