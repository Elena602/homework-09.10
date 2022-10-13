//В указанном массиве вещественных чисел найти разницу между максимальным и минимальным элементами
double[] array = new double[] {-5.15, 7.11, 18.67, -43.1, -65.87, 98.8, -32.9, -17.46, 124.78, 59.65, 75.6, 94.43};
int count = array.Length;
int index = 0;
while (index < count)
{
    Console.Write(array[index] + " ");
    index++;
}
Console.WriteLine();

double min = 0;
double max = 0; 
for (index = 0; index < count; index++)
{
    if (min > array[index])
    {
        min = array[index];
    }
}
for (index = 0; index < count; index++)
{
    if (max < array[index])
    {
        max = array[index];
    }
}
double difference = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементами: " + difference);