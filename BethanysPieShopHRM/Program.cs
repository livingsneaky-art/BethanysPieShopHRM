/*
 * Here are some test around working with valid identifiers in C#
 * We can write here as much as we want, this is all commnet
 */

Console.WriteLine("Welcome to Bethany's Pie Shop HRM");

//Console.WriteLine("Please enter your name: ");

////The following will accept the name
//string name = Console.ReadLine();

//string name2 = Console.ReadLine();

//string name_2 = Console.ReadLine();

//string Name_2 = Console.ReadLine();

/*
not allowed because it start with digit
string 2Name = Console.ReadLine();

CTRL + K + C = comment all
CTRL + K + U = uncomment
*/

/*
//Working with primitive types 

int monthlywage = 1234;

int months = 12, bonus = 1000;

bool isactive = true;

double rating = 99.25;

//byte numberofemployees = 300;//byte can only contain 0 - 255

int hoursworked;

hoursworked = 125;

hoursworked = 148;

//monthlywage = true;//it flag as warning, this is typesafety once the data type is declared it cant not change it's type
*/

/*
//Using constant values

const double interestrate = 0.07;

interestrate = 0.08; //can't be change because using a constant value
*/

/*
//Creating Strings

string firstName = "Bethany";
string lastName = "Smith";

string emptyString = "";

Console.WriteLine("Please enter your name");
string name = Console.ReadLine();
*/

/*
Demo: Using Operators in C#

int months = 12, bonus = 1000;

double ratePerHour = 12.34;
int numberOfHoursWorked = 165;

double currentMonthWage = ratePerHour * numberOfHoursWorked + bonus;
Console.WriteLine(currentMonthWage);

ratePerHour += 3;//ratePerHour = ratePerHour + 3;
Console.WriteLine(ratePerHour);

if (currentMonthWage > 2000)
    Console.WriteLine("To paid employee!");

int numberOfEmployees = 15;
numberOfEmployees--;//++
//Console.WriteLine(numberOfEmployees);

//automatically assign values | when running
bool a;
int b;

Console.ReadLine();
*/

/*
Demo: Working with Members on Primitive Types

int intMaxValue = int.MaxValue;
int intMinValue = int.MinValue;

char userSelection = 'a';
char uppperVersion = char.ToUpper(userSelection);

bool isDigit = char.IsWhiteSpace(uppperVersion);    

bool isLetter = char.IsLetter(uppperVersion);

Console.ReadLine();
*/

/*
Demo: Working with DateTime

DateTime hireDate = new DateTime(2022, 3, 28, 14, 30, 0);
Console.WriteLine(hireDate);

DateTime exitDate = new DateTime(2025, 12, 11);

//DateTime invalidDate = new DateTime(2025, 15, 11

DateTime startDate = hireDate.AddDays(15);
Console.WriteLine(startDate);

DateTime currentDate = DateTime.Now;
bool areWeInDst = currentDate.IsDaylightSavingTime();

DateTime startHour = DateTime.Now;
TimeSpan workTime = new TimeSpan(8, 35, 0);
DateTime endHour = startHour.Add(workTime);

Console.WriteLine(startHour.ToLongDateString());
Console.WriteLine(endHour.ToShortTimeString());
*/

/*
Demo: Converting Between Types

int numberOfHoursWorked = 165;

long veryLongMonth = numberOfHoursWorked;//works fine

double d = 123456789.0;

int x = (int) d;
int intVeryLongMOnth = (int) veryLongMonth;
*/

/*
Demo: Using var 

var monthlyWage = 1234;

int months = 12, bonus = 1000;

var isActive = true;

var rating = 99.25;

var numberOfEmployees = 300;

var hireDate = new DateTime(2022, 3, 28, 14, 30, 0);
*/


Console.ReadLine();