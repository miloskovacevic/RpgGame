using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGameApp.CharacterClasses
{
    public enum EntityGender
    { 
        Male, Female, Unknown
    }

    public abstract class Entity
    {
        #region Fields region
        protected Random rand;
        protected string _name;
        protected EntityGender _gender;
        protected int _strength, _dexterity, _wisdom, _health;
        protected int _strengthModifier, _dexterityModifier, _wisdomModifier, _healthModifier;
        #endregion

        #region Properties region
        public string Name { get { return _name; } protected set { _name = value; } }
        public EntityGender Gender { get { return _gender; } protected set { _gender = value; } }
        public int Strength { get { return _strength + _strengthModifier; } protected set { _strength = value; } }
        public int Dexterity { get { return _dexterity + _dexterityModifier; } protected set { _dexterity = value; } }
        public int Wisdom { get { return _wisdom + _wisdomModifier; } protected set { _wisdom = value; } }
        public int Health { get { return _health + _healthModifier; } protected set { _health = value; } }
        #endregion

        #region Constructors region
        public Entity()
        {
            Name = "";
            Strength = 0;
            Dexterity = 0;
            Wisdom = 0;
            Health = 0;
        }


        
        #endregion

        #region Methods region
        #endregion


    }
}
