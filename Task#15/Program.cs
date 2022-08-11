// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

Console.Clear();
Console.WriteLine("Input number day of week: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day > 5 && day <=7)
{
    Console.WriteLine("This weekend!");
}
else 
{
    if(day <= 5)
    {
        Console.WriteLine("Its working day!");
    }
    
    if(day>7)
    {
    Console.WriteLine("Incorrect Number");
    }
}
