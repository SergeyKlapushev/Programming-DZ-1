// See https://aka.ms/new-console-template for more information
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int Count = 1;

if (N < Count)
{
    Console.WriteLine("Введите положительное число которое больше нуля");
}

while(Count <= N)
{
    if (Count%2 == 0) {Console.Write(Count + " ");}
    Count++;
}