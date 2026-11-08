Console.WriteLine("========= Calculator and Unit Converter =========");
Console.WriteLine("Press 1 for Calculator");
Console.WriteLine("Press 2 for Unit Converter");
string decision = Console.ReadLine();

if (int.TryParse(decision, out int result) && result == 1)
{
    Console.WriteLine("======Welcome to Calculator=======");
    Console.WriteLine("Enter number: ");
    string a = Console.ReadLine();

    if (decimal.TryParse(a, out decimal number1))
    {
    }

    else
    {
        Console.WriteLine("Please enter a valid number.");
    }

    Console.WriteLine("Enter number: ");
    string b = Console.ReadLine();

    if (decimal.TryParse(b, out decimal number2))
    {
    }

    else
    {
        Console.WriteLine("Please enter a valid number.");
    }

    Console.WriteLine("Press 1 for Addition");
    Console.WriteLine("Press 2 for Subtraction");
    Console.WriteLine("Press 3 for Multiplication");
    Console.WriteLine("Press 4 for Division");
    string input = Console.ReadLine();

    if (decimal.TryParse(input, out decimal operationAddition) && operationAddition == 1)
    {
        Console.WriteLine($"The answer is: {number1 + number2}");

    }

    else if (decimal.TryParse(input, out decimal operationSubtraction) && operationSubtraction == 2)
    {
        Console.WriteLine($"The answer is: {number1 - number2}");
    }

    else if (decimal.TryParse(input, out decimal operationMultiplication) && operationMultiplication == 3)
    {
        Console.WriteLine($"The answer is: {number1 * number2}");
    }

    else if (decimal.TryParse(input, out decimal operationDivision) && operationDivision == 4)
    {
        Console.WriteLine($"The answer is: {number1 / number2}");
    }

    else
    {
        Console.Write("Please enter a valid operation method.");
    }

}

else if (int.TryParse(decision, out result) && result == 2)
{
    Console.WriteLine("====Welcome to Unit Converter====");
    Console.WriteLine("Press 1 to conver Kilometres to Miles");
    Console.WriteLine("Press 2 to convert Miles to Kilometer");
    Console.WriteLine("Press 3 to convert Degrees to Fahrenheit");
    Console.WriteLine("Press 4 to convert Fahrenheit to Degrees");
    Console.WriteLine("Press 5 to convert GHS to USD");
    string input = Console.ReadLine();

    if (int.TryParse(input, out int operationKmtoMi) && operationKmtoMi == 1)
    {
        Console.WriteLine("Please input Length in Kilometres");
        string length = Console.ReadLine();
        if (double.TryParse(length, out double lengthInKm))
        {
            Console.WriteLine($"The answer is: {lengthInKm * 0.621371} Miles.");
        }
        else
        {
            Console.WriteLine("Please input a valid length in Kilometres.");
        }
    }

    else if (int.TryParse(input, out int operationMitoKm) && operationMitoKm == 2)
    {
        Console.WriteLine("Please input Length in Miles");
        string length = Console.ReadLine();
        if (double.TryParse(length, out double lengthInMi))
        {
            Console.WriteLine($"The answer is: {lengthInMi * 1.609344} Kilometres.");
        }
        else
        {
            Console.WriteLine("Please input a valid length in Miles.");
        }
    }

    else if (int.TryParse(input, out int operationDgtoFr) && operationDgtoFr == 3)
    {
        Console.WriteLine("Please input temprature in Degrees Celcius");
        string temprature = Console.ReadLine();
        if (double.TryParse(temprature, out double tempratureInDg))
        {
            Console.WriteLine($"The answer is: {(tempratureInDg * 1.8) + 32} Degrees Fahrenheit");
        }
        else
        {
            Console.WriteLine("Please input valid temprature in Degrees Celcius.");
        }
    }

    else if (int.TryParse(input, out int operationFrtoDg) && operationFrtoDg == 4)
    {
        Console.WriteLine("Please input temprature in Degrees Fahrenheit");
        string temprature = Console.ReadLine();
        if (double.TryParse(temprature, out double tempratureInFr))
        {
            Console.WriteLine($"The answer is: {(tempratureInFr - 32) / 1.8} Degrees Celcius");
        }
        else
        {
            Console.WriteLine("Please input valid temprature in Degrees Fahrenheit");
        }
    }

    else if (int.TryParse(input, out int operationGHStoUSD) && operationGHStoUSD == 5)
    {
        Console.WriteLine("Please input amount in GHS");
        string amount = Console.ReadLine();
        Console.WriteLine("What is the rate of 1 GHS today?");
        string rate = Console.ReadLine();
        if (double.TryParse(rate, out double amountInRate))
        {
            Console.WriteLine($"Todays rate is: {amountInRate}");
        }
        else
        {
            Console.WriteLine("Please enter a valid rate");
        }
        if (double.TryParse(amount, out double amountInGHS))
        {
            Console.WriteLine($"The answer is: {amountInGHS * amountInRate} USD");
        }
        else
        {
            Console.WriteLine("Please input a valid amount in GHS");
        }
    }

    else
    {
        Console.WriteLine("Please input a valid operation.");
    }
}

else
{
    Console.WriteLine("Please input a valid operation.");
    Console.WriteLine("=======System Closing========");
}
