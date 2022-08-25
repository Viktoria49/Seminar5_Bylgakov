// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.WriteLine("Введите число элеентов маива");
int qty = Convert.ToInt32(Console.ReadLine());

if (qty < = 0 )
{
    Console.WriteLine("Ошибка: число элементов должно быть натуральным числом!");
    return;
}

int[] arr = CreateArrayRndInt(qty, 0, 9)
PrintArray(arr);
    int[] multsArr = GetMults(arr);
    Console.Write($" -> ");

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
