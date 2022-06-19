//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

 Console.WriteLine("Введи цифру от 1 до 7, обозначающую день недели: ");
int dayNumber= Convert.ToInt32(Console.ReadLine());
while (dayNumber < 1 || dayNumber > 7);
switch (dayNumber) {
        case 6:
           Console.WriteLine("Да, это суббота" );
            break;
        case 7:
            Console.WriteLine("Да, это воскресенье" );
            break;
         default :
            Console.WriteLine("Нет, это рабочий день" );
            break;
       }
