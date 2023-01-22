/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/
Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());
int amount = number.ToString().Length;
string str = number.ToString();
int[] b = new int[5];

if (amount < 5 || amount > 5)
{
    Console.WriteLine ("Вы ввели не пятизначное число");
}
else 
{
    for( int i=0; i< 5; i++)
{
     b[i] = int.Parse(str[i].ToString());
}
if (b[0]==b[4] && b[1]==b[3])
{
    Console.WriteLine($"Число {number} полиндром");
}
else
{
    Console.WriteLine($"Число {number} НЕ полиндром");
}
}