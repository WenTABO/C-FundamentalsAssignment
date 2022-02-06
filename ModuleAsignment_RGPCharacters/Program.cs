using ModuleAsignment_RPGcharacters.RPGcharacters.Item;
using System;

namespace ModuleAsignment_RPGcharacters.RPGcharacters.Characters
{
    class Game
    {
        static void Main(string[] arg)
        {
            var heromage = new MageCharacter { Name = "Per Kristian" };
            var itemLevel = 1;
            Console.WriteLine($"Hi my name is, { heromage.Name}");
            heromage.LevelUp();

            heromage.GetSecondaryAttributes();

            var ItemArmour = new Armour { ArmourType = ArmourType.Cloth, Slot = ItemSlot.Body };

            heromage.EquipArmour(ItemArmour, itemLevel);

            var ItemWeapon = new Weapon { weaponType = WeaponType.Wands, Slot = ItemSlot.Weapon };

            heromage.EquipWeapon(ItemWeapon, itemLevel);

            Console.WriteLine();

           
        }

    }
}