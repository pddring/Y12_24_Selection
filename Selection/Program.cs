Console.Write("What day is it?");
string day = Console.ReadLine();

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
