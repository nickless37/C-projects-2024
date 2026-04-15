using System;

class Program
{
    static void Main()
    {
        Executing.Ex1 first = new Executing.Ex1();
        //Executing.Ex2 second = new Executing.Ex2();
        //Executing.Ex3 third = new Executing.Ex3();
        //Executing.Ex4 fourth = new Executing.Ex4();


        first.Execute();
        //second.Execute();
        //third.Execute();       
        //fourth.Execute();

    }
}
namespace Executing
{
    internal class Ex1
    {
        public void Execute()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Ex 1");
            Console.ResetColor();


            int numberOfCustomers = 0;
            int shopGain = 0;
            string[] goods = ["олiвець", "ручка", "точилка", "клей","зошит", "набiр ольовцiв", "набiр фарб", "щоденник", "степлер", "дирокол"];
            int[] prices = [1000, 2000, 3000, 4000, 5000, 6000, 7000, 8000, 9000, 10000];
            bool customerIsOut= false;
            int choose = -1;


            Random rnd = new Random(); 

            for (; ; )
            {
                Console.WriteLine("enter number of customers");
                try
                {
                    numberOfCustomers = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("wrong format, try again");
                }
            }



            int[] customerCards = new int[numberOfCustomers];
            int[] customerBudget = new int[numberOfCustomers];
            int[] boughtCounter= new int[numberOfCustomers];
            int[] spentCounter = new int[numberOfCustomers];
            int[] goodsAmount = new int[10];
            for (int i=0; i<10; i++)
            {
                goodsAmount[i] = rnd.Next(1, numberOfCustomers);
            }
            //goodsAmount[0] = numberOfCustomers * 10;


            // Присвоюєння властивостей
            for (int i = 0; i < numberOfCustomers; i++)
            {

                customerCards[i] = rnd.Next(1, 1001);             //верхня границя не може випасти
                customerBudget[i] = rnd.Next(1, 11) * 1000;


            }

            for (int i = 0;i < numberOfCustomers; i++)            //вивід початкової інформації про покупця
            {
                Console.WriteLine($"Покупець N{i + 1}: Номер картки - {customerCards[i]}; Кiлькiсть грошей - {customerBudget[i]}");
            }

            Console.WriteLine(" ");

            for (int i = 0; i < 10; i++)                          //вивід початкової інформації про товар
            {
                Console.WriteLine($"товар N{i + 1}: назва - {goods[i]}; цiна - {prices[i]}; кiлькiсть - {goodsAmount[i]}");
            }

            for (int i = 0; i < numberOfCustomers; i++)            
            {

                for (; customerIsOut = true;)
                {
                    //перевірк на можливість закупу
                    for (int j = 0; j < 10; j++)
                    {
                        if (customerBudget[i] >= prices[j] && goodsAmount[j] > 0)
                        {
                            //Console.WriteLine($"Покупець може купити {goods[j]}.");
                            customerIsOut = false;
                            break;
                        }
                        else
                        {
                            customerIsOut = true;
                        }
                    }
                    if(customerIsOut == true)
                    {
                        break;
                    }

                    //закуп
                    choose = rnd.Next(0, 10);

                    if (customerBudget[i] >= prices[choose])
                    {
                        customerBudget[i] = customerBudget[i] - prices[choose];
                        shopGain = shopGain + prices[choose];
                        goodsAmount[choose] = goodsAmount[choose] - 1;
                        boughtCounter[i] = boughtCounter[i] + 1;
                        spentCounter[i] = spentCounter[i] + prices[choose];
                    }
                }



            }



            // пошук покупця з найбільшою кількістю покупок
            int boughtMax = -1;
            int boughtMaxNUMBER = -1;
            for (int i = 0; i < numberOfCustomers; i++)
            {
                if (boughtCounter[i] > boughtMax)
                {
                    boughtMax = boughtCounter[i];
                    boughtMaxNUMBER = i;
                }
            }

            // пошук покупця з найбільшими витратами
            int spentMax = -1;
            int spentMaxNUMBER = -1;
            for (int i = 0; i < numberOfCustomers; i++)
            {
                if (spentCounter[i] > spentMax)
                {
                    spentMax = spentCounter[i];
                    spentMaxNUMBER = i;
                }
            }


            Console.WriteLine($"Прибуток магазину - {shopGain}");
            Console.WriteLine($"Більше всього товарів купив покупець номер  {boughtMaxNUMBER}");
            Console.WriteLine($" {shopGain}");


        }
    }
}