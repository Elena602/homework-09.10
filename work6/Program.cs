// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
void FillArray(int[] collection)
{
    for (int index = 0; index < collection.Length; index++)
    {
   Random losk = new Random();
   collection[index] = losk.Next(-10,20);
    }
}

void PrintArray(int[] collection)
{
    for (int index = 0; index < collection.Length; index++)
    {
    Console.Write($"{collection[index]} ");
    }
}

int[] collection = new int[20];
FillArray(collection);
Console.Write("Массив: ");
PrintArray(collection);
Console.WriteLine(" ");
int result = 0;
for (int index = 0; index < collection.Length/2; index++)
  {
    result = collection[index] * collection[collection.Length - 1 - index];
    Console.WriteLine($"Произведение пар чисел: " + result);
  }
 