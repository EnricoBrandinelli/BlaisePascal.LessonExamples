using System.Xml.Linq;

namespace BlaisePascal.LessonExamples.Domain
{
    public class Enemy
    {


        public int Health { get; private set; }
        public string Name { get; private set; } 
        public string Description { get; private set; }

        public bool IsAlive => Health > 0;

       

        //Overloading del costruttore, serve a qualcosa
        public Enemy() 
        {

            Name = "Stefano";
            Health = 100;
        }


        public Enemy(string name)
        {
            Name = CharacterValidator.ValidateName(name);


        }


        public Enemy(string name, int health)
        {
            Name = CharacterValidator.ValidateName(name);
            Health = CharacterValidator.ValidateHealth(health);
            
        }

        public void SetHealth(int newHealth)
        {
            Health = CharacterValidator.ValidateHealth(newHealth);

        }

        public void ReName(string newName)
        {
            Name = CharacterValidator.ValidateName(newName);

        }
        public void TakeDamage(int damage)
        {
            if (damage < 0)
                throw new ArgumentException("Damage cannot be negative");

            Health = Math.Max(Health - damage, CharacterValidator.MinHealth);           
        }

        public void Heal(int amount)
        {
            if (amount < 0 || IsAlive == false)
                throw new ArgumentException("Enemy cannot be healed");

            Health = Math.Min(Health + amount, CharacterValidator.MaxHealth);
        }
       

        //Commit
    }

}
