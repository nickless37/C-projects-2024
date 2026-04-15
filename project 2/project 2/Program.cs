// у цій роботі були використані нововведення у вигляді зміни кольору номеру завдання та можливость повторного виконання одного завдання. Якщо Ви вважаєте їх непотрібними або навпаки маєте ідеї, стосовно покращення наступних робіт прошу повідомити про це за допомогою зворотнього зв'язку
class Program
{
    static void Main()
    {
        Executing.Ex1 first = new Executing.Ex1();
        Executing.Ex2 second = new Executing.Ex2();
        Executing.Ex3 third = new Executing.Ex3();
        Executing.Ex4 fourth = new Executing.Ex4();


        //first.Execute();
//second.Execute();
        third.Execute();       
        fourth.Execute();

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
            Console.WriteLine("please enter number, that will be reversed");
            string input = Console.ReadLine();
            int number = 0;
            int numeric2 = 0;
            bool NegativeNumber = false;
            int[] result1 = [];
            string result2 = "";
            int result3 = 0;
            int result4 = 0;
            List<int> hanoi = new List<int> { };
            for (int i = 0; i < 1;)
            {
                try
                {
                    number = int.Parse(input);
                    i++;
                }
                catch
                {
                    Console.WriteLine("wrong format. try again");
                    input = Console.ReadLine();
                }
                //Console.WriteLine(number);
            }
            if (number < 0)
            {
                NegativeNumber = true;
                number = number * -1;
                input = number + "";
            }
            else { NegativeNumber = false; }
            for (int i = 0; i < input.Length; i++)
            {
                char numeric = input[i];
                //Console.WriteLine(numeric);
                numeric2 = (int)char.GetNumericValue(numeric);
                hanoi.Insert(0, numeric2); //на майбутнє: у цій строчці елемент numeric2 вставляється на позицію 0 у списку, що інвертує його, але також є модифікатор "назва списку.reverse, що робить те ж саме
                result1 = hanoi.ToArray();
            }
            for (int i = 0; i < result1.Length; i++)
            {
                result2 = result2 + result1[i];
            }
            result3 = int.Parse(result2);
            if (NegativeNumber == true)
            {
                result4 = result3 * -1;
                Console.WriteLine(result4);
            }
            else
            {
                result4 = result3;
                Console.WriteLine(result4);
            }
        }
    }
    internal class Ex2
    {
        public void Execute()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Ex 2");
            Console.ResetColor();
            int number = 0;
            string text = "error in text output";
            string[] words = { "error in words output" };

            List<string> TemporaryList = new List<string> { };
            Console.WriteLine("please enter text");
            text = Console.ReadLine();
            for (int i = 0; i < 1;)
            {
                if (text != null && text != "" && text != " ")
                {
                    i = 1;
                }
                else { Console.WriteLine("please, don`t leave field empty"); text = Console.ReadLine(); }
            }
            Console.WriteLine("please enter number of words, that will be deleted");
            string numberSt = Console.ReadLine();
            for (int i = 0; i < 1;)
            {
                try
                {
                    number = int.Parse(numberSt);
                    i = 1;
                }
                catch
                {
                    Console.WriteLine("wrong format, try again");
                    numberSt = Console.ReadLine();
                }
            }
            int WordCount = CountWords(text);
            string[] WordsList = WordsMasive(text);
            ////////////////////////////////////////////////////////////////////////////////// замітка для себе: потренуватися з підпрограмами
            static int CountWords(string text2)
            {

                char[] delimiters = { ' ' };
                string[] words = text2.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

                return words.Length;
            }
            //////////////////////////////////////////////////////////////////////////////////
            static string[] WordsMasive(string text2)
            {

                char[] delimiters = { ' ' };
                string[] words = text2.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

                return words;
            }
            //Console.WriteLine(WordCount);
            for (int i = number; i < WordCount; i++)
            {
                //Console.WriteLine(WordsList[i]);
                TemporaryList.Add(WordsList[i]);
            }

            string result = string.Join(" ", TemporaryList);
            Console.WriteLine(result);
        }
    }
    internal class Ex3
    {
        public void Execute()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Ex 3");
            Console.ResetColor();
            string a = "";
            string b = "";
            double c = 0;
            float d = 0;
            string pi = "";
            string figure = "not set up";
            double result = 401401;
            string check = "error";
            Console.WriteLine("please chose figure, which area will be calculated (enter number OR name without spaces)");
            Console.WriteLine("1 - square");
            Console.WriteLine("2 - circle");
            Console.WriteLine("3 - rectangle");
            Console.WriteLine("4 - triangle");
            for (; ; )
            {
                Console.WriteLine("please chose figure, which area will be calculated (enter number OR name without spaces)");
                figure = Console.ReadLine();
                if (figure == "1" || figure == "square")
                {
                    
                    Console.Write("please enter ");
                    Console.WriteLine("side");
                    a = Console.ReadLine();
                    //Console.WriteLine(a);
                    try
                    {
                        c = double.Parse(a);
                    }
                    catch { Console.WriteLine("wrong format, try again (P.S. if you use floating number it must be written with [ , ], not [ . ])");  }
                    //Console.WriteLine(c);
                    result = c * c;
                }
                else if (figure == "2" || figure == "circle")
                {
                    
                    Console.Write("please enter ");
                    Console.WriteLine("radius");
                    a = Console.ReadLine();
                    //Console.WriteLine(a);
                    try
                    {
                        c = float.Parse(a);
                    }
                    catch { Console.WriteLine("wrong format, try again");  }
                    //Console.WriteLine(c);
                    result = 3.14 * c * c;
                    pi = "provided that number pi is equel to 3,14 ";
                }
                else if (figure == "3" || figure == "rectangle")
                {
                    
                    Console.Write("please enter ");
                    Console.WriteLine("fisrt side");
                    a = Console.ReadLine();
                    Console.WriteLine("second side");
                    b = Console.ReadLine();
                    try
                    {
                        c = float.Parse(a);
                        d = float.Parse(b);
                    }
                    catch { Console.WriteLine("wrong format, try again");  }
                    //Console.WriteLine(c);
                    //Console.WriteLine(d);
                    result = c * d;
                }
                else if (figure == "4" || figure == "triangle")
                {
                    
                    Console.Write("please enter ");
                    Console.WriteLine("triangles base");
                    a = Console.ReadLine();
                    Console.WriteLine("triangles height");
                    b = Console.ReadLine();
                    try
                    {
                        c = float.Parse(a);
                        d = float.Parse(b);
                    }
                    catch { Console.WriteLine("wrong format, try again");  }
                    //Console.WriteLine(c);
                    //Console.WriteLine(d);
                    result = c * d / 2;
                }
                else { Console.WriteLine("error in input, try again"); }

                    Console.WriteLine(pi + "area of chosen figure is: " + result);
                pi = "";
                    Console.WriteLine("do you want to check other? (Y or N)");
                    check = Console.ReadLine();
                    if (check == "N" || check == "n") { break; }
                // i
            }
        }
    }
    internal class Ex4
    {
        public void Execute()
        {
            string InputText = "";
            //char character = "";
            string symbol = "";
            List<string> hanoi = new List<string> { };
            //string[] result = {};
            string result = "";
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Ex 4");
            Console.ResetColor();
            Console.WriteLine("please enter any text");
            // кожен 3 - літеру X
            // кожен 5 - число 9
            // кожен 15 - (?)
            InputText = Console.ReadLine();
            for (int i = 0; i < InputText.Length; i++)
            {
                char character = InputText[i];
                symbol = (string)char.ToString(character);
                if ((1+i)%3 == 0 && i !=0) 
                {
                    if((1 + i) % 15 == 0) 
                    {
                        symbol = "?";
                        hanoi.Add(symbol);
                    }
                    else 
                    {
                        symbol = "X";
                        hanoi.Add(symbol);
                    }
                }
                else if ((1 + i) % 5 == 0 && i != 0) 
                {
                    if ((1 + i) % 15 == 0)
                    {
                        symbol = "?";
                        hanoi.Add(symbol);
                    }
                    else
                    {
                        symbol = "9";
                        hanoi.Add(symbol);
                    }
                }
                else {
                    hanoi.Add(symbol);
                }
            }
            result = string.Join("", hanoi);
            Console.WriteLine(result);
            //Console.WriteLine("HeXl9XniX9 Xed?anX 9XenX9yXs");


            //у прикладі результату вы написали "HeXl9XniX9 Xed?anX 9XenX9yXs", що налічує 2 помилки, сумарно на 5 символів, а саме: відсутність " car" та "gren" з однією е, а не двома, через що при вводі "Hello nice red car and green eyes" результат не співпадає з прикладом, написаним у тімс
        }
    }
}