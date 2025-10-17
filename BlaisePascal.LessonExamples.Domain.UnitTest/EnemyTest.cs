namespace BlaisePascal.LessonExamples.Domain.UnitTest
{
    public class EnemyTest
    {
        [Fact]
        public void EnemyName_WhenTheNameIsValid_TheNameMustBeAssignedCorrectly()
        {

            Enemy newEnemy = new Enemy("Stefano");

            
            Assert.Equal("Stefano", newEnemy.Name);


        }



        [Fact]

        public void EnemyHealth_WhenHealthIsValid_HealthIsAssignedCorrectly()
        {
            Enemy newEnemy = new Enemy("Stefano", 100);

            

            Assert.Equal(100, newEnemy.Health);

        }

        [Fact]

        public void TakeDamge_WhenDamageIsNegative_ShouldThrowArgumentException()
        {
            Enemy newEnemy = new Enemy();

            int damage = -1;

            Assert.Throws<ArgumentException>(() => newEnemy.TakeDamage(damage));

        }

        [Fact]

        public void TakeDamge_WhenDamageIs0_HealthRemainsTheSame()
        {
            Enemy newEnemy = new Enemy();

            newEnemy.TakeDamage(0);

            Assert.Equal(100, newEnemy.Health);

        }

        [Fact]

        public void TakeDamage_WhenDamageIs10_HealthGoesDownTo90()
        {
            Enemy newEnemy = new Enemy();

            newEnemy.TakeDamage(10);

            Assert.Equal(90, newEnemy.Health);

        }

        [Fact]

        public void TakeDamage_WhenDamageIsHigherThanHealth_EnemyDies()
        {
            Enemy newEnemy = new Enemy();

            newEnemy.TakeDamage(101);

            Assert.Equal(0, newEnemy.Health);
            Assert.False(newEnemy.IsAlive);

        }

        

     








    }

}