using System;
using AllWorlds.Classes;
using static AllWorlds.Classes.Actor;

namespace AllWorlds
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Race = Actor.races.elf; // Directly set the Race property
            Console.WriteLine(player.Race); // Directly access the Race property
            player.Gender = Actor.genders.male;
            Console.WriteLine(player.Gender);

            Shadow shadow, shadow2, shadow3, shadow4;
            shadow = new Shadow("buff1", 20, 5, 100);
            shadow2 = new Shadow("buff2", 50, 5, 100);
            shadow3 = new Shadow("buff3", 40, 5, 100);
            shadow4 = new Shadow("buff4", 30, 5, 100);

            shadow.GetProperties();
            player.AddShadow(shadow);
            player.AddShadow(shadow2);
            player.AddShadow(shadow3);
            player.AddShadow(shadow4);

            player.GetShadows();

            // Example of setting a property with validation
            player.Name = "Player1"; // Valid name
            Console.WriteLine(player.Name);

            // Set the Psi attribute using the new method
            player.SetAttribute(CharacterAttributes.Psi, -10); // Will be clamped to 0

            // Get the Psi attribute using the new method
            int psiValue = player.GetAttribute(CharacterAttributes.Psi);
            Console.WriteLine(psiValue);

            Console.ReadKey();
        }
    }
}