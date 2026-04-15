using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Task1.Ex1 first = new Task1.Ex1();
        Task1.Ex2 second = new Task1.Ex2();
        Task1.Ex3 third = new Task1.Ex3();
        Task1.Ex4 fourth = new Task1.Ex4();


            first.Execute();
            second.Execute();
            third.Execute();       
 
            fourth.Execute();

    }
}

namespace Task1
{
    internal class Ex1
    {
        public void Execute()
        {
            int year = 0;
            Console.WriteLine("ex1");
            Console.WriteLine("please, enter year");
            string yearSt = Console.ReadLine();
            try
            {
                year = int.Parse(yearSt);
            }
            catch { Console.WriteLine("incorrect data"); return; }
            //Console.WriteLine("text" + year);
            if (year % 4 == 0)
            { //на замітку для себе ( %х == у означає остача у при діленні на число х)
                //Console.WriteLine("checkup 1 done"); 
                if (year % 100 != 0)
                {
                    //Console.WriteLine("checkup2 done");
                    Console.WriteLine("this is a leap year");
                }
                else
                {
                    if (year % 400 == 0)
                    {
                        //Console.WriteLine("checkup3 done");
                        Console.WriteLine("this is a leap year");
                    }
                    else { Console.WriteLine("this isn`t a leap year"); }
                }
            }
            else { Console.WriteLine("this isn`t a leap year"); }
        }
    }
    internal class Ex2 {
        public void Execute()
        {
            int height = 1;
            Console.WriteLine("ex2");
            Console.WriteLine("please, enter triangle`s height");
            string heightSt = Console.ReadLine();
            try
            {
                height = int.Parse(heightSt) + 1;
            }
            catch { Console.WriteLine("incorrect data"); return; }
            //Console.WriteLine(height);
            for (int i = 0; i < height; i++)
            {

                double crutch = (height - i);
                for (int k = 0; k < crutch; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
    internal class Ex3
    {
        private int sc = 0;
        private bool wrongAnswer = false;
        public void Execute()
        {
            P1();
            if (wrongAnswer) return;
            P2();
            if (wrongAnswer) return;
            P3();
            if (wrongAnswer) return;
            P4();
            if (wrongAnswer) return;
            P5();
            if (wrongAnswer) return;
            P6();
            if (wrongAnswer) return;
        }
        private void P1()
        {
            int score = sc * 100;
            Console.WriteLine("ex3");
            Console.WriteLine("question N 1! what are the colors of the flag of Ukraine?"); //start of block
            Console.WriteLine("1) yellow and blue");
            Console.WriteLine("2) red and green");
            Console.WriteLine("3) black and yellow");
            Console.WriteLine("4) green and magenta");

            string answerSt = Console.ReadLine();
            int answer = 0;

            try
            {
                answer = int.Parse(answerSt);
            }
            catch
            {
                Console.WriteLine("this even is not an answer!");
                Console.WriteLine("you loose");
                Console.WriteLine("your score is" + score);
                wrongAnswer = true;
            }
            if (answer != 1)
            {
                Console.WriteLine("wrong answer!");
                Console.WriteLine("your score is" + score);
                wrongAnswer = true;
            }
            else
            {
                sc = sc + 1;
            }
        }                                                                                   //end of block
        private void P2()
        {                                                                                   //start
            int score = sc * 100;
            Console.WriteLine("your score is" + score);
            Console.WriteLine("question N 2! where  is ukraine located?");
            Console.WriteLine("1) Europe");
            Console.WriteLine("2) Asia");
            Console.WriteLine("3) Arctic");
            Console.WriteLine("4) Australia");

            string answerSt = Console.ReadLine();
            int answer = 0;
            try
            {
                answer = int.Parse(answerSt);
            }
            catch
            {
                Console.WriteLine("this even is not an answer!");
                Console.WriteLine("you loose");
                Console.WriteLine("your score is" + score);
                wrongAnswer = true;
            }
            if (answer != 1)
            {
                Console.WriteLine("wrong answer!");
                Console.WriteLine("your score is" + score);
                wrongAnswer = true;
            }
            else
            {
                sc = sc + 1;
            }
        }                                                                                   //end
        private void P3()
        {                                                                                   //start
            int score = sc * 100;
            Console.WriteLine("your score is" + score);
            Console.WriteLine("question N 3! how many people live in Ukraine in 2023?");
            Console.WriteLine("1) 31,5 ");
            Console.WriteLine("2) 31");
            Console.WriteLine("3) 32");
            Console.WriteLine("4) 32,5");

            string answerSt = Console.ReadLine();
            int answer = 0;
            try
            {
                answer = int.Parse(answerSt);
            }
            catch
            {
                Console.WriteLine("this even is not an answer!");
                Console.WriteLine("you loose");
                Console.WriteLine("your score is" + score);
                wrongAnswer = true;
            }
            if (answer != 1)
            {
                Console.WriteLine("wrong answer!");
                Console.WriteLine("your score is" + score);
                wrongAnswer = true;
            }
            else
            {
                sc = sc + 1;
            }
        }                                                                                   //end
        private void P4()
        {                                                                                       //start
            int score = sc * 100;
            Console.WriteLine("your score is" + score);
            Console.WriteLine("question N 4! when does WWII started?");
            Console.WriteLine("1) 1 September 1939");
            Console.WriteLine("2) 11 September 1939");
            Console.WriteLine("3) 21 September 1939");
            Console.WriteLine("4) 31 September 1939");

            string answerSt = Console.ReadLine();
            int answer = 0;
            try
            {
                answer = int.Parse(answerSt);
            }
            catch
            {
                Console.WriteLine("this even is not an answer!");
                Console.WriteLine("you loose");
                Console.WriteLine("your score is" + score);
                wrongAnswer = true;
            }
            if (answer != 1)
            {
                Console.WriteLine("wrong answer!");
                Console.WriteLine("your score is" + score);
                wrongAnswer = true;
            }
            else
            {
                sc = sc + 1;
            }
        }                                                                                   //end
        private void P5()
        {                                                                                            //start
            int score = sc * 100;
            Console.WriteLine("your score is" + score);
            Console.WriteLine("question N 2! when does WWII ended?");
            Console.WriteLine("1) 2 September 1945");
            Console.WriteLine("2) 12 September 1945");
            Console.WriteLine("3) 22 September 1945");
            Console.WriteLine("4) 1 September 1945");

            string answerSt = Console.ReadLine();
            int answer = 0;
            try
            {
                answer = int.Parse(answerSt);
            }
            catch
            {
                Console.WriteLine("this even is not an answer!");
                Console.WriteLine("you loose");
                Console.WriteLine("your score is" + score);
                wrongAnswer = true;
            }
            if (answer != 1)
            {
                Console.WriteLine("wrong answer!");
                Console.WriteLine("your score is" + score);
                wrongAnswer = true;
            }
            else
            {
                sc = sc + 1;
            }
        }                                                                                   //end
        private void P6()
        {
            int score = sc * 100;
            Console.WriteLine("You won! your score is  " + score);
        }
    }
    internal class Ex4
    {
        public void Execute()
        {
            float calculate = 0;
            bool check = false;
            bool hardNum = false;
            int d = 0;
            int e = 0;
            char c = '1';
            int a = 0; 
            char b = ' ';
            int result = 0;
            Console.WriteLine("ex 4");
            Console.WriteLine("please, enter, what you neen to calculate (example: 5+5*10+4/2-3)");
            string calculateSt = Console.ReadLine();
            for (int i = 0; i < calculateSt.Length; i++)
            {
                char character = calculateSt[i];
                //Console.WriteLine(i); 
                ////c = character;
                ////a = (int)Char.GetNumericValue(c);

                if (i%2 == 1)
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
/*                if (character != '+' && character != '-' && character != '*' && character != '/')
                {
                    hardNum = true;
                }
                else 
                {
                    hardNum = false;
                }*/
                if (character != '+' && character != '-' && character != '*' && character != '/')
                {
                    if (hardNum == true)
                    {
                        c = character;
                        e = (int)Char.GetNumericValue(c);
                        a = a * 10 + e;
                    }
                    else
                    {
                        c = character;
                        a = (int)Char.GetNumericValue(c);
                        hardNum = true;
                    }
                }
                else if (character == '+')
                {
                    // операція плюс
                    //Console.WriteLine(character);
                    b = '+';
                    hardNum = false;
                    //i++;
                }
                else if (character == '-')
                {
                    // операція мінус 
                    //Console.WriteLine(character);
                    b = '-';
                    hardNum = false;
                    //i++;
                }
                else if (character == '*')
                {
                    // операція множення 
                    //Console.WriteLine(character);
                    b = '*';
                    hardNum = false;
                    //i++;
                }
                else if (character == '/')
                {
                    // операція ділення 
                    //Console.WriteLine(character);
                    b = '/';
                    hardNum = false;
                    //i++;
                }
/*                else
                {
                   //Console.WriteLine(character);
                    c = character;
                    a = (int)Char.GetNumericValue(c);
                }*/

                if ( b == '+')
                {
                    if (check == false)
                    {
                        d = d + a;
                        b = ' ';
                    }
                    else if(i ==1 ) { d = a * 1; }
                    else {d = d *1; }

                }
                else if (b == '-')
                {
                    if (check == false)
                    {
                        d = d - a;
                        b = ' ';
                    }
                    else if (i == 1) { d = a * 1; }
                    else { d = d * 1; }
                }
                else if (b == '*')
                {
                    if (check == false)
                    {
                        d = d * a;
                        b = ' ';
                    }
                    else if (i == 1) { d = a * 1; }
                    else { d = d * 1; }
                }
                else if (b == '/')
                {
                    if (check == false)
                    {
                        d = d / a;
                        b = ' ';
                    }
                    else if(i == 1) { d = a * 1; }
                    else { d = d * 1; }
                }

                result = d;
                //Console.WriteLine(result); 
            }
            Console.WriteLine(result);
/*            int cheking = int.Parse("1"+ "0");
            Console.WriteLine(cheking);*/

        }
    }
}


