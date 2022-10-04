// See https://aka.ms/new-console-template for more information
Console.Write("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2) { Console.WriteLine("Первое число больше чем второе"); }
if (n2 > n1) { Console.WriteLine("Второе число больше чем первое"); }
if (n2 == n1) { Console.WriteLine("Оба числа равны"); }
