using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Models.Tests
{
    [TestClass]
    public class WordsTest
    {
        [TestMethod]
        public void CountWords_FindTwoWordsInString_2()
        {
            Assert.AreEqual(2, WordModel.CountWords("day", "this day is a nice day"));
        }
        [TestMethod]
        public void CountWords_FindTwoWordsInStringDespiteSpace_1()
        {
            Assert.AreEqual(1, WordModel.CountWords("day", "today is a nice day"));
        }
        [TestMethod]
        public void CountWords_FindTwoWordsInStringDespiteCaps_2()
        {
            Assert.AreEqual(2, WordModel.CountWords("Day", "this day is a nice day"));
        }
    }
}
