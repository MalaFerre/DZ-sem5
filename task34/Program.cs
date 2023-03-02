// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

const int SIZE = 10;
const int LEFT_RANGE = 100;
const int RIGT_RANGE = 999;
int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}
int[] array = new int[SIZE];
int count = 0;
/*Не понимаю как объявить тело, для этой функции((
*/
int[] GenerateCount(int count); 
{
for (int j = 0; j < array.Length; j++)
    {
     if(array[j] % 2 == 0)
        count++;
    }
    return count;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

void PrintCount(int[] count)
{
    System.Console.WriteLine(count);
}

var myArray = GenerateArray(SIZE, LEFT_RANGE, RIGT_RANGE);
PrintArray(myArray);
var myCount = GenerateCount(count);
PrintCount(myCount);
GenerateArray(count);

