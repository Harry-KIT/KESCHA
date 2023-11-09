// Greetings
Console.Write("Write your name: "); 

String name = Console.ReadLine();

Console.WriteLine($"Nice to meet you, {name.ToUpper()}.\nSo you have to solve 3 problems, ok?");

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


Console.Write("Insert number: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
string str_1 = "telefOn";

// task-1

Console.WriteLine("-------------------------");
Console.WriteLine("1. ToLower Or ToUpper");
Console.WriteLine("-------------------------");

if (str_1.Length > num_1) {
    Console.WriteLine(str_1.ToLower());
}
else {
    Console.WriteLine(str_1.ToUpper());
}

// task-2

Console.WriteLine("-------------------------");
Console.WriteLine("2. Comparation");
Console.WriteLine("-------------------------");

int x = 15;
int y = 10;

if (x > y) {
    Console.WriteLine("X is greater than Y");
}
else if (x < y) {
    Console.WriteLine("Y is greater than X");
}
else if (x == y) {
    Console.WriteLine("X is equal to Y");
}
else {
    Console.WriteLine("X and Y are not comparable");
}

// task-3

Console.WriteLine("-------------------------");
Console.WriteLine("3. Weekday and Weekend");
Console.WriteLine("-------------------------");

Console.Write("Insert string value: ");
string operation = Console.ReadLine();

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

string result_day = operation.ToLower() switch {
    "dushanba" => "Monday",
    "seshanba" => "Tuesday",
    "chorshanba" => "Wednesday",
    "payshanba" => "Thusday",
    "juma" => "Friday",
    "shanba" => "Saturday",
    "yakshanba" => "Sunday",
    _ => "Operation Not Found"
};

Console.WriteLine(result_day);