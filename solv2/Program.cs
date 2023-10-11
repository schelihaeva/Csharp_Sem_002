// Random rend = new Random();
// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа
// 456->46
//782 - >72
// 918->98
// Решение задачи
Random rand = new Random();
int randomNumber = rand.Next(100, 1000);
int leftDigit = randomNumber / 100;
int rightDigit = randomNumber % 10;
System.Console.WriteLine(leftDigit + "" + rightDigit);
//int result = leftDigit * 10 + rightDigit;
//System.Console.WriteLine(randomNumber + "->"+ result);

