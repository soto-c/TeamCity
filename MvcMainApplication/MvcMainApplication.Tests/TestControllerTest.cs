﻿using MvcMainApplication.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using System.Web.Mvc;

namespace MvcMainApplication.Tests
{


    /// <summary>
    ///This is a test class for TestControllerTest and is intended
    ///to contain all TestControllerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TestControllerTest
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

        [TestMethod]
        public void IndexTest()
        {
            //Test trigger filter +:Soto* dddd
            // Add comment buid +:comment=TeamCityBuild:**
            // Test comment TeamCityBuild
            //refs/heads/Soto  ww  
            // 1st commit 
            // 2nd commit 
            // final commit 
            // final commit2 
            // this is a new commit
            // tapes Work
            // This is Tape's work
            Assert.IsTrue(1 == 1);
        }

    }
}
