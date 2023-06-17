/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
class Program {
    public static void Main(string[] args) {
        int firstNumber = Prompt("Введите первое число: ");
        int secondNumber = Prompt("Введите второе число: ");
        Console.WriteLine($"Значение функции Аккермана A({firstNumber}, {secondNumber}) = {FunctionAckermann(firstNumber, secondNumber)}");
    }

    static int Prompt(string message) {
        Console.Write(message);
        string readInput = Console.ReadLine() ?? "Null";
        int number;
        bool isNumber = int.TryParse(readInput, out number);
        return number;
    }

    static int FunctionAckermann(int number, int argument) {
        if (number == 0) return argument + 1;
        else if (argument == 0) return FunctionAckermann(number - 1, 1);
        else return FunctionAckermann(number - 1, FunctionAckermann(number, argument - 1));
    }
}