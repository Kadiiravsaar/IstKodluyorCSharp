namespace Ders43GercekHayattaInterface
{
    public class OracleeCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");

        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted");

        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated");

        }
    }
}
