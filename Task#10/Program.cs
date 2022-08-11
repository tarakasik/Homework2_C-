// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int number2 = (number / 10);
int number3 = (number2 % 10);

if(number > 99 && number <= 999)
    {
    Console.WriteLine(number3);
    }  
else
    {  
    Console.WriteLine("Incorrect number");
    }
