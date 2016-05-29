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
    class Hero
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

    }
}
