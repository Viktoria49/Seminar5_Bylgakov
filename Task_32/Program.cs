﻿// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


int[]  CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

int[] ReplacePosElemArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
    return array;
}

void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]},");
    }
    Console.WriteLine("]");
}

int[] arr = CreateArrayRndInt(4, -10, 11);
PrintArray(arr);
int[] a = ReplacePosElemArray(arr);
PrintArray(a);

// Console.WriteLine($"Сумма отрицательных элементов = {sumPosNegElem[0]}");
// Console.WriteLine($"Сумма положительных элементов = {sumPosNegElem[1]}");