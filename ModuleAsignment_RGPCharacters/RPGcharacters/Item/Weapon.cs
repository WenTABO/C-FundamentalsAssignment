using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleAsignment_RPGcharacters.RPGcharacters.Item
{
    public class Weapon : IWeapon
    {
        public WeaponType WeaponType { get; set; }
       
        public ItemSlot Slot { get; set; }
    }
}
