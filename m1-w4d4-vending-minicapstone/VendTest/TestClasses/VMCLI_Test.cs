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
          
        }
        [TestMethod]
        public void VMCLI_ConstructorTest()
        {
           // Type type = typeof(VMCLI);
           // MethodInfo method = type.GetMethod("VMCLI");
           // //Assert.IsNotNull(method);
           //// Assert.AreEqual(typeof(void), method.ReturnType);
           // Assert.AreEqual(true, method.IsPublic);

        }

    }
}
