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
            

            //Console.WriteLine(); 
        }

    }
}