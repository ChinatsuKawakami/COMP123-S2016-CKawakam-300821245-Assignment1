using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using COMP123_S2016_Ckawakam_300821245_Assignment1;

namespace UnitTestFor_generateAbilities
{
    [TestClass]
    public class UnitTest
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


        [TestMethod]
        public void _hitAttemptTestMethod()
        {

            //Arrange
            Hero hero2 = new Hero("Jake");
            Random ram = new Random();
            int getAttack = ram.Next(0, 5);
            //Act 
            bool checkRam = getAttack >= 0 && getAttack < 5;
            string message = "message";
            //Assert 
            Assert.IsTrue(checkRam, message);//Pass! getAttack has 5 numbers and they are 0, 1, 2, 3, 4

            //Arrange
            bool actual;
             //Act  
             if (getAttack == 0)
             {
              //Assert
               actual=true;
               
            Assert.AreEqual(actual, hero2.HitAttemptTest(0));//Pass!!
            //Assert.AreEqual(actual, hero2.HitAttemptTest(2));//Failed because actual = true but hero2.HitAttemptTest = false

             }else if(getAttack ==1 || getAttack==2|| getAttack == 3|| getAttack ==4)
             {
                 //Assert
                actual= false;
               // Assert.AreEqual(actual, hero2.HitAttemptTest(0));//Fail because actual = false but hero2.HitAttemptTest = True
              Assert.AreEqual(actual, hero2.HitAttemptTest(1));//Pass!
              Assert.AreEqual(actual, hero2.HitAttemptTest(2));//Pass!
              Assert.AreEqual(actual, hero2.HitAttemptTest(3));//Pass!
              Assert.AreEqual(actual, hero2.HitAttemptTest(4));//Pass!
            }

           
          
        }//_hitAttemptTestMethod
      
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
            bool mayFail = damage == 5 || damage == 13 || damage == 22 || damage == 35 || damage == 41 || damage == 55 || damage == 59;
            //Assert

           Assert.IsTrue(expected, message);//Pass!
        // Assert.IsTrue(mayFail, message);//Failed

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
             string str = string.Format("!!{0} damaged {1}!!", hero4.Name,hero4.HitDamageTest());// _hitDamageTest method includes _hitDamage() metod
             string expectedFail = string.Format("!!{0} get damaged {1}!!", hero4.Name, hero4.HitDamageTest());
            //Assert
             Assert.AreEqual(str, hero4.FightTest()); //pass!  
             //Assert.AreEqual(expectedFail,hero4.FightTest()); //Failed
             
     
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
          
            string str = String.Format("\n{0} strength:{1}\n{0} speed:{2}\n{0} health:{3}", "Mike", 10,15, 20);
            string check = String.Format("\n{0} strength:{1}\n{0} speed:{2}\n{0} health:{3}", hero1.Name,hero1.Strength, hero1.Speed, hero1.Health);
            string failed = string.Format("\n{0} is strength:{1}\n{0} is speed:{2}\n{0} is health:{3}", "Mike", 10, 15, 20);
            //Assert
           Assert.AreEqual(str,hero1.ToString());//pass!!
           Assert.AreEqual(check, hero1.ToString());//pass!!
           // Assert.AreEqual(failed, hero1.ToString());//Failed
        }//closeShowTestMethod()

    }//UnitTest
}//namespace






