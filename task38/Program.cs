// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.7; 7.2; 2.1; 7.8] -> 5.7


Console.Write("Введите размер массива: ");
int Length = Convert.ToInt32(Console.ReadLine());
double[] array = new double[Length];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
    array[i] = Math.Round(rand.Next(-10, 10) + rand.NextDouble(), 1);
Console.Write("Ваш случайный массив: ");
Console.Write(string.Join("; ", array));
int iMax = 0;
int iMin = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[iMax] < array[i])
    {
        iMax = i;
    }
    else if (array[iMin] > array[i])
    {
        iMin = i;
    }
}
Console.WriteLine();
double difference = Math.Round(array[iMax] - array[iMin], 1);
Console.Write("Разница между максимальным и минимальным элементами = " + difference);
