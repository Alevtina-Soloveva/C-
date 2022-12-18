Console.Clear();
Console.WriteLine("Write your number : ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0)
    Console.WriteLine("Yes");
else if (a % 2 >= 0 || a % 2 <= 0)
    Console.WriteLine("No");
