﻿//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int x = IfNumber("Введите пятизначное число: ");

if (NumberCount(x) == 5)
{
    if ((MaybePalindrome(ArrayNumeral(x))))
    {
        Console.WriteLine($"Пятизначное число {x} - палиандром.");
    }
     else
     {
         Console.WriteLine($"Пятизначное число {x} - не  палиандром");
     }
}
if (NumberCount(x) != 5)
{
  Console.WriteLine($"Вы ввели не пятизначное число.");  
}


int NumberCount(int x)
{
    int count = 0;
    while (x > 0)
    {
        x = x / 10;
        count++;
    }
    return count;
}

int IfNumber(string argument)
{
    Console.Write(argument);
    int m;
    while (!int.TryParse(Console.ReadLine(), out m))
    {
        Console.WriteLine("Это не число");
   }
    return m;
}

int [] ArrayNumeral(int x)
{
    string str = x.ToString();
    int [] Namber = new int [str.Length];
    for (int i = 0; i < str.Length; i++)
    {
       Namber[i] = int.Parse(str[i].ToString()); 
    }
    return Namber;
}

bool MaybePalindrome(int [] Namber)
{  
    int first = 0;
    int last = Namber.Length - 1;
    while (first < last)
    {
        if (Namber[first] == Namber[last])
        {
            first++;
            last--;
        }
        else
        {
            return false;
        }
    }
return true;
}