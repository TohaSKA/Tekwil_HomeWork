using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_less1
{
    class ContBancar
    {
        public int Id { get; }
        public decimal Balance { get; private set; }
        private readonly object lockObj = new object();

        public ContBancar(int id, decimal soldInitial)
        {
            Id = id;
            Balance = soldInitial;
        }

        public void Depune(decimal suma)
        {
            lock (lockObj)
            {
                Balance += suma;
            }
        }

        public void Retrage(decimal suma)
        {
            lock (lockObj)
            {
                if (Balance >= suma)
                    Balance -= suma;
            }
        }

        public void Transfera(ContBancar destinatie, decimal suma)
        {

            ContBancar primul = this.Id < destinatie.Id ? this : destinatie;
            ContBancar alDoilea = this.Id < destinatie.Id ? destinatie : this;

            lock (primul.lockObj)
            {
                Thread.Sleep(100); 
                lock (alDoilea.lockObj)
                {
                    if (this.Balance >= suma)
                    {
                        this.Balance -= suma;
                        destinatie.Balance += suma;
                        Console.WriteLine($"Transfer reusit: {suma} din Cont{this.Id} in Cont{destinatie.Id}");
                    }
                    else
                    {
                        Console.WriteLine($"Fonduri insuficiente in Cont{this.Id}");
                    }
                }
            }
        }

        public void AfiseazaSold()
        {
            lock (lockObj)
            {
                Console.WriteLine($"Contul {Id} are soldul: {Balance}");
            }
        }
    }

    class Program
    {
        static void Main()
        {

            Console.Write("Introdu soldul initial pentru Contul 1: ");
            decimal sold1 = decimal.Parse(Console.ReadLine());

            Console.Write("Introdu soldul initial pentru Contul 2: ");
            decimal sold2 = decimal.Parse(Console.ReadLine());

            ContBancar cont1 = new ContBancar(1, sold1);
            ContBancar cont2 = new ContBancar(2, sold2);

            Task[] taskuri = new Task[10];

            for (int i = 0; i < 5; i++)
            {
                taskuri[i] = Task.Run(() => cont1.Transfera(cont2, 100));
                taskuri[i + 5] = Task.Run(() => cont2.Transfera(cont1, 50));
            }

            Task.WaitAll(taskuri);

            Console.WriteLine("\nSolduri finale:");
            cont1.AfiseazaSold();
            cont2.AfiseazaSold();
        }
    }
}
