using ModuleAsignment_RPGcharacters.RPGcharacters.Item;
using ModuleAsignment_RPGcharacters.RPGcharacters.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleAsignment_RPGcharacters.RPGcharacters.Characters
{
    public class WarriorCharacter : BaseCharacter
    {


        public WarriorCharacter()
        {
            attributes = new PrimaryAttributes { Vitality = 10, Strength = 5, Dexterity = 2, Intelligence = 1, };
            attributesGainPerLevel = new PrimaryAttributes { Vitality = 5, Strength = 3, Dexterity = 2, Intelligence = 1, };
            characterSecondAttributes = GetSecondaryAttributes();


        }
        public override void EquipArmour(IArmour armour, int itemLevel)
        {

            if (armour.ArmourType != ArmourType.Plate && ((armour.ArmourType) != ArmourType.Mail))
            {
                throw new InvalidArmourException();
            }
            equippedArmour[armour.Slot] = armour;
            validArmourMessage = "New Armour equipped";
            Console.WriteLine($"{ validArmourMessage}");
        }

        public override void EquipWeapon(IWeapon weapon, int itemLevel)
        {
            if (((weapon.weaponType) != WeaponType.Axes && ((weapon.weaponType) != WeaponType.Hammers)) && ((weapon.weaponType) != WeaponType.Swords))
            {


                throw new InvalidWeaponException();

            }

            equippedWeapon[weapon.Slot] = weapon;
            validWeaponMessage = "New Weapon equipped";
            Console.WriteLine($"{ validWeaponMessage}");

        }

    }



}



