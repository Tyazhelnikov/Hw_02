// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");

string input = Console.ReadLine();

char[] arr = input.ToCharArray();

int demandChar = 3;


if (arr.Length < demandChar){
    Console.WriteLine("такой цифры нет");
}

else Console.WriteLine(arr[demandChar -1]);


