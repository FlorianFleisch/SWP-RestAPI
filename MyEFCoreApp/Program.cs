using System;
using System.Linq;

namespace MyEFCoreApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Erstellen und Öffnen des DbContext
            using (var context = new AppDbContext())
            {
                // Sicherstellen, dass die Datenbank und alle Tabellen existieren
                context.Database.EnsureCreated();

                // Einen neuen Datensatz erzeugen
                var person = new Person
                {
                    Name = "John Doe",
                    Age = 30
                };

                // Den Datensatz zur Tabelle hinzufügen
                context.People.Add(person);

                // Änderungen speichern (erstellt die Tabelle, falls sie noch nicht existiert)
                context.SaveChanges();

                // Alle Datensätze aus der Tabelle auslesen und in der Konsole anzeigen
                var allPeople = context.People.ToList();
                foreach (var p in allPeople)
                {
                    Console.WriteLine($"ID: {p.Id}, Name: {p.Name}, Age: {p.Age}");
                }
            }

            Console.WriteLine("Fertig. Beliebige Taste zum Beenden drücken...");
            Console.ReadKey();
        }
    }
}
