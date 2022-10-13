// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных чисел
int[] array = new int[] {4, -3, 5, 3, -6, 8, 2, -1, 4, 9, 5, 4};
int count = array.Length;
int index = 0;
while (index < count)
{
    Console.Write(array[index] + " ");
    index++;
}
Console.WriteLine();

int sum = 0;
for (index = 0; index < count; index++)
{
    if (array[index] < 0)
    {
        sum = sum + array[index];
    }
}
Console.WriteLine($"Сумма отрицательных элементов массива: " + sum);

int sum1 = 0;
for (index = 0; index < count; index++)
{
    if (array[index] > 0)
    {
        sum1 = sum1 + array[index];
    }
}
Console.WriteLine($"Сумма положительных элементов массива: " + sum1);


