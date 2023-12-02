using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.UleevRI.Sprint5.TaskReview.V4;

namespace Tyuiu.UleevRI.Sprint5.TaskReview.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\roman\source\repos\Tyuiu.UleevRI.Sprint5.Review\Tyuiu.UleevRI.Sprint5.TaskReview.V4\bin\Debug\OutPutDataFileTask7V4.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
