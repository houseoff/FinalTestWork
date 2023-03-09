string[] DesiredArray(string[] array)
{
    string[] da = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
            da[i] = array[i];
    return da;
}

Console.Clear();
Console.Write("Введите элементы массива через запятую: ");
string[] array = Console.ReadLine()!.Split(',');
string[] da = DesiredArray(array);
if (da.Length == 0)
    Console.WriteLine($"Cтрок, длина которых меньше, либо равна трём символам, не найдено");
else
    Console.WriteLine($"Массив строк, длина которых меньше, либо равна трём символам: [{string.Join(',', da)}]");