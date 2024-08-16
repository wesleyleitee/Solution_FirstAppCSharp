// Camel Case
// For Example, the variable starts with a lowercase letter and other names
// without spaces and capital letters

string camelCase = "Example of message";

// Pascal Case
// For example, used for functions
void Example()
{
    Console.WriteLine("Example");
}

// Verbatim Literal
// Preserves content, characteres and newlines, readability is improved
string verbatim = @"C:\Files.txt
                    skipping line";

// Example of String Interpolation
// It is possible to include directly in the string
string name = "Wesley";
string interpolation = $"Hello, {name}";

// Example of Position Marker
// It is in the sequence of positions
string firstName = "Wesley";
string lastName = "Leite";
string positioned = string.Format("Here is {0} {1}", firstName, lastName);

Console.WriteLine(verbatim);
Console.WriteLine(interpolation);
Example();

