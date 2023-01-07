//Задаем первичный массив
string[] mass1 = { "Russia", "Pol", "1478" };

//Выводим массив на экран
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}