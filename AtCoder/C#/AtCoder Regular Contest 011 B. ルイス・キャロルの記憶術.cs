//AtCoder Regular Contest 011
//B. ルイス・キャロルの記憶術
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputMax = int.Parse(Console.ReadLine());
            string[] inputs = Console.ReadLine().Split(' ');
            bool isPrinted = false;
            for (int i = 0; i < inputMax; i++)
            {
                inputs[i] = inputs[i].ToLower();
                if (isPrinted)
                {
                    for (int j = 0; j < inputs[i].Length; j++)
                    {
                        if (inputs[i][j] == 'z' ||
                            inputs[i][j] == 'r' ||
                            inputs[i][j] == 'b' ||
                            inputs[i][j] == 'c' ||
                            inputs[i][j] == 'd' ||
                            inputs[i][j] == 'w' ||
                            inputs[i][j] == 't' ||
                            inputs[i][j] == 'j' ||
                            inputs[i][j] == 'f' ||
                            inputs[i][j] == 'q' ||
                            inputs[i][j] == 'l' ||
                            inputs[i][j] == 'v' ||
                            inputs[i][j] == 's' ||
                            inputs[i][j] == 'x' ||
                            inputs[i][j] == 'p' ||
                            inputs[i][j] == 'm' ||
                            inputs[i][j] == 'h' ||
                            inputs[i][j] == 'k' ||
                            inputs[i][j] == 'n' ||
                            inputs[i][j] == 'g' )
                        {
                            Console.Write(" ");
                            break;
                        }
                    }
                }
                for (int j = 0; j < inputs[i].Length; j++)
                {
                    if (inputs[i][j] == 'z' || inputs[i][j] == 'r')
                    {
                        Console.Write(0);
                        isPrinted = true;
                    }
                    else if (inputs[i][j] == 'b' || inputs[i][j] == 'c')
                    {
                        Console.Write(1);
                        isPrinted = true;
                    }
                    else if (inputs[i][j] == 'd' || inputs[i][j] == 'w')
                    {
                        Console.Write(2);
                        isPrinted = true;
                    }
                    else if (inputs[i][j] == 't' || inputs[i][j] == 'j')
                    {
                        Console.Write(3);
                        isPrinted = true;
                    }
                    else if (inputs[i][j] == 'f' || inputs[i][j] == 'q')
                    {
                        Console.Write(4);
                        isPrinted = true;
                    }
                    else if (inputs[i][j] == 'l' || inputs[i][j] == 'v')
                    {
                        Console.Write(5);
                        isPrinted = true;
                    }
                    else if (inputs[i][j] == 's' || inputs[i][j] == 'x')
                    {
                        Console.Write(6);
                        isPrinted = true;
                    }
                    else if (inputs[i][j] == 'p' || inputs[i][j] == 'm')
                    {
                        Console.Write(7);
                        isPrinted = true;
                    }
                    else if (inputs[i][j] == 'h' || inputs[i][j] == 'k')
                    {
                        Console.Write(8);
                        isPrinted = true;
                    }
                    else if (inputs[i][j] == 'n' || inputs[i][j] == 'g')
                    {
                        Console.Write(9);
                        isPrinted = true;
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
