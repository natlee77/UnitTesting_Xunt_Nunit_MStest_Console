using ConsoleApp;
using System;
using Xunit;

namespace XUnit_Console.Test
{

    //   LECTION 10_1    --TDD -TEST DRIVEN DEVELOPMENT( TEST FIRST THEN CODE)
    //EnhettsTest(Unit test)--IntegetionTest(flera f. tilsammans)--Början till slut(end to end)E2E
    //RÖD---GRÖN---REFACT     

    public class CalculatorTest
    {                
       // [Fact]1 test, --- inga parametr
              // olika använda[Theory]


        [Theory]
        [InlineData(1, 1, 2)] //test data 
        [InlineData(3, 1, 4)]
        [InlineData(4, 1, 5)]

        public void Add_should_add_value(int value1, int value2, int expected) //should ha parametr        
        {
            var calc = new Calculator();
            int result = calc.Add(value1, value2);
            Assert.Equal(expected, result);
        }

                                                           // arrange -- setapp
                                                           // act -- actual
                                                           // assert
        //[Fact]                                
        //public void Add_ShouldAddValue() 
        //{
        //    var calc = new Calculator();
        //    int actual = calc.Add(2, 2);           // måste göra value/parametr själv
        //    Assert.Equal(4, actual);
        //}


        //[Fact]        
        //public void Add_Person()       // exempl Fact
        //{
        //    var person = new Person();
        //    bool result = person.Create();          
        //    Assert.True( result);
        //}
    }

   
}
