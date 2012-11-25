using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameEngineTests
{
    [TestClass]
    public class StateSystemTest
    {
        [TestMethod]
        public void TestAddedStateExists()
        {
            GameEngine.StateSystem stateSystem = new GameEngine.StateSystem(); 
        }
    }
}
