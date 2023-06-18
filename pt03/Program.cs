// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите номер дня недели");

int input = Convert.ToInt32(Console.ReadLine());

if(input >7) Console.WriteLine("Ошибка, номер должен быть меньше 7");

else if (input == 6 || input == 7){
    Console.WriteLine("Выходной");
}
else Console.WriteLine("Рабочий");
