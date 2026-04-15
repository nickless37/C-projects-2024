using System;
using System.Collections.Generic;

namespace CommandPatternCalculator
{
    // Interface
    public interface ICommand
    {
        void Execute();
        void Undo();
    }

 
    public class Calculator
    {
        private double result;

        public double Result
        {
            get { return result; }
            private set { result = value; }
        }

        public void Add(double value) => Result += value;
        public void Subtract(double value) => Result -= value;
        public void Multiply(double value) => Result *= value;
        public void Divide(double value)
        {
            if (value != 0)
                Result /= value;
            else
                throw new DivideByZeroException("Cannot divide by zero.");
        }
    }

    // command: add 
    public class AddCommand : ICommand
    {
        private Calculator calculator;
        private double operand;

        public AddCommand(Calculator calculator, double operand)
        {
            this.calculator = calculator;
            this.operand = operand;
        }

        public void Execute() => calculator.Add(operand);
        public void Undo() => calculator.Subtract(operand);
    }

    // command: substract
    public class SubtractCommand : ICommand
    {
        private Calculator calculator;
        private double operand;

        public SubtractCommand(Calculator calculator, double operand)
        {
            this.calculator = calculator;
            this.operand = operand;
        }

        public void Execute() => calculator.Subtract(operand);
        public void Undo() => calculator.Add(operand);
    }

    // command: multiply
    public class MultiplyCommand : ICommand
    {
        private Calculator calculator;
        private double operand;

        public MultiplyCommand(Calculator calculator, double operand)
        {
            this.calculator = calculator;
            this.operand = operand;
        }

        public void Execute() => calculator.Multiply(operand);
        public void Undo() => calculator.Divide(operand);
    }

    // command: divide
    public class DivideCommand : ICommand
    {
        private Calculator calculator;
        private double operand;

        public DivideCommand(Calculator calculator, double operand)
        {
            this.calculator = calculator;
            this.operand = operand;
        }

        public void Execute() => calculator.Divide(operand);
        public void Undo() => calculator.Multiply(operand);
    }

    // starter
    public class CommandInvoker
    {
        private Stack<ICommand> commandHistory = new Stack<ICommand>();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            commandHistory.Push(command);
        }

        public void Undo()
        {
            if (commandHistory.Count > 0)
            {
                ICommand command = commandHistory.Pop();
                command.Undo();
            }
        }
    }




    /*    public class Program
        {
            public static void Main()
            {
                Calculator calculator = new Calculator();
                CommandInvoker invoker = new CommandInvoker();


                ICommand addCommand = new AddCommand(calculator, 10);
                invoker.ExecuteCommand(addCommand);
                Console.WriteLine("R1: " + calculator.Result);

                ICommand multiplyCommand = new MultiplyCommand(calculator, 2);
                invoker.ExecuteCommand(multiplyCommand);
                Console.WriteLine("R2: " + calculator.Result);


                invoker.Undo();
                Console.WriteLine("R3: " + calculator.Result);

                ICommand divideCommand = new DivideCommand(calculator, 5);
                invoker.ExecuteCommand(divideCommand);
                Console.WriteLine("R4: " + calculator.Result);
            }
        }*/
    public class Program
    {
        public static void Main()
        {
            Calculator calculator = new Calculator();
            CommandInvoker invoker = new CommandInvoker();
            for (int i = 0; i < 10; i++) {
                Console.WriteLine("enter operation: ");
                string n = Console.ReadLine();
                Console.WriteLine("enter number: ");
                int number = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case "+" or "plus":
                        ICommand addCommand = new AddCommand(calculator, number);
                        invoker.ExecuteCommand(addCommand);
                        Console.WriteLine("Result: " + calculator.Result);
                        break;
                    case "*" or "multiply":
                        ICommand multiplyCommand = new MultiplyCommand(calculator, number);
                        invoker.ExecuteCommand(multiplyCommand);
                        Console.WriteLine("Result: " + calculator.Result);
                        break;
                    case "-" or "substract":
                        ICommand substractCommand = new SubtractCommand(calculator, number);
                        invoker.ExecuteCommand(substractCommand);
                        Console.WriteLine("Result: " + calculator.Result);
                        break;
                    case "/" or "divide":
                        ICommand divideCommand = new DivideCommand(calculator, number);
                        invoker.ExecuteCommand(divideCommand);
                        Console.WriteLine("Result: " + calculator.Result);
                        break;
                    case "undo":
                        invoker.Undo();
                        Console.WriteLine("Result: " + calculator.Result);
                        break;
                }
            }
        }
    }
}