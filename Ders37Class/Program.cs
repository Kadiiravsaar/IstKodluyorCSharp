CustomerManager customerManager = new CustomerManager();
customerManager.Add();
customerManager.Update();

ProductManager productManager = new ProductManager();
productManager.Add();
productManager.Update();

Customer customer = new Customer();
customer.Id = 1;
customer.City = "Istanbul";
customer.FirstName = "Kadir";
customer.LastName = "Avsar";


Customer customer1 = new Customer
{
    Id=2,City="Istanbul",FirstName="Kadir",LastName="Avsar"
};

Console.WriteLine(customer1.FirstName);
