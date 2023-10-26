﻿PersonManager personManager = new PersonManager();
//personManager.Add(new Customer() 
//{ Id = 1,
//    FirstName = "Kadir", 
//    LastName = "Avsar", 
//    Adress = "Gop" 
//});

Customer customer = new Customer()
{
    Id = 1,
    FirstName = "Engin",
    LastName = "Demirog",
    Adress = "Ankara"

};
Student student  = new Student()
{
    Id = 1,
    FirstName = "Kadir",
    LastName = "Avşar",
    Departmant = "It"

};
personManager.Add(customer);
personManager.Add(student);
personManager.Add(new Worker());

interface IPerson
{
    int Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }

}
class Customer:IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Adress { get; set; }
}
class Student:IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Departmant { get; set; }

}

class Worker : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Departmant { get; set; }

}



class PersonManager
{
    public void Add(IPerson person)
    {
        Console.WriteLine(person.FirstName);
    }
}