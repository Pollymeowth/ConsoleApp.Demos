﻿// Declare variables

using System.Xml.Linq;

string firstName = string.Empty;
string lastName = string.Empty;

int age;
int retirementAge = 65;
decimal salary;
char gender;
bool working;

// Promp the user for input
Console.Write("Please enter your first name:");
firstName = Console.ReadLine();

Console.Write("Please enter your last name:");
lastName = Console.ReadLine();

Console.Write("Please enter your age:");
age =  Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your salary:");
salary = Convert.ToDecimal(Console.ReadLine());

Console.Write("Please enter your gender (M or F):");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are you working (true or false)?");
working = Convert.ToBoolean(Console.ReadLine());

//Process the data
int workingYearsRemaining = retirementAge - age;

//Output the results to the user
Console.WriteLine($"Nome: {firstName} {lastName}");
Console.WriteLine($"Idade: {age}");
Console.WriteLine($"Seu salário é de: R$ {salary}");
Console.WriteLine($"Seu gênero é: R$ {gender}");
Console.WriteLine($"Você está trabalhando: R$ {working}");
Console.WriteLine($"Quantidade de anos para se aposentar: {workingYearsRemaining}");





