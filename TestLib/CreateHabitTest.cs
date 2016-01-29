using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestLib
{
    public class CreateHabitTest
    {
        [Test]
        public void IfHabitNameIsNull_ThrowNullReferenceException()
        {
            Assert.Throws<ArgumentNullException>(() => new Habit(null));
        }

        [Test]
        public void IfHabitNameLengthLessThanTwoSymbols_ThrowNullReferenceException()
        {
            Assert.Throws<ArgumentException>(() => new Habit("a"));
        }

        [Test]
        public void IfHabitCreate_Success_DoesNotThrow()
        {
            Assert.DoesNotThrow(() => new Habit("My habit"));
        }

        [Test]
        public void IfHabitCreate_NameStartsHabit()
        {
            var habit = new Habit("My habit");
            Assert.True(habit.Name.StartsWith("Habit:"));
        }
    }
}
