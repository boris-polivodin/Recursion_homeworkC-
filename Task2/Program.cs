/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
class Program {
    public static void Main(string[] args) {
        int firstNumber = Prompt("Введите первое число: ");
        int secondNumber = Prompt("Введите второе число: ");
        Console.WriteLine($"Сумма чисел в промежутке от {firstNumber} до {secondNumber} = {GetSumOfNumbers(firstNumber, secondNumber)}");
    }

    static int Prompt(string message) {
        Console.Write(message);
        string readInput = Console.ReadLine() ?? "Null";
        int number;
        bool isNumber = int.TryParse(readInput, out number);
        return number;
    }

    static int GetSumOfNumbers(int firstNum, int secondNum) {
        if (firstNum == secondNum) return firstNum;
        else if (firstNum < secondNum) return secondNum + GetSumOfNumbers(firstNum, secondNum - 1);
        else return firstNum + GetSumOfNumbers(firstNum - 1, secondNum);
    }
}