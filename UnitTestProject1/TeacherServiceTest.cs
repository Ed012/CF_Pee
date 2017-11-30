using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CF_Pee.Models;
using CF_Pee.Services;

namespace UnitTestProject1
{
    [TestClass]
    public class TeacherServiceTest
    {
        [TestMethod]
        public void IsEmpty_TeacherName()
        {
            //Arrange 
            var service = new TeacherIsEmptyService();
            var teacher = new Teacher() { Name = string.Empty };

            //Act
            var result = service.IsValid(teacher);

            //Assert	
            Assert.IsFalse(result);
        }
    }
}
