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
        public void Add_ItemsGreaterThanCapacity_ReturnsListCount()
        {
            CustomList<int> myList = new CustomList<int>(); //can't make list with values assigned
            int value = 3;
            int valueTwo = 7;
            int valueThree = 12;
            int valueFour = 60;
            int valueFive = 34;
            int valueSix = 5;
            int valueSeven = 22;
            int expectedResult = 7;

            myList.Add(value);
            myList.Add(valueTwo);
            myList.Add(valueThree);
            myList.Add(valueFour);
            myList.Add(valueFive);
            myList.Add(valueSix);
            myList.Add(valueSeven);


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
        public void Remove_Item_ReturnsValueOfIndexOneAtIndexZero()
        {
            CustomList<int> myList = new CustomList<int>(); //can't make list with values assigned
            int value = 3;
            int valueTwo = 7;
            int valueThree = 12;
            int expectedResult = 7;

            myList.Add(value);
            myList.Add(valueTwo);
            myList.Add(valueThree);
            myList.Remove(3);

            Assert.AreEqual(expectedResult, myList[0]);

        }

        [TestMethod]
        public void Remove_Item_ReturnsListCountMinusTwo()
        {
            CustomList<int> myList = new CustomList<int>(); //can't make list with values assigned
            int value = 3;
            int valueTwo = 7;
            int valueThree = 12;
            int expectedResult = 1;

            myList.Add(value);
            myList.Add(valueTwo);
            myList.Add(valueThree);
            myList.Remove(3);
            myList.Remove(7);

            Assert.AreEqual(expectedResult, myList.Count);

        }
        [TestMethod]
        public void Remove_ItemInMiddleOfArray_ReturnsListCountOfTwo()
        {
            CustomList<int> myList = new CustomList<int>(); //can't make list with values assigned
            int value = 3;
            int valueTwo = 7;
            int valueThree = 12;
            int expectedResult = 2;

            myList.Add(value);
            myList.Add(valueTwo);
            myList.Add(valueThree);
            myList.Remove(7);

            Assert.AreEqual(expectedResult, myList.Count);

        }
        [TestMethod]
        public void Remove_ItemInMiddleOfArray_ReturnsIndexOne()
        {
            CustomList<int> myList = new CustomList<int>(); //can't make list with values assigned
            int value = 3;
            int valueTwo = 7;
            int valueThree = 12;
            int expectedResult = 12;

            myList.Add(value);
            myList.Add(valueTwo);
            myList.Add(valueThree);
            myList.Remove(7);

            Assert.AreEqual(expectedResult, myList[1]);

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
        [TestMethod]
        public void Indexer_ItemsGreaterThanCapacity_ReturnsMiddleIndex()
        {
            CustomList<int> myList = new CustomList<int>(); //can't make list with values assigned
            int value = 3;
            int valueTwo = 7;
            int valueThree = 12;
            int valueFour = 60;
            int valueFive = 34;
            int valueSix = 5;
            int valueSeven = 22;
            int expectedResult = 34;

            myList.Add(value);
            myList.Add(valueTwo);
            myList.Add(valueThree);
            myList.Add(valueFour);
            myList.Add(valueFive);
            myList.Add(valueSix);
            myList.Add(valueSeven);

            Assert.AreEqual(expectedResult, myList[4]);

        }
        [TestMethod]
        public void ToString_myList_ReturnsListAsString()
        {
            CustomList<int> myList = new CustomList<int>(); //can't make list with values assigned
            int value = 3;
            int valueTwo = 7;
            int valueThree = 12;
            int valueFour = 60;
            string expectedResult = "371260";

            myList.Add(value);
            myList.Add(valueTwo);
            myList.Add(valueThree);
            myList.Add(valueFour);
           
            Assert.AreEqual(expectedResult, myList.ToString());

        }
        [TestMethod]
        public void ToString_myList_ReturnsStringWithThreeValues()
        {
            CustomList<int> myList = new CustomList<int>(); 
            int value = 3;
            int valueTwo = 7;
            int valueThree = 12;           
            string expectedResult = "3712";

            myList.Add(value);
            myList.Add(valueTwo);
            myList.Add(valueThree);
            
            Assert.AreEqual(expectedResult, myList.ToString());

        }
        [TestMethod]
        public void ToString_myList_ReturnsListAsStringWithLetters()
        {
            CustomList<string> myList = new CustomList<string>(); 
            string value = "A";
            string valueTwo = "B";
            string valueThree = "C";
            string valueFour = "D";
            string expectedResult = "ABCD";

            myList.Add(value);
            myList.Add(valueTwo);
            myList.Add(valueThree);
            myList.Add(valueFour);

            Assert.AreEqual(expectedResult, myList.ToString());
        }
        [TestMethod]
        public void AddOverLoad_TwoCustomLists_ReturnsIfIndexZeroAndIndexOneOfExpectedAndResultAreEqual()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> listTwo = new CustomList<int>() { 2, 4, 6 };           
            CustomList<int> expectedResult = new CustomList<int> { 1, 3, 5, 2, 4, 6 }; 

            //Act
            CustomList<int> result = listOne + listTwo;

            //Assert
            Assert.IsTrue(expectedResult[0] == result[0] && expectedResult[1] == result[1]);
        }
        [TestMethod]
        public void AddOverLoad_TwoCustomLists_ReturnsIfAllIndexesAreEqual()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>() { 1, 3, 5, 7 };
            CustomList<int> listTwo = new CustomList<int>() { 2, 4, 6, 8 };
            CustomList<int> expectedResult = new CustomList<int> { 1, 3, 5, 7, 2, 4, 6, 8 };

            //Act
            CustomList<int> result = listOne + listTwo;

            //Assert
            Assert.IsTrue(expectedResult[0] == result[0] && expectedResult[1] == result[1] && expectedResult[2] == result[2] && expectedResult[3] == result[3] && expectedResult[4] == result[4] && expectedResult[5] == result[5] && expectedResult[6] == result[6] && expectedResult[7] == result[7]);
        }
        [TestMethod]
        public void AddOverLoad_TwoCustomLists_ReturnsIndexOfListOne()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> listTwo = new CustomList<int>() { 2, 4, 6 };
            int expectedResult = 2;

            //Act
            CustomList<int> result = listOne + listTwo;

            //Assert
            Assert.AreEqual(expectedResult, result[3]);
        }
        [TestMethod]
        public void MinusOverLoad_TwoCustomLists_ReturnsIfIndexesAreEqual()
        {
            CustomList<int> listOne = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> listTwo = new CustomList<int>() { 2, 1, 6 };
            CustomList<int> expectedResult = new CustomList<int>() { 3, 5 };

            CustomList<int> result = listOne - listTwo;
           
            Assert.IsTrue(expectedResult[0] == result[0] && expectedResult[1] == result[1]);
            
        }
        [TestMethod]
        public void MinusOverLoad_TwoCustomLists_ReturnsNewCount()
        {
            CustomList<int> listOne = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> listTwo = new CustomList<int>() { 2, 1, 6 };
            int expectedResult = 2;

            CustomList<int> result = listOne - listTwo;

            Assert.AreEqual(expectedResult, result.Count );

        }
        [TestMethod]
        public void Zip_TwoCustomListInstances_ReturnIfIndexZeroOfExpectedAndOddListAreEqual()
        {
            CustomList<int> oddList = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> evenList = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> expectedResult = new CustomList<int> { 1, 2, 3, 4, 5, 6 };

            oddList = oddList.Zip(oddList, evenList);

            Assert.IsTrue(oddList[0] == expectedResult[0]);

        }


    }
}
