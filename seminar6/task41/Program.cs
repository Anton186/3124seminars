

int countOfPositive = 0;

while (true)
{
    string answer = Console.ReadLine();
    if (answer  == "stop") // если ответ пользователья - стоп слово
    {
        break;
    }
    else
    {
        double.TryParse(answer, out double answerNumber);
        if (answerNumber > 0)
        {
            countOfPositive++;
        }
    }
}
Console.WriteLine(countOfPositive);
