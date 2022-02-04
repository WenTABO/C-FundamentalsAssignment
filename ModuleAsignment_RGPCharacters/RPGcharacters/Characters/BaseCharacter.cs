using ModuleAsignment_RPGcharacters.RPGcharacters.Characters.Attributes;
using ModuleAsignment_RPGcharacters.RPGcharacters.Item;
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
        public PrimaryAttributes Attributes { get; protected set; }
        public int Level { get; private set; } = 1;
        public PrimaryAttributes AttributesGainPerLevel { get; protected set; }
        public SecondaryAttributes CharacterSecondAttributes { get;  set; }
        public Dictionary<ItemSlot, IArmour> EquippedArmour { get; set; } = new Dictionary<ItemSlot, IArmour>();
        public Dictionary<ItemSlot, IWeapon> EquippedWeapon { get; set; } = new Dictionary<ItemSlot, IWeapon>();






        public int levelUp()
        {
            Attributes.Vitality += AttributesGainPerLevel.Vitality;
            //Console.WriteLine($"{ this.Attributes.Vitality}");
            Attributes.Strength += AttributesGainPerLevel.Strength;
            Attributes.Dexterity += AttributesGainPerLevel.Dexterity;
            Attributes.Intelligence += AttributesGainPerLevel.Intelligence;
            return Level += 1;


        }
        
        public SecondaryAttributes GetSecondaryAttributes()
        {
           return new SecondaryAttributes { Health = Attributes.Vitality * 10, ArmourRating = Attributes.Strength * Attributes.Dexterity, ElementalResistance = Attributes.Intelligence };
          
        }

        public abstract void EquipArmour(IArmour armour);
        public abstract void EquipWeapon(IWeapon weapon);
    }
}

