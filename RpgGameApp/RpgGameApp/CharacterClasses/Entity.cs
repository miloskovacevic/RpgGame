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
        protected string _name;
        protected EntityGender _gender;
        protected int _strength, _dexterity, _wisdom, _health;
        protected int _strengthModifier, _dexterityModifier, _wisdomModifier, _healthModifier;
        #endregion

        #region Properties region
        #endregion

        #region Constructors region
        #endregion

        #region Methods region
        #endregion


    }
}
