// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int InputNumber()
{

    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
void CreateArray(int[] arr, int minRand, int maxRand)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minRand, maxRand+1);
    }

}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
int  FindEven(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0){
            count++;
        }        
    }
    return count;

}
Console.Write("Введите размер массива: ");
int size = InputNumber();
int[] array = new int[size];
Console.Write("Введите минимальное значения для заполнения массива: ");
int min = InputNumber();
Console.Write("Введите максимальное значения для заполнения массива: ");
int max = InputNumber();
CreateArray(array, min, max);
Console.WriteLine("Получившийся массив");
PrintArray(array);
Console.WriteLine();
Console.Write("Количество четных чисел в массиве : ");
Console.Write(FindEven(array));
