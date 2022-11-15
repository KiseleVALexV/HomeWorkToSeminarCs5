// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] numbers = new int[4];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(-20,20);

    Console.Write(numbers[i] + " ");
}
int summa = 0;
for (int i=1; i < numbers.Length; i+=2)
    summa += numbers[i];
Console.WriteLine("\n" + summa);
Console.ReadKey();
