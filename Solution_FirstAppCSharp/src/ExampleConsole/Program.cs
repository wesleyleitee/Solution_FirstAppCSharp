// Write and keep in the same line
//Console.Write("Enter a letter for Write");

// Write and move to the next line
//Console.WriteLine("\nEnter a letter for WriteLine");

int? opcao = null;

while (opcao != 0)
{
    Console.Write("Enter a number:");

    // Character code, read only one
    //int value = Console.Read();
    //Console.WriteLine(value);

    // Shows key value and details
    //ConsoleKeyInfo value = Console.ReadKey();   
    //Console.WriteLine(value.KeyChar);

    // Read the entire line
    int value = int.Parse(Console.ReadLine()!);
    Console.WriteLine(value);

    opcao = value;
}
