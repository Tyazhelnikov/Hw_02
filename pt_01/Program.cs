// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число");

string input = Console.ReadLine();

char[] arr = input.ToCharArray();

Console.WriteLine(arr[1]);
