using System;
using System.Collections.Generic;

namespace Exempel
{
    public class Calculator
    {
        private string[] v;
        private string answer;
        Stack<int> stack = new Stack<int>();
        public Calculator()
        {
            Console.WriteLine("Skriv in tal och operatorer");
            v = Console.ReadLine().Split(" ");
            Expression();
            Console.WriteLine(answer);
        }
        public void Expression() 
        {
            
            foreach(string s in v)
            {
                int tal;
                if(int.TryParse(s, out tal)) //Det är ett tal, pusha det till stacken
                {
                    stack.Push(tal);
                }
                else //Det är en operator 
                {
                    int tal1 = stack.Pop(), tal2 = stack.Pop();
                    switch(s)
                    {
                        case "/":
                            stack.Push(tal1 / tal2);
                            break;
                        case "+":
                            stack.Push(tal1 + tal2);
                            break;
                        case "-":
                            stack.Push(tal1 - tal2);
                            break;
                        case "*":
                            stack.Push(tal1 * tal2);
                            break;
                        default:
                            throw new FormatException("Operator is not allowed");
                    }
                }
            }
            Console.WriteLine(stack.Pop());
        }         
    }
}