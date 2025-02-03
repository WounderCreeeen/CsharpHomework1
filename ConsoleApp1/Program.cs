using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("#1");
        Console.Write("Введите число: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Вы ввели число: {number1}");

        Console.Write("#2");
        Console.Write("Введите число: ");
        int number2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"{number2} — вот какое число Вы ввели");

        Console.Write("#3");
        Console.Write("Введите сторону квадрата: ");
        double side = double.Parse(Console.ReadLine());
        double perimeter = 4 * side;
        Console.WriteLine($"Периметр квадрата: {perimeter}");

        Console.Write("#4");
        Console.Write("Введите радиус окружности: ");
        double radius = double.Parse(Console.ReadLine());
        double diameter = 2 * radius;
        Console.WriteLine($"Диаметр окружности: {diameter}");

        Console.Write("#5");
        Console.Write("Введите объем тела (в м³): ");
        double volume = double.Parse(Console.ReadLine());
        Console.Write("Введите массу тела (в кг): ");
        double mass = double.Parse(Console.ReadLine());
        double density = mass / volume;
        Console.WriteLine($"Плотность материала: {density} кг/м³");

        Console.Write("#6");
        Console.Write("Введите основание 1 трапеции: ");
        double base1 = double.Parse(Console.ReadLine());
        Console.Write("Введите основание 2 трапеции: ");
        double base2 = double.Parse(Console.ReadLine());
        Console.Write("Введите высоту трапеции: ");
        double height = double.Parse(Console.ReadLine());
        double sideLength = Math.Sqrt(Math.Pow((base2 - base1) / 2, 2) + Math.Pow(height, 2)); // длина боковой стороны
        double perimeterTrapezoid = base1 + base2 + 2 * sideLength;
        Console.WriteLine($"Периметр равнобедренной трапеции: {perimeterTrapezoid}");

        Console.Write("#7");
        Console.Write("Введите массу в килограммах: ");
        double massInKg = double.Parse(Console.ReadLine());
        int fullTons = (int)(massInKg / 1000);
        Console.WriteLine($"Число полных тонн: {fullTons}");

        Console.Write("#8");
        Console.Write("Введите расстояние в метрах: ");
        double distanceInMeters = double.Parse(Console.ReadLine());
        int fullKilometers = (int)(distanceInMeters / 1000);
        Console.WriteLine($"Число полных километров: {fullKilometers}");

        Console.Write("#9");
        Console.Write("Введите двузначное число: ");
        int twoDigitNumber = int.Parse(Console.ReadLine());
        int tens = twoDigitNumber / 10;
        int units = twoDigitNumber % 10;
        int sum = tens + units;
        int product = tens * units;
        Console.WriteLine($"Число десятков: {tens}, Число единиц: {units}, Сумма цифр: {sum}, Произведение цифр: {product}");

        Console.Write("#10");
        Console.Write("Введите трехзначное число: ");
        int threeDigitNumber = int.Parse(Console.ReadLine());
        int reversedNumber = (threeDigitNumber % 10) * 100 + (threeDigitNumber / 10 % 10) * 10 + (threeDigitNumber / 100);
        Console.WriteLine($"Число, полученное при прочтении цифр справа налево: {reversedNumber}");
    }
}