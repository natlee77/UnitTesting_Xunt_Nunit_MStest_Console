using ConsoleApp;
using NUnit.Framework;

namespace NUnit_Console.Test
{
    public class Tests  // har olika f. [SetUp], [Test]   // 1.arrange -- setapp
                                                          // 2  act -- actual
                                                          // 3. assert
    {
        private Calculator calc;

         [SetUp]
         public void SetUp()
        {
            calc =new Calculator();
        }

        [Theory]
        [TestCase(1,1,2)]                 // instället [inlinedata]
        [TestCase(22, 1, 23)]
        [TestCase(6, 1, 7)]
        public void Add_ShouldAddToValue(int value1, int value2, int expected)
        {
            //var actual = person.Create();
            //Assert.True(actual);
            Assert.AreEqual(expected, calc.Add( value1,  value2));
        }
    }

    ////private Person person;
    //[SetUp]                           // 1.arrange -- setapp del
    //public void Setup()
    //{
    //    // var calc=new Calculator)(); // det ligger i egna metod [Setup]
    //    //har inte tillgång från [Test] metod-- flytta upp
    //    calc = new Calculator(); 
    ////     person  = new Person();
    //}

    //[Test]                            // 2  act -- actual = [fact]
    //                                  // 3. assert
    //public void Create_ShouldCreatePerson()
    //{
    //    var actual = person.Create();
    //    Assert.True(actual);
    //}
}
