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

    public enum EntityClass
    {
        Mage,
        Rogue,
        Cleric,
        Paladin,
        Lumberjack,
        Unknown
    }

    public abstract class Entity
    {
        #region Fields region
        protected Random rand;
        protected string _name;
        protected EntityGender _gender;
        protected EntityClass _characterClass;
        protected int _strength, _dexterity, _wisdom, _health;
        protected int _strengthModifier, _dexterityModifier, _wisdomModifier, _healthModifier;
        #endregion

        #region Properties region
        public string Name { get { return _name; }  set { _name = value; } }
        public EntityGender Gender { get { return _gender; }  set { _gender = value; } }
        public EntityClass CharacterClass { get { return _characterClass; }  set { _characterClass = value; } }
        public int Strength { get { return _strength + _strengthModifier; }  set { _strength = value; } }
        public int Dexterity { get { return _dexterity + _dexterityModifier; }  set { _dexterity = value; } }
        public int Wisdom { get { return _wisdom + _wisdomModifier; }  set { _wisdom = value; } }
        public int Health { get { return _health + _healthModifier; }  set { _health = value; } }
        #endregion

        #region Constructors region
        public Entity()
        {
            Name = "";
            Gender = EntityGender.Unknown;
            CharacterClass = EntityClass.Unknown;
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
