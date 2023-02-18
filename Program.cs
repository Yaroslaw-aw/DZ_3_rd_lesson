//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите пятизначное число");

int is_a_number_a_palindrome;

int.TryParse(Console.ReadLine(), out is_a_number_a_palindrome);

bool palindrome(int number)
{
    if (number < 0 || number % 10 == 0)
    {
        return false; 
    }
    else if (number == 0)
    {
        return true;
    }
    else
    {
        int revers_number = 0;
        int temp_number = number;
        int last_number;        

        while (number > revers_number)
        {
            last_number = number % 10;

            temp_number = number;

            number /= 10;

            revers_number = revers_number * 10 + last_number;
        }
        if (temp_number == revers_number || number == revers_number)
        {
            return true;
        }
        return false;
    }
}

if (palindrome(is_a_number_a_palindrome))
{
    Console.WriteLine("Число палиндром");
}    
else
{
    Console.WriteLine("Число не является палиндромом");
}