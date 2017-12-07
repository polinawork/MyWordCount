using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Test
{

    [TestClass]
    public class UnitTesting
    {
        [TestMethod]
        public void WordCountTest()
        {
            string testStr = "His extant works, including collaborations, consist of approximately";

            int res = WordCountModel.WordCount(testStr);

            Assert.AreEqual(8, res);
        }

        [TestMethod]
        public void CurWordCountTest()
        {
            string testStr = "His extant works, including collaborations, consist of approximately including including";

            int res = WordCountModel.CurWordCount(testStr, "including") ;

            Assert.AreEqual(3, res);
        }
    }
}
