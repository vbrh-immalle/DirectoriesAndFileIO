using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace DirectoriesAndFileIO
{
    [TestClass]
    public class Directories
    {
        [TestMethod]
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
        }
    }
}
