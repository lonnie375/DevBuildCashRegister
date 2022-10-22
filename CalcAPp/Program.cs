using CalcAPp;

Console.WriteLine("Welcome to the calculator!");
Console.WriteLine();
Console.Write("(1) Factorial or (2) Factors: ");
int choice = int.Parse(Console.ReadLine());

Console.Write("Great! What number? ");
int number = int.Parse(Console.ReadLine());

Calculator calc = new Calculator(number);

if (choice == 1)
{
    int factorial = calc.FindFactorial();
    Console.WriteLine($"The factorial of {number} is {factorial}."); 
}
else if (choice == 2)
{
    Console.WriteLine("Under construction. Coming soon");
    Console.WriteLine($"The factos of {number} are ... don't know yet!");
}