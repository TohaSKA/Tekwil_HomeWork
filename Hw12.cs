using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_less1
{

    public class Hw12
    {
        static async Task Main(string[] args)
        {
            #region Ex1 Citire asincronă de fișiere
            //        /*
            //        Cerință:
            //        Ai mai multe fișiere text într-un director (ex. data1.txt, data2.txt, data3.txt). 
            //        Creează un program care citește conținutul tuturor fișierelor asincron și afișează pe ecran numărul total de linii pentru fiecare fișier.
            //        Cerinte suplimentare:
            //        Creează o metodă ReadLinesAsync(string filePath) care returnează numărul de linii.
            //        Folosește Task.WhenAll pentru a le citi în paralel.
            //        Asigură-te că aplicația nu se blochează în timpul citirii.
            //        */

            //            string directoryPath = @"D:\Tekwil\ConsoleApp_less1\ConsoleApp_less1\hw_10"; 

            //            string[] filePaths = Directory.GetFiles(directoryPath, "*.txt");


            //            var tasks = filePaths.Select(filePath => CountLinesInFileAsync(filePath)).ToArray(); //paralel task

            //            var results = await Task.WhenAll(tasks);


            //            foreach (var result in results)
            //            {
            //                Console.WriteLine($"{result.FileName}: {result.LineCount} linii");
            //            }
            //        }

            //private record FileLineCount(string FileName, int LineCount);


            //    static async Task<FileLineCount> CountLinesInFileAsync(string filePath)
            //    {
            //        int lineCount = await ReadLinesAsync(filePath);
            //        return new FileLineCount(Path.GetFileName(filePath), lineCount);
            //    }


            //    static async Task<int> ReadLinesAsync(string filePath)
            //    {
            //        int count = 0;

            //        using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, useAsync: true))
            //        using (var reader = new StreamReader(stream))
            //        {
            //            while (await reader.ReadLineAsync() is not null)
            //            {
            //                count++;
            //            }
            //        }

            //        return count;
            //    }



            #endregion
            #region Ex2 Simulare de sarcini lente (I/O)
            /*
             Ex2 Simulare de sarcini lente (I/O)
             Cerință:
            Simulează procesarea mai multor comenzi de la clienți, fiecare necesitând 2-5 secunde pentru a fi procesată. Fiecare comandă va fi procesată asincron.
            Cerinte suplimentare:
            - Creează o clasă OrderProcessor cu o metodă ProcessOrderAsync(int orderId).
            - Folosește Task.Delay pentru a simula timpul de procesare.
            - Generează și procesează 5 comenzi în paralel.
            - Afișează mesajul „Order X processed in Y ms.” pentru fiecare comandă.
             */

            var processor = new OrderProcessor();
            var random = new Random();

            // 5 comenzi in paralel
            var tasks = Enumerable.Range(1, 5)
                .Select(orderId => processor.ProcessOrderAsync(orderId))
                .ToArray();

            await Task.WhenAll(tasks);
        }
    }

    public class OrderProcessor
    {
        private readonly Random _random = new();

        public async Task ProcessOrderAsync(int orderId)
        {
            var stopwatch = Stopwatch.StartNew();


            int delay = _random.Next(2000, 5001); //simulare intre 2 si 5 secunde
            await Task.Delay(delay);

            stopwatch.Stop();

            Console.WriteLine($"Comanda 1 {orderId} procesata in {stopwatch.ElapsedMilliseconds} ms.");
        }
    }
    #endregion 

}

