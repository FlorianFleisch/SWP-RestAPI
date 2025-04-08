namespace MyEFCoreApp
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }

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
