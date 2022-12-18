Console.Clear();
Console.WriteLine("Введите 1 число : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число : ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 число : ");
int c = Convert.ToInt32(Console.ReadLine());
if (a <= b && c <= b)
    Console.WriteLine($"Большее число : {b}");
else if (a >= b && a >= c)
    Console.WriteLine($"Большее число : {a}");
else if (c >= a && c >= b)
    Console.WriteLine($"Большее число : {c}");
else if (a == b && c >= a)
    Console.WriteLine($"Большее число : {c}");
else if (a == b && c <= a)
    Console.WriteLine($"Большее число : {a}");
else if (a == c && c <= b)
    Console.WriteLine($"Большее число : {b}");
else if (c == b && c <= a)
    Console.WriteLine($"Большее число : {a}");
else if (c == b && c >= a)
    Console.WriteLine($"Большее число : {c}");