using PeopleManager.Cyb.Ui.Mvc.Models;

namespace PeopleManager.Cyb.Ui.Mvc.Core
{
    public class Database
    {
        public IList<Person> People { get; set; } = new List<Person>();

        public void Seed()
        {
            People = new List<Person>
            {
                new Person
                {
                    FirstName = "Bavo",
                    LastName = "Ketels",
                    Email = "bavo.ketels@gmail.com"
                },
                new Person{FirstName = "Bavo2", LastName = "Ketels2", Email = "bavo.ketels2@gmail.com"},
                new Person{FirstName = "Bavo3", LastName = "Ketels3", Email = "bavo.ketels3@gmail.com"},
                new Person{FirstName = "Bavo4", LastName = "Ketels4", Email = "bavo.ketels4@gmail.com"}
            };
        }
    }
}
