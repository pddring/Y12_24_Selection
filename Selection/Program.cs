Console.Write("What day is it?");
string day = Console.ReadLine();

switch(day.Trim().ToLower())
{
    case "monday":
        Console.WriteLine("Oh dear, 4 days 'til the weekend");
        break;
    case "tuesday":
        Console.WriteLine("At least it's not Monday");
        break;
    case "wednesday":
        Console.WriteLine("At least it's not Monday");
        break;
    case "thursday":
        Console.WriteLine("At least it's not Monday");
        break;
    case "friday":
        Console.WriteLine("At least it's not Monday");
        break;
    case "saturday":
    case "sunday":
        Console.WriteLine("At least it's not Monday");
        break;
    default:
        Console.WriteLine("I don't recognise that, which means it's probably Monday?");
        break;
}

/*
if (day.ToUpper().Trim() == "MONDAY")
{
    Console.WriteLine("Oh dear, 4 days 'til the weekend");
} else if (day.ToUpper().Trim() == "TUESDAY")
{
    Console.WriteLine("At least it's not Monday");
} else if (day.ToUpper().Trim() == "WEDNESDAY")
{
    Console.WriteLine("You're nearly half way there");
}
else if (day.ToUpper().Trim() == "THURSDAY")
{
    Console.WriteLine("It's Friday tomorrow!");
}
else if (day.ToUpper().Trim() == "FRIDAY")
{
    Console.WriteLine("Oh well, it's not long til the weekend");
}
*/