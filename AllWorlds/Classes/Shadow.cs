using System;

namespace AllWorlds.Classes
{
    public class Shadow
    {
        public enum tags { Buff, Debuff, HoT, Skill }

        private string name;
        private int level;
        private int bonus;
        private int duration;

        public string Name
        {
            get => name;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Name cannot be empty.");
                }
            }
        }

        public int Level
        {
            get => level;
            set => level = Math.Max(0, value);
        }

        public int Bonus
        {
            get => bonus;
            set => bonus = Math.Max(0, value);
        }

        public int Duration
        {
            get => duration;
            set => duration = Math.Max(0, value);
        }

        public Shadow(string _name, int _level, int _bonus, int _duration)
        {
            Name = _name;
            Level = _level;
            Bonus = _bonus;
            Duration = _duration;
        }

        public void GetProperties()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Level);
            Console.WriteLine(Bonus);
            Console.WriteLine(Duration);
        }
    }
}