using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CF_Pee.Services;
using CF_Pee.Models;

namespace UnitTestProject1
{
    [TestClass]
    public class NoteServiceTest
    {
        [TestMethod]
        public void First_Test_Note()
        {
            //Arrange 
            var service = new NoteService();
            var note = new Notes() { First_Test = -3 };

            //Act
            var result = service.IsValid(note);

            //Assert	
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Last_Test_Note()
        {
            //Arrange 
            var service = new NoteService();
            var note = new Notes() { Last_Test = -3 };

            //Act
            var result = service.IsValid(note);

            //Assert	
            Assert.IsFalse(result);
        }
    }
}
