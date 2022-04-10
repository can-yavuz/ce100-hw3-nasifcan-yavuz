using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ce100_hw3_sln;

namespace ce100_hw3_algo_test_cs
{

    /**********
***********
* @file ce100_hw3_algo_test_cs *
* @author Can Yavuz *
* @date 10.04.2022 * 
*
* @brief <b> hw-3 Unit test </b> *
*
* 
*
* @see http://bilgisayar.mmf.erdogan.edu.tr/en/
*
***********
***********/



    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LongestCommonSubsquence_TestMethod1()
        {
            string s1 = "FXSXCŞSİDXÜQPWELQĞPFXCSAĞPDÖALSFXŞ";
            string s2 = "XCŞSLXDĞAKEĞQŞLXASDFKSDİŞFXQXWĞEŞF";


            int W = s1.Length;
            int Q = s2.Length;
            string result = Class1.LongestCommonSubsquence(s1, s2, W, Q);
            string expected = "XCŞSXEĞXADSFXŞ";
            Assert.AreEqual(result, expected);
        }


        [TestMethod]
        public void LongestCommonSubsquence_TestMethod2()
        {
            string s1 = "RAEIRPAERIQĞPAEQĞPOQÜOR";
            string s2 = "AEROĞLAEFAEÜFÖÜALQĞÜALÖ";


            int W = s1.Length;
            int Q = s2.Length;
            string result = Class1.LongestCommonSubsquence(s1, s2, W, Q);
            string expected = "AERAEAEQĞÜ";
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void LongestCommonSubsquence_TestMethod3()
        {
            string s1 = "ÇSNDLÇKNSDÇDCMSĞÇLMASZ";
            string s2 = "MCŞDSMDASŞÇNCAŞSLDMŞLA";


            int W = s1.Length;
            int Q = s2.Length;
            string result = Class1.LongestCommonSubsquence(s1, s2, W, Q);
            string expected = "DSDÇCSLMA";
            Assert.AreEqual(result, expected);
        }





        [TestMethod]
        public void MatrixChainOrder_TestMethod1()
        {
            int[] arr = { 1, 2, 3, 4 };
            int w = arr.Length;
            int res = Class1.MatrixChainOrder(arr, 1, w - 1);
            Assert.AreEqual(res, 18);
        }

        [TestMethod]
        public void MatrixChainOrder_TestMethod2()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 3 };
            int w = arr.Length;
            int res = Class1.MatrixChainOrder(arr, 1, w - 1);
            Assert.AreEqual(res, 30);
        }

        [TestMethod]
        public void MatrixChainOrder_TestMethod3()
        {
            int[] arr = new int[] { 10, 20, 30, 40, 30 };
            int w = arr.Length;
            int res = Class1.MatrixChainOrder(arr, 1, w - 1);
            Assert.AreEqual(res, 30000);
        }






    }
}
