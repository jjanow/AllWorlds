using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AllWorlds.Classes
{
    public class Actor
    {
        public enum races { human, elf, dwarf, troll, halfling, gnome }
        public enum genders { male, female, other, none }

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

        public string Name
        {
            get => name;
            set
            {
                if (Regex.IsMatch(value, @"^[a-zA-Z0-9]+$"))
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Name must contain only alphanumeric characters.");
                }
            }
        }

        public int Strength { get => strength; set => strength = Math.Max(0, value); }
        public int Dexterity { get => dexterity; set => dexterity = Math.Max(0, value); }
        public int Intelligence { get => intelligence; set => intelligence = Math.Max(0, value); }
        public int Willpower { get => willpower; set => willpower = Math.Max(0, value); }
        public int Speed { get => speed; set => speed = Math.Max(0, value); }
        public int Vitality { get => vitality; set => vitality = Math.Max(0, value); }
        public int HP { get => hp; set => hp = Math.Max(0, value); }
        public int SP { get => sp; set => sp = Math.Max(0, value); }
        public int Psi { get => psi; set => psi = Math.Max(0, value); }
        public races Race { get => race; set => race = value; }
        public genders Gender { get => gender; set => gender = value; }

        public void AddShadow(Shadow shadow)
        {
            shadows.Add(shadow);
        }

        public void GetShadows()
        {
            foreach (Shadow sh in shadows)
            {
                Console.WriteLine(sh.GetName());
            }
        }
    }
}
