using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 *This is driver class
 *Author: Chinatsu Kawakami
 *Date :May 28 th 2016
 *Date Modified: June 2nd 2016
 *Student Id: 300821245
 *Description: This program calls instance variables from Hero class
 *and print Fight and Show method.
 *version : 0.0.12- added UnitTest for checking _hitAttempt method
 *and added HitAttemptTest(int getAttack) int Hero class for _hitAttempt method
 */

namespace COMP123_S2016_Ckawakam_300821245_Assignment1
{
    /**
     * This is the driver class for our program , Assignment1
     * 
     * @class Program
     */
   public class Program
    {
        /**
         * The Main method for our driver class program
         * 
         * @constructor: Main
         * @param {string[]}args
         */
        static void Main(string[] args)
        {
            Hero hero1 = new Hero("Mike");
            //call Show method
            hero1.Show();
            hero1.Fight();


        }






    }
}
