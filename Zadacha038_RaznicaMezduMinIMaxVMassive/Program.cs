// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double[] array = new double[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,100);

    Console.Write(array[i] + " ");
}
double SearchDifference(double[] arrray)
{
    double maxi = array[0];
    double mini = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxi)
        {
            maxi = array[i];
        }
        if (array[i] < mini)
        {
            mini = array[i];
        }
    }
    double difference = maxi - mini;
    return difference;
}
Console.WriteLine($"Difference Max Min : {SearchDifference(array)}");

Console.ReadKey();
