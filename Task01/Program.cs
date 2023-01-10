// Задача 64: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
string NaturalNumber(int numb)
{
    if(numb == 1) return numb.ToString();
    else return (numb + ", " + NaturalNumber(numb-1));
}
int EnterData(string text)
{
    Console.Write(text);
    int numb = int.Parse(Console.ReadLine());
    return numb;
}
int numb = EnterData("Введите число: ");
Console.WriteLine("N = " + numb +" -> " +  NaturalNumber(numb)) ;