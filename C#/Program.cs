using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //SORTOVANI BUBBLESORT

            /*
            //string text = File.ReadAllText(@"c:\Test\test.txt", Encoding.UTF8);
            //int[] poleCislo = text.Split(',').Select(int.Parse).ToArray();

            //int[] poleCislo = { 3, 6, 8, 6, 2 };

            for (int i = 0; i < poleCislo.Length; i++)
            {
                for (int j = 0; j < poleCislo.Length - 1; j++)
                {
                    if (poleCislo[j] < poleCislo[j + 1])
                    {
                        int tmp = poleCislo[j];
                        poleCislo[j] = poleCislo[j + 1];
                        poleCislo[j + 1] = tmp;
                    }
                }
            }
            for (int i = 0; i < poleCislo.Length; i++)
            {
                Console.Write(poleCislo[i] + " ");
            }
            Console.Read();
                                                                        
            //VYHLEDANI NEJVETSIHO SOUBORU V DANEM ADRESARI 
            DirectoryInfo folderInfo = new DirectoryInfo("C:\\Test");
            FileInfo[] files = folderInfo.GetFiles();

            long largestSize = 0;
            for (int i = 0; i < files.Length; i++)
            {
                if (files[i].Length > largestSize)
                    largestSize = files[i].Length;
            }
            Console.WriteLine(largestSize);

            //NACTENI DAT DO STRINGU
            string text = File.ReadAllText(@"c:\Test\test.txt", Encoding.UTF8);
            Console.WriteLine(text);
            Console.ReadLine();

            //NACTENI STRING DO POLE
            string[] lines = File.ReadAllLines(@"c:\Test\test.txt", Encoding.UTF8);

            for (int i = 0; i < lines.Length; i++)
            {
            Console.WriteLine(lines[i]);
            }
            Console.ReadLine();

            // NACTENI ze souboru a prevod do int pole
            {
                string text = File.ReadAllText(@"c:\Test\test.txt", Encoding.UTF8);
                int[] array = text.Split(',').Select(int.Parse).ToArray();

                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }

                Console.ReadLine();
            }

            //NACTENI DAT Z CSV SOUBORU a export do csv -- String
            {
                string text = File.ReadAllText(@"c:\Test\test.csv", Encoding.UTF8);

                string[] test = { "aa", "dasd", "a3", "321" };          

                File.WriteAllLines(@"c:\Test\test_new.csv", test);
            }

            //Export Int pole do csv
            string strFilePath = @"C:\Test\test_new.csv";
            string strSeperator = ";";
            StringBuilder sbOutput = new StringBuilder();

            int[][] inaOutput = new int[][]
            {
                 new int[]{1000, 2000, 3000, 4000, 5000},
                 new int[]{6000, 7000, 8000, 9000, 10000},
                 new int[]{11000, 12000, 13000, 14000, 15000}
            };
            int ilength = inaOutput.GetLength(0);
            for (int i = 0; i < ilength; i++)
             sbOutput.AppendLine(string.Join(strSeperator, inaOutput[i]));

            // Create and write the csv file
            File.WriteAllText(strFilePath, sbOutput.ToString());

            // To append more lines to the csv file
            File.AppendAllText(strFilePath, sbOutput.ToString());


            ////EXPORT VYSLEDKU DO SOUBORU CSV
            string strFilePath = @"C:\Test\test_new.csv";
            string strSeperator = ";";
            StringBuilder sbOutput = new StringBuilder();

            string text = File.ReadAllText(@"c:\Test\test.txt", Encoding.UTF8);
            int[] Pole = text.Split(',').Select(int.Parse).ToArray();

            for (int i = 0; i < Pole.Length; i++)
                sbOutput.AppendLine(string.Join(strSeperator, Pole[i]));
            
            //Console.ReadLine();

            //int[][] inaOutput = new int[][]
            //{
            //     new int[]{1000, 2000, 3000, 4000, 5000},
            //     new int[]{6000, 7000, 8000, 9000, 10000},
            //     new int[]{11000, 12000, 13000, 14000, 15000}
            //};
            //int ilength = inaOutput.GetLength(0);
            //for (int i = 0; i < ilength; i++)
            //    sbOutput.AppendLine(string.Join(strSeperator, inaOutput[i]));
            
            // Create and write the csv file
            //File.WriteAllText(strFilePath, sbOutput.ToString());

            // To append more lines to the csv file
            //File.AppendAllText(strFilePath, sbOutput.ToString());
            */


            //VYHLEDANI hodnoty v poli linearnim vyhledavanim
            int[] poleCislo = { 3, 6, 8, 6, 2 };
            int value = 2;

            for (int i = 0; i < poleCislo.Length; i++)
            {
                if (poleCislo[i] == value)
                {
                    Console.WriteLine(i); // or Console.WriteLine("Element {0} found at location {1}\n", value, i + 1)
                    Console.ReadLine();
                }                         
            }
        }
    }
}
