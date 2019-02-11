using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;


namespace CustomListUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_ListValues_ReturnsNewListCount()
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
        public void Add_StringValues_ReturnsCountWithString()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            string value = "good"; //the number being added to the array
            int expectedResult = 1; //the amount of myList.Count that is expected

            //Act
            myList.Add(value);

            //Assert
            Assert.AreEqual(expectedResult, myList.Count);
        }

        [TestMethod]
        public void Add_MulitpleListValues_ReturnsLargerListCount()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 3; //the number being added to the array
            int valueTwo = 7; //second int added to array
            int valueThree = 5;
            int expectedResult = 3; //the amount of myList.Count that is expected

            //Act
            myList.Add(value);
            myList.Add(valueTwo);
            myList.Add(valueThree);
            //Assert
            Assert.AreEqual(expectedResult, myList.Count);
        }
        [TestMethod]
        public void Remove_Item_ReturnsListCountMinusOne()
        {
            CustomList<int> myList = new CustomList<int>(); //can't make list with values assigned
            int value = 3;
            int valueTwo = 7;
            int valueThree = 12;
            int expectedResult = 2;

            myList.Add(value);
            myList.Add(valueTwo);
            myList.Add(valueThree);
            myList.Remove(3);

            Assert.AreEqual(expectedResult, myList.Count);
            
        }



        [TestMethod]
        public void Indexer_IndexZero_ReturnsValueOfIndexZero()
        {
            //Arrange 
            CustomList<int> myList = new CustomList<int>();
            int value = 3; //number being added to array
            int expectedResult = 3; //number or value you expect to be at index[0]

            myList.Add(value);

            Assert.AreEqual(expectedResult, myList[0]);
        }

        [TestMethod]
        public void Indexer_IndexOne_ReturnsValueOfIndexOne()
        {
            //Arrange 
            CustomList<int> myList = new CustomList<int>();
            int value = 3; //number being added to array
            int otherValue = 5; //another number being added to the array
            int expectedResult = 5;

            myList.Add(value);
            myList.Add(otherValue);

            Assert.AreEqual(expectedResult, myList[1]);
        }

        [TestMethod]
        public void Indexer_IndexFive_ReturnsValueOfIndexFive()
        {
            //Arrange 
            CustomList<int> myList = new CustomList<int>();
            int value = 3; //number being added to array
            int otherValue = 5; //another number being added to the array
            int valueThree = 27;
            int valueFour = 74;
            int valueFive = 88;
            int valueSix = 12;
            int expectedResult = 12;

            myList.Add(value);
            myList.Add(otherValue);
            myList.Add(valueThree);
            myList.Add(valueFour);
            myList.Add(valueFive);
            myList.Add(valueSix);
           
            Assert.AreEqual(expectedResult, myList[5]);
        }

        [TestMethod]
        public void Indexer_LastIndexOfList_ReturnsValueOfLastIndex()
        {
            
            CustomList<int> myList = new CustomList<int>();
            int value = 3; //number being added to array
            int expectedResult = 3;

            myList.Add(value);

            Assert.AreEqual(expectedResult, myList[myList.Count - 1]);
        }
       
    }
}
