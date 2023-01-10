// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int NaturalNumber(int M, int N)
{
    if(M == N) return M;
    else return (M + NaturalNumber(M+1, N));
}
int EnterData(string text)
{
    Console.Write(text);
    int numb = int.Parse(Console.ReadLine());
    return numb;
}
int M = EnterData("Введите число M : ");
int N = EnterData("Введите число N : ");
Console.WriteLine(NaturalNumber(M,N));