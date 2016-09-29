using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace DirectoriesAndFileIO
{
    [TestClass]
    public class Directories
    {
        [TestInitialize]
        public void Initialize()
        {
            // Create a test-directory with known files
            //DirectoryInfo dir = Directory.CreateDirectory("testDir");

        }

        [TestCleanup]
        public void CleanUp()
        {
            // remove test-directory (can throw exceptions! annoying!)
            //Directory.Delete("testDir");
        }

        [TestMethod]
        public void TestCreateAndDeleteDirectory()
        {
            DirectoryInfo dir = Directory.CreateDirectory("testDir");

            Assert.IsTrue(dir.Exists, "Directory should exist");

            dir.Delete();
            dir.Refresh(); // only here we actually delete, otherwise use Directory.Delete("testDir");

            Assert.IsFalse(dir.Exists, "Directory should be deleted");
        }

        [TestMethod]
        public void TestCreateDirectoryCreationTime()
        {
            DirectoryInfo dir = Directory.CreateDirectory("testDir");

            DateTime now = DateTime.Now;
            DateTime creationTime = dir.CreationTime;

            Assert.IsTrue(dir.Exists, "Directory should exist");
            Assert.AreEqual(now, creationTime);

            dir.Delete();

            Assert.IsFalse(dir.Exists, "Directory should be deleted");
        }
    }
}
