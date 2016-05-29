using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Ckawakam_300821245_Assignment1
{
    /**
     * This class defines a generic Hero
     * 
     * @class Hero
     * @param 
     * @field _strength{int},_speed{int},_health{int},_name{string},Name{string}
     */
    public class Hero
    {
        //PRIVATE INSTANCE VARIABLES++++++++++++++++++++++++++++++++++++++++
        private int _strength;
        private int _speed;
        private int _health;
        private string _name;

        //PUBLIC INSTANCE VARIABLES+++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This is a propety for our _name field
         * </summary>
         * @property{string} Name
         */
        public string Name
        {
            get
            {
                return _name;
            }//close get
            set
            {
                _name = value;
            }//close set
        }//close public Name


        //CONSTRUCTOR+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
       
        /**
         * <summary>
         * This is constructor that takes name as a parameter and passes
         * it to the _name private instance variable
         * it to the _generateAbilities method
         * </summary>
         * @constructor Hero
         * @param {string} name
         */
        public Hero(string name)
        {
            this._name = name;
            this._generateAbilities();
        }

        /**
         * <summary>
         * This method to get values for _strength , _speed, _health randamly
         * </summary>
         * @method _generateAbilities
         * @return {void}
         */
        private void _generateAbilities()
        {
            Random ram = new Random();


            this._strength = ram.Next(1, 100);
            this._speed = ram.Next(1, 100);
            this._health = ram.Next(1, 100);
        }
        /**
       * <summary>
       * This method to check whether Hero object get damage or not by returning bool value
       * </summary>
       * @method _hitAttempt
       * @return {bool}_hitA
       */
        private bool _hitAttempt()
        {
            bool hitA;

            Random ram = new Random();
            int getAttack = ram.Next(0, 2);
            if (getAttack == 0)
            {
                //??this shold be only 20% of the time

                hitA = true;

            }
            else
            {
                hitA = false;
            }


            return hitA;

        }

        /**
       * <summary>
       * This method to calculate how much damage the Hero object gets 
       * </summary>
       * @method _hitDamage
       * @return {int} damage
       */
        private int _hitDamage()
        {
            Random ram = new Random();

            int damage = _strength * ram.Next(1, 6);
            return damage;
        }
        /**
     * <summary>
     * This method to display how much damage the Hero object gets to console
     * </summary>
     * @method Fight
     * @return {void} 
     */
        public void Fight()
        {
            _hitAttempt();
            if (_hitAttempt() == true)
            {
                _hitDamage();

                Console.WriteLine("!!You damaged {0}!!", _hitDamage());
            }

        }
        /**
     * <summary>
     * This method to display the Hero object's parameter(_name,_strength,_speed,_health)
     * </summary>
     * @method Show
     * @return {void} 
     */
        public void Show()
        {
            Console.WriteLine("\n{0} strength:{1}\nYour speed:{2},\nYour health:{3}", this._name, this._strength, this._speed, this._health);
        }

    }
}
