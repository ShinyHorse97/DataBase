using System;
using System.Collections.Generic;
using DataBase.Models;

public class Program
{
    private static readonly List<User> users = new List<User>
    {
        new User { Id = 1, Name = "Alice", Email = "alice@example.com", Password = "password1", BirthDate = new DateTime(1990, 1, 1) },
        new User { Id = 2, Name = "Bob", Email = "bob@example.com", Password = "password2", BirthDate = new DateTime(1985, 5, 15) },
        new User { Id = 3, Name = "Charlie", Email = "charlie@example.com", Password = "password3", BirthDate = new DateTime(1995, 10, 20) },
        new User { Id = 4, Name = "David", Email = "david@example.com", Password = "password4", BirthDate = new DateTime(1980, 8, 10) },
        new User { Id = 5, Name = "Eve", Email = "eve@example.com", Password = "password5", BirthDate = new DateTime(1992, 3, 25) },
        new User { Id = 6, Name = "Frank", Email = "frank@example.com", Password = "password6", BirthDate = new DateTime(1988, 12, 5) },
        new User { Id = 7, Name = "Grace", Email = "grace@example.com", Password = "password7", BirthDate = new DateTime(1990, 7, 12) },
        new User { Id = 8, Name = "Hannah", Email = "hannah@example.com", Password = "password8", BirthDate = new DateTime(1985, 11, 30) },
        new User { Id = 9, Name = "Ian", Email = "ian@example.com", Password = "password9", BirthDate = new DateTime(1990, 6, 18) },
        new User { Id = 10, Name = "Jack", Email = "jack@example.com", Password = "password10", BirthDate = new DateTime(1987, 9, 14) }
    };
    public static void SearchUsersByName(string name)
    {
        var matchingUsers = users.FindAll(u => u.Name.Contains(name, StringComparison.OrdinalIgnoreCase));
        if (matchingUsers.Count > 0)
        {
            Console.WriteLine($"Found {matchingUsers.Count} user(s) with name containing '{name}':");
            foreach (var user in matchingUsers)
            {
                Console.WriteLine($"Id: {user.Id}, Name: {user.Name}, Email: {user.Email}, BirthDate: {user.BirthDate.ToShortDateString()}");
            }
        }
        else
        {
            Console.WriteLine($"No users found with name containing '{name}'.");
        }
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("List of Users:");
        foreach (var user in users)
        {
            Console.WriteLine($"Id: {user.Id}, Name: {user.Name}, Email: {user.Email}, BirthDate: {user.BirthDate.ToShortDateString()}");
        }
        SearchUsersByName("b"); // Example search for users with 'a' in their name
    }
}