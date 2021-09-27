using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class CombinedFilterTest
    {
        [Test]
        public void CombinedFilterSimple()
        {
            int[] input = { 1, 3 };
            int[] output = CombinedFilter.combinedFilter(input);
            int[] expected = { 1, 3 };

            CollectionAssert.AreEqual(expected, output);
        }
    }
}
