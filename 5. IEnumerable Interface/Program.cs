using System.Diagnostics;
using System.Collections;
namespace MultipleInheritance
{
    class Money
    {
        public int amount;
    }
    class Wallet : IEnumerable
    {
        Money[] bills = null;
        int openIndex = 0;

        public Wallet()
        {
            bills = new Money[100];
        }

        public void Add(Money bill)
        {
            bills[openIndex] = bill;
            openIndex++;
        }
        public IEnumerator GetEnumerator()
        {
            foreach (Money bill in bills)
            {
                if (bill == null) break;
                yield return bill;
            }
        }
    }

    class Program
    {
        public static void Main(string[] arg)
        {
            Wallet wallet = new Wallet();
            wallet.Add(new Money() { amount = 1 });
            wallet.Add(new Money() { amount = 5 });
            wallet.Add(new Money() { amount = 10 });
            wallet.Add(new Money() { amount = 20 });
            wallet.Add(new Money() { amount = 50 });
            wallet.Add(new Money() { amount = 100 });
            wallet.Add(new Money() { amount = 200 });

            foreach(Money money in wallet){
                Console.WriteLine("Bill " + money.amount);
            }
        }
    }
}
