/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/



void hasThirdNumber(int x) {
    int div = 1;
    while (x / div >= 10) {
        div *= 10;
    }

    if (div < 100) {
        Console.WriteLine("Третьей цифры нет");
    } else {
        int digit = (x / (div / 100)) % 10;
        Console.WriteLine("Третье число {0}", digit);
    }
}
hasThirdNumber(57);
hasThirdNumber(189);
hasThirdNumber(5897);
hasThirdNumber(76523);
hasThirdNumber(896541);
hasThirdNumber(89456123);