using challengeApp;
using System.Runtime.CompilerServices;

namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TestOfInt()
        {  //Arrange
            int number1 = 2;
            int number2 = 2;
            // Act
            //Assert
            Assert.AreEqual(number1, number2);
        }
        [Test]
        public void TestOfFloat()
        {  //Arrange
            float number1 = 12345678901234567890;
            float number2 = 12345678901234567890;
            // Act
            //Assert
            Assert.AreEqual(number1, number2);
        }
        [Test]
        public void TestOfString()
        {  //Arrange
            string name1 = "Adam";
            string name2 = "Adam";
            // Act
            //Assert
            Assert.AreEqual(name1, name2);
        }
        [Test]
        public void TestOfTwoEmployees()
        {  //Arrange
            var employee1 = GetEmployee("Adam","Nowak",34);
            var employee2 = GetEmployee("Adam", "Nowak",34);
            // Act
            //Assert
            Assert.AreNotEqual(employee1, employee2);
}
            private Employee GetEmployee(string name, string surname, int age)
            {
                return new Employee(name , surname , age);
            }
        
    }
}

