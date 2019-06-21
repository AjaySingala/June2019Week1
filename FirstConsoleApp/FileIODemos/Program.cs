using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIODemos
{
    class Program
    {
        static void Main(string[] args)
        {
            //StreamReaderDemo();
            //FoldersDemo();
            ExceptionDemo();

            //try
            //{
            //    int i = 10;
            //    int j = 0;
            //    Console.WriteLine(i / j);
            //}

            //catch (DivideByZeroException dex)
            //{
            //    Console.WriteLine("ERROR! You are trying to divide by ZERO!!!");
            //    Console.WriteLine("Message: " + dex.Message);
            //    Console.WriteLine("Message: " + dex.StackTrace);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("ERROR! You are trying to divide by ZERO!!!");
            //    Console.WriteLine("Message: " + ex.Message);
            //    Console.WriteLine("Message: " + ex.StackTrace);
            //}
        }

        static void StreamReaderDemo()
        {
            string filename = @"D:\Temp\SampleFile.txt";
            Console.WriteLine("StreamReader #1");
            StreamReader sr = new StreamReader(filename);
            //Console.WriteLine(sr.ReadLine());
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();

            Console.WriteLine("StreamWriter #1");
            string f2 = @"D:\Temp\SampleFile2.txt";
            StreamWriter sw = new StreamWriter(f2);
            sw.WriteLine("This is the first line.");
            sw.WriteLine("This is the second line.");
            sw.Close();

            Console.WriteLine("StreamReader #2");
            StreamReader sr2 = new StreamReader(f2);
            Console.WriteLine(sr2.ReadToEnd());
            sr2.Close();

            Console.WriteLine("StreamReader #3");
            StreamReader sr3 = new StreamReader(filename);
            string s;
            while ((s = sr3.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
            sr3.Close();


            Console.WriteLine("StreamWriter #2");
            string f3 = @"D:\Temp\SampleFile3.txt";
            StreamWriter sw2 = File.CreateText(f3);
            sw2.WriteLine("This is the 1st line.");
            sw2.WriteLine("This is the 2nd line.");
            sw2.Close();

            Console.WriteLine("StreamReader #4");
            StreamReader sr4 = File.OpenText(f3);
            string s2;
            while ((s2 = sr4.ReadLine()) != null)
            {
                Console.WriteLine(s2);
            }
            sr4.Close();
        }

        static void FoldersDemo()
        {
            string path = @"D:\Temp";
            string[] dirs = Directory.GetDirectories(path);
            foreach (string dir in dirs)
            {
                Console.WriteLine(dir);
            }

            Console.WriteLine("Files in folder...)");
            string[] files = Directory.GetFiles(path);
            foreach (string i in files)
            {
                Console.WriteLine(i);
            }
        }

        static void ExceptionDemo()
        {
            StreamReader sr = null;
            try
            {
                string f2 = @"D:\Temp\SampleFile2.txt";
                sr = new StreamReader(f2);
                Console.WriteLine(sr.ReadToEnd());

                //throw new Exception("This is a demo Exception");
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR! File not found!!!");
                Console.WriteLine("Message: " + ex.Message);
                Console.WriteLine("Message: " + ex.StackTrace);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }
    }
}
