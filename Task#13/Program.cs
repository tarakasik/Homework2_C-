// // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Input number: ");
long Number = Convert.ToInt64(Console.ReadLine());
string NumberText = Convert.ToString(Number);

if (NumberText.Length > 2)
{
  Console.WriteLine("Third number -> " + NumberText[2]);
}
else 
{
  Console.WriteLine("Not three number");
}



