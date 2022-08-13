/* Напишите программу, которая принимает на вход трёхзначное число и на
выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */
// 1-st variant

Console.Write("Введи трёхзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]); 


/* 2-nd variant

Console.WriteLine("Введите трехзначное число: ");

int number = Convert.ToInt32(Console.ReadLine());

int secondNumber = (number % 100) / 10;

Console.Write(secondNumber);
 */