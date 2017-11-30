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
            //Arrange 
            var service = new StudentEmptyService();
            var student = new Student() { Name = string.Empty };

            //Act
            var result = service.IsValid(student);

            //Assert	
            Assert.IsFalse(result);
        }

    }
}
