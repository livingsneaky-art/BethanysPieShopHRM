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

/*
Demo: Working with relational Operators

int age = 23;

bool a = age == 23;

Console.WriteLine("Age is 23: " + a);

bool b = age >= 23;

Console.WriteLine("Age is greater than 23: " + b);

bool c = (age >= 18) && (age <= 65);
Console.WriteLine("Age is between 18 and 65: " + c); ;

int age1 = 16;
int age2 = 64;
bool d = (age1 >= 18) && (age2 <= 65);
Console.WriteLine("Age1 is greater than 18 AND age2 is less than 65: " + d);
bool e = (age1 >= 18) || (age2 <= 65);
Console.WriteLine("Age1 is greater thatn 18 OR age2 is less than 65: " + e);
*/

/*
Demo: Using if Statements 

Console.WriteLine("Enter the age of the new candidate: ");
int age = int.Parse(Console.ReadLine());

if (age < 18)
{
    Console.WriteLine("To young to apply");
    Console.WriteLine("Send email to candidate.");
}
else if(age > 65)
{
    Console.WriteLine("Sorry, the selected age is too old");
    Console.WriteLine("Send email to candidate.");
}
else
{
    Console.WriteLine("Great, you can now start with the application!");
}

DateTime today = DateTime.Now;
bool endOfMonthPaymentStarted = false;

if(today.Date.Day == 3)
{
    Console.WriteLine("Please start end-of-month employee payments");
}
else if(today.Date.Day >= 25 && !endOfMonthPaymentStarted)
{
    Console.WriteLine("Payments will be late!");
}
//else isn't required!
*/

/*
Demo: Using the switch Statement

Console.WriteLine("Enter the age of the new candidate: ");
int age = int.Parse(Console.ReadLine());

switch (age)
{
    case < 18:
        Console.WriteLine("Too young to apply");
        break;
    case > 65:
        Console.WriteLine("Sorry, the selected age is too old");
        break;
    default:
        Console.WriteLine("Great, you can now start with the application!");
        break;
}

switch (age)
{
    //Relational Expression
    case < 18:
        Console.WriteLine("Too young to apply");
        break;
    //Relational Expression
    case > 65:
        Console.WriteLine("Sorry, the selected age is too old");
        break;
    //Constant Expression
    case 23:
        Console.WriteLine("Wow, exactly what we are looking for");
        break;
    default:
        Console.WriteLine("Great, you can now start with the application!");
        break;
}

//can handle the 2 condition cases like the if conditions
switch (age)
{
    case < 18:
    case > 65:
        Console.WriteLine("Sorry, your age is not within the range we are looking for");
        break;
    case 23:
        Console.WriteLine("Wow, exactly what we are looking for");
        break;
    default:
        Console.WriteLine("Great, you can now start with the application!");
        break;
}

Console.WriteLine("Choose the action you want to do: ");
Console.WriteLine("1. Add employee");
Console.WriteLine("2. Update employee");
Console.WriteLine("3. Delete employee");
string selectedAction = Console.ReadLine();

switch (selectedAction)
{
    case "1":
        Console.WriteLine("Adding new employee...");
        break;
    case "2":
        Console.WriteLine("Updating employee...");
        break ;
    case "3":
        Console.WriteLine("Deleting employee...");
        break;
    default:
        Console.WriteLine("Invalid input");
        break;
}
*/

/*
Demo: Creating a while Loop

Console.WriteLine("Enter a value: ");
int max = int.Parse(Console.ReadLine());
int i = 10; //i = 0;

while (i > 0) //(i < max)
{
    Console.WriteLine(i);
    i--; //i++
}

Console.WriteLine("Loop finished!");

//Nested while
int i = 0;
int j = 0;

while (i < 10)
{
    while (j < 10)
    {
        Console.WriteLine("i: " + i + "  j: " + j);
        j++;
    }
    j = 0;
    i++;
}

//Infinite Loop
while (true)
{
    Console.WriteLine(DateTime.Now);
}
*/

/*
Demo: More Loops

string selectedAction;
do
{
    Console.WriteLine("Choose the action you want to do: ");
    Console.WriteLine("1. Add employee");
    Console.WriteLine("2. Update employee");
    Console.WriteLine("3. Delete employee");
    Console.WriteLine("99. Exit application");
    selectedAction = Console.ReadLine();

    switch (selectedAction)
    {
        case "1":
            Console.WriteLine("Adding new employee...");
            break;
        case "2":
            Console.WriteLine("Updating employee...");
            break;
        case "3":
            Console.WriteLine("Deleting employee...");
            break;
        default:
            Console.WriteLine("Invalid input");
            break;
    }
} while (selectedAction != "99");

Console.WriteLine("Closing application");

//Continue and Break
Console.WriteLine("Enter a value: ");
int max = int.Parse(Console.ReadLine());

for(int i = 0; i < 10; i++)
{
    if(i == 5)
    {
        Console.WriteLine("Bingo! " + i + " was found!");
        break;//continue;
    }
    Console.WriteLine(i);
}
*/



/*
Project
Console.WriteLine("Choose the action you want to do: ");
Console.WriteLine("1. Add employee");
Console.WriteLine("2. Update employee");
Console.WriteLine("3. Delete employee");
Console.WriteLine("99. Exit application");
string selectedAction = Console.ReadLine();

while(selectedAction != "99")
{
    switch (selectedAction)
    {
        case "1":
            Console.WriteLine("Adding new employee...");
            break;
        case "2":
            Console.WriteLine("Updating employee...");
            break;
        case "3":
            Console.WriteLine("Deleting employee...");
            break;
        default:
            Console.WriteLine("Invalid input");
            break;
    }
    Console.WriteLine("Choose the action you want to do: ");
    Console.WriteLine("1. Add employee");
    Console.WriteLine("2. Update employee");
    Console.WriteLine("3. Delete employee");
    Console.WriteLine("99. Exit application");
    selectedAction = Console.ReadLine();
}
Console.WriteLine("Closing application");
*/



