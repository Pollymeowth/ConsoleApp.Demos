// See https://aka.ms/new-console-template for more information

string name = "Pollyana";

Console.WriteLine("I am " + name); //string concatenation   
Console.WriteLine($"They call me {name}");// string interpolation
Console.WriteLine("They call me {0}", name);//formatted string

int age = 30;
int retirementYearsAge = 34;
int retirementAge = age + retirementYearsAge;
Console.WriteLine($"Hello! My name is {name} and I am {age} years old.");
Console.WriteLine("My retirement age is:" + retirementAge);


bool isRetired = false;

if ( age > retirementYearsAge)
{
    isRetired = true;
    Console.WriteLine("Você é aposentado!");
}
else
{ 
    isRetired = false;
    Console.WriteLine($"{name} não é aposentado!");
}

