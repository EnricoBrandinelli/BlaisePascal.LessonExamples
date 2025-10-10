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
            Name = name;
           
        }


        public Enemy(string name, int health)
        {
           Name = name;
            Health = health;
        }

        private void TakeDamage(int damage)
        {

            if (int.IsPositive(damage) && Health - damage > 0)
            {
                Health -= damage;
            }

        }
       


    }

}
