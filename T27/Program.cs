//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Введите число:   ");
int N=Convert.ToInt32(Console.ReadLine());
int sum=0;
string strA=N.ToString();
for (int i = 0; i <strA.Length; i++)
{
    sum=sum+(strA[i]-'0');
}
Console.WriteLine(sum);
