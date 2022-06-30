class Program
{
    static void checkDivisibility(int endNumber)
    {
        for (int i = 1; i <= endNumber; i++)
        {
            // Capture both conditions to trigger "FizzBuzz" print
            if (i % 3 == 0 && i % 5 == 0)
                Console.WriteLine(i.ToString() + " " + "FizzBuzz");
            // Capture "divisible by three" condition
            else if (i % 3 == 0)
                Console.WriteLine(i.ToString() + " " + "Fizz");
            // Capture "divisible by five" condition
            else if (i % 3 == 0)
                Console.WriteLine(i.ToString() + " " + "Buzz");
            // Print the nuber if none of the conditions are met
            else
                Console.WriteLine(i.ToString());
        }
    }
    // Call the defined method
    static void Main()
    {
        Console.WriteLine("Enter number to end rhe range:");
        // Converting and checking the input
        try
        {
            int inpNumber = Int32.Parse(Console.ReadLine());
            if (inpNumber == 0)
                Console.WriteLine("Number must be greater than '0'");
            else
            {
                if (inpNumber < 0)
                    Console.WriteLine("The '" + inpNumber.ToString() + "' converted to the absolute value.");
                    inpNumber = Math.Abs(inpNumber);
            }
                checkDivisibility(inpNumber);
        }
        catch (FormatException)
        {
            int inpNumber = 100;
            Console.WriteLine("Wrong input, assuming 100 value");
            checkDivisibility(inpNumber);
        }
        
    }
}
