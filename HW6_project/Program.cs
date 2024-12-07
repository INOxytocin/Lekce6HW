internal class Program
{
    private static void Main(string[] args)
    {

        int[] result = new int[5];
        result = new int[] { 10, 5, 12, 1, 3};

        int[] empty = new int[5];
        WriteArrayFirstToLast(result);

        Console.WriteLine("LOWEST TO HIGHEST");
        WriteArrayFirstToLast(LowestToHighest(result));//1

        Console.WriteLine("ORDER REVERSED");
        WriteArrayFirstToLast(ReverseArrayOrder(result));//2

        Console.WriteLine("REMOVE FIRST ELEMENT");
        WriteArrayFirstToLast(RemoveFirstElement(result));//3

        Console.WriteLine("REMOVE LAST ELEMENT");
        WriteArrayFirstToLast(RemoveLastElement(result));//4

        Console.WriteLine("REMOVE ELEMEND ON CHOSEN INDEX");
        WriteArrayFirstToLast(RemoveElementOnIndex(result));//5

        Console.WriteLine("ADD ELEMENT ON START");
        WriteArrayFirstToLast(AddElementOnStart(result));//6

        Console.WriteLine("ADD ELEMENT ON END");
        WriteArrayFirstToLast(AddElementOnEnd(result));//7

        Console.WriteLine("ADD ELEMENT ON INDEX");
        WriteArrayFirstToLast(AddElementOnIndex(result));//8





    }

    //ÚLOHA 1
    public static int[] LowestToHighest(int[] array)  
    {
        int[] result = new int[array.Length];
        result = array;
        int count = 0;
        do
        {
            count = 0;
            for (int i = 0; i < result.Length - 1; i++)
            {
                if (result[i] > result[i + 1])
                {
                    int lower = result[i + 1];
                    int higher = result[i];
                    result[i] = lower;
                    result[i + 1] = higher;

                    count++;
                }
                //WriteArrayFirstToLast(array);
            }
        }while (count > 0);
        



        return result;
    }
    //ÚLOHA 2
    public static int[] ReverseArrayOrder(int[] array) 
    {
        int[] result = new int[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            result[i] = array[array.Length - 1 - i];
        }
        return result;
    }
    //ÚLOHA 3
    public static int[] RemoveFirstElement(int[] array)

    {
        int[] result = new int[array.Length - 1];

        for (int i = 0; i < result.Length; i++)
        {
            result[i] = array[i + 1];
        }
        return result;
    }
    //ÚLOHA 4
    public static int[] RemoveLastElement(int[] array)

    {
        int[] result = new int[array.Length - 1];

        for (int i = 0; i < result.Length; i++)
        {
            result[i] = array[i];
        }
        return result;
    }
    //ÚLOHA 5
    public static int[] RemoveElementOnIndex(int[] array)
    {
        int[] result = new int[array.Length - 1];
        Console.WriteLine("Choose an index of the element you want to remove");
        string ReadIndex = Console.ReadLine();
        Int32.TryParse(ReadIndex, out int chosenIndex);
        int indexSkip = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (chosenIndex == i)
            {
                indexSkip++;
                continue;
            }
            result[i - indexSkip] = array[i];
        }
        return result;
    }
    public static int[] RemoveElementOnIndex(int[] array, int chosenIndex)
    {
        int[] result = new int[array.Length - 1];
        int indexSkip = 0;

        if (chosenIndex > array.Length || chosenIndex < 0)
        {
            Console.WriteLine("Index out of Bounds");
            return array;
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (chosenIndex == i)
            {
                indexSkip++;
                continue;
            }
            result[i - indexSkip] = array[i];
        }
        return result;
    }
    //ÚLOHA 6
    public static int[] AddElementOnStart(int[] array)
    {
        Console.WriteLine("Choose an element you want to add");
        string ReadElement = Console.ReadLine();
        Int32.TryParse(ReadElement, out int chosenElement);
        int[] result = new int[array.Length + 1];
        result[0] = chosenElement;
        for (int i = 0; i < array.Length; i++)
        {
            result[i + 1] = array[i];
        }

        return result;
    }
    public static int[] AddElementOnStart(int[] array, int chosenElement)
    {
        int[] result = new int[array.Length + 1];
        result[0] = chosenElement;
        for (int i = 0; i < array.Length; i++)
        {
            result[i + 1] = array[i];
        }

        return result;
    }
    //ÚLOHA 7
    public static int[] AddElementOnEnd(int[] array)
    {
        Console.WriteLine("Choose an element you want to add");
        string ReadElement = Console.ReadLine();
        Int32.TryParse(ReadElement, out int chosenElement);
        int[] result = new int[array.Length + 1];
        result[result.Length - 1] = chosenElement;
        for (int i = 0; i < array.Length; i++)
        {
            result[i] = array[i];
        }

        return result;
    }
    public static int[] AddElementOnEnd(int[] array, int chosenElement)
    {
        int[] result = new int[array.Length + 1];
        result[result.Length - 1] = chosenElement;
        for (int i = 0; i < array.Length; i++)
        {
            result[i] = array[i];
        }

        return result;
    }
    //ÚLOHA 8
    public static int[] AddElementOnIndex(int[] array)
    {
        Console.WriteLine("Choose on what index you want to add an element");
        string ReadIndex = Console.ReadLine();
        Int32.TryParse(ReadIndex, out int chosenIndex);
        if (chosenIndex > array.Length || chosenIndex < 0)
        {
            Console.WriteLine("Index out of Bounds");
            return array;
        }

        Console.WriteLine("Choose an element you want to add");
        string ReadElement = Console.ReadLine();
        Int32.TryParse(ReadElement, out int chosenElement);

        int[] result = new int[array.Length + 1];
        result[chosenIndex] = chosenElement;
        int indexSkip = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (i == chosenIndex)
            {
                indexSkip++;
            }
            result[i + indexSkip] = array[i];
        }

        return result;
    }
    public static int[] AddElementOnIndex(int[] array, int chosenIndex)
    {

        if (chosenIndex > array.Length || chosenIndex < 0)
        {
            Console.WriteLine("Index out of Bounds");
            return array;
        }

        Console.WriteLine("Choose an element you want to add");
        string ReadElement = Console.ReadLine();
        Int32.TryParse(ReadElement, out int chosenElement);

        int[] result = new int[array.Length + 1];
        result[chosenIndex] = chosenElement;
        int indexSkip = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (i == chosenIndex)
            {
                indexSkip++;
            }
            result[i + indexSkip] = array[i];
        }

        return result;
    }
    public static int[] AddElementOnIndex(int[] array, int chosenIndex, int chosenElement)
    {

        if (chosenIndex > array.Length || chosenIndex < 0)
        {
            Console.WriteLine("Index out of Bounds");
            return array;
        }

        int[] result = new int[array.Length + 1];
        result[chosenIndex] = chosenElement;
        int indexSkip = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (i == chosenIndex)
            {
                indexSkip++;
            }
            result[i + indexSkip] = array[i];
        }

        return result;
    }


    //Pomocné funkce
    public static void WriteArrayFirstToLast(Array array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array.GetValue(i) + ", "); //Tohle jsem si musel najít :D
        }
        Console.WriteLine("\n");

    }
    public static void WriteLineArrayFirstToLast(Array array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array.GetValue(i)); //Tohle jsem si musel najít :D
        }
        
    }

}
