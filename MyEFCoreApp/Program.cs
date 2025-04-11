using Microsoft.EntityFrameworkCore; // Wichtig für Include, etc.

namespace MyEFCoreApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                context.Database.Migrate();
                var city = new City("Wien");

                // Neue Person anlegen und direkt der Stadt zuweisen
                var person = new Person("Hugo", 109);
                city.AddResidentToCity(person);

                // Objekte hinzufügen
                context.Cities.Add(city);
                context.People.Add(person);

                // Änderungen speichern
                context.SaveChanges();

                // Daten auslesen
                var allPeople = context.People.ToList();
                foreach (var p in allPeople)
                {
                    Console.WriteLine($"ID: {p.ID}, Name: {p.Name}, Age: {p.Age}");
                }
            }
            Console.WriteLine("Fertig. Beliebige Taste zum Beenden drücken...");
            Console.ReadKey();
        }
    }
}
