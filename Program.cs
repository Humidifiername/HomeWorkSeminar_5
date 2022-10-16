/* Задача 34 Задайте массив заполненный случайными положительными трехзначными числами. 
Напишите программу, которая покажет количество четных чисел в массиве */

int[] num = new int[10];
int count = 0;

for (int i = 0; i < num.Length; i++)
{
    num[i] = new Random().Next(100, 1000);
}

for (int i = 0; i < num.Length; i++)
{
    if (num[i] % 2 == 0)
    {
        count++;
    }
}
Console.Write(count);

/* Задача 36 Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечетных позициях */

int[] array = new int[10];
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(23, 47);
}

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 != 0)
    {
        sum = sum + (array[i]);
    }
}

Console.WriteLine($"Сумма элементов на нечетных позициях = {sum}");

/* Задача 38 Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива */

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] arrayNum = new int[size];
int max = arrayNum[0];
int min = arrayNum[1]; 

for (int i = 0; i < arrayNum.Length; i++)
{
    arrayNum[i] = new Random().Next(-5, 100); 
    Console.Write($"{arrayNum[i]},");
}

for (int i = 0; i < arrayNum.Length; i++)
{
    if (arrayNum[i] > max)
    {
        max = arrayNum[i];
    }
    else if (arrayNum[i] < min)
    {
        min = arrayNum[i];
    }
}
int maxmin = max - min;

Console.WriteLine($"Разница между максимальным и минимальным элементами равна = {maxmin}");