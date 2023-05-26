// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

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
int  LastMinusFirst(int[] arr)
{
    int count = 0;
    int min = arr[0], max = arr[0];
    for (int i = 0; i < arr.Length; i++){
       if(min > arr[i]){
        min = arr[i];
       } 
       if(max < arr[i]){
        max = arr[i];
       }
       count = max - min; 
    }
    Console.WriteLine($"Минимальное число в массиве - {min}"); 
    Console.WriteLine($"Максимальное число в массиве - {max}"); 
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
Console.Write($"Разница между большим и меньшим числов в массиве: {LastMinusFirst(array)}");
