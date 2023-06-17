/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
class Program {
    public static void Main(string[] args) {
        int number = Prompt("Введите число N: ");
        Console.WriteLine($"Последовательность: {GetStringOfNumbers(number)}");
    }

    static int Prompt(string message) {
        Console.Write(message);
        string readInput = Console.ReadLine() ?? "Null";
        int number;
        bool isNumber = int.TryParse(readInput, out number);
        return number;
    }

    static string GetStringOfNumbers(int number) {
        return number <= 1 ? number.ToString() : number + ", " + GetStringOfNumbers(number - 1);
    }
}