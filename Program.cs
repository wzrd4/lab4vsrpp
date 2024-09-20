﻿using lab4;

using (ApplicationContext db = new ApplicationContext())
{
    /*User tom = new User("Tom", 33);
    User alice = new User("Alice", 26);

    db.Users.Add(alice);
    db.Users.Add(tom);

    db.SaveChanges();
    Console.WriteLine("Saved!");*/

    List<User> users = db.Users.ToList();
    Console.WriteLine("Users:");
    foreach (User user in users)
    {
        Console.WriteLine($"{user.Id}.{user.Name} - {user.Age}");
    }
}