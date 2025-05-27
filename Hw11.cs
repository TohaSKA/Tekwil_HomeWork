//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp_less1
//{
//    class Hw11
//    {

//        static SemaphoreSlim semaphore = new SemaphoreSlim(3);


//        static void Main()
//        {
//            #region Acces controlat la o bază de date

//            Console.WriteLine("Start simulare acces la baza de date cu maxim 3 conexiuni simultane.\n");

            
//            for (int i = 1; i <= 10; i++)
//            {
//                int conexiuneId = i; 
//                Task.Run(() => AccesBazaDeDate(conexiuneId));
//            }

            
//            Console.ReadLine();
//        }

//        static void AccesBazaDeDate(int id)
//        {
//            Console.WriteLine($"Conexiunea {id} incearca sa se conecteze...");

            
//            semaphore.Wait();

//            try
//            {
//                Console.WriteLine($"Conexiunea {id} a fost acceptata si este activa.");


//                Thread.Sleep(2000);

//                Console.WriteLine($"Conexiunea {id} se inchide.");
//            }
//            finally
//            {

//                semaphore.Release();
//            }
//            #endregion
//        }
//    }
//}
