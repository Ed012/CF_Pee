using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CF_Pee.Services;
using CF_Pee.Models;

namespace UnitTestProject1
{
    [TestClass]
    public class StudentServiceTest
    {
        [TestMethod]
        public void IsValid_StudentNameEMpty()
        {
            var service = new StudentService();
            var student = new Student() { Name = string.Empty };

            var result = service.IsValid(student);

            Assert.IsFalse(result);
        }
    }
}
