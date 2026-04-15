using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main()
    {
        Executing.Ex1 first = new Executing.Ex1();
        Executing.Ex2 second = new Executing.Ex2();
/*        for (; ; )
        {
            Console.WriteLine("enter number of exersise");
            int a = int.Parse(Console.ReadLine());
            if (a == 1)
            {
                first.Execute();
            }
            else if (a == 2)
            {
                second.Execute();
            }
        }*/


        first.Execute();
        second.Execute();
        

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
            string[] goods = ["олiвець", "ручка", "точилка", "клей", "зошит", "набiр ольовцiв", "набiр фарб", "щоденник", "степлер", "дирокол"];
            int[] prices = [1000, 2000, 3000, 4000, 5000, 6000, 7000, 8000, 9000, 10000];
            bool customerIsOut = false;
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
            int[] boughtCounter = new int[numberOfCustomers];
            int[] spentCounter = new int[numberOfCustomers];
            int[] goodsAmount = new int[10];
            for (int i = 0; i < 10; i++)
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

            for (int i = 0; i < numberOfCustomers; i++)            //вивід початкової інформації про покупця
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
                    if (customerIsOut == true)
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

            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine(" ");
            Console.WriteLine($"Прибуток магазину - {shopGain}");
            Console.WriteLine($"Бiльше всього товарiв купив покупець з номером картки: {customerCards[boughtMaxNUMBER]}");
            Console.WriteLine($"Бiльше всього витратив покупець з номером картки: {customerCards[spentMaxNUMBER]}");

            Console.ResetColor();

        }
    }

    internal class Ex2
    {
        public void Execute()
        {



            string[] users = { "Fox", "Bunny", "Owl" };
            string[] usersNickname = { "@Foxmen", "@TinyBunny", "@Sage" };
            string[] usersMale = { "Foxer@gmail.com", "TinyBunny@gmail.com", "@Owl21022002@gmail.com" };
            List<string[]> myPosts = new List<string[]>();
            int[] userID = { 0, 1, 2 };





            /////////////////////////////////////////////////////////////////////////// функція створення постів
            static string[] createUserPost()
            {
                //string[] post = { "date", "text", "likes", "comments" };
                Random rnd = new Random();

                int day = rnd.Next(1, 29);
                int mont = rnd.Next(1, 13);
                string date = $"{day}.{mont}.2024";

                //int textNotSring = rnd.Next(1000, 10000);          тут був текст постів, замінений на костиль для зручності
                //string text = textNotSring.ToString();
                string text = "here could be random number";

                int likesNotString = rnd.Next(1, 21);
                string likes = likesNotString.ToString();

                /*                List<string> comments = new List<string>();
                                int com1 = rnd.Next(1, 3);
                                int com2;
                                for (; ; )
                                {
                                    com2 = rnd.Next(1, 3);
                                    if (com1 != com2) { break; }
                                }
                                if (com1 == 1) { comments.Add("wow"); }
                                else if (com1 == 2) { comments.Add("good"); }
                                else if (com1 == 3) { comments.Add("amazing"); }
                                if (com2 == 1) { comments.Add("wow"); }
                                else if (com2 == 2) { comments.Add("good"); }
                                else if (com2 == 3) { comments.Add("amazing"); }*/

                string[] post = [date, text, likes,];
                return post;
            }
            /////////////////////////////////////////////////////////////////////////////


            /*            for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                List<string[]> posts = new List<string[]>();
                                posts.Add(createUserPost());
                            }
                        }*/
            static List<string[]> addToUser()
            {
                List<string[]> posts = new List<string[]>();
                for (int j = 0; j < 5; j++)
                {
                    posts.Add(createUserPost());
                }
                return posts;
            }

            List<string[]> user1Posts = addToUser();
            List<string[]> user2Posts = addToUser();
            List<string[]> user3Posts = addToUser();

            ///////////////////////////////////////////////////////////////////////////////// фукція додавання коментарів
            static List<string> postComments()
            {
                Random rnd = new Random();
                List<string> comments = new List<string>();
                int com1 = rnd.Next(1, 3);
                int com2;
                for (; ; )
                {
                    com2 = rnd.Next(1, 3);
                    if (com1 != com2) { break; }
                }
                if (com1 == 1) { comments.Add("wow"); }
                else if (com1 == 2) { comments.Add("good"); }
                else if (com1 == 3) { comments.Add("amazing"); }
                if (com2 == 1) { comments.Add("wow"); }
                else if (com2 == 2) { comments.Add("good"); }
                else if (com2 == 3) { comments.Add("amazing"); }
                return comments;
            }
            /////////////////////////////////////////////////////////////////////////////////


            // основна причина існування коментарів до постів у такому вигляді полягає у неможливості збереження списку в одному списку з звичайними записами
            // u-user p-post

            List<string> U1P1 = postComments();
            List<string> U1P2 = postComments();
            List<string> U1P3 = postComments();
            List<string> U1P4 = postComments();
            List<string> U1P5 = postComments();

            List<string> U2P1 = postComments();
            List<string> U2P2 = postComments();
            List<string> U2P3 = postComments();
            List<string> U2P4 = postComments();
            List<string> U2P5 = postComments();

            List<string> U3P1 = postComments();
            List<string> U3P2 = postComments();
            List<string> U3P3 = postComments();
            List<string> U3P4 = postComments();
            List<string> U3P5 = postComments();

            bool isItID = false;
            bool isItMe = false;
            int ID = -1;
            List<string[]> consoleOutput = user1Posts;




            ////////////////////////////////////////////////////////////////
            static string[] createMyOwnPost()
            {
                Console.WriteLine("enter which day is it");
                int day = int.Parse(Console.ReadLine());
                Console.WriteLine("enter which month is it");
                int month = int.Parse(Console.ReadLine());
                Console.WriteLine("enter text");
                string text = Console.ReadLine();



                string date = $"{day}.{month}.2024";
                string likes = "0";
                string[] post = [date, text, likes,];
                return post;
            }
            ////////////////////////////////////////////////////////////////
            

            for (; ; )
            {
                Console.WriteLine("enter user ID(1-3) to see 5 last posts of this user or enter 'me' to see you posts ");
                string enter = Console.ReadLine();
                try
                {
                    ID = int.Parse(enter);
                    isItID = true;
                }
                catch
                {
                    if (enter == "me") { isItMe = true;}
                }

                if (isItID == true)
                {
                    Console.WriteLine($"user {ID}, name - {users[ID - 1]}, nickname - {usersNickname[ID - 1]}, mail - {usersMale[ID - 1]}");
                    if (ID == 1)
                    {
                        consoleOutput = user1Posts;
                    }
                    else if (ID == 2)
                    {
                        consoleOutput = user2Posts;
                    }
                    else if (ID == 3)
                    {
                        consoleOutput = user3Posts;
                    }

                    for (int i = 0; i < consoleOutput.Count; i++)
                    {
                        //Console.WriteLine(consoleOutput[i]);
                        Console.WriteLine($"post{i + 1}");
                        for (int j = 0; j < consoleOutput[i].Length; j++)
                        {
                            if (j == 0) { Console.WriteLine("date"); }
                            else if (j == 1) { Console.WriteLine("text"); }
                            else if (j == 2) { Console.WriteLine("likes"); }
                            Console.WriteLine(consoleOutput[i][j]);

                        }





                    }
                    Console.WriteLine("to see post coments enter U(user number)P(post number) or enter nothing to go next. Example 'U1P1'");
                    string enter2 = Console.ReadLine();
                    int checkup = 1;
                    try
                    {
                        checkup = int.Parse(enter2);
                    }
                    catch
                    {
                        //u1
                        if (enter2 == "U1P1")
                        {
                            for (int i = 0; i < U1P1.Count; i++)
                            {
                                Console.WriteLine(U1P1[i]);
                            }
                        }
                        else if (enter2 == "U1P2")
                        {
                            for (int i = 0; i < U1P2.Count; i++)
                            {
                                Console.WriteLine(U1P2[i]);
                            }
                        }
                        else if (enter2 == "U1P3")
                        {
                            for (int i = 0; i < U1P3.Count; i++)
                            {
                                Console.WriteLine(U1P3[i]);
                            }
                        }
                        else if (enter2 == "U1P4")
                        {
                            for (int i = 0; i < U1P4.Count; i++)
                            {
                                Console.WriteLine(U1P4[i]);
                            }
                        }
                        else if (enter2 == "U1P5")
                        {
                            for (int i = 0; i < U1P5.Count; i++)
                            {
                                Console.WriteLine(U1P5[i]);
                            }
                        }
                        //u2
                        else if (enter2 == "U2P1")
                        {
                            for (int i = 0; i < U2P1.Count; i++)
                            {
                                Console.WriteLine(U2P1[i]);
                            }
                        }
                        else if (enter2 == "U2P2")
                        {
                            for (int i = 0; i < U2P1.Count; i++)
                            {
                                Console.WriteLine(U2P2[i]);
                            }
                        }
                        else if (enter2 == "U2P3")
                        {
                            for (int i = 0; i < U2P1.Count; i++)
                            {
                                Console.WriteLine(U2P3[i]);
                            }
                        }
                        else if (enter2 == "U2P4")
                        {
                            for (int i = 0; i < U2P1.Count; i++)
                            {
                                Console.WriteLine(U2P4[i]);
                            }
                        }
                        else if (enter2 == "U2P5")
                        {
                            for (int i = 0; i < U2P1.Count; i++)
                            {
                                Console.WriteLine(U2P5[i]);
                            }
                        }
                        //p3
                        else if (enter2 == "U3P1")
                        {
                            for (int i = 0; i < U3P1.Count; i++)
                            {
                                Console.WriteLine(U3P1[i]);
                            }
                        }
                        else if (enter2 == "U3P2")
                        {
                            for (int i = 0; i < U3P1.Count; i++)
                            {
                                Console.WriteLine(U3P2[i]);
                            }
                        }
                        else if (enter2 == "U3P3")
                        {
                            for (int i = 0; i < U3P1.Count; i++)
                            {
                                Console.WriteLine(U3P3[i]);
                            }
                        }
                        else if (enter2 == "U3P4")
                        {
                            for (int i = 0; i < U3P1.Count; i++)
                            {
                                Console.WriteLine(U3P4[i]);
                            }
                        }
                        else if (enter2 == "U3P5")
                        {
                            for (int i = 0; i < U3P1.Count; i++)
                            {
                                Console.WriteLine(U3P5[i]);
                            }
                        }
                    }

                    string enter3 = "-1";

                    Console.WriteLine("do you want to add any comment? ");
                    enter2 = Console.ReadLine();
                    if (enter2 == "y" || enter2 == "yes" || enter2 == "Y")
                    {
                        Console.WriteLine("enter U(user number)P(post number)");
                        enter2 = Console.ReadLine();
                        Console.WriteLine("enter coment");
                        enter3 = Console.ReadLine();
                        if(enter2 == "U1P1") { U1P1.Add(enter3); }
                        else if (enter2 == "U1P2") { U1P2.Add(enter3); }
                        else if (enter2 == "U1P3") { U1P3.Add(enter3); }
                        else if (enter2 == "U1P4") { U1P4.Add(enter3); }
                        else if (enter2 == "U1P5") { U1P5.Add(enter3); }
                        else if (enter2 == "U2P1") { U2P1.Add(enter3); }
                        else if (enter2 == "U2P2") { U2P2.Add(enter3); }
                        else if (enter2 == "U2P3") { U2P3.Add(enter3); }
                        else if (enter2 == "U2P4") { U2P4.Add(enter3); }
                        else if (enter2 == "U2P5") { U2P5.Add(enter3); }
                        else if (enter2 == "U3P1") { U3P1.Add(enter3); }
                        else if (enter2 == "U3P2") { U3P2.Add(enter3); }
                        else if (enter2 == "U3P3") { U3P3.Add(enter3); }
                        else if (enter2 == "U3P4") { U3P4.Add(enter3); }
                        else if (enter2 == "U3P5") { U3P5.Add(enter3); }
                    }

                    Console.WriteLine("do you want to like any post? ");
                    enter2 = Console.ReadLine();
                    if (enter2 == "y" || enter2 == "yes" || enter2 == "Y")
                    {
                        Console.WriteLine("enter users number");
                        int choosenUser = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter number of post");
                        int choosenPost = int.Parse(Console.ReadLine());

                        int temporaryInINT = -1;
                        string temporaryInString = "-1";

                        if (choosenUser == 1)
                        {
                            temporaryInINT = int.Parse(user1Posts[choosenPost - 1][2]);
                            temporaryInINT = temporaryInINT +1;
                            user1Posts[choosenPost - 1][2] = temporaryInINT + "";
                            //user1Posts[choosenPost - 1] = user1Posts[choosenPost - 1] + 1;
                        }
                        else if (choosenUser == 2)
                        {
                            consoleOutput = user2Posts;
                        }
                        else if (choosenUser == 3)
                        {
                            consoleOutput = user3Posts;
                        }
                    }






                }

                if (isItMe)
                {
                    if (myPosts.Count == 0)
                    {
                        Console.WriteLine("there is no posts, do you want to create any?");
                        enter = Console.ReadLine();
                        if (enter == "y" || enter == "Y")
                        {
                            /*                            Console.WriteLine("enter which day is it");
                                                        int day = int.Parse(Console.ReadLine());
                                                        Console.WriteLine("enter which month is it");
                                                        int month = int.Parse(Console.ReadLine());
                                                        Console.WriteLine("enter text");
                                                        string text = Console.ReadLine();



                                                        string date = $"{day}.{month}.2024";
                                                        string likes = "0";
                                                        string[] post = [date, text, likes,];*/
                            myPosts.Add(createMyOwnPost());
                            
                        }

                    }
                    else
                    {
                        for (int i = 0; i < myPosts.Count; i++)
                        {
                            Console.WriteLine($"post number {i+1}");
                            for (int j = 0; j < myPosts[i].Length; j++) { Console.WriteLine(myPosts[i][j]); }
                            //Console.WriteLine(myPosts[i]);
                            Console.WriteLine();
                        }
                    }
                    Console.WriteLine("enter C to create new post, D to delete post, N to go next");
                    enter = Console.ReadLine();
                    if (enter == "C" || enter == "c")
                    {
                        myPosts.Add(createMyOwnPost());
                    }
                    else if (enter == "D" || enter == "d")
                    {
                        Console.WriteLine("enter number of post");
                        ID = int.Parse(Console.ReadLine());
                        myPosts.RemoveAt(ID-1);
                    }



                }

                isItID = false;
                isItMe = false;
                Console.WriteLine("leave ex 2?");
                enter= Console.ReadLine();
                if(enter == "Y" || enter == "y") { break; }
            }
        } 
    }
}