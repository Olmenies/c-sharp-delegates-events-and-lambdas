/*
    - Calulate amount of cars in collection
    - Calculate amount of cars are Ford
    - Get the most valuable car
    - Calculate the total value of all cars
    - Amount of unique manufacturers
 */

List<ClassicCar> cars = [];
populateData(cars);

// Calculate amount of cars in collection
Console.WriteLine($"Amount of cars in collection: {cars.Count}");

// Calculate amount of cars are Ford
//IEnumerable<ClassicCar> fordCars = cars.Where(car => car.Make == "Ford");
//List<ClassicCar> fordCars = cars.FindAll(e => e.Make == "Ford");
IEnumerable<ClassicCar> fordCars = from car in cars where car.Make == "Ford" select car; // Same with LINQ
Console.WriteLine($"Amount of cars are Ford: {fordCars.Count()}");

// Get the most valuable car
ClassicCar? mostValuableCar = cars.MaxBy(car => car.Value);
Console.WriteLine($"Most valuable car: {mostValuableCar?.Make} {mostValuableCar?.Model} {mostValuableCar?.Year} {mostValuableCar?.Value}");

// Calculate the total value of all cars
int totalValue = cars.Sum(car => car.Value);

// Amount of unique manufacturers
int uniqueManufacturers = cars.Select(car => car.Make).Distinct().Count();



static void populateData(List<ClassicCar> theList)
{
    theList.Add(new ClassicCar("Alfa Romeo", "Spider Veloce", 1965, 15000));
    theList.Add(new ClassicCar("Alfa Romeo", "1750 Berlina", 1970, 20000));
    theList.Add(new ClassicCar("Alfa Romeo", "Giuletta", 1978, 45000));

    theList.Add(new ClassicCar("Ford", "Thunderbird", 1971, 35000));
    theList.Add(new ClassicCar("Ford", "Mustang", 1976, 29800));
    theList.Add(new ClassicCar("Ford", "Corsair", 1970, 17900));
    theList.Add(new ClassicCar("Ford", "LTD", 1969, 12000));

    theList.Add(new ClassicCar("Chevrolet", "Camaro", 1979, 7000));
    theList.Add(new ClassicCar("Chevrolet", "Corvette Stringray", 1966, 21000));
    theList.Add(new ClassicCar("Chevrolet", "Monte Carlo", 1984, 10000));

    theList.Add(new ClassicCar("Mercedes", "300SL Roadster", 1957, 19800));
    theList.Add(new ClassicCar("Mercedes", "SSKL", 1930, 14300));
    theList.Add(new ClassicCar("Mercedes", "130H", 1936, 18400));
    theList.Add(new ClassicCar("Mercedes", "250SL", 1968, 13200));
}

class ClassicCar(string make, string model, int year, int value)
{
    public string Make { get; set; } = make;
    public string Model { get; set; } = model;
    public int Year { get; set; } = year;
    public int Value { get; set; } = value;
}