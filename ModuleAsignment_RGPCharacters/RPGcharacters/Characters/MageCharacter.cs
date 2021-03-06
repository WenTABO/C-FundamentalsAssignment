using ModuleAsignment_RPGcharacters.RPGcharacters.Item;
using ModuleAsignment_RPGcharacters.RPGcharacters.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleAsignment_RPGcharacters.RPGcharacters.Characters
{
    public class MageCharacter : BaseCharacter
    {

        public MageCharacter()
        {
            attributes = new PrimaryAttributes { Vitality = 5, Strength = 1, Dexterity = 1, Intelligence = 8, };
            attributesGainPerLevel = new PrimaryAttributes { Vitality = 3, Strength = 1, Dexterity = 1, Intelligence = 5, };
            characterSecondAttributes = GetSecondaryAttributes();
            
            
        }
        public override void EquipArmour (IArmour armour, int equipmentLevel)
        {
            if (equipmentLevel != 1)

                throw new Exception();

            if (armour.ArmourType != ArmourType.Cloth)
            {
                throw new InvalidArmourException();
            }
            equippedArmour[armour.Slot] = armour;
            validArmourMessage = "New Armour equipped";
            Console.WriteLine($"{ validArmourMessage}");
        }

        public override void EquipWeapon(IWeapon weapon, int itemLevel)
        {
            if (itemLevel != 1)
            {
                throw new Exception();
            }
            if (((weapon.weaponType) !=  WeaponType.Staffs && ((weapon.weaponType) != WeaponType.Wands))) 
            {


                throw new InvalidWeaponException();

            }

            equippedWeapon[weapon.Slot] = weapon;
            validWeaponMessage =  "New Weapon equipped";
            Console.WriteLine($"{ validWeaponMessage}");

        }

    }



}
