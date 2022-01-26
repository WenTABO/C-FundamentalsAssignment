using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleAsignment_RPGcharacters.RPGcharacters.Characters
{
    public abstract class BaseCharacter : IBaseCharacter
    {

        public string Name { get; set; }
        public PrimaryAttributes Attributes {get; protected set;}
        public int Level { get; set; } = 1;
        public PrimaryAttributes AttributesGainPerLevel { get;protected set; }

      
        public void levelUp()
        {
            Attributes.Vitality += AttributesGainPerLevel.Vitality;
            Attributes.Strength += AttributesGainPerLevel.Strength;
            Attributes.Dexterity += AttributesGainPerLevel.Dexterity;
            Attributes.Intelligence += AttributesGainPerLevel.Intelligence;
            
        
        }
     }
}
