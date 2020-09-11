using NUnit.Allure.Core;
using NUnit.Framework;
using System;
using System.IO;

namespace NUnitTestProject1
{
    [AllureNUnit]
    public class Tests
    {
        [OneTimeSetUp]
        public void Init()
        {
            Environment.CurrentDirectory = Directory.GetParent(GetType().Assembly.Location).Parent.Parent.Parent.FullName;
        }

        [Test]
        [Description("Test Description")]
        [Category("Sanity")]
        [Category("Regression")]
        public void Test1()
        {
            System.Console.WriteLine("SID: 123456");
            Assert.AreEqual(true, true);
        }

        [Test]
        [Description("Test Description")]
        [Category("Sanity")]
        [Category("Regression")]
        public void Test2()
        {
            System.Console.WriteLine("SID: 654321");
            Assert.AreEqual(true, false, "Failure message of the test!");
        }

        [Test]
        [Description("Test Description")]
        [Category("Sanity")]
        [Category("Regression")]
        public void Test3()
        {
            System.Console.WriteLine("SID: 52623452346524562435234523452436243634253245234");
            Assert.AreEqual(false, false);
        }
    }
}
