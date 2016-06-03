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


        /*[TestMethod]
        public void _hitAttemptTestMethod()
        {

            //Arrange
            Hero hero2 = new Hero("Jake");
            Program.
            bool hitCheck = 

            //Act

            
            //Assert

            


        }//_hitAttemptTestMethod
         */
        [TestMethod]
        public void  _hitDamageTestMethod()
        {
            //Arrange
            Hero hero3 = new Hero("Tom");
            Random ram = new Random();
            hero3.Strength = 10;// initialize hero3.Strength =10 for the test
            int damage = hero3.Strength * ram.Next(1, 7);
            
            
            //Act
           
            bool expected = damage == 10 || damage == 20 || damage == 30 || damage == 40 || damage == 50 || damage == 60;
            string message = "message";
           
            //Assert

            Assert.IsTrue(expected, message);//Pass!


        }//close_hitDamageTestMethod()

        [TestMethod]
        public void FightTestMethod()
        {
            //Arrange
            Hero hero4 = new Hero("Mary");
            hero4.Strength = 20;
            hero4.Speed = 30;
            hero4.Health = 40;
            //Act
             string str = string.Format("!!{0} damaged {1}!!", hero4.Name,hero4._hitDamageTest());
            //Assert
             Assert.AreEqual(str, hero4.FightTest());        
            

        }//closeFightTestMethod()
        
        [TestMethod]
        public void ShowTestMethod()
        {
            //Arrange
            
            Hero hero1 = new Hero("Mike");
            hero1.Strength = 10;
            hero1.Speed = 15;
            hero1.Health = 20;
            
            //Act
          
            string str = String.Format("\n{0} strength:{1}\n{0} speed:{2},\n{0} health:{3}", "Mike", 10,15, 20);
            string check = String.Format("\n{0} strength:{1}\n{0} speed:{2},\n{0} health:{3}", hero1.Name,hero1.Strength, hero1.Speed, hero1.Health);
            //Assert
            Assert.AreEqual(str,hero1.ToString());//pass!!
            Assert.AreEqual(check, hero1.ToString());//pass!!
        }//closeShowTestMethod()

    }//UnitTest
}//namespace






