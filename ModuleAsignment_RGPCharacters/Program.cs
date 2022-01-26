using System;

namespace ModuleAsignment_RPGcharacters.RPGcharacters.Characters
{
    class Game
    {
        static void main(string[] args)
        {
            var heroMage = new MageCharacter { Name = "PK" };
            Console.WriteLine("hello, I am a hero and my name is ", heroMage);
        }

    }
}