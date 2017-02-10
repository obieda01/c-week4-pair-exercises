using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vend.Classes;
using System.Reflection;
using System.IO;
using System.Collections.Generic;

namespace VendTest.TestClasses
{
    [TestClass]
    public class VendMachineItems_Tests
    {
        [TestMethod]
        public void VendMachineItems_Properties_Tests()
        {
            Type type = typeof(VendMachineItems);
            PropertyInfo prop = type.GetProperty("ItemPrice");
            Assert.IsNotNull(prop);
            Assert.IsTrue(prop.CanRead);
            Assert.IsTrue(prop.CanWrite);
            Assert.AreEqual(typeof(double), prop.PropertyType);

            prop = type.GetProperty("ItemName");
            Assert.IsNotNull(prop);
            Assert.IsTrue(prop.CanRead);
            Assert.IsTrue(prop.CanWrite);
            Assert.AreEqual(typeof(string), prop.PropertyType);


            prop = type.GetProperty("ItemSlot");
            Assert.IsNotNull(prop);
            Assert.IsTrue(prop.CanRead);
            Assert.IsTrue(prop.CanWrite);
            Assert.AreEqual(typeof(string), prop.PropertyType);

            prop = type.GetProperty("ItemCount");
            Assert.IsNotNull(prop);
            Assert.IsTrue(prop.CanRead);
            Assert.IsTrue(prop.CanWrite);
            Assert.AreEqual(typeof(int), prop.PropertyType);


            prop = type.GetProperty("ItemDictionary");
            Assert.IsNotNull(prop);
            Assert.IsTrue(prop.CanRead);
            Assert.IsFalse(prop.CanWrite);
            Assert.AreEqual(typeof(Dictionary<string, object>), prop.PropertyType);
        }
    }
}
