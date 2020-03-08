using System;
using System.Collections.Generic;
namespace AllWorlds.Classes
{
    class Actor
    {
        public enum races
        {
            human,
            elf,
            dwarf,
            troll,
            halfling,
            gnome
        }
        public enum genders
        {
            male,
            female,
            other,
            none
        }

        private string name;
        private int strength;
        private int dexterity;
        private int intelligence;
        private int willpower;
        private int speed;
        private int vitality;
        private int hp;
        private int sp;
        private int psi;
        private races race;
        private genders gender;
        private List<Shadow> shadows = new List<Shadow>();

        public void AddShadow(Shadow shadow)
        {
            shadows.Add(shadow);
        }

        public void GetShadows()
        {
            foreach (Shadow sh in shadows )
            {
                Console.WriteLine(sh.GetName());
            }
        }

        public void SetRace(Actor.races newRace)
        {
            race = newRace;
        }

        public string GetRace()
        {
            return race.ToString();
        }

        public void SetGender(Actor.genders newGender)
        {
            gender = newGender;
        }

        public string GetGender()
        {
            return gender.ToString();
        }
    }
}
