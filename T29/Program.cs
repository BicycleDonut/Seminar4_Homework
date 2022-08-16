//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

Console.Clear();
int N = 8;
int[] Array(int N, int min, int max)
{
    int[] arr = new int[N];
    for (int i = 0; i < N; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}
Console.WriteLine();
Console.WriteLine("[" + string.Join(",", Array(N, 1, 100)) + "]");
Console.WriteLine();










