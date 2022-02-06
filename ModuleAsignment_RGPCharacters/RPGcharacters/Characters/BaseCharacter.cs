using ModuleAsignment_RPGcharacters.RPGcharacters.Characters.Attributes;
using ModuleAsignment_RPGcharacters.RPGcharacters.Item;
using ModuleAsignment_RPGcharacters.RPGcharacters.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleAsignment_RPGcharacters.RPGcharacters.Characters
{
    //this class is abstract and contains the common behaviors of an character/hero
    public abstract class BaseCharacter : IBaseCharacter
    {

        public string Name { get; set; }
        public PrimaryAttributes attributes { get; protected set; }
        public int level { get; set; } = 1;
        public PrimaryAttributes attributesGainPerLevel { get; protected set; }
        public SecondaryAttributes characterSecondAttributes { get;  set; }
        public Dictionary<ItemSlot, IArmour> equippedArmour { get; set; } = new Dictionary<ItemSlot, IArmour>();
        public Dictionary<ItemSlot, IWeapon> equippedWeapon { get; set; } = new Dictionary<ItemSlot, IWeapon>();
        public String itemName { get; set; }
        public int itemLevel { get; set; }
        public string validArmourMessage { get; set; }
        public string validWeaponMessage { get; set; }


        //all the character level up, LevelUp will increasse the attributes primary and secundary
        //when the hero/character gain level if a level is invalid like 0 or -1 ,
        //LevelUP will throw an exception


        public void LevelUp()
        {
            if (level < 1)
            {
                throw new Exception();
            }
            attributes.Vitality += attributesGainPerLevel.Vitality;
            //Console.WriteLine($"{ this.Attributes.Vitality}");
            attributes.Strength += attributesGainPerLevel.Strength;
            attributes.Dexterity += attributesGainPerLevel.Dexterity;
            attributes.Intelligence += attributesGainPerLevel.Intelligence;
            level += 1;

            characterSecondAttributes = GetSecondaryAttributes();
        }
        
        //This will calculate character/hero second attributes
        public SecondaryAttributes GetSecondaryAttributes()
        {
           
            
        return new SecondaryAttributes { Health = attributes.Vitality * 10, ArmourRating = attributes.Strength + attributes.Dexterity, ElementalResistance = attributes.Intelligence };
            

        }

        public abstract void EquipArmour(IArmour armour, int itemLevel);
        public abstract void EquipWeapon(IWeapon weapon, int itemLevel);
    }
}

