using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleAsignment_RPGcharacters.RPGcharacters.Tools
{
    public class InvalidArmourException : Exception
    {
        public InvalidArmourException()
        {
        }
        public InvalidArmourException(string Message) : base(Message)
        {

        }
        public override string Message => "The Armour you try to Equip is Invalid for the Character";
    }
}
