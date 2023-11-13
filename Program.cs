﻿using KESCHA.Classes;

// Greetings

// Console.Write("Write your name: "); 

// String name = Console.ReadLine();

// Console.WriteLine($"Nice to meet you, {name.ToUpper()}.\nSo you have to solve 3 problems, ok?");

// Console.WriteLine("-------------------------");
// Console.WriteLine("1. Calculation of the surface of a circle and the length of a circle");
// Console.WriteLine("-------------------------");

// // task-1
// Console.Write("Enter radius: ");

// string asstring_radius = Console.ReadLine();
// float radius = Convert.ToSingle(asstring_radius);

// double pi = 3.14;

// double L = 2 * pi * radius;
// double S = pi * radius * radius;

// Console.WriteLine($"L = {L}, S = {S}");

// Console.WriteLine("-------------------------");
// Console.WriteLine("2. Currency converter");
// Console.WriteLine("-------------------------");

// Console.Write("Enter number: ");

// string asstring_num = Console.ReadLine();
// float num = Convert.ToSingle(asstring_num);

// int kurs = 12400;

// double kurs_result = kurs * num;
// Console.WriteLine($"Currency Rates: {kurs_result}");

// Console.WriteLine("-------------------------");
// Console.WriteLine("3. Age calculation");
// Console.WriteLine("-------------------------");

// Console.Write("Enter the current year: ");
// string asstring_current_year = Console.ReadLine();
// int current_year = Convert.ToInt32(asstring_current_year);

// Console.Write("Enter the birth year: ");
// string asstring_birth_year = Console.ReadLine();
// int birth_year = Convert.ToInt32(asstring_birth_year);

// int one_year = 365;

// double age_in_days = one_year * (current_year - birth_year);

// Console.WriteLine($"{name}, Your age is equal{age_in_days}");


// Console.Write("Insert number: ");
// int num_1 = Convert.ToInt32(Console.ReadLine());
// string str_1 = "telefOn";

// // task-1

// Console.WriteLine("-------------------------");
// Console.WriteLine("1. ToLower Or ToUpper");
// Console.WriteLine("-------------------------");

// if (str_1.Length > num_1) {
//     Console.WriteLine(str_1.ToLower());
// }
// else {
//     Console.WriteLine(str_1.ToUpper());
// }

// // task-2

// Console.WriteLine("-------------------------");
// Console.WriteLine("2. Comparation");
// Console.WriteLine("-------------------------");

// int x = 15;
// int y = 10;

// if (x > y) {
//     Console.WriteLine("X is greater than Y");
// }
// else if (x < y) {
//     Console.WriteLine("Y is greater than X");
// }
// else if (x == y) {
//     Console.WriteLine("X is equal to Y");
// }
// else {
//     Console.WriteLine("X and Y are not comparable");
// }

// // task-3

// Console.WriteLine("-------------------------");
// Console.WriteLine("3. Weekday and Weekend");
// Console.WriteLine("-------------------------");

// Console.Write("Insert string value: ");
// string operation = Console.ReadLine();

// switch (operation.ToLower()) {
//     case "dushanba":
//         Console.WriteLine("Monday");
//         break;
//     case "seshanba":
//         Console.WriteLine("Tuesday");
//         break;
    
//     case "chorshanba":
//         Console.WriteLine("Wednesday");
//         break;
    
//     case "payshanba":
//         Console.WriteLine("Thusday");
//         break;
    
//     case "juma":
//         Console.WriteLine("Friday");
//         break;
    
//     case "shanba":
//         Console.WriteLine("Saturday");
//         break;
    
//     case "yakshanba":
//         Console.WriteLine("Sunday");
//         break;
    
//     default:
//         Console.WriteLine("Operation Not Found!");
//         break;
// }

// string result_day = operation.ToLower() switch {
//     "dushanba" => "Monday",
//     "seshanba" => "Tuesday",
//     "chorshanba" => "Wednesday",
//     "payshanba" => "Thusday",
//     "juma" => "Friday",
//     "shanba" => "Saturday",
//     "yakshanba" => "Sunday",
//     _ => "Operation Not Found"
// };

// Console.WriteLine(result_day);

// task-1

// int num = 10;
// int i = 0;
// int sum = 0;

// while (i <= num) 
// {
    
//     if (i % 2 != 0) 
//     {
//         sum +=i;
//     }
//     i++;
// }

// Console.WriteLine(sum);

// task-2

// int[] num_list = {6, 2, 3, 4, 5, 3};

// int smallest = num_list[0];
// int largest = num_list[0];

// for (int j = 1; j < num_list.Length; j++)
// {
//     if (num_list[j] < smallest)
//     {
//         smallest = num_list[j];
//     }

//     if (num_list[j] > largest)
//     {
//         largest = num_list[j];
//     }
// }

// int res_multi = smallest * largest;
// Console.WriteLine(res_multi);

// // task-3

// Console.Write("Enter random number: ");
// int random_num =  Convert.ToInt32(Console.ReadLine());

// int initial_num = 1;
// int sum_factorial = 1;

// while(initial_num != random_num+1){
    
//     sum_factorial *=initial_num;
//     initial_num +=1;
//     // sum_factorial = sum_factorial * initial_num;
//     // initial_num = initial_num + 1;
// }

// Console.WriteLine(sum_factorial);

// OOP bo’limi uchun 1-amaliy vazifa

Console.WriteLine("--Welcome to our Book Shop--\nWe have the following books:");

Book AliBaba = new Book(book_name: "Alibaba", book_author: "Zarif Jamal", book_price: 12);
Book HarryPotter = new Book(book_name: "Harry Potter", book_author: "Joanne Rowling", book_price: 18);
Book AtomicHabits = new Book(book_name: "Aromic Habits", book_author: "James Clear", book_price: 30);


Console.WriteLine("---------------------");
AliBaba.PrintBookDetails();
Console.WriteLine("---------------------");
HarryPotter.PrintBookDetails();
Console.WriteLine("---------------------");
AtomicHabits.PrintBookDetails();
Console.WriteLine("---------------------");


Console.Write("--Thank you for choosing our Book Shop--");




