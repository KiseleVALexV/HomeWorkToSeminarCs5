// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] numbers = new int[4];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(100,1000);

    Console.Write(numbers[i] + " ");
}

int summa = 0;
for (int i=0; i < numbers.Length; i++)
    if (numbers[i] % 2 == 0 )
    {
        summa++;
    }
Console.WriteLine("\n" + summa);
Console.ReadKey();
