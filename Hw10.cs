//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.IO;
//using System.Security.Cryptography.X509Certificates;

//namespace ConsoleApp_less1
//{
//    public class Hw10
//    {
//        public static void Main(string[] args)
//        {
//            #region  Ex1 Compararea Conținutului a Două Fișiere

//            Console.WriteLine("==============Exmeplul 1===============");

//            // imi creez din start o variabile de tip string sa nu scriu de fiacare data calea catre fisere dar doar sa folosesc variabila
//            string basePath = @"D:\Tekwil\ConsoleApp_less1\ConsoleApp_less1\hw_10";
//            string file1Path = Path.Combine(basePath, "file1.txt");
//            string file2Path = Path.Combine(basePath, "file2.txt");

//            //foloesc conditia sa verific daca sunt creata 2 fisiere inc az ca execut programul de cateva ori si sa nu se suprascrie daca sunt create
//            if (!File.Exists(file1Path))
//            {
//                File.WriteAllText(file1Path, "Salut, esti in fisierul_1");
//            }


//            if (!File.Exists(file2Path))
//            {
//                File.WriteAllText(file2Path, "Salut, esti in fisierul_2");
//            }

//            Console.WriteLine("Fisierele au fost verificate/create daca lipseau.");



//            string text1 = File.ReadAllText(file1Path);
//            string text2 = File.ReadAllText(file2Path);

//            if (text1 == text2)
//            {
//                Console.WriteLine("Fisierele sunt identice");
//            }
//            else
//            {
//                Console.WriteLine("Fiserele nu sunt identice");
//            }
//            #endregion

//            #region  Ex2  Mutarea Fișierelor într-un Director Nou

//            Console.WriteLine("\n==============Exmeplul 2===============");

//            string sourceFolder = @"D:\Tekwil\ConsoleApp_less1\ConsoleApp_less1\hw_10";
//            string backupFolder = @"D:\Tekwil\ConsoleApp_less1\ConsoleApp_less1\hw_10";

//            Directory.CreateDirectory(sourceFolder);
//            Directory.CreateDirectory(backupFolder);


//            File.WriteAllText(Path.Combine(sourceFolder, "file1.txt"), "Esti in fiserul 1");
//            File.WriteAllText(Path.Combine(sourceFolder, "file2.txt"), "Esti in fiserul 2");
//            File.WriteAllText(Path.Combine(sourceFolder, "file3.txt"), "Esti in fiserul 3");

//            Console.WriteLine("Fisierele au fost create in SourceFolder.");


//            string[] files = Directory.GetFiles(sourceFolder);

           
//            foreach (string filePath in files)
//            {
//                string fileName = Path.GetFileName(filePath);
//                string destFile = Path.Combine(backupFolder, fileName);

                
//                File.Move(filePath, destFile);

//                Console.WriteLine($"Fisierul {fileName} a fost mutat in BackupFolder.");
//            }


//            Console.WriteLine("\nFisierele din BackupFolder:");

//            string[] backupFiles = Directory.GetFiles(backupFolder);
//            foreach (string backupFile in backupFiles)
//            {
//                Console.WriteLine(Path.GetFileName(backupFile));
//            }

//            #endregion
//        }
//    }
//}
