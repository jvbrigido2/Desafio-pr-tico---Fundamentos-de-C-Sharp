using System.Globalization;
var validLetter = false;

Console.Write("Do you want to use random numbers? (Y/N) ");
while (!validLetter)
{
    var userChoice = char.Parse(Console.ReadLine());
    switch (userChoice)
    {
        case 'Y':
        case 'y':
            Random random = new Random();
            Console.Write("Define a range for generating the number, starting from 0 to ");
            var range = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            var firstRandomNumber = random.NextDouble() * range;
            var secondRandomNumber = random.NextDouble() * range;
            Calculator(firstRandomNumber, secondRandomNumber);
            validLetter = true;
            break;
        case 'N':
        case 'n':
            Console.Write("Enter the firstNumber: ");
            var firstNumber = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter the secondNumber: ");
            var secondNumber = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Calculator(firstNumber, secondNumber);
            validLetter = true;
            break;
        default:
            Console.Write("Enter valid letter Y or N: ");
            break;
    }

}
Console.WriteLine();
Console.WriteLine("Application finished, enter a key");
Console.ReadKey();



void Calculator(double firstNumber, double secondNumber)
{
    Console.WriteLine();

    Console.WriteLine($"Sum of {firstNumber.ToString("N2", CultureInfo
        .InvariantCulture)} and {secondNumber.ToString("N2", CultureInfo
        .InvariantCulture)} = {(firstNumber + secondNumber).ToString("N2", CultureInfo
        .InvariantCulture)}");
    Console.WriteLine($"Subtraction of {firstNumber.ToString("N2", CultureInfo
        .InvariantCulture)} and {secondNumber.ToString("N2", CultureInfo
        .InvariantCulture)} = {(firstNumber - secondNumber).ToString("N2", CultureInfo
        .InvariantCulture)}");
    Console.WriteLine($"Multiplication of {firstNumber.ToString("N2", CultureInfo
        .InvariantCulture)} and {secondNumber.ToString("N2", CultureInfo
        .InvariantCulture)} = {(firstNumber * secondNumber).ToString("N2", CultureInfo
        .InvariantCulture)}");
    if(secondNumber <= 0)
    {
        Console.WriteLine("Cannot divide by 0");
    }
    else
    {
        Console.WriteLine($"Division of {firstNumber.ToString("N2", CultureInfo
        .InvariantCulture)} and {secondNumber.ToString("N2", CultureInfo
        .InvariantCulture)} = {(firstNumber + secondNumber).ToString("N2", CultureInfo
        .InvariantCulture)}");
    }
    Console.WriteLine($"Average of {firstNumber.ToString("N2", CultureInfo
        .InvariantCulture)} and {secondNumber.ToString("N2", CultureInfo
        .InvariantCulture)} = {((firstNumber + secondNumber) / 2.0).ToString("N2", CultureInfo
        .InvariantCulture)}");
}