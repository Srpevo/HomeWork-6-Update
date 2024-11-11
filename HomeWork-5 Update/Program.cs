﻿using HomeWork_6_Update.Users.Classes;
using HomeWork_6_Update.Users.Exceptions;

Console.WriteLine("=== Welcome! Let's Create a New User Account ===");
Console.WriteLine();

User user = new();

while (true)
{
    try
    {
        Console.Write("Enter Name: ");
        user.name = Console.ReadLine();

        Console.Write("Enter Email: ");
        user.email = Console.ReadLine();

        Console.Write("Enter Password (minimum 10 characters): ");
        user.password = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("User account successfully created!");
        Console.WriteLine($"Welcome, {user.name}.");
        break;
    }
    catch (IncorrectNameEntryException ex)
    {
        Console.WriteLine($"\n[Name Error] {ex.Message}");
    }
    catch (IncorrectEmailEntryException ex)
    {
        Console.WriteLine($"\n[Email Error] {ex.Message}");
    }
    catch (IncorrectPasswordEntryException ex)
    {
        Console.WriteLine($"\n[Password Error] {ex.Message}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\n[Unknown Error] {ex.Message}");
    }

    Console.WriteLine("\nPlease press any key to try again...");
    Console.ReadKey();
    Console.Clear();
}

Console.WriteLine("\n=======================================");
Console.WriteLine($"User {user.name} created successfully.");
Console.WriteLine("=======================================");
