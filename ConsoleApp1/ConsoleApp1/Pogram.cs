//Numbers();

BranchesAndLoops();


#region Branches and loops

void BranchesAndLoops()
{
    ExploreIf();

    ExploreLoops();

    SumIntegetrsBetween1And20ThatAreDivisibleBy3();
}

void SumIntegetrsBetween1And20ThatAreDivisibleBy3()
{
    int sum = 0;
    for (int index = 1; index < 21; index++)
    {
        if (index %3 == 0)
        {
            sum = sum + index;
        }
    }
    Console.WriteLine($"the sum of all the numbers 1-20 divisible by 3 is {sum}");
}

void ExploreIf()
{
    int a = 5;
    int b = 3;
    if (a + b > 10)
    {
        Console.WriteLine("the answer is greater than 10.");
    }
    else
    {
        Console.WriteLine("the answer is not greater than 10");
    }
    int c = 4;
    if ((a + b + c > 10) || (a == b))
    {
        Console.WriteLine("The answer is greater than 10");
        Console.WriteLine("And the First number is equal to the second");
    }
    else
    {
        Console.WriteLine("The answer is not greater than 10");
        Console.WriteLine("Or the first number is not equal to the second");
        if ((a + b + c > 10) || (a == b))
        {
            Console.WriteLine("the answer is greater than 10");
            Console.WriteLine("or the First number is equal to the second");
        }
        else
        {
            Console.WriteLine("The answer is not greater than 10");
            Console.WriteLine("And the first number is not equal to the second");
        }
    }
}

void ExploreLoops()
{
    int counter = 0;
    do
    {
        Console.WriteLine($"Hello world! the couinter is {counter}");
        counter++;
    } while (counter < 10);

    for (int index = 0; index < 10; index++)
    {
        Console.WriteLine($"Hello World! The index is {index}");
    }
    for (int row = 1; row < 11; row++)
    {
        Console.WriteLine($"the row is {row}");
    }
    for (char column = 'a'; column < 'k'; column++)
    {
        Console.WriteLine($"The column is {column}");
    }
    for (int row = 1; row < 11; row++)
    {
        for (char column = 'a'; column < 'k'; column++)
        {
            Console.WriteLine($"The column is {column}");
        }
        Console.WriteLine($"the row is {row}");
    }
}

#endregion

#region Numbers

void Numbers()
    {
        WorkWithIntegers();

        OrderPrecedence();

        TestLimits();

        WorkWithDoubles();

        WorkingWithDecimals();

        CalculateAreaOfAUserDefinedCircle();
    }

    void WorkWithIntegers()
    {
        int a = 18;
        int b = 6;
        int c = a + b;
        Console.WriteLine(c);

        // subtraction
        c = a - b;
        Console.WriteLine(c);

        //multiplication
        c = a * b;
        Console.WriteLine(c);

        //division
        c = a / b;
        Console.WriteLine(c);
    }

    void OrderPrecedence()
    {
        int a = 5;
        int b = 4;
        int c = 2;
        int d = (a + b) * c;
        Console.WriteLine(d);

        d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
        Console.WriteLine(d);

        int e = 7;
        int f = 4;
        int g = 3;
        int h = (e + f) / g;
        Console.WriteLine(h);
    }

    void TestLimits()
    {
        int a = 7;
        int b = 4;
        int c = 3;
        int d = (a + b) / c;
        int e = (a + b) % c;
        Console.WriteLine($"quotient: {d}");
        Console.WriteLine($"remainder: {e}");

        int max = int.MaxValue;
        int min = int.MinValue;
        Console.WriteLine($"the range of integers is {min} to {max}");

        int what = max + 3;
        Console.WriteLine($"an example of overflow: {what}");
    }

    void WorkWithDoubles()
    {
        double a = 5;
        double b = 4;
        double c = 2;
        double d = (a + b) / c;
        Console.WriteLine(d);

        double e = 19;
        double f = 23;
        double g = 8;
        double h = (e + f) / g;
        Console.WriteLine(h);

        double max = double.MaxValue;
        double min = double.MinValue;
        Console.WriteLine($"the range of double is {min} to {max}");

        double third = 1.0 / 3.0;
        Console.WriteLine(third);
    }

    void WorkingWithDecimals()
    {
        decimal min = decimal.MinValue;
        decimal max = decimal.MaxValue;
        Console.WriteLine($"the range of the decimal type is {min} to {max}");

        double a = 1.0;
        double b = 3.0;
        Console.WriteLine(a / b);

        decimal c = 1.0M;
        decimal d = 3.0M;
        Console.WriteLine(c / d);
    }

    void CalculateAreaOfACircle(double radius)
    {
        double area = radius * radius * Math.PI;
        Console.WriteLine($"The area of a circle with a radius {radius} is {area}");
    }

    void CalculateAreaOfAUserDefinedCircle()
    {
        Console.WriteLine("Enter radius:");
        string input = Console.ReadLine();
        double rad;
        bool ok = Double.TryParse(input, out rad);
        if (!ok)
        {
            Console.WriteLine($"This is not a number: {input}");
        }
        else
        {
            CalculateAreaOfACircle(rad);
        }
    }

#endregion