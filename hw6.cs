//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;
//using static System.Runtime.InteropServices.JavaScript.JSType;


//namespace ConsoleApp_less1
//{

//    //struct Angajat
//    //{
//    //    public string nume;
//    //    public string departament;
//    //    public float salariu;
//    //}
//    public class HomeWork_less_5
//    {

//        static void Main(string[] args)
//        {
//            #region Ex_1
//            /*Ex 1: Utilizare array unidimensional
//         - Creați un program care să stocheze și să afișeze notele unui grup de studenți.
//         - Solicitați utilizatorului să introducă numărul de studenți și să completeze notele fiecărui student.
//         - Utilizați un array unidimensional pentru a stoca notele.
//         - Afișați toate notele la ecran.
//         - Calculați și afișați media notelor studentului.*/
//            /*Console.WriteLine("Introdu nr de stundeti:");
//            int nrStudenti = int.Parse(Console.ReadLine()!);
//            float[] note = new float[nrStudenti];

//            int i = 0;

//            while (i < nrStudenti)
//            {
//                Console.WriteLine($"introdu nota pentru Studentul {i + 1}: ");
//                float Nota = float.Parse(Console.ReadLine()!);
//                note[i] = Nota;
//                i++;
//            }

//            int j = 0;

//            while (j < nrStudenti)
//            {
//                Console.WriteLine($"Nota sudentului {j + 1} este: {note[j]}");
//                j++;
//            }

//            float suma = 0;
//            int k = 0;

//            while (k < nrStudenti)
//            {
//                suma += note[k];
//                k++;
//            }

//            float media = suma / nrStudenti;
//            Console.WriteLine($"Media notelor este: {media}");*/
//            #endregion

//            #region Ex_2
//            /*Ex 2: Utilizare array unidimensional
//        - Creați un program care să stocheze și să gestioneze datele despre angajații unei companii.
//        - Citit de la tastatura datele (numele, departamentul, salariul) a 3 angajati. 
//         - Folosiți structura pentru a indica șablonul unui angajat.(Utilizati tipul struct pentru a stoca informatiile despre angajati)
//        - Calculați salariul mediu.
//        - Afișați la ecran numele angajaților cu salariul mai mare decat media.
//        */


//            /*Angajat[] angajati = new Angajat[3];

//            int i = 0;

//            while (i < angajati.Length)
//            {
//                Console.WriteLine($"Introduceti datele pentru angajatul {i + 1}:");

//                Console.Write("Nume: ");
//                angajati[i].nume = Console.ReadLine()!;

//                Console.Write("Departament: ");
//                angajati[i].departament = Console.ReadLine()!;

//                Console.Write("Salariu: ");
//                angajati[i].salariu = float.Parse(Console.ReadLine()!);

//                i++;
//            }

//            float suma = 0;
//            int j = 0;
//            while (j < angajati.Length)
//            {
//                suma += angajati[j].salariu;
//                j++;
//            }

//            float media = suma / angajati.Length;
//            Console.WriteLine($"\nSalariul mediu este: {media}");


//            Console.WriteLine("\nAngajatii cu salariul mai mare decat media:");
//            int k = 0;
//            while (k < angajati.Length)
//            {
//                if (angajati[k].salariu > media)
//                {
//                    Console.WriteLine(angajati[k].nume);
//                }
//                k++;

//            */
//                #endregion

//                #region Ex_optional_2
//                /*Ex4 Optional:
//Scrie un program care citește un array de numere întregi și afișează elementul maxim și minim din array.
//*/
//                Console.WriteLine("Introdu numarul de elemente:");
//                int n = int.Parse(Console.ReadLine()!);
//                int[] numere = new int[n];

//                int i = 0;
//                while (i < n)
//                {
//                    Console.WriteLine($"Introdu elementul {i + 1}:");
//                    numere[i] = int.Parse(Console.ReadLine()!);
//                    i++;
//                }

//                int minim = numere[0];
//                int maxim = numere[0];

//                int j = 1;
//                while (j < n)
//                {
//                    if (numere[j] < minim)
//                    {
//                        minim = numere[j];
//                    }
//                    if (numere[j] > maxim)
//                    {
//                        maxim = numere[j];
//                    }
//                    j++;
//                }

//                Console.WriteLine($"Minimul este: {minim}");
//                Console.WriteLine($"Maximul este: {maxim}");
//                #endregion
            
//        }

//    }

//}
