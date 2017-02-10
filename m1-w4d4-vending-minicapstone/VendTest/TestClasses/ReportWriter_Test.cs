using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vend.Classes;
using System.Reflection;
using System.IO;
using System.Collections.Generic;
namespace VendTest.TestClasses
{
    [TestClass]
    public class ReportWriter_Test
    {
        [TestMethod]
        public void ReportWriter_readWriteFile_Method_Tests()
        {
            Type type = typeof(ReportWriter);
            MethodInfo method = type.GetMethod("readWriteFile");
            Assert.IsTrue(File.Exists(@"C:\Users\aobiedat\Tech Elevator\.Net class\week1\c-week4-pair-exercises\m1-w4d4-vending-minicapstone\Vend\bin\Debug\TransactionLog.txt"));
            Assert.IsTrue(Directory.Exists(@"C:\Users\aobiedat\Tech Elevator\.Net class\week1\c-week4-pair-exercises\m1-w4d4-vending-minicapstone\Vend\bin\Debug"));

            Assert.IsNotNull(method);
            Assert.IsTrue(method.IsPublic);
            Assert.AreEqual(0, method.GetParameters().Length);
            Assert.AreEqual(typeof(void), method.ReturnType);
        }
        [TestMethod]
        public void ReportWriter_readWriteFile_Property_Tests()
        {
            Type type = typeof(ReportWriter);
            PropertyInfo prop = type.GetProperty("DictionaryOfItemSale");
            Assert.IsNotNull(prop);
            Assert.IsTrue(prop.CanRead);
            Assert.IsFalse(prop.CanWrite);
            Assert.AreEqual(typeof(Dictionary<string, int>), prop.PropertyType);
        }


        [TestMethod]
        public void ReportWriter_readWriteFile_Reading_Tests()
        {
            ReportWriter testedInstance= new ReportWriter();
            testedInstance.readWriteFile();
           CollectionAssert.AllItemsAreUnique(testedInstance.DictionaryOfItemSale);
            CollectionAssert.AllItemsAreNotNull(testedInstance.DictionaryOfItemSale);


            Dictionary<string, VendMachineItems> items = new ItemReader().fileReaderCSV();
            foreach (var item in items)
            {
                Assert.AreEqual(5, item.Value.ItemCount);
                Assert.IsNotNull(item.Value.ItemName);
                Assert.IsNotNull(item.Value.ItemPrice);
                Assert.IsNotNull(item.Value.ItemSlot);

            }
        }
    }
}
