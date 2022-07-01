/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("Введите номер дня недели");
int num = Convert.ToInt32(Console.ReadLine());

if(num == 6 || num == 7) {
    Console.WriteLine("Выходной день");
}
else if (num > 7) {
     Console.WriteLine("Введен неверный номер");
    }
    else {Console.WriteLine("Будний день");
    }