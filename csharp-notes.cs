<!-- escape character sequence -->

Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");
Console.WriteLine("Hello \"World\"!");
Console.WriteLine("c:\\source\\repos");

<!-- verbatim string literal -->
Console.WriteLine(@"   c:\source\repos   
      (""this is where your code goes"")");

<!-- string concatenation -->
string firstName = "Bob";
string greeting = "Hello";
Console.WriteLine(greeting + " " + firstName + "!");

<!-- interpolation expression - variable surrounded by an opening and closing curly brace symbol { } -->
