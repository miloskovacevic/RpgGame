﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGameApp.CharacterClasses
{
    public class Player : Entity
    {
        Random rand = new Random();

        public Player()
            : base()
        { 
            
        
        }

        public Player(string name, EntityGender eGender, EntityClass eClass)
            : base()
        {
            Name = name;
            Gender = eGender;
            CharacterClass = eClass;
        }

        public Player(string name, EntityGender eGender, EntityClass eClass, int dexterity, int health, int strength, int wisdom)
        {
            Name = name;
            Gender = eGender;
            CharacterClass = eClass;
            Dexterity = dexterity;
            Health = health;
            Wisdom = wisdom;
            Strength = strength;
        }

    }
}
