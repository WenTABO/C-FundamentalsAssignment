using ModuleAsignment_RPGcharacters.RPGcharacters.Item;
using System;

namespace ModuleAsignment_RPGcharacters.RPGcharacters.Characters
{
    class Game
    {
        static void Main(string[] arg)
        {
            var heromage = new MageCharacter { Name = "Per Kristian" };
            Console.WriteLine($"Hi my name is, { heromage.Name}");
            heromage.levelUp();

            heromage.GetSecondaryAttributes();

            var ItemArmour = new Armour { ArmourType = ArmourType.Cloth, Slot = ItemSlot.Body };

            heromage.EquipArmour(ItemArmour);

            var ItemWeapon = new Weapon { WeaponType = WeaponType.Wands, Slot = ItemSlot.Weapon };

            Console.WriteLine();

           
        }

    }
}