using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGameApp.CharacterClasses
{
    public class Mage : Entity
    {
        
        public Mage() : base()
        { 
   
        }

        
        public Mage(string name, EntityGender gender) : base()
        {
            rand = new Random();
            Name = name;
            Gender = gender;
            _wisdom = rand.Next(3, 8);
        
        }

        public Mage(string name, EntityGender gender, int strength, int dexterity,int wisdom, int health)
        {
            _name = name;
            _gender = gender;
            _wisdom = wisdom;
            _strength = strength;
            _health = health;
            _dexterity = dexterity;
        }
    }
}
