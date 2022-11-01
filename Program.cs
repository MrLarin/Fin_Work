
string[] AS = new string[4];
for (int i = 0; i < AS.Length; i++)
{
    Console.Write("Введите Строку: ");
    AS[i] = Console.ReadLine()!;
}

for (int i = 0; i < AS.Length; i++)
{
    Console.Write($"{AS[i]} /n ");
}
