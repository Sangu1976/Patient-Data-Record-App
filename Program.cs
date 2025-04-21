using System;
using System.Collections.Generic;

class Program
{
    static List<Patient> patients = new List<Patient>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- Patient Record System ---");
            Console.WriteLine("1. Add Patient");
            Console.WriteLine("2. List Patients");
            Console.WriteLine("3. Search by ID");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");

            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    AddPatient();
                    break;
                case "2":
                    ListPatients();
                    break;
                case "3":
                    SearchById();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    static void AddPatient()
    {
        Console.Write("Enter ID: ");
        string id = Console.ReadLine();
        Console.Write("First Name: ");
        string first = Console.ReadLine();
        Console.Write("Last Name: ");
        string last = Console.ReadLine();
        Console.Write("Implant Type: ");
        string implant = Console.ReadLine();
        Console.Write("Implant Date (yyyy-mm-dd): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        patients.Add(new Patient
        {
            Id = id,
            FirstName = first,
            LastName = last,
            ImplantType = implant,
            ImplantDate = date
        });

        Console.WriteLine("✅ Patient added!");
    }

    static void ListPatients()
    {
        if (patients.Count == 0)
        {
            Console.WriteLine("No patients found.");
            return;
        }

        foreach (var p in patients)
        {
            Console.WriteLine(p);
        }
    }

    static void SearchById()
    {
        Console.Write("Enter ID to search: ");
        string id = Console.ReadLine();

        var patient = patients.Find(p => p.Id == id);
        if (patient != null)
        {
            Console.WriteLine("🔎 Found: " + patient);
        }
        else
        {
            Console.WriteLine("❌ No patient found with that ID.");
        }
    }
}
