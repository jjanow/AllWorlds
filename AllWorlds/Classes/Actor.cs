using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AllWorlds.Classes
{
    public class Actor
    {
        public enum races { human, elf, dwarf, troll, halfling, gnome }
        public enum genders { male, female, other, none }
        public enum CharacterAttributes
        {
            Strength,
            Dexterity,
            Intelligence,
            Willpower,
            Speed,
            Vitality,
            HP,
            SP,
            Psi
        }

        private string name;
        private Dictionary<CharacterAttributes, int> attributes = new Dictionary<CharacterAttributes, int>();
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


        public races Race { get => race; set => race = value; }
        public genders Gender { get => gender; set => gender = value; }

        public int GetAttribute(CharacterAttributes attribute)
        {
            return attributes.TryGetValue(attribute, out int value) ? value : 0;
        }

        public void SetAttribute(CharacterAttributes attribute, int value)
        {
            if (value >= 0)
            {
                attributes[attribute] = value;
            }
            else
            {
                Console.WriteLine($"{attribute} cannot be negative.");
            }
        }

        public void AddShadow(Shadow shadow)
        {
            shadows.Add(shadow);
        }

        public void GetShadows()
        {
            foreach (Shadow sh in shadows)
            {
                Console.WriteLine(sh.Name); // Use the Name property instead of GetName method
            }
        }

        public bool ContainsShadow(Shadow shadow)
        {
            return shadows.Contains(shadow);
        }
    }
}