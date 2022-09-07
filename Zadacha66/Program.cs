// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());

if (M > N) return;

int SumNumbers(int M, int N)
{
    if ( M == N) return N;
    return (N + SumNumbers(M, N-1));

}
Console.WriteLine($"Сумма цифр от {M} до {N} = {SumNumbers(M,N)}");

