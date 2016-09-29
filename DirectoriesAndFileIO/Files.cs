using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace DirectoriesAndFileIO
{
    [TestClass]
    public class Files
    {
        [TestInitialize]
        public void Initialize()
        {
            // Create a test-directory with known files and directories
            Directory.CreateDirectory("testDir");
            File.WriteAllText(@"testDir\a.txt", "This is a.txt.");
            File.WriteAllText(@"testDir\b.txt", "This is b.txt.");
            Directory.CreateDirectory(@"testDir\subDir");
        }

        [TestCleanup]
        public void CleanUp()
        {
            if (Directory.Exists("testDir"))
            {
                Directory.Delete("testDir", true); // remove test-directory (can throw exceptions! annoying!)
            }
        }

        [TestMethod]
        public void TestFileReadAllText()
        {
            string txt = File.ReadAllText(@"testDir\a.txt");
            Assert.AreEqual("This is a.txt.", txt);
        }

        [TestMethod]
        public void TestReadAllLines()
        {
            string[] lines = File.ReadAllLines(@"testDir\a.txt");

            Assert.AreEqual(1, lines.Length);
            Assert.AreEqual("This is a.txt.", lines[0]);
        }

        [TestMethod]
        public void TestStreamReader()
        {
            StreamReader s = new StreamReader(@"testDir\a.txt");

            string txt = s.ReadToEnd();
            Assert.AreEqual("This is a.txt.", txt);

            s.Close();
        }

        [TestMethod]
        public void TestFileStream()
        {
            byte[] data = new byte[20];

            FileStream stream = File.OpenRead(@"testDir\a.txt");
            int r = stream.Read(data, 0, 20);

            string txt = "";
            foreach(byte b in data)
            {
                if(b != 0)
                {
                    txt += (char)b;
                }
            }

            Assert.AreEqual(14, r);
            Assert.AreEqual("This is a.txt.", txt);

            stream.Close();
        }

    }
}
