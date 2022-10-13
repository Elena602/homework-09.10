//Найти сумму чисел одномерного массива, стоящих на нечетной позиции
int[] array = new int[] {5, 7, 18, 43, -65, 98, -32, -17, 124, 59, 75, 94};
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
    if (index % 2 == 1)
    {
        sum = sum + array[index];
    }
}
Console.WriteLine($"Сумма чисел, стоящих на нечетной позиции массива: " + sum);
