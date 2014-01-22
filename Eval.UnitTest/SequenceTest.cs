using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Eval.UnitTest
{
    [TestClass]
    public class SequenceTest
    {
        [TestMethod]
        public void CanGetOddNumbers()
        {
            List<int> odds = Sequence
                .GetOddNumbers(new int[] { 1, 2, 3, 6, 7, 9, 12, 16, 17 })
                .ToList();

            //Avoid Multiple Assert and combining the range.
            //We can also try collection assert and enumerate....
            Assert.IsTrue(odds.SequenceEqual(new List<int> { 1,3,7,9,17 }));
    
            //Assert.IsTrue(odds.Contains(1));
            //Assert.IsTrue(odds.Contains(3));
            //Assert.IsTrue(odds.Contains(7));
            //Assert.IsTrue(odds.Contains(9));
            //Assert.IsTrue(odds.Contains(17));
        }

        [TestMethod]
        public void CanExamineInfiniteSet()
        {
            List<int> odds = Sequence
                .GetOddNumbers(Sequence.GetPositiveIntegers())
                .Take(5)
                .ToList();

            Assert.IsTrue(odds.Contains(1));
            Assert.IsTrue(odds.Contains(3));
            Assert.IsTrue(odds.Contains(5));
            Assert.IsTrue(odds.Contains(7));
            Assert.IsTrue(odds.Contains(9));
        }
    }
}
