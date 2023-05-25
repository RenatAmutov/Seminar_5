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
    int first = arr[0];
    int last = arr[arr.Length];
    if(last > first){
        count = last - first;
    }
    else if(last < first){
        count = first - last;
    }
    else{
        count=0;
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
Console.Write("Сумма всех не четных позиций в масиве равна : ");
Console.Write(LastMinusFirst(array));