// Final capital of savings - Program.cs
// Code by Peter Stackebrandt
// Task by Hardy:C#IT.-2024, 3.1, p. 289

// See https://aka.ms/new-console-template for more information

using FinalCapitalOfSavingsConsApp;

Console.WriteLine("Calculate Final Capital");
var calculator = new FinalCapitalCalculator();
Console.WriteLine("The final capital will be {0:F3}", calculator.GetFinalCapital());

// Test example
// Initial capital: 1000 euros, interest rate: 5 %, final capital: 1157.625 euros after 3 years.