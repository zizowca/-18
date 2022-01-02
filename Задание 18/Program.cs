using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string one = Console.ReadLine();
            Console.WriteLine(Check(one));
            Console.ReadKey();
        }

        static bool Check (string one)
        {
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> sk = new Dictionary<char, char>
                {
                    {'(',')'},
                    {'{','}'},
                    {'[',']'},
                };
            foreach (char c in one)
            {
                if (c == '(' || c == '{' || c == '[')
                    stack.Push(sk[c]);
                if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0 || stack.Pop() != c)
                    {
                        return false;
                    }
                }
            }
                if (stack.Count == 0)
                    return true;
                else
                    return false;  
        }

    }
}
