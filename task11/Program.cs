// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] numbers = new int[8] {1, 2, 3, 4, 5, 6, 7, 8};

int i = 0;
while(i < numbers.Length)
{
    Console.WriteLine(numbers[i]);
    i++;
}

// foreach(int i in numbers){
//     Console . Write(i + " ");
// }

// for (int i = 0; i < numbers.Length; i++)
// {
//     Console.WriteLine(numbers[i]);
// }