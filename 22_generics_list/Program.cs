
List<Employee> employees = new List<Employee>
{
    new("Leo Mattioli", 1000),
    new("Hernán MalaFama", 1500),
    new("Hernán Champions", 2000),
    new("Lali Espósito", 2500),
};
Console.WriteLine("------  ------");

employees.Add(new Employee("Gordo Luis", 1500));

foreach (var employee in employees)
{
    Console.WriteLine($"Name: {employee.Name}, Salary: {employee.Salary}");
}

Console.WriteLine("------  ------");

Console.WriteLine($"Does Lali exists? {employees.Exists(e => e.Name == "Lali Espósito")}");
employees.Remove(new Employee("Lali Espósito", 2500));
Console.WriteLine("Lali was eliminated");

Console.WriteLine("------  ------");

Employee? bestEmployee = employees.Find(e => e.Name == "Leo Mattioli");

foreach (var employee in employees)
{
    Console.WriteLine($"Name: {employee.Name}, Salary: {employee.Salary}");
}

Console.WriteLine("------ Adding 1000 ------");

employees.ForEach(e => e.Salary += 1000);
employees.ForEach(e => Console.WriteLine($"Name: {e.Name}, Salary: {e.Salary}"));

Console.WriteLine("------  ------");
int totalSalary = employees.Sum(e => e.Salary);
Console.WriteLine($"Total salary (after adding 1000 to each): {totalSalary}");

class Employee(string name, int salary)
{
    public string Name { get; set; } = name;
    public int Salary { get; set; } = salary;

}