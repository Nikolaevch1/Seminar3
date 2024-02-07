// Задайте массив из 10 элементов, заполненный числами из промежутка [-10, 10]. 
// Замените отрицательные элементы на положительные, а положительные на отрицательные.
// Пример
// [1 -5 6] => [-1 5 -6]

const int size = 10;
int[] array = new int[size] { 1, -5, 6, 3, -9, -3, 5, 3, 7, 0 };
for (int i = 0; i < size; i++)
{
    System.Console.Write(array[i] + " ");
}

for (int i = 0; i < size; i++)
{
    array[i] = -array[i];
}

for (int i = 0; i < size; i++)
{
    System.Console.Write(array[i] + " ");
}
