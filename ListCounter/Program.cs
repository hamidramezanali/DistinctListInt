// See https://aka.ms/new-console-template for more information

public class App
{
    public static void Main()
    {
        var items = new int[] { 7, 1, 3, 5, 3, 3, 1, 1, 5 };
        var count=CountDuplicates(items);
        var distinctList = distinct(items,count);
        Print(distinctList);
        int[] distinctListLinq = items.Distinct().ToArray();
        Print(distinctListLinq);
        Console.Read();


    }

    private static void Print(int[] distinctList)
    {
        foreach (var item in distinctList)
        {
            Console.Write($@"{item} ");
        }
    }

    public static int[] distinct(int[] items, int count)
    {
        int[] newlist =new int[count];
        int n = items.Length;
        int counter = 0;
        for (int i = 0; i < n; i++)
        {
            bool isDuplicate = false;
            for (int j = 0; j < i; j++)
            {
           
                if (items[i] == items[j])
                {
                    isDuplicate = true;
                    break;
                }
        
            }
            if (!isDuplicate)
            {

                newlist[counter] = items[i];
                counter++;
            }
        }
        return newlist;
    }
    public static int CountDuplicates(int[] items)
    {
        int n = items.Length;
        int counter = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (items[i] == items[j])
                {
                    counter++;
                    break;
                }
            }

        }
        return (n - counter);
    }
}
