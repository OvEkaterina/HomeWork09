// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int FunctionAkkerman(int m, int n)
{
    if(m == 0) return n + 1;
    if(m > 0 & n == 0) return FunctionAkkerman(m-1,1);
    else return FunctionAkkerman(m-1,FunctionAkkerman(m,n-1));
    
}
int EnterData(string text)
{
    Console.Write(text);
    int numb = int.Parse(Console.ReadLine());
    return numb;
}
int m = EnterData("Введите число m : ");
int n = EnterData("Введите число n : ");
Console.WriteLine($" m = {m}, n = {n} -> A(m,n) = {FunctionAkkerman(m,n)}");