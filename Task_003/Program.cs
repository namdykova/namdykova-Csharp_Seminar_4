int[] newArray = CreateArray(6, 10, 99);
PrintArray(newArray);
newArray = ReverseArray(newArray);
PrintArray(newArray);

int[] CreateArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange);
    }
    return array;
}
void PrintArray(int[] array)
{
    foreach (int i in array)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}
int[] ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
    return array;
}