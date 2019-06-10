using PayRollLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReadWriteLib
{
    public class FileOperation
    {
       static string writeText = "";
        static string[] LineArr;

        //Checking For File Existance
        public static bool CheckFile(string filePath)
        {
            return File.Exists(filePath);
        }
        //Reading File Content
        public static string[] ReadFile(string filePath)
        {
            return File.ReadAllLines(filePath);
        }
        //Read Each Line Of File
        public static string ReadLines(string line)
        {
            line = line.Replace("\\n", "");
            line = line.Replace("\\r", "");
            return line;
        }
        //This Method Uses all the Method
        public static string WriteFile(string filePath)
        {
            if (CheckFile(filePath))
            {
                foreach (var Line in ReadFile(filePath))
                {
                    LineArr = ReadLines(Line).Split('\t');
                    if (CalculatePaySlip.CheckDate(LineArr[2]))
                        writeText += ReadLines(Line) + "\t" + CalculatePaySlip.SalaryIncreament(LineArr[3]) + Environment.NewLine;
                   else
                        writeText += ReadLines(Line) + "\t" + LineArr[3]+ Environment.NewLine;
                }
            }
            return writeText;
        }
    }
}