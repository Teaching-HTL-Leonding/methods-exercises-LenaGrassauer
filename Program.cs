string selection;
do
{
    Console.Clear();
    Console.WriteLine("What do you want to execute?");
    Console.WriteLine("============================");
    Console.WriteLine();
    Console.WriteLine("0. Calculate Circle Area");
    Console.WriteLine("1. Random in Range");
    Console.WriteLine("2. To FizzBuzz");
    Console.WriteLine("3. Fibonacci by Index");
    Console.WriteLine("4. Ask for Number in Range");
    Console.WriteLine("5. Is palindrome?");
    Console.WriteLine("6. Is palindrome? (advanced)");
    Console.WriteLine("7. Chart Bar");
    Console.WriteLine("8. Count Smiling Faces");
    Console.WriteLine("q to Quit");
    selection = Console.ReadLine()!;

    if (selection != "q")
    {
        Console.Clear();
        switch (selection)
        {
            case "0": RunCalculateCircleArea(); break;
            case "1": RunRandomInRange(); break;
            case "2": RunFizzBuzz(); break;
            case "3": FibonacciByIndex(); break;
            case "4": AskForNumberInRane(); break;
            case "5": RunCheckIfPalindrome(); break;

            default: break;
        }

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}
while (selection != "q");


#region Calculate Circle Area
void RunCalculateCircleArea()
{
    Console.Write("Enter radius:");
    var radius = double.Parse(Console.ReadLine()!);
    var area = CalculateCircleArea(radius);
    Console.WriteLine($"Area of circle with radius {radius} is {area}");
}

double CalculateCircleArea(double radius)
{
    return radius * radius * Math.PI;
}
#endregion


void RunRandomInRange()
{
    //Variables 
    int counter_for_minimum = 0, counter = 0, counter_for_maximum = 0;

    Console.Write("Enter the minimum: ");
    int minimum = int.Parse(Console.ReadLine()!);

    Console.Write("Enter the maximum:  ");
    int maximum = int.Parse(Console.ReadLine()!);

    for (int i = 0; i < 1_000_000; i++)
    {
        var result = RandomInRange(minimum, maximum);

        if (result == minimum)
        {
            counter_for_minimum++;
        }
        else if (result == maximum)
        {
            counter_for_maximum++;
        }
        else
        {
            counter++;
        }
    }
    Console.WriteLine($"Counter for {minimum} is {counter_for_minimum} ");
    Console.WriteLine($"Counter for {maximum} is {counter_for_maximum} ");
    Console.WriteLine($"Counter for random number is {counter}");
}
int RandomInRange(int min, int max)
{
    max++;
    int random = Random.Shared.Next(min, max);
    return random;
}

void RunFizzBuzz()
{



    System.Console.Write("Please enter a number: ");
    int num1 = int.Parse(Console.ReadLine()!);

    if (num1 % 3 != 0 && num1 % 5 != 0)
    {
        System.Console.WriteLine(num1 + " ");
    }

    else if (num1 % 3 == 0 && num1 % 5 == 0)
    {
        System.Console.WriteLine(" FizzBuzz ");
    }

    else if (num1 % 3 == 0)
    {
        Console.WriteLine(" Fizz ");
    }

    else if (num1 % 5 == 0)
    {
        System.Console.WriteLine(" Buzz ");
    }




}

void FibonacciByIndex()
{
    System.Console.Write("Please enter your first ");
    int num1 = int.Parse(System.Console.ReadLine()!);
}

void AskForNumberInRane()
{
    System.Console.Write("Please enter your minimum: ");
    int min = int.Parse(System.Console.ReadLine()!);
    System.Console.Write("Please enter your maximum: ");
    int max = int.Parse(System.Console.ReadLine()!);

    System.Console.Write($"Please enter a number between {min} and {max}: ");
    int num = int.Parse(System.Console.ReadLine()!);
    if (num < min || num > max) 
    {
        do
        {System.Console.Write("Wrong number, please try again: ");
        num = int.Parse(System.Console.ReadLine()!);
        }while (num < min || num > max);   
         }
    System.Console.WriteLine("Thank you, your number is valid");
}

void RunCheckIfPalindrome()
{
    Console.Write("Please enter your text: ");
    string text = Console.ReadLine()!;

    var result = CheckIfPalindrome(text);
    Console.WriteLine($"The result is: {result}");
}
bool CheckIfPalindrome(string input)
{
    for (int i = 0; i < input.Length / 2; i++)
    {
        if (input[i] != input[input.Length - i - 1])
        {
            return false;
        }
    }
    return true;

}



void RunCheckIfPalindromeAdvanced()
{
    Console.Write("Please enter your text: ");
    string text = Console.ReadLine()!;

    var result = CheckIfPalindromeAdvanced(text);
    Console.WriteLine($"The result is: {result}");
}

bool CheckIfPalindromeAdvanced(string input)
{
    input = input
    .Replace(" ", "")
    .Replace(",", "")
    .Replace("-", "")
    .ToLower();

    for (int i = 0; i < input.Length / 2; i++)
    {
        if (input[i] != input[input.Length - i - 1])
        {
            return false;
        }
    }
    return true;
}



void RunChartBar()
{
    Console.Write("Please enter your number: ");
    double input = double.Parse(Console.ReadLine()!);

    var result = ChartBar(input);

    Console.WriteLine($"The result of {input} is {result}");
}

string ChartBar(double input)
{
    string bar;
    if (input > 0 && input < 0.1)
    {
        bar = "..........";
    }
    else if (input >= 0.1 && input < 0.2)
    {
        bar = "o.........";
    }
    else if (input >= 0.2 && input < 0.3)
    {
        bar = "oo........";
    }
    else if (input >= 0.3 && input < 0.4)
    {
        bar = "ooo.......";
    }
    else if (input >= 0.4 && input < 0.5)
    {
        bar = "oooo......";
    }
    else if (input >= 0.5 && input < 0.6)
    {
        bar = "ooooo.....";
    }
    else if (input >= 0.6 && input < 0.7)
    {
        bar = "oooooo....";
    }
    else if (input >= 0.7 && input < 0.8)
    {
        bar = "oooooo....";
    }
    else if (input >= 0.8 && input < 0.9)
    {
        bar = "oooooooo..";
    }
    else if (input >= 0.9 && input < 1)
    {
        bar = "ooooooooo.";
    }
    else
    {
        bar = "oooooooooo";
    }
    return bar;
}

