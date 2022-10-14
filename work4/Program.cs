//В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
void FillArray(int[] collection)
{
    for (int index = 0; index < collection.Length; index++)
    {
   Random losk = new Random();
   collection[index] = losk.Next(-500,500);
    }
}

void PrintArray(int[] collection)
{
    for (int index = 0; index < collection.Length; index++)
    {
    Console.Write($"{collection[index]} ");
    }
}

int[] collection = new int[123];
FillArray(collection);
Console.Write("Массив: ");
PrintArray(collection);
Console.WriteLine(" ");
int count = 0;
for (int index = 0; index < collection.Length; index++)
{
    if (collection[index] >= 10)
    {
        if (collection[index] <= 99)
        {
        count++;
        }
    }
}
 Console.WriteLine($"Количество элементов из отрезка [10,99]: " + count);