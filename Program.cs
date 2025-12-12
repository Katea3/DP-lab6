using System;
using System.Diagnostics;

class Program
{
    // Функция выполняет попарное сложение элементов двух массивов A и B
    static int[] PairwiseSum(int[] A, int[] B)
    {
        int nA = A.Length;
        int nB = B.Length;

        // Проверка, что оба массива одинаковой длины (иначе ошибка)
        Debug.Assert(nA == nB, "Ошибка: списки разной длины");

        // Создаём новый массив для результата
        int[] C = new int[nA];

        // --- Сложение с помощью цикла while ---
        int i = 0;
        while (i < nA)
        {
            int x = A[i];   // элемент из массива A
            int y = B[i];   // элемент из массива B
            int s = x + y;  // сумма элементов

            C[i] = s;       // запись в массив результата
            i++;
        }

        // Вывод результата после цикла while
        Console.WriteLine("Результат (while): " + string.Join(", ", C));

        // --- Сложение с помощью цикла for ---
        for (int j = 0; j < nA; j++)
        {
            int x = A[j];   // элемент из A
            int y = B[j];   // элемент из B
            int s = x + y;  // сумма

            C[j] = s;       // обновление значения в массиве результата
        }

        // Вывод результата после цикла for
        Console.WriteLine("Результат (for): " + string.Join(", ", C));

        return C; // Возвращаем массив C
    }

    static void Main()
    {
        // Исходные массивы
        int[] A = { 1, 2, 3, 4, 5 };
        int[] B = { 10, 20, 30, 40, 50 };

        // Вызов функции попарного сложения
        var result = PairwiseSum(A, B);

        // Печать массива рез
