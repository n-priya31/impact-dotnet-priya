using System;

int studentAge = 20;                  // camelCase local variable
string firstName = "Priya";           // camelCase local variable
double accountBalance = 1500.75;      // camelCase local variable
bool isActive = true;                 // camelCase local variable
char grade = 'A';                     // camelCase local variable

Console.WriteLine(studentAge);        // PascalCase method
Console.WriteLine(firstName);
Console.WriteLine(accountBalance);
Console.WriteLine(isActive);
Console.WriteLine(grade);

// Compiler Error
//int class = 10;

// Fixed using @
int @class = 10;
Console.WriteLine(@class);