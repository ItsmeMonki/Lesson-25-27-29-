// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Задача 27. Выдаёт сумму цифр в числе");
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int sum = 0;
do 
{
    sum = sum + numberN % 10;
    numberN = numberN / 10;
}
while (numberN > 0 );
{
Console.WriteLine(sum);
}
