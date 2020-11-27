namespace TechReturners {

    public class Person {

        public Person(string firstname, string surname, string city, int age) {
            Firstname = firstname;
            Surname = surname;
            City = city;
            Age = age;
        }

        public string Firstname 
        { get; set; }

        public string Surname
        { get; set; }

        public string City
        { get; set; }

        public int Age
        { get; set; }
    }
}

