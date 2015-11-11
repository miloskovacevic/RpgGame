using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGameApp.CharacterClasses
{
    class Lumberjack : Entity
    {
        public Lumberjack() : base()
        { 
            
        }
        public Lumberjack(string name, EntityGender gender) : base()
        {
            Name = name;
            Gender = gender;
            _strength = rand.Next(3, 8);

        }
    }
}
