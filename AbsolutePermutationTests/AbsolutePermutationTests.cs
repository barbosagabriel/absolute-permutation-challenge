using Microsoft.VisualStudio.TestTools.UnitTesting;
using AbsolutePermutation;

namespace AbsolutePermutationTests
{
    [TestClass]
    public class AbsolutePermutationTests
    {
        [TestMethod]
        public void AbsolutePermutationSuccess()
        {
            int[] expectedResult = { 4, 5, 6, 1, 2, 3, 10, 11, 12, 7, 8, 9 };
            int[] result = Program.AbsolutePermutation(12, 3);

            CollectionAssert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void AbsolutePermutationFail()
        {
            int[] expectedResult = { -1 };
            int[] result = Program.AbsolutePermutation(3, 2);

            CollectionAssert.AreEqual(expectedResult, result);
        }
    }
}
