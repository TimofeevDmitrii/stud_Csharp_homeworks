﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArray()
{
    System.Console.WriteLine("Введите размер необходимого массива:");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int [size];
    return array;
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100,1000);
}

void PrintArray(int[] array)
{
    System.Console.Write("[ ");
    foreach (int item in array)
        System.Console.Write($"{item} ");
    System.Console.Write("]");
    System.Console.WriteLine();
}

int QuantityOfEvenNumbers(int[] array)
{
    int countEvenNumbers = 0;
    for (int i=0; i<array.Length; i++)
    {
       if (array[i]%2 == 0)
           countEvenNumbers += 1; 
    }
    return countEvenNumbers;
}

int[] testArray = CreateArray();
FillArray(testArray);
PrintArray(testArray);
System.Console.WriteLine($"Количество четных чисел в массиве: {QuantityOfEvenNumbers(testArray)}");
