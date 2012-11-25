using GameEngine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace GameEngineTests
{
    
    
    /// <summary>
    ///This is a test class for FastLoopTest and is intended
    ///to contain all FastLoopTest Unit Tests
    ///</summary>
    [TestClass()]
    public class FastLoopTest
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
        ///A test for IsAppStillIdle
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GameEngine.exe")]
        public void IsAppStillIdleTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            FastLoop_Accessor target = new FastLoop_Accessor(param0); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsAppStillIdle();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for OnApplicationEnterIdle
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GameEngine.exe")]
        public void OnApplicationEnterIdleTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            FastLoop_Accessor target = new FastLoop_Accessor(param0); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.OnApplicationEnterIdle(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for PeekMessage
        ///</summary>
        [TestMethod()]
        public void PeekMessageTest()
        {
            Message msg = new Message(); // TODO: Initialize to an appropriate value
            Message msgExpected = new Message(); // TODO: Initialize to an appropriate value
            IntPtr hWnd = new IntPtr(); // TODO: Initialize to an appropriate value
            uint messageFilterMin = 0; // TODO: Initialize to an appropriate value
            uint messageFilterMax = 0; // TODO: Initialize to an appropriate value
            uint flags = 0; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = FastLoop.PeekMessage(out msg, hWnd, messageFilterMin, messageFilterMax, flags);
            Assert.AreEqual(msgExpected, msg);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
