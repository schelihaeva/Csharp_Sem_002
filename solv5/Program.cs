// напишите программу, которая на входе принимает два числа и проверяет, является ли одно число квадратом втрого
//5,25->да
//4,16 ->lf
//8,9 ->нет

System.Console.WriteLine("введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if(secondNumber == firstNumber * firstNumber || firstNumber == secondNumber * secondNumber){
    System.Console.WriteLine("yes");
}
else{
    System.Console.WriteLine("no");
}