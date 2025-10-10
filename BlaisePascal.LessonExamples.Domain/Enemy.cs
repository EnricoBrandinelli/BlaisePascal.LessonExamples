namespace BlaisePascal.LessonExamples.Domain
{
    public class Enemy
    {


        public int Health { get; private set; }
        public string Name { get; private set; } 
        public string Description { get; private set; }

        public bool IsAlive { get; private set; }
        

        //Overloading del costruttore, serve a qualcosa
        public Enemy() 
        {

            Name = "Stefano";
            Health = 100;
            IsAlive = true;
        }


        public Enemy(string name, bool isAlive)
        {
            SetName(name);
           IsAlive = isAlive;
        }


        public Enemy(string name, int health, bool isAlive)
        {
            SetName(name);
            SetHealth(health);
            IsAlive = isAlive;
        }

        private void SetHealth(int newHealth)
        {
            if (int.IsPositive(newHealth) && newHealth <= 100)
            {
                Health = newHealth;
            }
        }

        private void SetName(string newName)
        {
            if (!string.IsNullOrWhiteSpace(newName.Trim()))
            {
                Name = newName;
            }

        }
        private void TakeDamage(int damage)
        {
            if (int.IsNegative(damage))
                throw new ArgumentOutOfRangeException("Damage cannot be negative");

            if (damage < Health && IsAlive == true)
            {
                Health -= damage;
            }
            else 
            {
                Health = 0;
                IsAlive = false;
            }
            
        }
       


    }

}
