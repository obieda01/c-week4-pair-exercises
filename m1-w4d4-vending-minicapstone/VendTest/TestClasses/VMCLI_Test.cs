using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vend.Classes;
using System.Reflection;
namespace VendTest.TestClasses
{
    [TestClass]
    public class VMCLI_Test
    {
        [TestMethod]
        public void VMCLI_CaculateChangeMethodTest()
        {
            Type type = typeof(VMCLI);
            MethodInfo method = type.GetMethod("calculateChange");
            Assert.IsNotNull(method);
            Assert.AreEqual(typeof(void), method.ReturnType);
            Assert.AreEqual(true, method.IsPublic);
            Assert.AreEqual(1, method.GetParameters().Length);
        }

        [TestMethod]
        public void VMCLI_ProcessMenuSelectionsTest()
        {
            Type type = typeof(VMCLI);
            MethodInfo method = type.GetMethod("processMenuSelections");
            Assert.IsNotNull(method);
            Assert.AreEqual(typeof(void), method.ReturnType);
            Assert.AreEqual(true, method.IsPublic);
            Assert.AreEqual(1, method.GetParameters().Length);
        }

        [TestMethod]
        public void VMCLI_PrintAllItemsTest()
        {
            Type type = typeof(VMCLI);
            MethodInfo method = type.GetMethod("printAllItems");
            Assert.IsNotNull(method);
            Assert.AreEqual(typeof(void), method.ReturnType);
            Assert.AreEqual(true, method.IsPublic);
            Assert.AreEqual(1, method.GetParameters().Length);
        }

        [TestMethod]
        public void VMCLI_PrintSalesTest()
        {
            Type type = typeof(VMCLI);
            MethodInfo method = type.GetMethod("printSales");
            Assert.IsNotNull(method);
            Assert.AreEqual(typeof(void), method.ReturnType);
            Assert.AreEqual(true, method.IsPublic);
            Assert.AreEqual(0, method.GetParameters().Length);
        }
        [TestMethod]
        public void VMCLI_LaunchRunTest()
        {
            Type type = typeof(VMCLI);
            MethodInfo method = type.GetMethod("launchRun");
            Assert.IsNotNull(method);
            Assert.AreEqual(typeof(void), method.ReturnType);
            Assert.AreEqual(true, method.IsPublic);
            Assert.AreEqual(1, method.GetParameters().Length);
        }
      
    }
}
