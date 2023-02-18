//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите пятизначное число");
string is_a_number_a_palindrome = Console.ReadLine();

if (is_a_number_a_palindrome.Length != 5)
{
    Console.WriteLine("Введено неверное число");
}
else if (is_a_number_a_palindrome[0] == is_a_number_a_palindrome[4] && is_a_number_a_palindrome[1] == is_a_number_a_palindrome[3])
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}

// проверку на то, что введены именно циферные значения вводить не стал