namespace BlaisePascal.LessonExamples.Domain
{
    public class Enemy
    {

        private string _name;
        private string _description;
        private int _health;
        private bool _isAlive;


        //Overloading del costruttore, serve a qualcosa
        public Enemy() { }


        public Enemy(string name)
        {

            SetName(name);
        }


        public Enemy(string name, int health)
        {
            SetName(name);
            SetHealth(health);
        }


        public void SetName(string newName)
        {
            if (newName != null && newName.Trim() != "")
            {

                _name = newName;

            }

        }


        public void SetHealth(int newHealth)
        {
            if (newHealth > 0 && newHealth <= 100)
            {
                _health = newHealth;
            }


        }

        public string GetName() => _name;
        public int GetHealth() => _health;


    }

}
