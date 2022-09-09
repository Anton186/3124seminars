Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int x = 0;
if (number > 1)
{
    for (int i = 1; number > 0; i++)
    {
        number = number / 10;
        x++;
    }
    Console.Write($"Количество цифр в числе состовляет {x}");
}
else
{
    Console.Write("Вы ввели некорректное число.");
}
