///*using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp_less1
//{
//    public class hw8
//    {
//        struct Persoana
//        {
//            public string NumePers;
//            public int VarstaPers;
//            public string OcupatiePers;
//        }
//        static void Main(string[] args)
//        {
//            #region Utilizare for
//            /*Creați un program care să afișeze toate numerele pare într-un interval dat.
//Solicitați utilizatorului să introducă un număr de început și un număr de sfârșit al intervalului.
//Utilizați o buclă for pentru a itera prin toate numerele din interval.
//În fiecare iterație, verificați dacă numărul este par și, dacă este, afișați-l la ecran.
//*/
//            int startNum, endNum;

//            Console.WriteLine("Introdu inceputul intervalului");
//            startNum = int.Parse(Console.ReadLine());

//            Console.WriteLine("Introdu sfarsitul intervalului");
//            endNum = int.Parse(Console.ReadLine());

//            for (int i = startNum; i <= endNum; i++)
//            {
//                if (i % 2 == 0)
//                {
//                    Console.WriteLine(i);
//                }
//            }

//            #endregion
//            #region Utilizarea While
//            /*Creați un program care să solicite utilizatorului să introducă numere de la tastatură până la introducerea valorii 0.
//Utilizați o buclă while pentru a verifica continuu valoarea introdusă și a afișa un mesaj corespunzător în funcție de valoarea introdusă.
//Întrerupeți bucla atunci când utilizatorul introduce valoarea 0 și afișați un mesaj de încheiere.*/
//            /*
//                        int numar;

//                        Console.WriteLine("Introdu un numar (0 va finaliza programul)");
//                        numar = int.Parse(Console.ReadLine());

//                        while (numar != 0)
//                        {
//                            Console.WriteLine("Ai introdus nr:" + numar);

//                            Console.Write("Introdu un numar");
//                            numar = int.Parse(Console.ReadLine()) ;

//                        }
//                        Console.WriteLine("Programul s-a incheiat.");
//            */

//            #endregion
//            #region Utilizare foreach
//            /*
//             Creați o listă de persoane, unde fiecare persoană este reprezentată de o structură care conține informații precum Nume, Vârstă și Ocupație.
//Adăugați câteva persoane în lista de persoane, fiecare persoană fiind un obiect cu informațiile corespunzătoare.
//Utilizați o buclă foreach pentru a itera prin lista de persoane și a afișa informațiile despre fiecare persoană.
//Permiteți utilizatorului să introducă o ocupație de referință.
//Utilizați o buclă foreach pentru a itera prin lista de persoane și afișați doar persoanele care au aceeași ocupație ca și cea introdusă de utilizator.
//*/
// /*          List<Persoana> persoane = new List<Persoana>();
//            while (true)
//            {
//                Console.Write("Introduce numele (sau 'stop' pentru a termina): ");
//                string nume = Console.ReadLine()!;
//                if (nume.ToLower() == "stop")
//                    break;

//                Console.Write("Introduce varsta: ");
//                int varsta = int.Parse(Console.ReadLine()!);

//                Console.Write("Introduce ocupatia: ");
//                string ocupatie = Console.ReadLine()!;

//                persoane.Add(new Persoana { NumePers = nume, VarstaPers = varsta, OcupatiePers = ocupatie });
//            }

//            Console.WriteLine("\nToate persoanele:");
//            foreach (Persoana p in persoane)
//            {
//                Console.WriteLine($"Nume: {p.NumePers}, Varsta: {p.VarstaPers}, Ocupatie: {p.OcupatiePers}");
//            }

//            Console.Write("\nIntroduce o ocupatie pentru filtrare: ");
//            string searchOcupatie = Console.ReadLine()!;

//            Console.WriteLine($"\nPersoanele cu ocupatia '{searchOcupatie}':");
//            foreach (Persoana p in persoane)
//            {
//                if (p.OcupatiePers.ToLower() == searchOcupatie.ToLower())
//                {
//                    Console.WriteLine($"Nume: {p.NumePers}, Varsta: {p.VarstaPers}");
//                }
//            }

//*/

//            #endregion
//        }
//    }
    
//}
