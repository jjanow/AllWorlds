using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllWorlds.Classes
{
    class Shadow
    {
        public enum tags
        {
            Buff,
            Debuff,
            HoT,
            Skill
        }

        private string name;
        private int level;
        private int bonus;
        private int duration;

        public Shadow(string _name, int _level, int _bonus, int _duration)
        {
            name = _name;
            level = _level;
            bonus = _bonus;
            duration = _duration;
        }

        public string GetName()
        {
            return name;
        }

        public int GetLevel()
        {
            return level;
        }

        public int GetBonus()
        {
            return bonus;
        }

        public int GetDuration()
        {
            return duration;
        }

        public void GetProperties()
        {
            Console.WriteLine(name);
            Console.WriteLine(level);
            Console.WriteLine(bonus);
            Console.WriteLine(duration);
        }
    }
}
