/*
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
*/
/*
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
*/
/*
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
*/

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
