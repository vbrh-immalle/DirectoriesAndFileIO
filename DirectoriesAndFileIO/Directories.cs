using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace DirectoriesAndFileIO
{
    [TestClass]
    public class Directories
    {
        
        [TestMethod]
        // bad test : hard to reproduce
        public void TestGetCurrentDirectory()
        {
            string curdir = Directory.GetCurrentDirectory();

            Assert.AreEqual(@".", curdir);
        }

        [TestMethod]
        public void TestGetFiles()
        {
            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory());

            Assert.AreEqual(10, files.Length);
            // TODO
        }

        [TestMethod]
        public void TestGetFilesWithSearchPattern()
        {
            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.exe");

            Assert.AreEqual(10, files.Length);
            // TODO
        }

        [TestMethod]
        public void TestGetFilesInSubdirectories()
        {
            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory(), "", SearchOption.AllDirectories);

            Assert.AreEqual(10, files.Length);
        }
        
    }
}
