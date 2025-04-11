namespace MyEFCoreApp
{
    public class City
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string? PLZ { get; set; }

        // Navigation Property: Eine Stadt hat eine Liste von Bewohnern (Personen)
        public List<Person> Residents { get; set; } = new List<Person>();
        public City(string name)
        {
            Name = name;
        }

        public void AddResidentToCity(Person person)
        {
            Residents.Add(person);
        }
    }
}
