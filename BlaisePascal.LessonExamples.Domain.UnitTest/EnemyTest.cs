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
            Assert.Equal("Stefano", newEnemy.GetName());


        }

        [Fact]

        public void EnemyName_WhenNameIsNull_NameIsNotAssigned()
        {

            Enemy newEnemy = new Enemy(null);

            Assert.Equal(null, newEnemy.GetName());


        }

        [Fact]

        public void EnemyName_WhenNameIsEmpty_NameIsNotAssigned()
        {

            Enemy newEnemy = new Enemy("");

            Assert.Equal(null, newEnemy.GetName());


        }

        [Fact]

        public void EnemyName_WhenNameIsOnlySpaces_NameIsNotAssigned()
        {

            Enemy newEnemy = new Enemy("        ");

            Assert.Equal(null, newEnemy.GetName());


        }


        [Fact]

        public void EnemyHealth_WhenHealthIsValid_HealthIsAssignedCorrectly()
        {
            Enemy newEnemy = new Enemy();

            newEnemy.SetHealth(100);

            Assert.Equal(100, newEnemy.GetHealth());

        }


        [Fact]

        public void EnemyHealth_WhenHealthIsNegative_HealthIsNotAssigned()
        {
            Enemy newEnemy = new Enemy();

            newEnemy.SetHealth(-1);

            Assert.Equal(100, newEnemy.GetHealth());

        }


        [Fact]

        public void EnemyHealth_WhenHealthIsOver100_HealthIsNotAssigned()
        {
            Enemy newEnemy = new Enemy();

            newEnemy.SetHealth(101);

            Assert.Equal(100, newEnemy.GetHealth());

        }

        [Fact]

        public void EnemyHealth_WhenHealthIsZero_HealthIsNotAssigned()
        {
            Enemy newEnemy = new Enemy();

            newEnemy.SetHealth(0);

            Assert.Equal(100, newEnemy.GetHealth());

        }


    }

}