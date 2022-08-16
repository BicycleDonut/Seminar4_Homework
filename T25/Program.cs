//Напишите цикл, который принимает на вход два числа (A и B) и возводит
//число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.WriteLine("Введите число А:  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В:  ");
int b = Convert.ToInt32(Console.ReadLine());
Random Rand = new Random();
int[] num_ved = new int[b];
int res = 1;
for (int i = 0; i < num_ved.Length; i++)
{
    num_ved[i] = Rand.Next(a, a);
    res *= num_ved[i];
}
Console.WriteLine(res);
