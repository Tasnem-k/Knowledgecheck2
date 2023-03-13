// See https://aka.ms/new-console-template for more information

using knowledgecheck2;

Console.WriteLine("How many cats do you want to add? ");
var numberOfCats = int.Parse(Console.ReadLine());

var catList = new List<Cat>();
for (int i = 0; i < numberOfCats; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var cat = new Cat();

    Console.WriteLine("Enter the species of the cat");
    cat.Species = Console.ReadLine();
    Console.WriteLine("Enter the name of the cat");
    cat.Name = Console.ReadLine();
    Console.WriteLine("Enter the age of the cat");
    cat.Age = int.Parse(Console.ReadLine());

    catList.Add(cat);
}

// Print out the list of cats using Console.WriteLine()
foreach (var cat in catList)
{
    Console.WriteLine($"Species: {cat.Species}, Name: {cat.Name}, Age:{cat.Age}");
}
        