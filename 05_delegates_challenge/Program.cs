/*
    - Joe's Shipping hast to ship items to different destinations
    - Each Zone has an assosiated shipping fee, which is a percetage of the item's price
    - Some zones are dangerous, so they have to be shipped with extra insurance of U$D 25 
    - Given zone and price, calculate the shipping fee
    - Ask zone and price to the user using the console

    - Zone 1: 25% -> Regular risk
    - Zone 2: 12% -> High risk
    - Zone 3: 8% -> Regular risk
    - Zone 4: 4% -> High risk
 */


Zone[] zones = [
    new(1, 25, false),
    new(2, 12, true),
    new(3, 8, false),
    new(4, 4, true)
];

Zone selectedZone;
ShippingCalculator shippingCalculator = CalculateShipping;

selectedZone = AskUserForZone(zones);
decimal itemPrice = AskUserForPrice();

decimal shippingFee = shippingCalculator(selectedZone, itemPrice);
Console.WriteLine($"The shipping fee for zone {selectedZone.Id} is {shippingFee}");
Console.WriteLine($"Total price: {itemPrice + shippingFee}");



decimal CalculateShipping(Zone zone, decimal price)
{
    decimal shippingFee = price * zone.Fee / 100;
    if (zone.IsRisky)
    {
        shippingFee += 25;
    }
    return shippingFee;
}

Zone AskUserForZone(Zone[] zones)
{
    Console.WriteLine("Please select a zone:");
    Console.WriteLine("1. Zone 1");
    Console.WriteLine("2. Zone 2");
    Console.WriteLine("3. Zone 3");
    Console.WriteLine("4. Zone 4");
    Console.Write("Enter the number of the zone: ");
    string input = Console.ReadLine();
    if (int.TryParse(input, out int inputNumber))
    {
        if (inputNumber >= 1 && inputNumber < zones.Length)
        {
            return zones[inputNumber - 1];
        }
    }
    return null;
}

decimal AskUserForPrice()
{
    Console.Write("Enter the price of the item: ");
    string input = Console.ReadLine();
    if (decimal.TryParse(input, out decimal price))
    {
        return price;
    }
    return 0;
}

class Zone(int id, int fee, bool isRisky)
{
    public int Id { get; } = id;
    public int Fee { get; } = fee;
    public bool IsRisky { get; } = isRisky;
}

delegate decimal ShippingCalculator(Zone zone, decimal price);