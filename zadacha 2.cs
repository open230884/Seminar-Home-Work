// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

Console.WriteLine("Введите первое число:");

int n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число:");

int n2 = int.Parse(Console.ReadLine());

if (n1 == n2)
{
    Console.WriteLine($"число {n1} равно числу {n2}");
}
else
   {
         if (n1 > n2)
        {
        Console.WriteLine($"число {n1} больше числа {n2}");
        }
        else
        {
        Console.WriteLine($"число {n1} меньше числа {n2}");
        }
        }