using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenge4;

namespace UnitTestProject_Challenge4
{
    [TestClass]
    public class UnitTest1
    {

        /// <summary>
        /// アルファベット変換テスト
        /// </summary>
        [TestMethod]
        public void TestMethod1_ToAlphabet()
        {
            
            Assert.AreEqual(Henkan.ToAlphabet(1), "A");
            Assert.AreEqual(Henkan.ToAlphabet(26), "Z");
            Assert.AreEqual(Henkan.ToAlphabet(27), "AA");
            Assert.AreEqual(Henkan.ToAlphabet(702), "ZZ");
            Assert.AreEqual(Henkan.ToAlphabet(2147483647), "FXSHRXW");

            Assert.AreEqual(Henkan.ToAlphabet(0), "");
            Assert.AreEqual(Henkan.ToAlphabet(-1), "");
        }


        /// <summary>
        /// 数値変換テスト
        /// </summary>
        [TestMethod]
        public void TestMethod2_ToInt()
        {

            Assert.AreEqual(Henkan.ToInt("A"), 1);
            Assert.AreEqual(Henkan.ToInt("Z"), 26);
            Assert.AreEqual(Henkan.ToInt("AA"), 27);
            Assert.AreEqual(Henkan.ToInt("ZZ"), 702);
            Assert.AreEqual(Henkan.ToInt("FXSHRXW"), 2147483647);

            Assert.AreEqual(Henkan.ToInt("1"), 0);
            Assert.AreEqual(Henkan.ToInt("-"), 0);
            Assert.AreEqual(Henkan.ToInt(";"), 0);
            Assert.AreEqual(Henkan.ToInt("/"), 0);

        }


        
    }
}
