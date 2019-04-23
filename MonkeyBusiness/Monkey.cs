using System;
using System.Collections.Generic;
using System.Text;

namespace MonkeyBusiness
{
    public class Monkey
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        private const int UpperAgeLimit = 50;
        private const int LowerAgeLimit = 0;
        private List<string> favouriteFoods;


        private MonkeyAgeBrackets GetAgeBracket()
        {
            if (Age > 60)
            {
                return MonkeyAgeBrackets.Senior;
            }
            else if (Age > 18)
            {
                return MonkeyAgeBrackets.Adult;
            }
            else
            {
                return MonkeyAgeBrackets.Child;
            }
        }
        public string FavouriteFood { get; }

        public void AddFavouriteFood(string food)
        {
            favouriteFoods.Add(food.ToLowerInvariant());
        }

        public void RemoveFavouriteFood(string food)
        {
            if (food.Trim().ToLowerInvariant() != "banana")
            {
                favouriteFoods.RemoveAll(x => x.ToLowerInvariant().Trim() == food);
            }
        }

        public bool IsFavouriteFood(string food)
        {
            return favouriteFoods.Contains(food.ToLowerInvariant());
        }

        private enum MonkeyAgeBrackets
        {
            Child,
            Adult,
            Senior,
        }
        
        public void JumpAround()
        {
            Console.WriteLine($"{Name} jumps around!");
        }

        public void Dance()
        {
            Console.WriteLine($"{Name} dances like... a monkey!");
        }

        public Monkey(string monkeyName, int monkeyAge)
        {
            if (String.IsNullOrWhiteSpace(monkeyName))
            {
                throw new ArgumentException("A monkey must have a name.");
            }
            else
            {
                this.Name = monkeyName;
            }

            if (monkeyAge < LowerAgeLimit)
            {
                throw new ArgumentOutOfRangeException($"A monkey's age cannot be less than {LowerAgeLimit}.");
            }
            else if (monkeyAge > UpperAgeLimit)
            {
                throw new ArgumentOutOfRangeException($"A monkey's age cannot be greater than {UpperAgeLimit}");
            }
            else
            {
                this.Age = monkeyAge;
            }

            this.favouriteFoods = new List<string>();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
