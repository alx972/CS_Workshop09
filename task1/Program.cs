// Задайте значения M и N. Напишите программу, которая выведет
// все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

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
            System.Console.WriteLine("ОШИБКА: Числа не должны совпадать.");
            Environment.Exit(1);
            return (0, 0);
        default: 
            System.Console.WriteLine("ОШИБКА: Числа не могут быть отрицательными");
            Environment.Exit(2);
            return (0, 0);
    }
}

void PrintEvenNumbers(int begin, int end) // вывод четных чисел на экран
{
    if (begin > end) return;
    if (begin % 2 == 1) begin++;
    System.Console.Write($"{begin} ");
    PrintEvenNumbers(begin + 2, end);
}

int natNum1 = InputInt("Введите натуральное число");
int natNum2 = InputInt("Введите другое натуральное число");
(int begin, int end) natNum = CheckInputNumbers(natNum1, natNum2);
PrintEvenNumbers(natNum.begin, natNum.end);