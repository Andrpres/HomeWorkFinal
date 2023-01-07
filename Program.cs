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

//Формируем новый массив, в котором оставляем строки в 3 или меньше символа
string[] resultMass(string[] array){
    string[] mass2 = new string[3];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3){
           mass2[i] = array[i];
        }
    }
    mass2 = mass2.Where(x => x != null).ToArray();
    return mass2;
}

Console.Write("Изначальный массив: ");
PrintArray(mass1);
Console.WriteLine();
//Выводим итоговый массив на экран
Console.Write("Итоговый массив: ");
PrintArray(resultMass(mass1));