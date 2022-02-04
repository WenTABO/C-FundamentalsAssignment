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
        int levelUp();
        void EquipArmour(IArmour armour);
        void EquipWeapon(IWeapon weapon);

    }
}

