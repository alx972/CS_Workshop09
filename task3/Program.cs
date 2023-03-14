// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

ushort InputInt (string msg) // ввод с консоли целого числа
{
    Console.Write($"{msg} ->");
    ushort result;
    if (ushort.TryParse(Console.ReadLine(), out result)) return result;
    Console.WriteLine("ОШИБКА: Введено не целочисленное значение.");
    Environment.Exit(1);
    return 0;
}

ushort ValidInt(ushort num) // проверка на положительное значение введенного числа
{
        if (num >= 0) return num;
    else 
    {
        System.Console.WriteLine("ОШИБКА: Введено отрицательное значение.");
        Environment.Exit(1);
        return 0;
    }
}

ulong Ackerman(ulong m, ulong n) // функция Аккермана
{
    if (m == 0)
    {
        return n + 1;
    }
    if (n == 0)
    {
        return Ackerman (m - 1, 1);
    }
    return Ackerman(m - 1, Ack(m, n - 1));
}

ushort num1 = ValidInt(InputInt("Введите неотрицательное число"));
ushort num2 = ValidInt(InputInt("Введите ещё одно неотрицательное число"));
System.Console.WriteLine($"m = {num1}, n = {num2} -> {Ack(num1, num2)}");