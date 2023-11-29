Employee employee1 = new Employee("Adam", "Kowalski", 45);
Employee employee2 = new Employee("Bogdan", "Nowak", 35);
Employee employee3 = new Employee("Celina", "Syrska", 25);

employee1.AddScore(4);
employee1.AddScore(5);
employee1.AddScore(6);
employee1.AddScore(5);
employee1.AddScore(6);

employee2.AddScore(9);
employee2.AddScore(6);
employee2.AddScore(4);
employee2.AddScore(4);
employee2.AddScore(4);

employee3.AddScore(2);
employee3.AddScore(4);
employee3.AddScore(4);
employee3.AddScore(4);
employee3.AddScore(4);

List<Employee> employees = new List<Employee>()

{
    employee1, employee2, employee3
};

int maxResult = 0;
Employee bestEmployee = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        bestEmployee = employee;
        maxResult = employee.Result;
    }
}
Console.WriteLine("Best result " + bestEmployee.Result + " points");
Console.WriteLine(bestEmployee.Name + " " + bestEmployee.Surname + " " + bestEmployee.Age + " years");

public class Employee
{
    private List<int> score = new List<int>();
    public void AddScore(int number)
    {
        this.score.Add(number);
    }
    public Employee(string name, string surname, int age)
    {
        this.Name = name;
        this.Surname = surname;
        this.Age = age;

    }

    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }

    public int Result
    {
        get
        {
            return this.score.Sum();
        }
    }


}
