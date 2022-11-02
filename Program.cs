// Вариант решения через создание второго массива. Не подходит!
//Так как не могу во втором массиве ограничить его размер количеством элементов в нем!
string[] AS = new string[4];
for (int i = 0; i < AS.Length; i++)
{
    Console.Write("Введите Строку: ");
    AS[i] = Console.ReadLine()!;
}
Console.Write($"[");
for (int i = 0; i < AS.Length; i++)
{
    Console.Write($"{AS[i]}; ");
}
Console.Write($"]");
Console.Write($"-> ");


string[] AS2 = new string[4];
for (int i = 0; i < AS.Length; i++)
{
    if (AS[i].Length <= 3)
    {
        AS2[i] = AS[i];
    }
}
for (int i = 0; i < AS2.Length; i++)
{
    Console.Write($"{AS2[i]}; ");
}
Console.Write($"\n");

// Вариант решения простым выводом результата в консоль!
//Без создания второго массива!
// Не подходит. Т.к. задача стоит сформировать массив из массива!
string[] AS = new string[4];
for (int i = 0; i < AS.Length; i++)
{
    Console.Write("Введите Строку: ");
    AS[i] = Console.ReadLine()!;
}
Console.Write($"[");
for (int i = 0; i < AS.Length; i++)
{
    Console.Write($"{AS[i]}; ");
}
Console.Write($"]");
Console.Write($"-> ");

for (int i = 0; i < AS.Length; i++)
{
    if (AS[i].Length <= 3)
    {
        Console.Write($"{AS[i]}; ");
    }
}

// Решение через динамический массив.
//Позволяет ограничить итоговый массив количеством элементов в нем!
string[] AS = new string[4];
for (int i = 0; i < AS.Length; i++)
{
    Console.Write("Введите Строку: ");
    AS[i] = Console.ReadLine()!;
}
Console.Write($"[");
for (int i = 0; i < AS.Length; i++)
{
    Console.Write($"{AS[i]};");
}
Console.Write($"]");
Console.Write($"-> ");


List<string> AS2 = new List<string>();
for (int i = 0; i < AS.Length; i++)
{
    if (AS[i].Length <= 3)
    {
        AS2.Add(AS[i]);
    }
}
Console.Write($"[");
foreach (var item in AS2)
    Console.Write($"{item};");
Console.Write($"]");

// Решение с неограниченым вводом значений пользователем через клавиатуру,
//До тех пор, пока не будет введено пустое значение
string s;
List<string> AS = new List<string>();
do
{
    Console.Write("Введите Значения через Enter: ");
    s = Console.ReadLine()!;
    if (s != "")
        AS.Add(s);
} while (s != "");


Console.Write($"[");
foreach (var item in AS)
    Console.Write($"{item};");
Console.Write($"]");
Console.Write($"-> ");

List<string> AS2 = new List<string>();
foreach (var item in AS)
{
    if (item.Length <= 3)
    {
        AS2.Add(item);
    }
}
Console.Write($"[");
foreach (var item in AS2)
    Console.Write($"{item};");
Console.Write($"]");

//Решение задачи с использованием методов. И в новой ветке.
string[] AS = new string[4];
AS = FillAS(4);
PrintAS(AS);


List<string> AS2 = new List<string>();
for (int i = 0; i < AS.Length; i++)
{
    if (AS[i].Length <= 3)
    {
        AS2.Add(AS[i]);
    }
}
Console.Write($"[");
foreach (var item in AS2)
    Console.Write($"{item};");
Console.Write($"]");


//Метод Заполнения Массива
string[] FillAS(int n)
{
    string[] _AS = new string[n];
    for (int i = 0; i < _AS.Length; i++)
    {
        Console.Write("Введите Строку: ");
        _AS[i] = Console.ReadLine()!;
    }
    return _AS;
}

//Метод вывода массива
void PrintAS(string[] _AS)
{
    Console.Write($"[");
    for (int i = 0; i < _AS.Length; i++)
    {
        Console.Write($"{_AS[i]};");
    }
    Console.Write($"]");
    Console.Write($"-> ");
}