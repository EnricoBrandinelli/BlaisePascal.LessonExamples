namespace BlaisePascal.LessonExamples.Domain.UnitTest
{
    public class EnemyTest
    {
        [Fact]
        public void EnemyName_WhenTheNameIsValid_TheNameMustBeAssignedCorrectly()
        {
            //Arrange
            Enemy newEnemy = new Enemy();

            //Act
            newEnemy.SetName("Stefano");

            //Assert
            Assert.Equal("Stefano", newEnemy.Name);


        }

        [Fact]

        public void EnemyName_WhenNameIsNull_NameIsNotAssigned()
        {

            Enemy newEnemy = new Enemy();
            
            Assert.Equal("Stefano", newEnemy.Name);


        }

        [Fact]

        public void EnemyName_WhenNameIsEmpty_NameIsNotAssigned()
        {

            Enemy newEnemy = new Enemy();
            newEnemy.SetName("");
            Assert.Equal("Stefano", newEnemy.Name);


        }

        [Fact]

        public void EnemyName_WhenNameIsOnlySpaces_NameIsNotAssigned()
        {

            Enemy newEnemy = new Enemy();
            newEnemy.SetName("         ");
            Assert.Equal("Stefano", newEnemy.Name);


        }


        [Fact]

        public void EnemyHealth_WhenHealthIsValid_HealthIsAssignedCorrectly()
        {
            Enemy newEnemy = new Enemy();

            newEnemy.SetHealth(100);

            Assert.Equal(100, newEnemy.Health);

        }


        [Fact]

        public void EnemyHealth_WhenHealthIsNegative_HealthIsNotAssigned()
        {
            Enemy newEnemy = new Enemy();

            newEnemy.SetHealth(-1);

            Assert.Equal(100, newEnemy.Health);

        }


        [Fact]

        public void EnemyHealth_WhenHealthIsOver100_HealthIsNotAssigned()
        {
            Enemy newEnemy = new Enemy();

            newEnemy.SetHealth(101);

            Assert.Equal(100, newEnemy.Health);

        }   

        [Fact]

        public void TakeDamge_WhenDamageIs0_HealthRemainsTheSame()
        {
            Enemy newEnemy = new Enemy();

            newEnemy.TakeDamage(0);

            Assert.Equal(100, newEnemy.Health);

        }

        [Fact]

        public void TakeDamge_WhenDamageIs10_HealthGoesDownTo90()
        {
            Enemy newEnemy = new Enemy();

            newEnemy.TakeDamage(10);

            Assert.Equal(90, newEnemy.Health);

        }

        [Fact]

        public void TakeDamge_WhenDamageIsHigherThanHealth_EnemyDies()
        {
            Enemy newEnemy = new Enemy();

            newEnemy.TakeDamage(101);

            Assert.Equal(0, newEnemy.Health);
            Assert.False(newEnemy.IsAlive);

        }

     








    }

}