using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleAsignment_RPGcharacters.RPGcharacters.Item
{
    public class Weapon : IWeapon
    {
        //public WeaponType Weapontype { get; set; }
        public WeaponType WeaponType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ItemSlot Slot { get; set; }
    }
}
