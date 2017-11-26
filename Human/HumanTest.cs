using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace unittest.plutosols.libraries.Human
{
    [TestClass]
    public class HumanTest
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
    }

    interface IBody { }
    interface IWettana { }
    interface ISanya { }
    interface ISangkarn { }

    public class Winyarn : IBody, IWettana, ISanya, ISangkarn
    {

    }

    public class Human : Winyarn
    {

    }
}
