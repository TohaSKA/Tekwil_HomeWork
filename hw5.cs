//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp_less1
//{
//    #region Sarcina 1
//    //public class Obiecte
//    //{
//    //    static void Main(string[] args)
//    //    {
//    //        Console.WriteLine("Introdu un obiect");

//    //        while (true)
//    //        {
//    //            Console.Write(">>");
//    //            string input = Console.ReadLine()!;

//    //            object obj;

//    //            if (int.TryParse(input, out int intVal))
//    //            {
//    //                obj = intVal;
//    //            }
//    //            else
//    //            {
//    //                obj = input;
//    //            }
//    //            switch (obj)
//    //            {
//    //                case int valoare when valoare % 2 == 0:
//    //                    Console.WriteLine($"Numar par: {valoare}");
//    //                    break;

//    //                case int valoare:
//    //                    Console.WriteLine($"Numar impar: {valoare}");
//    //                    break;

//    //                case string sir when sir.Length > 5:
//    //                    Console.WriteLine($"Ai scris un sir lung de caractere: {sir}");
//    //                    break;

//    //                case string caracter:
//    //                    Console.WriteLine($"Ai scris un caracter/ sir de caractere scurt: {caracter}");
//    //                    break;

//    //                default:
//    //                    Console.WriteLine($"Obiect necunoscut: {obj}");
//    //                    break;




//    //            }
//    //        }
//    //    }
//    //}
//    #endregion

//    #region Sarcina 2

//    //public class Evaluare
//    //{
//    //    static void Main(string[] args)
//    //    {
//    //        Console.WriteLine("\nIntrodu Nota de la test (1-10)");

//    //        while (true)

//    //        {
//    //            Console.Write("Nota: ");
//    //            string input = Console.ReadLine();

//    //            if (int.TryParse(input, out int nota))
//    //            {
//    //                if (nota < 1 || nota > 10)
//    //                {
//    //                    Console.WriteLine("Nota trebuie sa fie intre 1 si 10");

//    //                }
//    //                else if (nota == 10)
//    //                {
//    //                    Console.WriteLine("Calificativ: Excelent");
//    //                }
//    //                else if (nota >= 8)
//    //                {
//    //                    Console.WriteLine("Calificativ: Bun");
//    //                }
//    //                else if (nota >= 5)
//    //                {
//    //                    Console.WriteLine("Calificativ: Suficient");
//    //                }
//    //                else
//    //                {
//    //                    Console.WriteLine("Calificativ: Necalificat");
//    //                }
//    //            }
//    //            else
//    //            {
//    //                Console.WriteLine("Introdu un numar valid");
//    //            }   

//    //        }
//    //    }

//    //}
//    #endregion

//    #region Sarcina 3

//    public class restaurant
//    {
//        enum  Meniu
//        {
//            Supa = 1,
//            SalataCesar,
//            SalataGreceasca,
//            Inghetata
//        }

//        static void Main(string[] args)
//        {
//            while (true)
//            {
//                Console.WriteLine("\n _______Meniu restaurant_______");
//                Console.WriteLine("\n ____________Supa (1)__________");
//                Console.WriteLine("\n _________Salata Cezar (2)_____");
//                Console.WriteLine("\n _______Salata Greceasca (3)___");
//                Console.WriteLine("\n __________Inghetata (4)_______");
//                Console.WriteLine("\n _______Alege o optiune:_______");

//                string input = Console.ReadLine()!;

//                if (int.TryParse(input, out int optiune))
//                {
//                    if (Enum.IsDefined(typeof(Meniu), optiune))
//                    {
//                        Meniu alegere = (Meniu)optiune;

//                        switch (alegere)
//                        {
//                            case Meniu.Supa:
//                                Console.WriteLine("Supa de legume - 60 lei");
//                                break;

//                            case Meniu.SalataCesar:
//                                Console.WriteLine("Salata Caesar - 125 lei");
//                                break;

//                            case Meniu.SalataGreceasca:
//                                Console.WriteLine("Salata Greceasca - 80 lei");
//                                break;

//                            case Meniu.Inghetata:
//                                Console.WriteLine("Inghetata de vanilie - 50 lei");
//                                break;
//                        }
//                    }
//                    else
//                    {
//                        Console.WriteLine("Optiune invalida. Alege un numar intre 1 si 4.");
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("Input invalid. Introdu numar sau 'stop'.");
//                }
//            }

//        }
        
//    }
//    #endregion
//}


