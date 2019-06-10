using System;
using FileReadWriteLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PayRollLib;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckFileTestMethod()
        {
            //Arrange Test
            bool Result;

            //Act Test
            Result = FileOperation.CheckFile(@"E:\testfile.txt");

            //Assert Test
            Assert.AreEqual(true, false);
        }

        [TestMethod]
        public void ReadFileTestMethod()
        {
            //Arrange Test
            string[] Result;

            //Act Test
            Result = FileOperation.ReadFile(@"E:\testfile.txt");

            //Assert Test
            Assert.AreEqual(3,Result.Length);
        }

        [TestMethod]
        public void ReadLinesTestMethod()
        {
            //Arrange Test
            string Result;
            string Line = "102\tankur\t11-07-2016\t40000\\r\\n";


            //Act Test
            Result = FileOperation.ReadLines(Line);

            //Assert Test
            Assert.AreEqual("101\tsahil\t10-12-2017\t30000", Result);
        }


        [TestMethod]
        public void CheckDateTestMethod()
        {
            //Arrange Test
            bool Result;
            
            //Act Test
            Result = CalculatePaySlip.CheckDate("10-12-2017");

            //Assert Test
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void SalaryIncreamentTestMethod()
        {
            //Arrange Test
            string salary= "30000";
            double Result;

            //Act Test
            Result = CalculatePaySlip.SalaryIncreament(salary);

            //Assert Test
            Assert.AreEqual(33000, Result);
        }

        [TestMethod]
        public void WriteFileTestMethod()
        {
            //Arrange Test
            string filepath = @"E:\testfile.txt";
            string Result;

            //Act Test
            Result = FileOperation.WriteFile(filepath);

            //Assert Test
            Assert.AreEqual("101\tsahil\t10-12-2017\t30000\t33000\r\n", Result);
        }
    }
}
