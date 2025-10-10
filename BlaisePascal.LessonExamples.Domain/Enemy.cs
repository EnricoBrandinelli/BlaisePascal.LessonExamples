namespace BlaisePascal.LessonExamples.Domain
{
    public class Enemy
    {


        public int Health { get; private set; }
        public string Name { get; private set; } 
        public string Description { get; private set; }

        public bool isAlive { get; private set; }
        

        //Overloading del costruttore, serve a qualcosa
        public Enemy() 
        {

            Name = "Stefano";
            Health = 100;
            
        }


        public Enemy(string name)
        {
            SetName(name);
           
        }


        public Enemy(string name, int health)
        {
            SetName(name);
            SetHealth(health);
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
            if (!string.IsNullOrWhiteSpace(newName))
            {
                Name = newName;
            }

        }
        private void TakeDamage(int damage)
        {

            if (int.IsPositive(damage))
            {
                //Health = Math.Max(0, Health - damage);
                Health -= damage;
                 
            }
            if(Health <= 0)
            {
                isAlive = false;
            }
            else
            {
                isAlive = true;
            }
        }
       


    }

}
