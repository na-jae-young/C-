using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorigthm.tests
{
    [TestClass]
    public class AlorithmClassTest
    {
        [TestMethod]
        public void MyTestMethod()
        {
        }
        [TestMethod]
        public void Sort_ShouldReturnSortedArray()
        {
            int[] arr = { 5, 8, 2, 4 };

            int[] results = JyClassLibrary1.Algorithm.sort(arr);

            Assert.AreEqual(2, results[0]);  // true

            Assert.AreEqual(8, results[results.Length - 1]);  //true  

            //테스트 탐색기 로 테스트 실행 
        }
    }
}
