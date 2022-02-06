using ModuleAsignment_RPGcharacters.RPGcharacters.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleAsignment_RPGcharacters.RPGcharacters.Characters
{
    public interface IBaseCharacter 
    {
        void LevelUp();
        void EquipArmour(IArmour armour, int itemLevel);
        void EquipWeapon(IWeapon weapon, int itemLevel);
        

    }
}

