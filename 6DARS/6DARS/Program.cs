namespace _6DARSQuyida 
using System;

class Program
{
    static void Main()
    {
        // 1. Add()
        Console.WriteLine(Add(2.5f, 3.5f));
        Console.WriteLine(Add(1.1f, 2.2f, 3.3f));
        Console.WriteLine(Add("Hello ", "World"));

        // 2. repeat()
        Console.WriteLine(repeat(5, 3));
        Console.WriteLine(repeat(4));

        // 3. calculate()
        Console.WriteLine(calculate(3, 4));
        Console.WriteLine(calculate(2, 3, 4));

        // 4. getAmountDigit()
        Console.WriteLine(getAmountDigit(12345));
        Console.WriteLine(getAmountDigit("a1b2c3"));

        // 5. findMax()
        Console.WriteLine(findMax(3, 7, 1));
        Console.WriteLine(findMax(3, 7, 1, 9));
        Console.WriteLine(findMax(3, 7, 1, 9, 2));

        // 6. multiplication()
        Console.WriteLine(multiplication(5));
        Console.WriteLine(multiplication(4, 7));
        Console.WriteLine(multiplication(2, 8, 5));

                                                // 7. digitCount (rekursiya)
        Console.WriteLine(digitCount(1234));

                                            // 8. sumRange (rekursiya)
        Console.WriteLine(sumRange(1, 5));

                                                             // 9. sumOfCubes
        Console.WriteLine(sumOfCubes(7));

                                           // 10. myMax()
        Console.WriteLine(myMax(5, 9));

                                        // 11. myAbs()
        Console.WriteLine(myAbs(-10));

                                   // 12. isUpper()
        Console.WriteLine(isUpper('A'));

                              // 13. toUpper()
        Console.WriteLine(toUpper('b'));

                                                                       // 14. isDigit()
        Console.WriteLine(isDigit('7'));

                                           // 15. isLower()
        Console.WriteLine(isLower('x'));

     
        Console.WriteLine(toLower('M'));

       
        Console.WriteLine(myPow(2, 5));
    }

                            // 1. Add()
    static float Add(float a, float b)
    {
        float result = a + b;
        return result;
    }

    static float Add(float a, float b, float c)
    {
        float result = a + b + c;
        return result;
    }

    static string Add(string a, string b)
    {
        string result = a + b;
        return result;
    }

                                                // 2. repeat()
    static string repeat(int a, int b)
    {
        string result = "";

        for (int i = 0; i < b; i++)
        {
            result = result + a + " ";
        }

        return result.Trim();
    }

    static string repeat(int a)
    {
        string result = "";

        for (int i = 0; i < a; i++)
        {
            result = result + a + " ";
        }

        return result.Trim();
    }

                                                 // 3. calculate()
    static int calculate(int a, int b)
    {
        int sum = a + b;
        return sum;
    }

    static int calculate(int a, int b, int c)
    {
        int product = a * b * c;
        return product;
    }

                                          // 4. getAmountDigit()
    static int getAmountDigit(int n)
    {
        n = Math.Abs(n);

        if (n == 0)
        {
            return 1;
        }

        int count = 0;

        while (n > 0)
        {
            count = count + 1;
            n = n / 10;
        }

        return count;
    }

    static int getAmountDigit(string s)
    {
        int count = 0;

        foreach (char c in s)
        {
            if (char.IsDigit(c))
            {
                count = count + 1;
            }
        }

        return count;
    }

                                                 // 5. findMax()
    static int findMax(int a, int b, int c)
    {
        int max = a;

        if (b > max)
        {
            max = b;
        }

        if (c > max)
        {
            max = c;
        }

        return max;
    }

    static int findMax(int a, int b, int c, int d)
    {
        int max = findMax(a, b, c);

        if (d > max)
        {
            max = d;
        }

        return max;
    }

    static int findMax(int a, int b, int c, int d, int e)
    {
        int max = findMax(a, b, c, d);

        if (e > max)
        {
            max = e;
        }

        return max;
    }

                                                 // 6. multiplication()
    static int multiplication(int a)
    {
        int result = 1;

        for (int i = 1; i <= a; i++)
        {
            result = result * i;
        }

        return result;
    }

    static int multiplication(int a, int b)
    {
        int result = 1;

        for (int i = a; i <= b; i++)
        {
            result = result * i;
        }

        return result;
    }

    static int multiplication(int a, int b, int c)
    {
        int result = a * b * c;
        return result;
    }

                                                     // 7. digitCount (rekursiya)
    static int digitCount(int n)
    {
        n = Math.Abs(n);

        if (n < 10)
        {
            return 1;
        }

        return 1 + digitCount(n / 10);
    }

                                             // 8. sumRange (rekursiya)
    static int sumRange(int a, int b)
    {
        if (a > b)
        {
            return 0;
        }

        return a + sumRange(a + 1, b);
    }

                                                     // 9. sumOfCubes
    static int sumOfCubes(int n)
    {
        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            sum = sum + (i * i * i);
        }

        return sum;
    }

                                                 // 10. myMax()
    static int myMax(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }

                                                             // 11. myAbs()
    static int myAbs(int a)
    {
        if (a < 0)
        {
            return -a;
        }
        else
        {
            return a;
        }
    }

                                                    // 12. isUpper()
   
                                                 // 13. toUpper()
    static char toUpper(char c)
    {
        if (c >= 'a' && c <= 'z')
        {
            return (char)(c - 32);
        }
        else
        {
            return c;
        }
    }


                                                    // 15. isLower()
    static bool isLower(char c)
    {
        if (c >= 'a' && c <= 'z')
        {
            return true;
        }
        else
        {
            return false;
        }
    }

   

                                             // 17. myPow()
    static int myPow(int a, int b)
    {
        int result = 1;

        for (int i = 0; i < b; i++)
        {
            result = result * a;
        }

        return result;
    }
}
}