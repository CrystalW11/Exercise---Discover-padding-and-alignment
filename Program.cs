string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);

Console.WriteLine(result);

/* Formatting strings by adding whitespace before or after*/
string input = "Pad this";

/* Padding Before*/
Console.WriteLine(input.PadLeft(12));
/* Padding After*/

Console.WriteLine(input.PadRight(12));

/*
In C#, an overloaded method is another version of a method with different or extra arguments that modify the functionality of the method slightly, as is the case with the overloaded version of the PadLeft() method.
*/

Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));

/* Add the Payment ID to the output*/

// string paymentId = "769C";
// var formattedLine = paymentId.PadRight(6);
// Console.WriteLine(formattedLine);

/*Add the payee name to the output*/

string paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);

/*Add a line of numbers above the output to more easily confirm the result*/
Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);



