using GameEngine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GameEngineTests
{
    
    
    /// <summary>
    ///This is a test class for PreciseTimerTest and is intended
    ///to contain all PreciseTimerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PreciseTimerTest
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
        ///A test for PreciseTimer Constructor
        ///</summary>
        [TestMethod()]
        public void PreciseTimerConstructorTest()
        {
            PreciseTimer target = new PreciseTimer();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for GetElapsedTime
        ///</summary>
        [TestMethod()]
        public void GetElapsedTimeTest()
        {
            PreciseTimer target = new PreciseTimer(); // TODO: Initialize to an appropriate value
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            actual = target.GetElapsedTime();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for QueryPerformanceCounter
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GameEngine.exe")]
        public void QueryPerformanceCounterTest()
        {
            long PerformanceCount = 0; // TODO: Initialize to an appropriate value
            long PerformanceCountExpected = 0; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = PreciseTimer_Accessor.QueryPerformanceCounter(ref PerformanceCount);
            Assert.AreEqual(PerformanceCountExpected, PerformanceCount);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for QueryPerformanceFrequency
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GameEngine.exe")]
        public void QueryPerformanceFrequencyTest()
        {
            long PerformanceFrequency = 0; // TODO: Initialize to an appropriate value
            long PerformanceFrequencyExpected = 0; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = PreciseTimer_Accessor.QueryPerformanceFrequency(ref PerformanceFrequency);
            Assert.AreEqual(PerformanceFrequencyExpected, PerformanceFrequency);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
