// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

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

int FunctionAckerman(int m, int n)
{
    int result = n + 1;
    if (m == 0)
    {
        return result;
    }
    else if ((m > 0) && (n == 0))
    {
        return FunctionAckerman(m - 1, 1);
    }
    else if ((m > 0) && (n > 0))
    {
        return FunctionAckerman(m - 1, FunctionAckerman(m, n - 1));
    }
    else
        return result;
}

int m = Prompt("Введите значение m: ");
int n = Prompt("Введите значение n: ");
Console.WriteLine("Функция Аккермана для этих значенийЖ: ");
Console.WriteLine($"A({m},{n}) = {FunctionAckerman(m, n)}");