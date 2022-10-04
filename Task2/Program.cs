// See https://aka.ms/new-console-template for more information
Console.WriteLine($"Введите три числа: ");

int [] array = {Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())};

int maxCount = 0;

for(int i =0; i < array.Length; i++)
{
    if(array[i] > maxCount)
    {
        maxCount = array[i];
    }
}

Console.WriteLine($"Максимальное число: {maxCount}");