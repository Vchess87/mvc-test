using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication3.Models;

namespace WebApplication3.IntegrationTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            Assert.IsTrue(context.Users.Count() == 1);
        }
    }
}