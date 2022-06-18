// Задача 16: Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
Console.WriteLine("Введите два числа: ");
int number1 = Convert.ToInt32(Console.ReadLine( ));
int number2 = Convert.ToInt32(Console.ReadLine( ));
if (number1 == Math.Sqrt(number2)) 
{   
    Console.WriteLine("Да");
}
else
{
     Console.WriteLine("Нет");
}