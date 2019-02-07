using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;


namespace CustomListUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 3; //the number being added to the array
            int expectedResult = 1; //the amount of myList.Count that is expected

            //Act
            myList.Add(value);

            //Assert
            Assert.AreEqual(expectedResult, myList.Count);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange 
            CustomList<int> myList = new CustomList<int>();

        }
    }
}
