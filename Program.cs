/*
Print the Pattern 2 in reverse from Coding Challenges
by Silvio Duka

Last modified date: 2018-03-13

Write a program to output the following patterns given the number of rows: 
Pattern #1 
1 
4 9 
16 25 36 
49 64 81 100 
121 144 169 196 225 
and so on. 

Pattern #2 
1 
3 2 
6 5 4 
10 9 8 7 
15 14 13 12 11 
and so on. 

Pattern #3 

A B 
C D E F 
G H I J K L 
M N O P Q R S T 
U V W X Y Z A B C D 
and so on. 

Pattern #4 
### 
#### 
##### 
###### 
##### 
#### 
### 

Pattern #5 
###### 
##### 
#### 
### 
#### 
##### 
###### 

As a second challenge, create a program to output the patterns in reverse (from bottom row to top).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintThePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = 1; // Insert a pattern type (1, 2, 3, 4, 5)
            var rows = 5; // Insert a number of rows

            PrintPattern(pattern, rows);
        }

        static void PrintPattern(int p, int r)
        {
            Console.WriteLine($"Pattern #{p}");

            switch (p)
            {
                case 1:
                    {
                        int n = (int)Math.Pow((r * (r + 1) / 2), 2), m = r * (r + 1) - 1;

                        for (int i = r; i >= 1; i--)
                        {
                            string s = String.Empty;

                            for (int j = 1; j <= i; j++)
                            {
                                s = n.ToString() + " " + s;
                                n += -m;
                                m -= 2;
                            }

                            Console.WriteLine($"{s}");
                        }
                    }
                    break;

                case 2:
                    {
                        int n = r * (r + 1) / 2;

                        for (int i = r; i >= 1; i--)
                        {
                            string s = String.Empty;

                            for (int j = 1; j <= i; j++)
                            {
                                s += n.ToString() + " ";
                                n--;
                            }

                            Console.WriteLine($"{s}");
                        }
                    }
                    break;

                case 3:
                    {
                        char n = (char)(r * (r + 1) - 26 + 'A' - 1);

                        for (int i = r; i >= 1; i--)
                        {
                            string s = String.Empty;

                            for (int j = 1; j <= i * 2; j++)
                            {
                                s = n.ToString() + " " + s;
                                n--;
                                if (n < 'A') n = 'Z';
                            }

                            Console.WriteLine($"{s}");
                        }
                    }
                    break;

                case 4:
                    {
                        int n = r / 2;
                        int m = 1;

                        for (int i = 1; i <= r + 1; i++)
                        {
                            string s = String.Empty;

                            Console.WriteLine($"{new String('#', n)}");

                            n += m;

                            if (n == r) m = -1;
                        }
                    }
                    break;

                case 5:
                    {
                        int n = r;
                        int m = -1;

                        for (int i = 1; i <= r + 1; i++)
                        {
                            string s = String.Empty;

                            Console.WriteLine($"{new String('#', n)}");

                            n += m;

                            if (n == r / 2) m = 1;
                        }
                    }
                    break;
            }
        }
    }
}