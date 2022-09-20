int[] GetArray(int size,int leftRange,  int rightRange) // 5
{
    int[] arr = new int[size];
    Random rand = new Random();
    for(int i = 0; i < size; i++)
    {
        arr[i] = i;
    }
    return arr;
}
int [] arr = GetArray(12, -9, 9);
Console.Write("Сгенерирован массив: ");
Console.WriteLine(string.Join(", ", arr));
