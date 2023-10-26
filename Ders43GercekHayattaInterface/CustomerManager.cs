namespace Ders43GercekHayattaInterface
{
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
            customerDal.Update();
            customerDal.Delete();
        }
    }
}
