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
        [TestMethod]
        public void TestMethod2()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.ChangeNode(56);
            linkedList.ChangeNode(30);
            linkedList.ChangeNode(70);
            Assert.AreEqual(56, linkedList.head.data);
        }
        [TestMethod]
        public void TestMethod3()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.ChangeNode(56);
            linkedList.ChangeNode(70);
            linkedList.InsertElement(30, 2);
            Assert.AreEqual(30, linkedList.head.next.data);
        }
        [TestMethod]
        public void TestMethod4()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.ChangeNode(56);
            linkedList.ChangeNode(30);
            linkedList.ChangeNode(70);
            Node head = linkedList.DeleteFirstElement();
            Assert.AreEqual(30, head.data);
        }
        [TestMethod]
        public void TestMethod5()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.ChangeNode(56);
            linkedList.ChangeNode(30);
            linkedList.ChangeNode(70);
            Node last= linkedList.DeleteLastElement();
            Assert.AreEqual(30, last.data);
        }
        [TestMethod]
        public void TestMethod6()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.ChangeNode(56);
            linkedList.ChangeNode(30);
            linkedList.ChangeNode(70);
            int position = linkedList.SearchList(30);
            Assert.AreEqual(2, position);
        }
        [TestMethod]
        public void TestMethod7()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.ChangeNode(56);
            linkedList.ChangeNode(30);
            linkedList.ChangeNode(70);
            linkedList.InsertAfterElement(40, 30);
            int position = linkedList.SearchList(40);
            Assert.AreEqual(3, position);
        }
        [TestMethod]
        public void TestMethod8()
        {
            LinkedList linkedList = new LinkedList();

            linkedList.ChangeNode(56);
            linkedList.ChangeNode(30);
            linkedList.ChangeNode(70);
            linkedList.InsertAfterElement(40, 30);
            linkedList.DeleteMiddleNode(40);
            int size = linkedList.size();
            Assert.AreEqual(3, size);
        }
        [TestMethod]
        public void TestMethod9()
        {
            OrderedLinkedList orderedLinkedList = new OrderedLinkedList();
            orderedLinkedList.AddElement(56);
            orderedLinkedList.AddElement(30);
            orderedLinkedList.AddElement(40);
            orderedLinkedList.AddElement(70);
            Assert.AreEqual(30, orderedLinkedList.head.data);
        }
    }
}
