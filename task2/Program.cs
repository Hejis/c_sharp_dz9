// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int Prompt(string messege)
{
    Console.Write(messege);
    string strValue = Console.ReadLine() ?? "0";
    bool isNumber = int.TryParse(strValue, out int value);
    if (isNumber)
    {
        return value;
    }
    throw new Exception("Данное значение не возможно преобразовать в число");
}

int Sum(int m, int n)
{
    if (n < m) { return 0; }
    return n + Sum(m, n-1);
}

int m = Prompt("Введи число M: ");
int n = Prompt("Введи число N: ");
Console.WriteLine("Сумма натуральных элементов от M до N: ");
Console.WriteLine(Sum(m, n));
