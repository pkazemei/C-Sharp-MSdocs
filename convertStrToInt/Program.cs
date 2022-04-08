string[] values = { "12.3", "45", "ABC", "11", "DEF" };
string message = "";
decimal result = 0;

foreach (var value in values)
{
    decimal num;
    if (decimal.TryParse(value, out num))
    {
        result += num;
    }
    else
    {
        message += value;
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {result}");