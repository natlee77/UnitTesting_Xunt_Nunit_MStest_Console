using ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTest
{
    [TestClass]
    public class CalculatorTest
    {

        // med parametr
        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2, 2, 4)]
        public void Add_Value(int value1, int value2, int expected)
        {
            var calc = new Calculator();
            Assert.AreEqual(expected, calc.Add(value1, value2));
        }
        // exempl Fact
        //{
        //    var person = new Person();
        //    bool result = person.Create();          
        //    Assert.True( result);
        //}

        //[TestMethod]  // som Fact  utan parametr 
        //public void Create_Person()       // exempl Fact
        //{
        //    var person = new Person();
        //    bool result = person.Create();
        //    Assert.IsTrue(result);
        //}
    }
}
