// Дано натуральное трёхзначное число. Создайте массив, состоящий из цифр этого числа. 
// Младший разряд числа должен располагаться на 0- м индексе массива, старший – на 2-м.
// Пример
// 456 => [6 5 4] 781 => [1 8 7]

// int[] array = { 1, 3, 2, 123, 4, 2, 3 };

// for (int i = 0; i < array.Length / 2 + 1; i++)
// {
//     Console.WriteLine($"{array[i]} {array[^(i + 1)]}");
// }

Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 10)
{
Console.WriteLine(N);
}
else
{
while (N > 0)
{
int currentDigit = N % 10;
N /= 10;
if (N > 0)
{
Console.Write(currentDigit + ",");
}
else
{
Console.WriteLine(currentDigit);
}
}
}