using CircleObjectsLab;
bool runProgram = true;
int CircleObjectCount = 0;

Console.WriteLine("Welcome to the circle tester");

while(runProgram)
{
    while (true)
    {
        try
        {
            Console.WriteLine("Enter a radius:");
            Circle myCircle = new Circle(double.Parse(Console.ReadLine()));
            Console.WriteLine($"Circumfrence: {myCircle.CalculateFormattedCircumference()}");
            Console.WriteLine($"Area: {myCircle.CalculateFormattedArea()}");
            CircleObjectCount++;
            break;
        }

        catch (FormatException)
        {
            Console.WriteLine("Enter a number for the radius please");
            continue;
        }

    }
    Console.WriteLine("Continue? y/n");
    while (true)
    {
        string response = Console.ReadLine().ToLower().Trim();
        if (response == "y")
        {
            break;
        }
        else if (response == "n")
        {
            Console.WriteLine($"Goodbye. You created {CircleObjectCount} Circle object(s).");
            runProgram = false;
            break;
        } 
        else
        {
            continue;
        }
    }
}

