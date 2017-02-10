using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vend.Classes;
using System.Reflection;
using System.IO;
using System.Collections.Generic;

namespace VendTest.TestClasses
{
    [TestClass]
    public class VendMachine_Test
    {
       
        [TestMethod]
        public void VendMachine_Properties_Tests()
        {
            Type type = typeof(VendMachine);
            PropertyInfo prop = type.GetProperty("ItemDictionary");
            Assert.IsNotNull(prop);
            Assert.IsTrue(prop.CanRead);
            Assert.IsTrue(prop.CanWrite);
           Assert.AreEqual(typeof(Dictionary<string, VendMachineItems>), prop.PropertyType);

             prop = type.GetProperty("Balance");
            Assert.IsNotNull(prop);
            Assert.IsTrue(prop.CanRead);
            Assert.IsTrue(prop.CanWrite);
            Assert.AreEqual(typeof(double), prop.PropertyType);
        }
    }
}
