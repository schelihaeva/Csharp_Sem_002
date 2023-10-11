// Напишите программу,которая будет принимать на вход два числа и выводить, является ли второе число кратное первому. Если число 2 не кратно числу 1, то прогрмма выводит остаток от деления
// 34, 5 -> не кратно, оасток 4
// 16, 4 - > кратно
System.Console.WriteLine("введите первое число");
 int FirstNumber = Convert.ToInt32(Console.ReadLine());
 System.Console.WriteLine("введите второе число");
 int secondtNumber = Convert.ToInt32(Console.ReadLine());
 if ((FirstNumber % secondtNumber) == 0)
 {
    System.Console.WriteLine("числа являются кратными");
 }
 else
 {
    System.Console.WriteLine("числа не являются кратными, остаток равен" + (FirstNumber % secondtNumber));
 }