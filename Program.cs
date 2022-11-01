
string[] AS = new string[4];
for (int i = 0; i < AS.Length; i++)
{
    Console.Write("Введите Строку: ");
    AS[i] = Console.ReadLine()!;
}

for (int i = 0; i < AS.Length; i++)
{
    Console.Write($"{AS[i]} \n ");
}

string[] AS2 = new string[4];

for (int i = 0; i < AS.Length; i++)
{
    if (AS[i].Length <= 3)
        AS2[i] = AS[i];
}

for (int i = 0; i < AS2.Length; i++)
{
    Console.Write($"{AS2[i]} \n ");
}
