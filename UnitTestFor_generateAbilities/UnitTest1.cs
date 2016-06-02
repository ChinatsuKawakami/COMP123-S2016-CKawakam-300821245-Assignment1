using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using COMP123_S2016_Ckawakam_300821245_Assignment1;

namespace UnitTestFor_generateAbilities
{
    [TestClass]
    public class UnitTest1 // : Hero
    {

        [TestMethod]
        public void _generateAbilitiesTestMethod()
        {
            //Arrange
            Hero hero1 = new Hero("Mark");

           // int number = 0; //I failed to pass the test for using 0
          //  int number = 100; // I can pass the test for using 100
            //Act
       
            string message = "message";
            bool check = hero1.Strength>=1 && hero1.Strength<101; // check the hero1.Strength is between 0 and 100 or not
            bool check1 = hero1.Speed >= 1 && hero1.Speed < 101;//check the hero1.Speed is between 0 and 100 or not
            bool check2 = hero1.Health >= 1 && hero1.Health < 101;//check the hero1.Health is between 0 and 100 or not
            //Assert
            
            Assert.IsTrue(check,message);//Pass!
            Assert.IsTrue(check1, message);//Pass!
            Assert.IsTrue(check2, message);//Pass!

        
        }//_generateAbilitiesTestMethod()


      
    }//UnitTest
}//namespace






