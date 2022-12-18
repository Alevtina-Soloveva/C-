Console.Clear();
Console.WriteLine("Введите 1 число : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число : ");
int b = Convert.ToInt32(Console.ReadLine());
if (a <= b)
    Console.WriteLine($"Большее число : {b}");
else if (a >= b)
    Console.WriteLine($"Большее число : {a}");
else if (a == b)
    Console.WriteLine("Числа равны");