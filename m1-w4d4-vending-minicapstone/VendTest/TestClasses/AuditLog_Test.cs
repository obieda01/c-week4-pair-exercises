using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vend.Classes;
using System.Reflection;
using System.IO;
namespace VendTest
{
    [TestClass]
    public class AuditLog_Test
    {
        [TestMethod]
        public void AuditLog_writeToLog_Test()
        {
            Type type = typeof(AuditLog);
            MethodInfo method = type.GetMethod("writeToLog");
            Assert.IsNotNull(method);
            Assert.AreEqual(typeof(void), method.ReturnType);
            Assert.AreEqual(true, method.IsPublic);
            Assert.AreEqual(5, method.GetParameters().Length);
        }

        [TestMethod]
        public void AuditLog_writeToLog_Writing_Test()
        {
            Assert.IsTrue(Directory.Exists(@"C:\Users\aobiedat\Tech Elevator\.Net class\week1\c-week4-pair-exercises\m1-w4d4-vending-minicapstone\Vend\bin\Debug"));
            Assert.IsTrue(File.Exists(@"C:\Users\aobiedat\Tech Elevator\.Net class\week1\c-week4-pair-exercises\m1-w4d4-vending-minicapstone\Vend\bin\Debug\TransactionLog.txt"));
            Assert.AreEqual("2/10/2017 11:09:00 AM",File.GetLastWriteTime(@"C:\Users\aobiedat\Tech Elevator\.Net class\week1\c-week4-pair-exercises\m1-w4d4-vending-minicapstone\Vend\bin\Debug\TransactionLog.txt").ToString());
            

        }
    }

}
