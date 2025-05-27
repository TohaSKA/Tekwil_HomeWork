//using System;

//namespace CalculatorSimplu
//{
//    public class Operatii
//    {
//       //static void Main()
//       // {
//       //     #region Conversia temp
//       //     //// Conversia temperaturii
//       //     //Console.Write("Introdu temp in Celsius: ");
//       //     //if (double.TryParse(Console.ReadLine(), out double celsius))
//       //     //{
//       //     //    double fahrenheit = (celsius * 9 / 5) + 32;
//       //     //    Console.WriteLine($"Temp in F: {fahrenheit:F2} F");
//       //     //}
//       //     //else
//       //     //{
//       //     //    Console.WriteLine("Valoare invalida");
//       //     //}
//       //     #endregion

//       //     #region Calcul masa
//       //     //Console.Write("Introdu kg: ");
//       //     //bool kgValid = double.TryParse(Console.ReadLine(), out double greutate);

//       //     //Console.Write("Introud inaltimea in CM: ");
//       //     //bool cmValid = double.TryParse(Console.ReadLine(), out double inaltime);
//       //     //double inaltimeCM = inaltime / 100;

//       //     //if (kgValid && cmValid && inaltime > 0)
//       //     //{
//       //     //    double imc = greutate / (inaltimeCM * inaltimeCM);

//       //     //    Console.WriteLine($"IMC: {imc:F2}");
//       //     //}
//       //     //else
//       //     //{
//       //     //    Console.WriteLine("Valori invalide.");
//       //     //}
//       //     #endregion


//       //     #region Salariu

//       //     //Console.WriteLine("\n Introdu numele:");
//       //     //string nume = Console.ReadLine()!;

//       //     //Console.WriteLine("\n Introdu salariul:");
//       //     //float salariuBrut = float.Parse(Console.ReadLine()!);

//       //     //Console.WriteLine("\n Rata de schimb (raport USD): ");
//       //     //double rataSchimb = double.Parse(Console.ReadLine()!);

//       //     //Console.WriteLine("\n Categoria de impozitare (categoria 1 2 sau 3):");
//       //     //int categorie = int.Parse(Console.ReadLine()!);

//       //     //float impozit = 0;

//       //     //if (categorie == 1)
//       //     //    impozit = 0.10f;
//       //     //else if (categorie == 2)
//       //     //    impozit = 0.20f;
//       //     //else if (categorie == 3)
//       //     //    impozit = 0.30f;
//       //     //else
//       //     //    Console.WriteLine("Categorie invalida.");

//       //     //float salariuNet = salariuBrut - (salariuBrut * impozit);
//       //     //double salariuNetUSD = (double)salariuNet / rataSchimb;


//       //     //if (salariuNetUSD > 2000)
//       //     //    Console.WriteLine("Salariul este peste medie.");
//       //     //else
//       //     //{
//       //     //}
//       //     //Console.WriteLine("Salariul este sub medie.");

//       //     #endregion

//       //     #region Calc
//       //     //while (true) {

//       //     //Console.WriteLine("\nIntrodu 1 Numar:");
//       //     //double numar1 = double.Parse(Console.ReadLine()!);

//       //     //Console.WriteLine("\n Intridu al 2 numar:");
//       //     //double numar2 = double.Parse(Console.ReadLine()!);

//       //     //Console.WriteLine("\nAlege operatia(+, -, *, /):");
//       //     //string operatie = Console.ReadLine()!;

//       //     //double rezultat = 0;

//       //     //    switch (operatie)
//       //     //    {
//       //     //        case "+":
//       //     //            rezultat = numar1 + numar2;
//       //     //            break;
//       //     //        case "-":
//       //     //            rezultat = numar1 - numar2;
//       //     //            break;
//       //     //        case "*":
//       //     //            rezultat = numar1 * numar2;
//       //     //            break;
//       //     //        case "/":
//       //     //            if (numar2 != 0)
//       //     //            {
//       //     //                rezultat = numar1 / numar2;
//       //     //            }
//       //     //            else
//       //     //            {
//       //     //                Console.WriteLine("\nEroare: Impartirea la 0 nu este permisa.");
//       //     //                return;
//       //     //            }
//       //     //            break;
//       //     //        default:
//       //     //            Console.WriteLine("\nOperatie necunoscuta.");
//       //     //            return;
//       //     //    }


//       //     //    Console.WriteLine($"\nRezultatul este: {rezultat}");
//       //     //}
//       //     #endregion

//       //     #region Gestionarea datelor de nastere

//       //     //Console.WriteLine("\n Vei introduce ziua luna si anu nasterii \n Introdu ziua Nasterii");

//       //     //int ziua = int.Parse(Console.ReadLine()!);
//       //     //Console.WriteLine("\n Introdu luna Nasterii");
//       //     //int luna = int.Parse(Console.ReadLine()!);
//       //     //Console.WriteLine("\n Introdu anu Nasterii");
//       //     //int anul = int.Parse(Console.ReadLine()!);

//       //     //DateTime dataNasterii = new DateTime(anul, luna, ziua);

          
//       //     //DateTime azi = DateTime.Today;

         
//       //     //int varsta = azi.Year - dataNasterii.Year;

            
//       //     //if (dataNasterii > azi.AddYears(-varsta))
//       //     //{
//       //     //    varsta--;
//       //     //}

//       //     //Console.WriteLine($"\nAi {varsta} ani.");


//       //     #endregion
//       // }
//    }
//}
