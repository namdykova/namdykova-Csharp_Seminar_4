int[] newArray = GenerateArray(5, 100, 999);
PrintArray(newArray);
Console.WriteLine("Кличество четных чисел: " + CountEven(newArray));

int[] GenerateArray (int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange + 1);
    }
    return array;
}

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int CountEven (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}