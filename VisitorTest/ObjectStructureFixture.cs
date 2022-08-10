using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Visitor;

namespace VisitorTest
{
    [TestClass]
    public class ObjectStructureFixture
    {
        [TestMethod]
        public void AcceptTest()
        {
            ConcreteElementA a1 = new ConcreteElementA("A1");
            ObjectStructure objectStructure = new ObjectStructure();
            objectStructure.Add(a1);
            var visitor = new ConcreteVisitor1();
            List<string> vs = objectStructure.Accept(visitor);

            string expected = "Type:ConcreteElementA  Name:A1  Visitor:ConcreteVisitor1";
            string actual = vs[0];

            Assert.AreEqual(expected, actual);

        }
    }
}
