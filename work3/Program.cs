//Задать массив, заполнить случайными положительными трехзначными числами. Показать количество нечетных/четных чисел
void FillArray(int[] collection)
{
    for (int index = 0; index < collection.Length; index++)
    {
   Random losk = new Random();
   collection[index] = losk.Next(100,999);
    }
}

void PrintArray(int[] collection)
{
    for (int index = 0; index < collection.Length; index++)
    {
    Console.Write($"{collection[index]} ");
    }
}

int[] collection = new int[15];
FillArray(collection);
Console.Write("Массив: ");
PrintArray(collection);
Console.WriteLine(" ");
int count = 0;
int count1 = 0;
for (int index = 0; index < collection.Length; index++)
{
    if (collection[index] % 2 == 0)
    {
        count++;
    }
}
 Console.WriteLine($"Число четных элементов массива: " + count);
for (int index = 0; index < collection.Length; index++)
{
    if (collection[index] % 2 == 1)
    {
        count1++;
    }
}
Console.WriteLine($"Число нечетных элементов массива: " + count1);



