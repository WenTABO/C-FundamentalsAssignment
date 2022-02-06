using ModuleAsignment_RPGcharacters.RPGcharacters.Item;
using ModuleAsignment_RPGcharacters.RPGcharacters.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleAsignment_RPGcharacters.RPGcharacters.Characters
{
    public class RogueCharacter: BaseCharacter
    {
        public RogueCharacter()
        {
            attributes = new PrimaryAttributes { Vitality = 8, Strength = 2, Dexterity = 6, Intelligence = 1, };
            attributesGainPerLevel = new PrimaryAttributes { Vitality = 3, Strength = 1, Dexterity = 4, Intelligence = 1, };
            characterSecondAttributes = GetSecondaryAttributes();


        }
        public override void EquipArmour(IArmour armour, int itemLevel)
        {

            if (armour.ArmourType != ArmourType.Leather && ((armour.ArmourType) != ArmourType.Mail))
            {
                throw new InvalidArmourException();
            }
            equippedArmour[armour.Slot] = armour;
            validArmourMessage = "New Armour equipped";
            Console.WriteLine($"{ validArmourMessage}");
        }

        public override void EquipWeapon(IWeapon weapon, int itemLevel)
        {
            if (((weapon.weaponType) != WeaponType.Daggers && ((weapon.weaponType) != WeaponType.Swords)))
            {


                throw new InvalidWeaponException();

            }

            equippedWeapon[weapon.Slot] = weapon;
            validWeaponMessage = "New Weapon equipped";
            Console.WriteLine($"{ validWeaponMessage}");

        }

    }
}
