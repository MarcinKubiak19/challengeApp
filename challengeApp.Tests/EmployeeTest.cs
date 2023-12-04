using challengeApp;

namespace ChallengeApp.Tests
{
    public class Tests
    {

        [Test]
        public void CheckingAddScoreOperation()
        {
            var employee = new Employee("Adam", "Nowak", 34);
            employee.AddScore(5);
            employee.AddScore(6);
            employee.AddScore(-12);
            var result = employee.Result;

            Assert.AreEqual(-1, result);
        }
    }
}