using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using COMP123_S2016_Ckawakam_300821245_Assignment1;

namespace UnitTestFor_generateAbilities
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void _generateAbilitiesTestMethod()
        {
            //Arrange

            string result;
          
            //Act
            result = Program._generateAbilities();

            //Assert
            Assert.IsNotNull(result);
        }

      
    }
}
