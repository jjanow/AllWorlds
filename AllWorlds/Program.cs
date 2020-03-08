using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllWorlds.Classes;

namespace AllWorlds
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player;
            player = new Player();

            player.SetRace(Actor.races.elf);
            Console.WriteLine(player.GetRace());

            player.SetGender(Actor.genders.male);
            Console.WriteLine(player.GetGender());

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

            Console.ReadKey();
        }
    }
}