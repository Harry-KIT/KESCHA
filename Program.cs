// Greetings
Console.Write("Write your name: "); 

String name = Console.ReadLine();

Console.WriteLine($"Nice to meet you, {name}.\nSo you have to solve 3 problems, ok?");

Console.WriteLine("-------------------------");
Console.WriteLine("1. Calculation of the surface of a circle and the length of a circle");
Console.WriteLine("-------------------------");

// task-1
Console.Write("Enter radius: ");

string asstring_radius = Console.ReadLine();
float radius = Convert.ToSingle(asstring_radius);

double pi = 3.14;

double L = 2 * pi * radius;
double S = pi * radius * radius;

Console.WriteLine($"L = {L}, S = {S}");

Console.WriteLine("-------------------------");
Console.WriteLine("2. Currency converter");
Console.WriteLine("-------------------------");

Console.Write("Enter number: ");

string asstring_num = Console.ReadLine();
float num = Convert.ToSingle(asstring_num);

int kurs = 12400;

double kurs_result = kurs * num;
Console.WriteLine($"Currency Rates: {kurs_result}");

Console.WriteLine("-------------------------");
Console.WriteLine("3. Age calculation");
Console.WriteLine("-------------------------");

Console.Write("Enter the current year: ");
string asstring_current_year = Console.ReadLine();
int current_year = Convert.ToInt32(asstring_current_year);

Console.Write("Enter the birth year: ");
string asstring_birth_year = Console.ReadLine();
int birth_year = Convert.ToInt32(asstring_birth_year);

int one_year = 365;

double age_in_days = one_year * (current_year - birth_year);

Console.WriteLine($"{name}, Your age is equal{age_in_days}");



