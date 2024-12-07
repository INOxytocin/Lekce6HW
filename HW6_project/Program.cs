internal class Program
{
    private static void Main(string[] args)
    {

        int[] result = new int[9];
        result = new int[] { 10, 5, 5, 1, 3, 7, 155, 1003, 1234};

        int[] empty = new int[5];
        Console.WriteLine("ORIGINAL ARRAY");
        WriteArrayFirstToLast(result);

        
        WriteArrayFirstToLast(LowestToHighest((int[])result.Clone()));//1

        WriteArrayFirstToLast(ReverseArrayOrder((int[])result.Clone()));//2

        WriteArrayFirstToLast(RemoveFirstElement((int[])result.Clone()));//3

        WriteArrayFirstToLast(RemoveLastElement((int[])result.Clone()));//4

        WriteArrayFirstToLast(RemoveElementOnIndex((int[])result.Clone()));//5

        WriteArrayFirstToLast(AddElementOnStart((int[])result.Clone()));//6

        WriteArrayFirstToLast(AddElementOnEnd((int[])result.Clone()));//7

        WriteArrayFirstToLast(AddElementOnIndex((int[])result.Clone()));//8





    }

    //ÚLOHA 1
    public static int[] LowestToHighest(int[] array)  
    {
        Console.WriteLine("LOWEST TO HIGHEST");
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
        Console.WriteLine("ORDER REVERSED");

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
        Console.WriteLine("REMOVE FIRST ELEMENT");
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
        Console.WriteLine("REMOVE LAST ELEMENT");
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
        Console.WriteLine("REMOVE ELEMEND ON CHOSEN INDEX");
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
        Console.WriteLine("REMOVE ELEMEND ON CHOSEN INDEX");
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
        Console.WriteLine("ADD ELEMENT ON START");
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
        Console.WriteLine("ADD ELEMENT ON START");
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
        Console.WriteLine("ADD ELEMENT ON END");
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
        Console.WriteLine("ADD ELEMENT ON END");
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
        Console.WriteLine("ADD ELEMENT ON INDEX");
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

        Console.WriteLine("ADD ELEMENT ON INDEX");
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

        Console.WriteLine("ADD ELEMENT ON INDEX");
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
