using Microsoft.VisualStudio.TestTools.UnitTesting;
using AbsolutePermutation;

namespace AbsolutePermutationTests
{
    [TestClass]
    public class AbsolutePermutationTests
    {
        [TestMethod]
        public void AbsolutePermutation_ShouldReturnSmallestPermutation_GivenAValidInput()
        {
            int[] expectedResult = { 4, 5, 6, 1, 2, 3, 10, 11, 12, 7, 8, 9 };
            int[] result = Program.AbsolutePermutation(12, 3);

            CollectionAssert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void AbsolutePermutation_ShouldReturnSmallestPermutation_GivenAValidInput2()
        {
            int[] expectedResult = { 3, 4, 1, 2 };
            int[] result = Program.AbsolutePermutation(4, 2);

            CollectionAssert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void AbsolutePermutation_ShouldReturnSmallestPermutation_GivenAValidInput3()
        {
            int[] expectedResult = { 3, 4, 1, 2, 7, 8, 5, 6, 11, 12, 9, 10, 15, 16, 13, 14, 19, 20, 17, 18, 23, 24, 21, 22, 27, 28, 25, 26, 31, 32, 29, 30, 35, 36, 33, 34, 39, 40, 37, 38, 43, 44, 41, 42, 47, 48, 45, 46, 51, 52, 49, 50, 55, 56, 53, 54, 59, 60, 57, 58, 63, 64, 61, 62, 67, 68, 65, 66, 71, 72, 69, 70, 75, 76, 73, 74, 79, 80, 77, 78, 83, 84, 81, 82, 87, 88, 85, 86, 91, 92, 89, 90, 95, 96, 93, 94, 99, 100, 97, 98 };
            int[] result = Program.AbsolutePermutation(100, 2);

            CollectionAssert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void AbsolutePermutation_ShouldReturnMinusOne_GivenAInvalidInput()
        {
            int[] expectedResult = { -1 };
            int[] result = Program.AbsolutePermutation(3, 2);

            CollectionAssert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void AbsolutePermutation_ShouldReturnMinusOne_GivenAInvalidInput2()
        {
            int[] expectedResult = { -1 };
            int[] result = Program.AbsolutePermutation(10, 3);

            CollectionAssert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void AbsolutePermutation_ShouldReturnMinusOne_GivenAInvalidInput3()
        {
            int[] expectedResult = { -1 };
            int[] result = Program.AbsolutePermutation(12, 5);

            CollectionAssert.AreEqual(expectedResult, result);
        }

    }
}
