// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.

int InputInt (string msg) // ввод с консоли целого числа
{
    Console.Write($"{msg} ->");
    int result;
    if (int.TryParse(Console.ReadLine(), out result))
    {
        return result;
    }
    Console.WriteLine("ОШИБКА: Введено не целочисленное значение.");
    Environment.Exit(1);
    return 0;
}

(int begin, int end) CheckInputNumbers(int natNum1, int natNum2) // проверка валидности введенных чисел
{
    switch ((natNum1, natNum2))
    {
        case (>=0, >=0) when natNum1 < natNum2:
            return (natNum1, natNum2);
        case (>=0, >=0) when natNum1 > natNum2:
            return (natNum2, natNum1);
        case (>= 0, >= 0) when natNum1 == natNum2:
            Console.WriteLine("ОШИБКА: Числа не должны совпадать.");
            Environment.Exit(1);
            return (0, 0);
        default: 
            Console.WriteLine("ОШИБКА: Числа не могут быть отрицательными");
            Environment.Exit(2);
            return (0, 0);
    }
}

int SumNatNumbers(int begin, int end) // вывод суммы натурального ряда
{
    if (begin > end) return 0;
    return begin + SumNatNumbers(begin + 1, end);
}

int natNum1 = InputInt("Введите натуральное число");
int natNum2 = InputInt("Введите другое натуральное число");
(int begin, int end) natNum = CheckInputNumbers(natNum1, natNum2);
Console.WriteLine(SumNatNumbers(natNum.begin, natNum.end));