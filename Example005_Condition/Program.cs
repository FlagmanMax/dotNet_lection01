﻿Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "максим")
{
        Console.WriteLine("Ура, это же Максим!");
}
else
{
         Console.Write("Привет, ");
         Console.WriteLine(username);
}