Console.Clear();
string[] array = { "hello", "2", "world", ":-)" };
string[] array2 = { "1234", "1567", "-2", "computer science" };
string[] array3 = { "Russia", "Denmark", "Kazan" };
//Для создания массива вывода результатов вычисляем его размер
int size = 0;
foreach (string item in array) if (item.Length <= 3) size++;

Console.WriteLine($"Размер массива равен {size}");
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
Console.WriteLine($" -> [{string.Join(", ", result)}]");