using System;

namespace TestLib
{
    internal class Habit
    {
        public string Name { get; set; }

        public static string HabitPrefix
        {
            get
            {
                return "Habit:";
            }
        }

        public Habit(string name)
        {
            if (name == null) throw new ArgumentNullException();
            if (name.Length < 2) throw new ArgumentException();

            this.Name = string.Concat(HabitPrefix, name);
        }
    }
}