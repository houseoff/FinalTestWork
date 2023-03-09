Console.Clear();
Console.Write("Введите элементы массива через запятую: ");
string[] array = Console.ReadLine()!.Split(',').Select(x => x.Trim()).Where(x => x.Length <= 3).ToArray();
Console.WriteLine($"Длина массива: {array.Length}");
if (array.Length < 1 || string.IsNullOrWhiteSpace(array[0]))
    Console.WriteLine($"Cтрок, длина которых меньше, либо равна трём символам, не найдено");
else
    Console.WriteLine($"Массив строк, длина которых меньше, либо равна трём символам: [{string.Join(',', array)}]");