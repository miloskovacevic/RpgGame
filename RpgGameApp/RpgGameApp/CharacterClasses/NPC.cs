using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGameApp.CharacterClasses
{
    class NPC : Entity
    {

        Random rand = new Random();

        public NPC() : base()
        { 
            
        }

        public NPC(string name, EntityGender eGender, EntityClass eClass)
            : base()
        {
            Name = name;
            Gender = Gender;
            CharacterClass = eClass;
        }
    }
}
