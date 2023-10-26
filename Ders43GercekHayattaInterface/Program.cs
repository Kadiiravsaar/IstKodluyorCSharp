using Ders43GercekHayattaInterface;

CustomerManager customerManager = new CustomerManager();
customerManager.Add(new SqlServerCustomerDal());
customerManager.Add(new OracleeCustomerDal());

// ders 44 
Console.WriteLine("********");
ICustomerDal[] customerDals = new ICustomerDal[3]
{
    new SqlServerCustomerDal(),
    new OracleeCustomerDal(),
    new MySqlServerCustomerDal()

};
foreach (var customerDal in customerDals)
{
    customerDal.Add();
}