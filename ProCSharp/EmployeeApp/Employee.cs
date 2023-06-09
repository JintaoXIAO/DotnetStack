namespace EmployeeApp;
public class Employee
{
    public int ID { get; set; }
    
    public float Pay { get; set; }
    
    public int Age { get; set; }
    
    public string Name { get; set; }
    
    public string SocialSecurityNumber { get; }
    
    public EmployeePayTypeEnum PayType { get; set; }
    
    public Employee() {}

    public Employee(string name, int id, float pay, int age, string ssn, EmployeePayTypeEnum payType)
    {
        Name = name;
        ID = id;
        Pay = pay;
        Age = age;
        SocialSecurityNumber = ssn;
        PayType = payType;
    }

    public void GiveBonus(float amount)
    {
        Pay = this switch
        {
            { Age: >= 18, PayType: EmployeePayTypeEnum.Commision } => Pay += .10F * amount,
            { PayType: EmployeePayTypeEnum.Hourly } => Pay += 40F * amount / 2080F,
            { PayType: EmployeePayTypeEnum.Salaried } => Pay += amount,
            _ => Pay
        };
    }

    public void DisplayStatus()
    {
        Console.WriteLine("Name: {0}", Name);
        Console.WriteLine("ID: {0}", ID);
        Console.WriteLine("Pay: {0}", Pay);
    }
}
