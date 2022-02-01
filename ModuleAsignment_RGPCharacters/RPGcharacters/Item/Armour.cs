using ModuleAsignment_RPGcharacters.RPGcharacters.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleAsignment_RPGcharacters.RPGcharacters.Item
{
    public class Armour : IArmour
    {
        public ArmourType ArmourType { get; set; }
        public ItemSlot Slot { get; set; }
    }
}
