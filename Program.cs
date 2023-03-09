Console.Clear();
Console.Write("Введите элементы массива через запятую: ");
string[] array = Console.ReadLine()!
    .Split(',')
    .Select(x => x.Trim())
    .Where(x => (x.Length <= 3 & !string.IsNullOrWhiteSpace(x)))
    .ToArray();

if (array.Length < 1)
    Console.WriteLine($"Cтрок, длина которых меньше, либо равна трём символам, не найдено");
else
    Console.WriteLine($"Массив строк, длина которых меньше, либо равна трём символам: [{string.Join(',', array)}]");