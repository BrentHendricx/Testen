using System;
using System.IO;

namespace Directories
{
    class Program
    {
        static void Main(string[] args)
        {
            int keuze = 0;
            bool endProgram = false;
            string root = @".\Temp";
            string file = "file.txt";

            while (!endProgram)
            {
                Console.WriteLine("===========================================");
                Console.WriteLine("Kies wat je wilt doen.");
                Console.WriteLine("1) Create Directory          2) Create Sub Directory             3) Delete Directory" +
                                "\n4) Move Directory            5) Get Files                        6) Get Creation Date" +
                                "\n7) Get Last Acces Time       8) Get Last Write Time              9) Get Current Write Date" +
                                "\n10) Get Current Write Date   11) Change Creation Time            ");
                Console.WriteLine("-------------------------------------------");
                keuze = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                try
                {
                    switch (keuze)
                    {
                        case 0: //Exit. keuze is standaard 0.
                            endProgram = true;
                            break;

                        case 1: //Create Directory -[Directory.CreateDirectory(root)]-
                                //Creates a directory(folder) in the SOLUTION_NAME\NAMESPACE_NAME\bin\Debug\netcoreapp3.1
                            if (!Directory.Exists(root))
                                Directory.CreateDirectory(root);
                            else
                                Console.WriteLine("Directory already exists.");
                            break;

                        case 2: //Create Sub Directory -[Directory.CreateDirectory(root)]-
                            string subdir = @".\subdir";
                            if (!Directory.Exists(root + subdir))
                                Directory.CreateDirectory(root + subdir);
                            break;

                        case 3: //Delete Directory -[Directory.Delete(root)]-
                                // !!! IF DIRECTORY DOES NOT EXIST, DO NOT TRY !!!
                            if (!Directory.Exists(root))
                                Directory.Delete(root);
                            break;

                        case 4: //Move Directory -[Directory.Move(ToMove, MoveTo)]-
                            string sourceDirName = @".\Temp";
                            string destDirName = @".\NewTemp";
                            if (Directory.Exists(root))
                            {
                                try
                                {
                                    Directory.Move(sourceDirName, destDirName);
                                }
                                catch (IOException e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                            }
                            else
                            {
                                try
                                {
                                    Directory.Move(destDirName, sourceDirName);
                                }
                                catch (IOException e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                            }
                            
                            break;

                        case 5: //Get Files -[Directory.GetFiles(root)]-
                            string[] fileEntries = Directory.GetFiles(root);
                            foreach (string fileName in fileEntries)
                                Console.WriteLine(fileName);
                            break;

                        case 6: //Get Creation Date -[Directory.GetCreationTime(root)]-

                            //Directory.SetCreationTime(root, DateTime.Now); //Set aanmaakdatum
                            if (Directory.Exists(root))
                                Console.WriteLine(Directory.GetCreationTime(root));
                            else
                                Console.WriteLine("Directory doesn't exists.");
                            break;

                          case 7: //Get Last Acces Time -[Directory.GetLastAccessTime(root)]-

                            //Directory.SetLastAccessTime(root, DateTime.Now); //Zet laatst verandert datum
                            if (Directory.Exists(root))
                                Console.WriteLine(Directory.GetLastAccessTime(root));
                            else
                                Console.WriteLine("Directory doesn't exists.");
                            break;

                         case 8: //Get Creation Time (file) -[Directory.GetCreationTime()]-

                            //Directory.GetCreationTime(file, DateTime.Now); //Zet aanmaak datum
                            if (Directory.Exists(root))
                                Console.WriteLine(Directory.GetCreationTime(file));
                            else
                                Console.WriteLine("Directory doesn't exists.");
                            break;

                         case 9: //Get Last Acces Time -[Directory.GetLastAccessTime]-

                            //Directory.SetCurrentDirectory(root); //Zet laatst verandert datum
                            if (Directory.Exists(root))
                                Console.WriteLine(Directory.GetLastAccessTime(file));
                            else
                                Console.WriteLine("Directory doesn't exists.");
                            break;
                        
                        case 10: //Get Last Write Time -[Directory.GetLastWriteTime]-

                            //Directory.SetLastWriteTime(root, DateTime.Now); //Zet laatst verandert datum
                            if (Directory.Exists(root))
                                Console.WriteLine(Directory.GetLastWriteTime(file));
                            else
                                Console.WriteLine("Directory doesn't exists.");
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
