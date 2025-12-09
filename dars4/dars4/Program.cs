namespace dars4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.Write("Ismingizni kiriting: ");
            //string name = Console.ReadLine()!;
            //var natija = helloname(name);

            //static string helloname(string name)
            //{
            //    return "hello " + name;
            //}


            //Console.WriteLine(natija);


            //                                      2-masala


            //Console.Write("Str1: ");
            //var str1 = Console.ReadLine()!;
            //Console.Write("Str2: ");
            //var str2 = Console.ReadLine()!;





            //static string doubling(string str1, string str2)
            //{
            //    return str1 + str2 + str2 + str1;
            //}

            //Console.WriteLine(doubling(str1,str2));


            //                                      3-masala

            //Console.Write("str1: ");
            //var str1 = Console.ReadLine()!;
            //Console.Write("str2: ");
            //var str2 = Console.ReadLine()!;


            //static string makeOutWord(string str1, string str2)
            //{

            //    if (str1.Length != 4)
            //    {
            //        Console.WriteLine("Birinchi str uznligi 4 bolishi shart");
            //    }


            //    return str1.Substring(0, 2) + str2 + str1.Substring(2);
            //}

            //Console.WriteLine(makeOutWord(str1, str2));



            //                                      4-masala

            //Console.Write("Matn kiriting: ");
            //var str = Console.ReadLine()!;


            //if (str.Length <= 2)
            //{
            //    Console.WriteLine("Str uzunligi kamida 2 bolishi lozim!!");

            //}


            //static string extraEnd(string str)
            //{

            //    var res = str.Substring(str.Length - 2);
            //    return res + res + res;
            //}
            //Console.WriteLine(extraEnd(str));


            //                                      5 -masala

            //Console.Write("Matn kiriting: ");
            //var str = Console.ReadLine()!;

            //static string firstTwo(string str)
            //{
            //    return str.Substring(0, 2);
            //}
            //Console.WriteLine(firstTwo(str));



            //                                      6 -masala


            //Console.Write("Matn kiriting: ");
            //var str = Console.ReadLine()!;
            //var result = firstHalf(str);

            //static string firstHalf(string str)
            //{
            //    var res = str.Length / 2;
            //    return str.Substring(0, res);
            //}
            //Console.WriteLine(result);

            //                                      7 -masala

            //Console.Write("Matn kiriting: ");
            //var str = Console.ReadLine()!;
            //var res = withoutEnd(str);

            //Console.WriteLine(res);

            //static string withoutEnd(string str)
            //{
            //    return str.Substring(1, str.Length - 1);
            //}

            //                                      8 -masala

            //Console.Write("Matn kiriting: ");
            //var b = Console.ReadLine()!;
            //Console.Write("Matn kiriting: ");
            //var a = Console.ReadLine()!;
            //var res = comboString(a, b);


            //Console.WriteLine(res);


            //static string comboString(string a, string b)
            //{
            //    var str = string.Empty;

            //    if (a.Length > b.Length)
            //    {
            //        str = b + a + b;
            //    }
            //    else
            //    {
            //        str = a + b + a;
            //    }

            //    return str;
            //}



            //                                      9 -masala


            //Console.Write("Matn kiriting: ");
            //var str1 = Console.ReadLine()!;

            //Console.Write("Matn kiriting: ");
            //var str2 = Console.ReadLine()!;

            //var res = nonStart(str1,str2!);

            //static string nonStart(string str1, string str2)
            //{
            //    var res1 = string.Empty;
            //    res1 = str1.Substring(1);
            //    var res2 = string.Empty;
            //    res2 = str2.Substring(1);

            //    return res1+res2;
            //}
            //Console.WriteLine(res);

            //                                      10 -masala


            //Console.Write("Matn kiriting: ");
            //var str = Console.ReadLine()!;

            //var res = left2(str);

            //static string left2(string str)
            //{

            //    if( str.Length <= 2)
            //    {
            //        return str;
            //    }
            //    var first2 = str.Substring(0, 2);
            //    var left = str.Substring(2);

            //    return left + first2;


            //}
            //Console.WriteLine(res);

            //                                      11 -masala

            //Console.Write("MAtn kiritng: ");
            //var str = Console.ReadLine()!;

            //Console.Write("True False tanlang 1-True, 0-False: ");


            //var boole = int.Parse(Console.ReadLine()!);

            //static string theEnd(int boole, string str)
            //{
            //    var first = str.Substring(0, 1);

            //    var last = str.Substring(str.Length - 1);

            //    if (boole == 1)
            //    {
            //        return first;
            //    }
            //    if (boole == 0)
            //    {
            //        return last;
            //    }

            //    return str;

            //}

            //Console.WriteLine(theEnd(boole,str));





            //                                      12 -masala

            //Console.Write("Matn kiriting: ");
            //var str = Console.ReadLine()!;

            //Console.Write("N kiring: ");
            //var N = int.Parse(Console.ReadLine()!);

            //var result = nTwice(str, N);
            //static string nTwice (string str, int N)
            //{
            //    var start = str.Substring(0, N);    
            //    var left = str.Substring(str.Length-N);

            //    return start + left;
            //}
            //Console.WriteLine(result);


            //                                      13 -masala

            //Console.Write("Matn : ");
            //var str = Console.ReadLine()!;
            //var res = middleThere(str);

            //static string middleThere(string str)
            //{

            //    var mid = str.Substring((str.Length / 2) - 1, 3);

            //    return mid;
            //}

            //Console.WriteLine(res);

            //                                      14 -masala

            //Console.Write("Matn1 : ");
            //var str1 = Console.ReadLine()!;

            //Console.Write("Matn2 : ");
            //var str2 = Console.ReadLine()!;

            //var result = ConCat(str1, str2);

            //static string ConCat(string str1, string str2)
            //{
            //    if (str1.Length == 0)
            //    {
            //        return str2;
            //    }

            //    if (str2.Length == 0)
            //    {
            //        return str1;
            //    }

            //    if (str1[str1.Length - 1] == str2[0])
            //    {
            //        return str1 + str2.Substring(1);
            //    }

            //    return str1 + str2;
            //}

            //Console.WriteLine(result);




            //                                      15 -masala

            //Console.Write("Matn1 : ");
            //var str1 = Console.ReadLine()!;


            //var res = frontAgain(str1);


            //static bool frontAgain(string str1)
            //{

            //    if (str1.Substring(0, 2) == str1.Substring(str1.Length - 2))
            //    {
            //        return true;
            //    }

            //    else
            //    {
            //        return false;
            //    }


            //}
            //Console.WriteLine(res);



            //                                      16 -masala


            //static string seeColor(string str)
            //{
            //    if (str.StartsWith("red"))
            //        return "red";

            //    if (str.StartsWith("blue"))
            //        return "blue";

            //    return "";
            //}




            //                                      17 -masala


            //static bool frontAgain(string str)
            //{
            //    if (str.Length < 2)
            //        return false;

            //    string first2 = str.Substring(0, 2);
            //    string last2 = str.Substring(str.Length - 2);

            //    return first2 == last2;
            //}


            //static void Main()
            //{
            //    Console.WriteLine(frontAgain("edited"));
            //    Console.WriteLine(frontAgain("edit"));
            //    Console.WriteLine(frontAgain("ed"));
            //}

            //                                      18 -masala


            //static string withoutX(string str)
            //{
            //    if (str.StartsWith("x"))
            //        str = str.Substring(1);

            //    if (str.EndsWith("x"))
            //        str = str.Substring(0, str.Length - 1);

            //    return str;
            //}

            //static void Main()
            //{
            //    string s = Console.ReadLine();
            //    Console.WriteLine(withoutX(s));
            //}



            //                                      20 -masala


            //string s = Console.ReadLine();
            //string result = "";

            //foreach (char c in s)
            //{
            //    if (!char.IsDigit(c))
            //        result += c;
            //}

            //Console.WriteLine(result);


            //                                      21 -masala

            //string s = Console.ReadLine();
            //string result = "";

            //foreach (char c in s)
            //{
            //    if (!char.IsLower(c))
            //        result += c;
            //}

            //Console.WriteLine(result);

            //                                      22 -masala


            //string s = Console.ReadLine();
            //string result = "";

            //foreach (char c in s)
            //{
            //    if (c != '@')
            //        result += c;
            //}

            //Console.WriteLine(result);


            //                                      24 -masala

            //string s = Console.ReadLine();
            //s = s.Replace(" ", "");
            //Console.WriteLine(s);


            //                                      1.4.2


            //                                      1 - masala

            //static int Task1()
            //{
            //    int a = int.Parse(Console.ReadLine()!);
            //    int b = int.Parse(Console.ReadLine()!);
            //    return a + b;
            //}

            //                                      2 - masala
            //static string Task2()
            //{
            //    string s = Console.ReadLine()!;
            //    s = s.Replace("x", "y").Replace("y", "z");
            //    return s;
            //}


            //                                      3 - masala


            //static int Task3()
            //{
            //    string s = Console.ReadLine()!;
            //    int count = 0;
            //    foreach (char c in s) if (char.IsLower(c)) count++;
            //    return count;
            //}


            //                                      4 - masala


            //static int Task4()
            //{
            //    int a = int.Parse(Console.ReadLine()!);
            //    int b = int.Parse(Console.ReadLine()!);
            //    int count = 0;
            //    for (int i = a + 1; i < b; i++) if (i % 2 != 0) count++;
            //    return count;
            //}


            //                                      5 - masala


            //static int Task5()
            //{
            //    int n = int.Parse(Console.ReadLine()!);
            //    return n.ToString().Length;
            //}

            //                                      6 - masala


            //static bool Task6()
            //{
            //    string s = Console.ReadLine()!;
            //    foreach (char c in s) if (!char.IsDigit(c)) return false;
            //    return true;
            //}


            //                                      7 - masala


            //static bool Task7()
            //{
            //    int n = int.Parse(Console.ReadLine()!);
            //    if (n < 2) return false;
            //    for (int i = 2; i <= Math.Sqrt(n); i++)
            //        if (n % i == 0) return false;
            //    return true;
            //}


            //                                      8 - masala


            //static string Task8()
            //{
            //    string s = Console.ReadLine()!;
            //    char[] arr = s.ToCharArray();
            //    Array.Reverse(arr);
            //    return new string(arr);
            //}

            //                                      9 - masala

            //static int Task9()
            //{
            //    string s = Console.ReadLine()!;
            //    int count = 0;
            //    foreach (char c in s) if (c == ' ') count++;
            //    return count;
            //}


            //                                      10 - masala
            //static bool Task10()
            //{
            //    string s = Console.ReadLine()!;
            //    char[] arr = s.ToCharArray();
            //    Array.Reverse(arr);
            //    return s == new string(arr);
            //}

            //                                      11 - masala

            //static bool Task11()
            //{
            //    string s = Console.ReadLine()!;
            //    foreach (char c in s) if (!char.IsDigit(c)) return false;
            //    return true;
            //}


            //                                      12 - masala
            //static int Task12()
            //{
            //    string s = Console.ReadLine()!;
            //    int count = 0;
            //    foreach (char c in s) if (char.IsDigit(c)) count++;
            //    return count;
            //}


            //                                      13 - masala
            //static int Task13()
            //{
            //    string s = Console.ReadLine()!;
            //    int count = 0;
            //    foreach (char c in s) if (char.IsUpper(c)) count++;
            //    return count;
            //}


            //                                      14 - masala

            //static bool Task14()
            //{
            //    string s = Console.ReadLine()!;
            //    foreach (char c in s) if (!char.IsUpper(c)) return false;
            //    return true;
            //}

            //                                      15 - masala

            //static bool Task15()
            //{
            //    string s = Console.ReadLine()!;
            //    foreach (char c in s) if (!char.IsLower(c)) return false;
            //    return true;
            //}


            //                                      16 - masala

            //static string Task16()
            //{
            //    string s = Console.ReadLine()!;
            //    return s.ToUpper();
            //}

            //                                      17 - masala


            //static int Task17()
            //{
            //    string s = Console.ReadLine()!;
            //    int count = 0;
            //    for (int i = 0; i < s.Length - 1; i++)
            //        if (s.Substring(i, 2) == "ok") count++;
            //    return count;
            //}

            //                                      18 - masala

            //static string Task18()
            //{
            //    string s = Console.ReadLine()!;
            //    char[] arr = s.ToCharArray();
            //    for (int i = 0; i < arr.Length; i++)
            //        if (char.IsLower(arr[i])) arr[i] = '*';
            //    return new string(arr);
            //}

            //                                      19 - masala

            //static string Task19()
            //{
            //    string s = Console.ReadLine()!;
            //    return s.ToLower();
            //}

            //                                      20 - masala

            //static string Task20()
            //{
            //    string s = Console.ReadLine()!;
            //    return s.ToUpper();
            //}

            //                                      21 - masala

            //static int Task21()
            //{
            //    string s = Console.ReadLine()!;
            //    int count = 0;
            //    foreach (char c in s) if (c == '@') count++;
            //    return count;
            //}








        }
    }
}