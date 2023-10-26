using Ders46Kalitim;

Person[] persons = new Person[3]
{
    new Customer{FirstName="Kadir"}, new Person{FirstName = "Kadirr"}, new Student{FirstName = "Kadirrr"}
};

foreach (var person in persons)
{
    Console.WriteLine(person.FirstName);
}