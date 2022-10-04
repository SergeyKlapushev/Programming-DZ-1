// See https://aka.ms/new-console-template for more information
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int ost = n%2;
Console.WriteLine(ost);
if (ost > 0 || ost < 0) {Console.Write($"{n} —> нечётное");}
else {Console.Write($"{n} —> чётное");}
