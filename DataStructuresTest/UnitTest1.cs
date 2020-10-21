using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Data_Structures_Problem;

namespace DataStructuresTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            LinkedList linkedList = new LinkedList();
            linkedList.AddNode(70);
            linkedList.AddNode(30);
            linkedList.AddNode(56);
            Assert.AreEqual(56, linkedList.head.data);
        }
    }
}
