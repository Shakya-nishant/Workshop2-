DateTime birthDate = new DateTime(2004, 2, 12);
DateTime currentDate = DateTime.Now;

TimeSpan ageSpan = currentDate - birthDate;
int age = (int)(ageSpan.TotalDays / 365.25);

Console.WriteLine($"Birthdate: {birthDate:yyyy-MM-dd}");
Console.WriteLine($"Current Date: {currentDate:yyyy-MM-dd}");
Console.WriteLine($"Age: {age} years");

DateTime newDate = birthDate.AddDays(10);
Console.WriteLine($"Birthdate + 10 Days: {newDate:yyyy-MM-dd}");