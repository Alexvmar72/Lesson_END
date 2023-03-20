using System;
using static System.Console;
Clear();

string[] GetArray(string[] array)
{
    //Для создания массива вывода результатов вычисляем его размер
    int size = 0;
    foreach (string item in array) if (item.Length <= 3) size++;

    //Создаём массив определённой размерности
    string[] result = new string[size];

    int index = 0;
    foreach (string item in array)
    {
        if (item.Length <= 3)
        {
            result[index] = item;
            index++;
        }
    }

    return result;
}


void PrintArray(string[] array)
{
    WriteLine($" -> [{string.Join(", ", array)}]");
}


string[] array1 = { "hello", "2", "world", ":-)" };
string[] array2 = { "1234", "1567", "-2", "computer science" };
string[] array3 = { "Russia", "Denmark", "Kazan" };
string[] printarray = GetArray(array1);


PrintArray(GetArray(array1));
WriteLine();
PrintArray(GetArray(array2));
WriteLine();
PrintArray(GetArray(array3));