﻿using OOP.Inheritance;

////Product product1 = new Product();
////product1.Id = 1;
////product1.Name = "Laptop";
////product1.CategoryId = 1;

//Product product2 = new Product();
//product2.Id = 2;
//product2.Name = null;
//product2.CategoryId = 2;

//ProductManager productManager = new ProductManager();
//List<Product> products = productManager.GetAll();

//foreach (Product product in products)
//{
//    Console.WriteLine(product.Id + " " + product.Name + " " + product.CategoryId);
//}

////Console.WriteLine("Hello, World!");

//////Console.WriteLine("Casper Excalibur G870");
//////Console.WriteLine("Casper Excalibur G870");
//////Console.WriteLine("Casper Excalibur G870");

////string productName = "Casper Excalibur G870";

////Console.WriteLine(productName);
////Console.WriteLine(productName);
////Console.WriteLine(productName);
////Console.WriteLine(productName);

////double unitPrice = 27.999;
////int unitPrice1 = 27000;
////var total = unitPrice1 + unitPrice ;

////string productNamee;
////double unitPricee;
////var unitInStock = 10;

////DateTime now = DateTime.Now;
////Console.WriteLine(now.Year);
////char gender = 'K';
////Console.WriteLine(gender);

//////-------------------------------------------------

////int number1 = 100;
////int number2 = 100;

////if (number1 < number2)
////{
////    Console.WriteLine(number1 + " is smaller.");
////}
////else if (number2 < number1)
////{
////    Console.WriteLine(number1 + " is bigger.");
////}
////else
////{
////    Console.WriteLine(number1 + " equals " + number2 + ".");
////}

//////-------------------------------------------------

////var assigment = -15;

////if (assigment <= 100 && assigment >= 81)
////{
////    Console.WriteLine("AA");
////}
////else if (assigment <= 80  && assigment >= 71)
////{
////    Console.WriteLine("BA");
////}
////else if (assigment <= 70 && assigment >= 51)
////{
////    Console.WriteLine("CC");
////}
////else if (assigment <= 50 && assigment >= 40)
////{
////    Console.WriteLine("DD");
////}
////else if (assigment <= 39 && assigment >= 0)
////{
////    Console.WriteLine("FF");
////}
////else
////{
////    Console.WriteLine("Wrong number.");
////}

//////Console.Write("Enter your balance: ");
//////double accountBalance = Convert.ToDouble(Console.ReadLine());

//////Console.Write("Enter amount you want to withdraw: ");
//////double amount = Convert.ToDouble(Console.ReadLine());

//////if (accountBalance >= amount)
//////{
//////    accountBalance -= amount;
//////    Console.WriteLine("Withdrawal transaction successful, your balance: " + accountBalance);
//////}
//////else
//////{
//////    Console.WriteLine("Insufficient funds");
//////}

////for (int i =0; i < 100; i++)
////{
////    Console.WriteLine(i);
////}

////for (int i = 0; i <= 50; i++)
////{
////    if (i % 2 == 0)
////    {
////        Console.WriteLine(i + " is an even number");
////    }
////    else
////    {
////        Console.WriteLine(i + " is an odd number");
////    }
////}

//////Console.Write("Enter the total number of student: ");
//////int totalStudentNum = Convert.ToInt32(Console.ReadLine());

//////for (int i = 0; i < totalStudentNum; i++)
//////{
//////    Console.Write("Enter first name of the student: ");
//////    string firstName = Console.ReadLine();

//////    Console.Write("Enter last name of the student: ");
//////    string lastName = Console.ReadLine();

//////    Console.WriteLine("Enter first grade: ");
//////    int firstGrade = Convert.ToInt32(Console.ReadLine());

//////    Console.WriteLine("Enter second grade: ");
//////    int secondGrade = Convert.ToInt32(Console.ReadLine());

//////    Console.WriteLine("Student's name is: {0} {1}", firstName, lastName);
//////    Console.WriteLine("Average grade is: {0}", (firstGrade +  secondGrade) / 2);
//////}

////int number = 15;
////bool isPrime = true;

////if (number == 15)
////{
////    return;
////}

////Console.WriteLine("X");

////for (int i = 2; i < number; i++)
////{
////    if (number % i == 0)
////    {
////        isPrime = false;
////    }
////}

////if (isPrime) Console.WriteLine("{0} is prime number");
////else Console.WriteLine("{0} is not prime number");
///

//User user = new User();
//user.Id = 1;
//user.FirstName = "Muhammed";
//user.LastName = "Inan";
//user.Email = "example@hotmail.com";
//user.Password = "1251245124";
//user.Status = true;
//user.Department = "Muhendislik";

//User user1 = new User();
//user1.Id = 1;
//user1.FirstName = "Baran";
//user1.LastName = "Efe";
//user1.Email = "baran@hotmail.com";
//user1.Password = "12423124";
//user1.Status = true;
//user1.Department = null;
//user1.About = "Software Engineer";

//Student student = new Student();
//student.Id = 1;
//student.FirstName = "Ali";
//student.LastName = "Basdemir";
//student.Email = "ali@hotmail.com";
//student.Password = "123456";
//student.Status = true;
//student.About = "Computer Engineer";

//Instructor instructor = new Instructor();
//instructor.Id = 2;
//instructor.FirstName = "Muhammed";
//instructor.LastName = "Inan";
//instructor.Email = "muhammed@hotmail.com";
//instructor.Password = "12321424";
//instructor.Status = true;
//instructor.Department = "Muhendislik";

User user = new User();
user.Id = Guid.NewGuid();
Console.WriteLine(user.Id);

Brand brand = new Brand();
