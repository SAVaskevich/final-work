Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное допустимое число элементиов одной строки: ");
int srtmax = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите строку массива под индексом {i}:\t");
    string? temp = Console.ReadLine();
    if (srtmax + 1 > temp.Length)
        array[i] = temp;
    else
        array[i] = "";
}
Console.Write("Строки массива:\t[");
for (int i = 0; i < array.Length; i++)
{
    if (array[i] != "")
        Console.Write($"{array[i]}");
    if (i + 1 < array.Length && array[i] != "")
        Console.Write($", ");
}
Console.Write("]");
