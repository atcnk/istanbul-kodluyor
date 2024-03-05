Console.WriteLine("Hello, World!");

//Console.WriteLine("Casper Excalibur G870");
//Console.WriteLine("Casper Excalibur G870");
//Console.WriteLine("Casper Excalibur G870");

string productName = "Casper Excalibur G870";

Console.WriteLine(productName);
Console.WriteLine(productName);
Console.WriteLine(productName);
Console.WriteLine(productName);

double unitPrice = 27.999;
int unitPrice1 = 27000;
var total = unitPrice1 + unitPrice ;

string productNamee;
double unitPricee;
var unitInStock = 10;

DateTime now = DateTime.Now;
Console.WriteLine(now.Year);
char gender = 'K';
Console.WriteLine(gender);

//-------------------------------------------------

int number1 = 100;
int number2 = 100;

if (number1 < number2)
{
    Console.WriteLine(number1 + " is smaller.");
}
else if (number2 < number1)
{
    Console.WriteLine(number1 + " is bigger.");
}
else
{
    Console.WriteLine(number1 + " equals " + number2 + ".");
}

//-------------------------------------------------

var assigment = -15;

if (assigment <= 100 && assigment >= 81)
{
    Console.WriteLine("AA");
}
else if (assigment <= 80  && assigment >= 71)
{
    Console.WriteLine("BA");
}
else if (assigment <= 70 && assigment >= 51)
{
    Console.WriteLine("CC");
}
else if (assigment <= 50 && assigment >= 40)
{
    Console.WriteLine("DD");
}
else if (assigment <= 39 && assigment >= 0)
{
    Console.WriteLine("FF");
}
else
{
    Console.WriteLine("Wrong number.");
}

//Console.Write("Enter your balance: ");
//double accountBalance = Convert.ToDouble(Console.ReadLine());

//Console.Write("Enter amount you want to withdraw: ");
//double amount = Convert.ToDouble(Console.ReadLine());

//if (accountBalance >= amount)
//{
//    accountBalance -= amount;
//    Console.WriteLine("Withdrawal transaction successful, your balance: " + accountBalance);
//}
//else
//{
//    Console.WriteLine("Insufficient funds");
//}

for (int i =0; i < 100; i++)
{
    Console.WriteLine(i);
}

for (int i = 0; i <= 50; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i + " is an even number");
    }
    else
    {
        Console.WriteLine(i + " is an odd number");
    }
}

//Console.Write("Enter the total number of student: ");
//int totalStudentNum = Convert.ToInt32(Console.ReadLine());

//for (int i = 0; i < totalStudentNum; i++)
//{
//    Console.Write("Enter first name of the student: ");
//    string firstName = Console.ReadLine();
    
//    Console.Write("Enter last name of the student: ");
//    string lastName = Console.ReadLine();

//    Console.WriteLine("Enter first grade: ");
//    int firstGrade = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("Enter second grade: ");
//    int secondGrade = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("Student's name is: {0} {1}", firstName, lastName);
//    Console.WriteLine("Average grade is: {0}", (firstGrade +  secondGrade) / 2);
//}

int number = 15;
bool isPrime = true;

if (number == 15)
{
    return;
}

Console.WriteLine("X");

for (int i = 2; i < number; i++)
{
    if (number % i == 0)
    {
        isPrime = false;
    }
}

if (isPrime) Console.WriteLine("{0} is prime number");
else Console.WriteLine("{0} is not prime number");