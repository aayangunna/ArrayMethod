using System;
public class Array
{
    public static void Main()
    {
        int[] myArr = new int[5] { 66, 96, 59, 83, 24 };
        int i, j, temp;
        Console.WriteLine("Elements: ");
        for (i = 0; i < 5; i++)
        {
            Console.WriteLine("{0} ", myArr[i]);
        }
        for (i = 0; i < 5; i++)
        {
            for (j = i + 1; j < 5; j++)
            {
                if (myArr[i] < myArr[j])
                {
                    temp = myArr[i];
                    myArr[i] = myArr[j];
                    myArr[j] = temp;
                }
            }
        }
        Console.WriteLine("Descending order:");
        for (i = 0; i < 5; i++)
        {
            Console.WriteLine("{0} ", myArr[i]);
        }
    }
}