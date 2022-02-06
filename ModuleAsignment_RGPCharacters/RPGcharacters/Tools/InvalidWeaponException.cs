using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleAsignment_RPGcharacters.RPGcharacters.Tools
{
    public class InvalidWeaponException: Exception
    {
        public InvalidWeaponException()
        {
        }
        public InvalidWeaponException(string Message) : base(Message)
        {

        }
        public override string Message => "The Weapon you try to Equip is Invalid for the Character";
    }

}
