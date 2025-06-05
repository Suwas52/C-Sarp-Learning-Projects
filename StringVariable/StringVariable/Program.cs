
string firstName = string.Empty;

firstName = "Tim";

Console.WriteLine(firstName);

//string interpolation
Console.WriteLine($"Hello {firstName}");

string filePath = string.Empty;

filePath = @"C:\Temp\Demo";

Console.WriteLine($@"Hello this {firstName} is at {filePath}");