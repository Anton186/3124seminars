int[] array = new int[8]; //создали массив на 8 элементов

Random rand = new Random();
for(int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(array[i]);
}


