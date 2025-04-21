

public class Patient
{
    public string Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime ImplantDate { get; set; }
    public string ImplantType { get; set; }

    public override string ToString()
    {
        return $"ID: {Id}, Name: {FirstName} {LastName}, Implant: {ImplantType}, Date: {ImplantDate.ToShortDateString()}";
    }
}
