namespace Dars8;


internal class Program
{
    static void Main()
    {
        //        List<int> list = new List<int> { 12, 105, -256, 9, 999, 1000, -99, 14, 21, 35 };

        //        //------------------1-masala------------------



        //        Console.WriteLine(ThreeDigitCount(list));



        //        //------------------2-masala------------------

        //        Console.WriteLine(EvenCount(list));



        //        //------------------3-masala------------------

        //        Console.WriteLine(OddSum(list));



        //        //------------------4-masala------------------

        //        Console.WriteLine(MultipleThreeAndSevenCount(list));



        //        //------------------5-masala------------------


        //        Console.WriteLine(TwoDigitOddInfo(list));



        //        //------------------6-masala------------------


        //        SwapFirstLast(list);

        //        Console.WriteLine(string.Join(" ", list));



        //        //------------------7-masala------------------


        //        Console.WriteLine(FirstThreeSum(list));


        //        //------------------8-masala------------------


        //        Console.WriteLine(LastThreeSum(list));


        //        //------------------9-masala------------------

        //             Console.WriteLine(OddMoreThanEven(list));


        //        //------------------10-masala------------------

        //        MultiplyEvenByThree(list);

        //        Console.WriteLine(string.Join(" ", list));

        //        //------------------11-masala------------------

        //        Console.WriteLine(AllMultipleOfFive(list));


        //        //------------------12-masala------------------

        //        Console.WriteLine(FirstThreeTwoDigit(list));

        //        //------------------13-masala------------------

        //        Console.WriteLine(CheckFirstEvenLastOdd(list));

        //        //------------------14-masala------------------

        //        Console.WriteLine(MinElement(list));

        //        //------------------15-masala------------------

        //        Console.WriteLine(MinMaxSum(list));

        //        //------------------16-masala------------------
        //        IncreaseTwoDigitByHundred(list);
        //        Console.WriteLine(string.Join(" ", list));

        //        //------------------17-masala------------------
        //        Console.WriteLine(PositiveNegativeCount(list));

        //        //------------------18-masala------------------
        //        Console.WriteLine(LessThanFirstCount(list));

        //        //------------------19-masala------------------
        //        Console.WriteLine(GreaterThanLastSum(list));


        //        //------------------21-masala------------------
        //        Console.WriteLine(IsIncreasing(list));

        //        //------------------22-masala------------------
        //        Console.WriteLine(IsDecreasing(list));



        //        //------------------24-masala------------------
        //        Console.WriteLine(TotalSum(list));
        //    }






        //    //------------------1-masala------------------
        //    static int ThreeDigitCount(List<int> list)
        //    {
        //        int count = 0;
        //        foreach (int x in list)
        //            if (Math.Abs(x) >= 100 && Math.Abs(x) <= 999)
        //                count++;
        //        return count;
        //    }

        //    //------------------2-masala------------------
        //    static int EvenCount(List<int> list)
        //    {
        //        int count = 0;
        //        foreach (int x in list)
        //            if (x % 2 == 0)
        //                count++;
        //        return count;
        //    }

        //    //------------------3-masala------------------
        //    static int OddSum(List<int> list)
        //    {
        //        int sum = 0;
        //        foreach (int x in list)
        //            if (x % 2 != 0)
        //                sum += x;
        //        return sum;
        //    }

        //    //------------------4-masala------------------
        //    static int MultipleThreeAndSevenCount(List<int> list)
        //    {
        //        int count = 0;
        //        foreach (int x in list)
        //            if (x % 3 == 0 && x % 7 == 0)
        //                count++;
        //        return count;
        //    }

        //    //------------------5-masala------------------
        //    static string TwoDigitOddInfo(List<int> list)
        //    {
        //        int count = 0, sum = 0;
        //        foreach (int x in list)
        //            if (Math.Abs(x) >= 10 && Math.Abs(x) <= 99 && x % 2 != 0)
        //            {
        //                count++;
        //                sum += x;
        //            }
        //        return count + " " + sum;
        //    }

        //    //------------------6-masala------------------
        //    static void SwapFirstLast(List<int> list)
        //    {
        //        int temp = list[0];
        //        list[0] = list[list.Count - 1];
        //        list[list.Count - 1] = temp;
        //    }

        //    //------------------7-masala------------------
        //    static int FirstThreeSum(List<int> list)
        //    {
        //        return list[0] + list[1] + list[2];
        //    }

        //    //------------------8-masala------------------
        //    static int LastThreeSum(List<int> list)
        //    {
        //        int n = list.Count;
        //        return list[n - 1] + list[n - 2] + list[n - 3];
        //    }

        //    //------------------9-masala------------------
        //    static bool OddMoreThanEven(List<int> list)
        //    {
        //        int odd = 0, even = 0;
        //        foreach (int x in list)
        //            if (x % 2 == 0) even++; else odd++;
        //        return odd > even;
        //    }


        //    //------------------10-masala------------------

        //    static void MultiplyEvenByThree(List<int> list)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //            if (list[i] % 2 == 0)
        //                list[i] *= 3;
        //    }


        //    //------------------11-masala------------------

        //    static bool AllMultipleOfFive(List<int> list)
        //    {
        //        foreach (int x in list)
        //            if (x % 5 != 0)
        //                return false;
        //        return true;
        //    }


        //    //------------------12-masala------------------

        //    static bool FirstThreeTwoDigit(List<int> list)
        //    {
        //        for (int i = 0; i < 3; i++)
        //            if (Math.Abs(list[i]) < 10 || Math.Abs(list[i]) > 99)
        //                return false;
        //        return true;
        //    }



        //    //------------------13-masala------------------

        //    static bool CheckFirstEvenLastOdd(List<int> list)
        //    {
        //        return list[0] % 2 == 0 && list[1] % 2 == 0 &&
        //               list[^1] % 2 != 0 && list[^2] % 2 != 0;
        //    }


        //    //------------------14-masala------------------

        //    static int MinElement(List<int> list)
        //    {
        //        int min = list[0];
        //        foreach (int x in list)
        //            if (x < min) min = x;
        //        return min;
        //    }



        //    //------------------15-masala------------------

        //    static int MinMaxSum(List<int> list)
        //    {
        //        int min = list[0], max = list[0];
        //        foreach (int x in list)
        //        {
        //            if (x < min) min = x;
        //            if (x > max) max = x;
        //        }
        //        return min + max;
        //    }


        //    //------------------16-masala------------------

        //    static void IncreaseTwoDigitByHundred(List<int> list)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //            if (Math.Abs(list[i]) >= 10 && Math.Abs(list[i]) <= 99)
        //                list[i] += 100;
        //    }


        //    //------------------17-masala------------------

        //    static string PositiveNegativeCount(List<int> list)
        //    {
        //        int pos = 0, neg = 0;
        //        foreach (int x in list)
        //            if (x > 0) pos++; else if (x < 0) neg++;
        //        return pos + " " + neg;
        //    }


        //    //------------------18-masala------------------

        //    static int LessThanFirstCount(List<int> list)
        //    {
        //        int count = 0;
        //        foreach (int x in list)
        //            if (x < list[0])
        //                count++;
        //        return count;
        //    }


        //    //------------------19-masala------------------
        //    static int GreaterThanLastSum(List<int> list)
        //    {
        //        int sum = 0;
        //        foreach (int x in list)
        //            if (x > list[^1])
        //                sum += x;
        //        return sum;
        //    }



        //    //------------------21-masala------------------
        //    static bool IsIncreasing(List<int> list)
        //    {
        //        for (int i = 1; i < list.Count; i++)
        //            if (list[i] <= list[i - 1])
        //                return false;
        //        return true;
        //    }


        //    //------------------22-masala------------------
        //    static bool IsDecreasing(List<int> list)
        //    {
        //        for (int i = 1; i < list.Count; i++)
        //            if (list[i] >= list[i - 1])
        //                return false;
        //        return true;
        //    }




        //    //------------------24-masala------------------
        //    static int TotalSum(List<int> list)
        //    {
        //        int sum = 0;
        //        foreach (int x in list)
        //            sum += x;
        //        return sum;
        //    }
        //}
    }
}
