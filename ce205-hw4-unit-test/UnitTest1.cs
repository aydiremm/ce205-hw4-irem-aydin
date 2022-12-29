using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ce205_hw4_gui;
using System.Collections.Generic;
using static ce205_hw4_gui.trie_algorithm;

namespace ce205_hw4_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void horspool_good_test()
        {
            horspool h = new horspool();
            string text = "This is a test text";
            string pattern = "test";
            int index = h.ShiftMyTable(pattern, text, 0);
            Assert.AreEqual(10, index);
        }
        [TestMethod]
        public void horspool_bad_test()
        {
            horspool h = new horspool();
            string text = "Lorem ipsum dolor sit amet.";
            string pattern = "sit";
            int index = h.ShiftMyTable(pattern, text, 0);
            Assert.AreEqual(18, index);
        }
        [TestMethod]
        public void horspool_ugly_test()
        {
            horspool h = new horspool();
            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur quis.";
            string pattern = "elit";
            int index = h.ShiftMyTable(pattern, text, 0);
            Assert.AreEqual(51, index);
        }
       
        [TestMethod]
        public void KMP_good_test()
        {
            knuth_morris_pratt k = new knuth_morris_pratt();
            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas congue.";
            string pattern = "congue";
            int index = k.KMPSearch(text, pattern, 0);
            Assert.AreEqual(-1, index);
        }
        [TestMethod]
        public void KMP_bad_test()
        {
            knuth_morris_pratt k = new knuth_morris_pratt();
            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas ut.";
            string pattern = "dolor";
            int index = k.KMPSearch(text, pattern, 0);
            Assert.AreEqual(-1, index);
        }
        [TestMethod]
        public void KMP_ugly_test()
        {
            knuth_morris_pratt k = new knuth_morris_pratt();
            string text = "Ut eget velit sit amet purus auctor ullamcorper vitae eu enim. Suspendisse efficitur venenatis nisl.";
            string pattern = "enim";
            int index = k.KMPSearch(text, pattern, 0);
            Assert.AreEqual(-1, index);
        }
        
        [TestMethod]
        public void needleman_test()
        {
            needleman_wunsch needleman = new needleman_wunsch();
            string s1 = "AGCAT";
            string s2 = "GAC";

            string expected = "AGCAT\n-G-AC";
            string actual = needleman.Align(s1, s2);

            Assert.AreEqual(expected, actual);
        }
       
        [TestMethod]
        public void smith_waterman_test()
        {
            smith_waterman smith = new smith_waterman();
            // Arrange
            string seq1 = "AGCT";
            string seq2 = "ACCT";

            // Act
            string actual = smith.SmithWatermanAlign(seq1, seq2);
            string expected = "AGCT\nACCT";
            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void boyer_goodase_test()
        {
            boyer_moore boyer = new boyer_moore();
            string stringToSearch = "The quick brown fox jumps over the lazy dog.";
            string pattern = "fox";
            int expectedResult = 16;
            int actualResult = boyer.BoyerMoore(stringToSearch, pattern);
            Assert.AreEqual(expectedResult, actualResult);
        }

       
        [TestMethod]
        public void trie_test()
        {
            Trie trie = new Trie();
            trie_algorithm.Trie.Insert("hello");
            trie_algorithm.Trie.Insert("world");
            trie_algorithm.Trie.Insert("helix");
            trie_algorithm.Trie.Insert("helium");

            List<string> words = trie.SearchPrefix("hel");
            CollectionAssert.AreEqual(new[] { "hello", "helix", "helium" }, words);

            words = trie.SearchPrefix("wor");
            CollectionAssert.AreEqual(new[] { "world" }, words);

        }
       
        [TestMethod]
        public void FindLargestCommonSubsequenceTest()
        {
            // Test with simple input
            string lcs = hunt_szymanski.FindLargestCommonSubsequence("ABCBDAB", "BDCABA");
            Assert.AreEqual("BDAB", lcs);

            // Test with empty input
            lcs = hunt_szymanski.FindLargestCommonSubsequence("", "BDCABA");
            Assert.AreEqual("", lcs);

            // Test with identical input
            lcs = hunt_szymanski.FindLargestCommonSubsequence("ABCBDAB", "ABCBDAB");
            Assert.AreEqual("ABCBDAB", lcs);

            // Test with no common characters
            lcs = hunt_szymanski.FindLargestCommonSubsequence("XYZ", "ABC");
            Assert.AreEqual("", lcs);
        }
    }
}


