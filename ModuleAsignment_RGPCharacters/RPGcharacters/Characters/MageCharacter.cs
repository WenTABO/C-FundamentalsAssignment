using ModuleAsignment_RPGcharacters.RPGcharacters.Item;
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
            Attributes = new PrimaryAttributes { Vitality = 5, Strength = 1, Dexterity = 1, Intelligence = 8, };
            AttributesGainPerLevel = new PrimaryAttributes { Vitality = 3, Strength = 1, Dexterity = 1, Intelligence = 5, };
            CharacterSecondAttributes = GetSecondaryAttributes();
            
            Console.WriteLine();
        }
        public override void EquipArmour (IArmour armour)
        {

            if (armour.ArmourType != ArmourType.Cloth)
            {
                throw new Exception();
            }
            EquippedArmour[armour.Slot] = armour;
        }

        public override void EquipWeapon(IWeapon weapon)
        {
            if (weapon.WeaponType != WeaponType.Staffs)
            {

                throw new Exception();
            }
            else if (weapon.WeaponType != WeaponType.Wands)
            {
                throw new Exception();
            }

            else
            {
                EquippedWeapon[weapon.Slot] = weapon;
            }
           
        }

    }



}
