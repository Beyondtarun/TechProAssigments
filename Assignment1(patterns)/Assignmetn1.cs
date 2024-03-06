using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Assignment
{
    internal class Assignmetn1
    {
        public void BinaryTriangle(int n)
        {
            Console.WriteLine("Binary Triangle");

            for( int i = 0; i < n; i++ ) { 
            
            for ( int j = 0; j <= i; j++ ) {

                    if ((i + j) % 2 == 0)
                    {
                        Console.Write("1 ");
                    }
                    else
                    {
                        Console.Write("0 ");
                    }
                }
                Console.WriteLine();
            }
        }

        public void NumberPattern(int n)
        {
            Console.WriteLine("NUMBER PATTERN");

            for (int i = 0; i< n; i++ )
            {
                for(int k = 0; k < n-i-1; k++ )
                {
                    Console.Write(" ");
                }
                for(int j = 0; j <=i; j++ )
                {
                    Console.Write(i + 1+ " ");
                }
                Console.WriteLine() ;
            }
        }

        public void NumberInc(int n)
        {
            Console.WriteLine("NUMBER INCREASING");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(j+1+ " ");
                }
                Console.WriteLine();
            } 
        }
        
        public void NumberDec(int n)
        {
            Console.WriteLine("NUMBER DECREASING");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n-i; j++)
                {
                    Console.Write(j+1+ " ");
                }
                Console.WriteLine();
            } 
        }

        public void CounterPyramid(int n)
        {
            Console.WriteLine("COUNTER PYRAMID");

            int count = 1;

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j <= i; j++)
                { if(count < 10)
                    Console.Write(count+"  ");
                    else
                    {
                        Console.Write(count+" ");
                    }
                count++;
                }
                Console.WriteLine();
            }
        }
        public void Diamond( int n)
        {
            Console.WriteLine("DIAMOND");
            for (int i = 0; i < n; i++)
            {
                for (int k = n - 1 - i; k > 0; k--)
                    Console.Write(" ");
                for (int j = 0; j < (i * 2) + 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
            for (int i = 1; i < n; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = i * 2; j < (n * 2) - 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        public void Rohmbus(int n)
        {
            Console.WriteLine("ROHMBUS");
            for(int i = 0; i<n; i++)
            {
                for(int k = 0;k < n-i-1; k++)
                {
                    Console.Write(" ");
                }
                for(int j = 0; j < n; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
       public void MirrorImage(int n)
        {

            Console.WriteLine("MIRROR IMAGE");
            for (int i = 1; i < n; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = i; j <n; j++)
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n-2; i++)
            {
                for (int k = n - 2 - i; k > 0; k--)
                    Console.Write(" ");
                for (int j = n-i-2; j < n; j++)
                    Console.Write(j+" ");
                Console.Write("\n");
            }
            
        }

        public void PascalTriangle(int n)
        {
            Console.WriteLine("PASCAL TRIANGLE");
            for(int i = 1; i<= n; i++)
            {
                int B = 1;
                for(int k = 0; k < n - i; k++)
                {
                    Console.Write(" ");
                }
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(B + " ");
                    B = B * (i - j) / j;
                }
                Console.WriteLine();
            }

        }
        public void PalindromeTriangle(int n)
        {
            Console.WriteLine("PALINDROME TRIANGLE");
            for(int i = 0; i < n; i++)
            {
                for (int k = 0; k < n- i; k++)
                {
                    Console.Write("  ");
                }
                for(int j = i; j >= 0; j--)
                {
                    Console.Write(j + 1 + " ");
                }
                for (int l = 1; l <= i; l++)
                {
                    Console.Write(l + 1 + " ");
                }
                Console.WriteLine();
            }
        }


        public void SquareHollowPattern(int n){
            Console.WriteLine("HOLLOW SQUARE ");

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i == 1 || i == n || j == 1 || j == n)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        public void HollowTrianglePattern(int n){
            Console.WriteLine("HOLLOW TRIANGLE");

            for (int i = 1; i <= n; i++)
            {
                
                for (int j = 1; j <= n - i; j++)
                    Console.Write(" ");

                
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    if (k == 1 || k == 2 * i - 1 || i == n)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }

                Console.WriteLine();
            }
        }

        
        public void HollowReverseTrianglePattern(int n)
        {
            Console.WriteLine("HOLLOW REVERSE TIRANGLE");

            for (int i = n; i >= 1; i--)
            {
                
                for (int j = 1; j <= n - i; j++)
                    Console.Write(" ");

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    if (k == 1 || k == 2 * i - 1 || i == n)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }

                Console.WriteLine();
            }
        }

        
        public void HollowDiamondPyramid(int n)
        {
            Console.WriteLine("HOLLOW DIAMOND");

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                    Console.Write(" ");
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    if (k == 1 || k == 2 * i - 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 1; j <= n - i; j++)
                    Console.Write(" ");
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    if (k == 1 || k == 2 * i - 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        
        public void HollowHourglassPattern(int n)
        {
            Console.WriteLine("HOLLOW HOUR GLASS");
            for (int i = 0; i < n; i++)
            {
                
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }

                
                for (int j = 0; j < n - i; j++)
                {
                    if (i == 0 || i == n - 1 || j == 0 || j == n - i - 1)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }

                Console.WriteLine();
            }

          
            for (int i = n - 2; i >= 0; i--)
            {
               
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }

                
                for (int j = 0; j < n - i; j++)
                {
                    if (i == 0 || i == n - 1 || j == 0 || j == n - i - 1)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }

                Console.WriteLine();
            }
        }



    }
}
