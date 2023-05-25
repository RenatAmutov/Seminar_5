// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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
int  FindSumNoEvenI(int[] arr)
{
    int count = 0;
    int i = 0;
    while (i <= arr.Length){
        if(i%2 != 0){
        count = count + arr[i];
        }
        i++;
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
Console.Write(FindSumNoEvenI(array));
