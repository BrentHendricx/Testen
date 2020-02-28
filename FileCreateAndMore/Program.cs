using System;
using System.IO;

namespace FileCreateAndMore
{
    class Program
    {
        static void Main(string[] args)
        {
            int keuze = 0;
            bool endProgram = true;
            string fileName = @"./Test/MyFile.txt"; // --> Er is geen map 'Test', dus er zal een foutmelding opkomen
                                                    //C:\Users\brent\Documents\00School\Schoonmeersen 19-20\Programmeren\Programmeren 3\Testen\Exception\bin\Debug\netcoreapp3.1\Test
            /*
            try "MyFile.txt" --> Bestand wordt gemaakt 
            Gebruik @ om de / te gebruiken. Anders ziet windows het als escape.
            Gebruik \ voor 0 problemen.
            */
            while (!endProgram)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Kies wat je wilt doen.");
                Console.WriteLine("1) Create File \n2) Delete File \n3) Read File \n4) Write Lines in File \n");
                keuze = Convert.ToInt32(Console.ReadLine());
                try
                {
                    switch (keuze)
                    {
                        case 0:
                            endProgram = true;
                            break;
                        case 1: //Create File
                            if (!File.Exists(fileName))
                            {
                                File.Delete(fileName);
                                using (StreamWriter fileStream = File.CreateText(fileName))
                                {
                                    fileStream.WriteLine("Hallo, Dit is de eerste lijn.");
                                    fileStream.WriteLine("Dit is de tweede lijn.");
                                    fileStream.WriteLine("Dit is de derde en laatste lijn.");
                                }
                                Console.WriteLine("\nFile created succesfuly.");
                            }
                            else
                            {
                                Console.WriteLine("\nFile already exist.");
                            }
                            break;
                        case 2: //Delete File
                            if (File.Exists(fileName))
                            {
                                File.Delete(fileName);
                                Console.WriteLine("\nFile deleted succesfuly.");
                            }
                            else
                            {
                                Console.WriteLine("\nNo file found.");
                            }
                            break;
                        case 3: //Read File
                            if (File.Exists(fileName))
                            {
                                using StreamReader sr = File.OpenText(fileName);
                                string s = "";
                                while ((s = sr.ReadLine()) != null)
                                {
                                    Console.WriteLine(s);
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nNo file found.");
                            }
                            break;
                        case 4: //Write Lines in File
                            if (File.Exists(fileName))
                            {
                                Console.WriteLine("\nSpecify number of lines to write: ");
                                int n = Convert.ToInt32(Console.ReadLine());
                                string[] arrayLines = new string[n];
                                Console.Write("\nSpecify {0} strings: " + Environment.NewLine, n);
                                for (int i = 0; i < n; i++)
                                {
                                    Console.Write("Line {0}: ", i + 1);
                                    arrayLines[i] = Console.ReadLine();
                                }
                                File.WriteAllLines(fileName, arrayLines);
                                Console.WriteLine("\nFile created succesfuly.");
                            }
                            else
                            {
                                Console.WriteLine("\nNo file found.");
                            }
                            break;
                        case 5: //Find Word in File
                            if (File.Exists(fileName))
                            {
                                using StreamReader sr = File.OpenText(fileName);
                                string s = "";
                                while ((s = sr.ReadLine()) != null)
                                {
                                    Console.WriteLine(sr.Contains(s));
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nNo file found.");
                            }
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine();
                }
                catch (System.IO.DirectoryNotFoundException dirEx)
                {
                    System.Diagnostics.Debug.WriteLine(dirEx.Message);
                }
                catch (System.Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
