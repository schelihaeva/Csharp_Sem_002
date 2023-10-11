// Напишите программу, которая выводит случайное число из отрезка(10,99) и показывает наибольшую цифру
// 78->8
//12->2
//85->8
int randomNumber = new Random().Next(10,100); // в диапазоне в скобке слева число будет входить в расчет, а справа-не будет входить в расчет!!! Запомнить при такой функции!!
System.Console.WriteLine(randomNumber);
// 67/10 - >6 (получится 6) узнаем левую цифру числа
// 67/% 10- > 7 (получаем остаток от деления 7) узнаем правую числу числа
//
 // int leftDigit = randomNumber / 10;
//int rightDigit = randomNumber % 10;


if (randomNumber / 10 > randomNumber % 10)
{
    System.Console.WriteLine(randomNumber / 10);
}
else{
    System.Console.WriteLine(randomNumber % 10);
}
