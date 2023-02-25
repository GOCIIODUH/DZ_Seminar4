// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] GenArr(int lenght, int left, int right)
{
    int[] array = new int[lenght];
    Random random = new Random();
    for (int i = 0; i < lenght; i++)
    {
        array[i] = random.Next(left, right + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("["+string.Join(", ", array)+"]");
}

PrintArray(GenArr(8, 10, 100));