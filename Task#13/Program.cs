// // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int number2 = (number % 100);
int number3 = (number2 % 10);
int number4 = (number2 /10);
int number5 = (number / 100 % 10);
    
    if(number > 99 && number <999)
    {   
       Console.WriteLine(number3);
    }
    if(number > 999 && number <9999)
    {
       Console.WriteLine(number4);
    }
    if(number => 10000 && number <99999)
    {
       Console.WriteLine(number5);
    }
    if(number <= 99)
    {
       Console.WriteLine("Incorrect number");
    }


