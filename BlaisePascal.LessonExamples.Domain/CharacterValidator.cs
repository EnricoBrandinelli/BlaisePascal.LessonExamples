using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlaisePascal.LessonExamples.Domain
{
    public static class CharacterValidator
    {

        public const int MaxHealth = 100;

        public const int MinHealth = 0;
        public static string ValidateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name.Trim()))
                throw new ArgumentException("Name cannot be null or empty");
            
            return name;

        }

        //TO DO: Add ValidateHealth method

        public static int ValidateHealth(int health)
        {

            if (health < MinHealth || health > MaxHealth)
                throw new ArgumentException("Health cannot be lower than MinHealth or higher than MaxHealth");

            return health;
        }

        //Commit
    }
}
