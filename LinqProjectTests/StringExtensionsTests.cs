using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinqProject;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinqProject.Tests
{
    [TestClass()]
    public class StringExtensionsTests
    {
        public TestContext TestContext { get; set; }
        [TestMethod()]
        public void ConvertToTitleCaseTest()
        {
            var source = "The return of the king";
            var expected = "The Return of the king";
            var result = StringExtensions.ConvertToTitleCase(source);
            Assert.IsNotNull(result);
            Assert.AreEqual(expected, result);
        }
    }
}