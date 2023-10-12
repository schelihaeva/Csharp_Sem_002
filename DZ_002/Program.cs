//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
int Prompt(string message)
{

System.Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}
int thirdNumber (int number){
    while (number > 999){
        number /=10;
    }
    return number % 10;
} 
bool NoNumber (int number){
    if (number < 100){
        System.Console.WriteLine("третье цифры нет");
        return false;
    }
    return true;
}
int number = Prompt ("Введите число >");
if (NoNumber(number)){
    System.Console.WriteLine(thirdNumber(number));
}