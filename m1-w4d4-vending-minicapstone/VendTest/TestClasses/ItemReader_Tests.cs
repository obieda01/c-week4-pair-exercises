using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vend.Classes;
using System.Reflection;
using System.IO;
using System.Collections.Generic;
namespace VendTest.TestClasses
{
    [TestClass]
    public class ItemReader_Tests
    {
        [TestMethod]
        public void ItemReader_Proprerty_ItemDictionary_Tests()
        {
            Type type = typeof(ItemReader);
            PropertyInfo prop = type.GetProperty("ItemDictionary");
            Assert.IsNotNull(prop);
            Assert.IsTrue(prop.CanRead);
            Assert.IsFalse(prop.CanWrite);
            Assert.AreEqual(typeof(Dictionary<string, VendMachineItems>), prop.PropertyType);
        }
        [TestMethod]
        public void ItemReader_fileReaderCSV_Tests()
        {
            Type type = typeof(ItemReader);
            MethodInfo method = type.GetMethod("fileReaderCSV");

            Assert.IsNotNull(method);
            Assert.IsTrue(method.IsPublic);
            Assert.AreEqual(0,method.GetParameters().Length);
            Assert.AreEqual(typeof(Dictionary<string, VendMachineItems>), method.ReturnType);
        }

        [TestMethod]
        public void ItemReader_fileReaderCSV_Reading_Tests()
        {
            Type type = typeof(ItemReader);
            MethodInfo method = type.GetMethod("fileReaderCSV");
            Assert.IsTrue(Directory.Exists(@"C:\Users\aobiedat\Tech Elevator\.Net class\week1\c-week4-pair-exercises\m1-w4d4-vending-minicapstone\Vend\bin\Debug"));
            Assert.IsTrue(File.Exists(@"C:\Users\aobiedat\Tech Elevator\.Net class\week1\c-week4-pair-exercises\m1-w4d4-vending-minicapstone\Vend\bin\Debug\TransactionLog.txt"));
            Assert.AreEqual("2/10/2017 11:09:00 AM", File.GetLastWriteTime(@"C:\Users\aobiedat\Tech Elevator\.Net class\week1\c-week4-pair-exercises\m1-w4d4-vending-minicapstone\Vend\bin\Debug\TransactionLog.txt").ToString());

            CollectionAssert.AllItemsAreUnique(new ItemReader().fileReaderCSV());
            CollectionAssert.AllItemsAreNotNull(new ItemReader().fileReaderCSV());
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
