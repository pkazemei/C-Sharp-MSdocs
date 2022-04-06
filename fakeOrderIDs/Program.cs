string[] fakeOrderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
Console.WriteLine("Here is a list of fraudulent ID's that start with B: ");

foreach (string orderID in fakeOrderIDs)
{
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine(orderID);
    }
}