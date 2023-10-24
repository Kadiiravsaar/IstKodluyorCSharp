PrimeNumber primeNumber = new PrimeNumber();

if (primeNumber.IsPrimeNumber(6))
{
    Console.WriteLine("This is a prime number");
}
else
{
    Console.WriteLine("This is a not prime number");
}


// *************************************** böyle de olur ***********////////////////////
//if (IsPrimeNumber(6))
//{
//    Console.WriteLine("This is a prime number");
//}
//else
//{
//    Console.WriteLine("This is a not prime number");
//}


//static bool IsPrimeNumber(int number)
//{
//    bool result = true;
//    for (int i = 2; i < number; i++)
//    {
//        if (number % i == 0)
//        {
//            result = false;
//            break;
//        }
//    }
//    return result;
//}


class PrimeNumber
{
    public bool IsPrimeNumber(int number)
    {
        bool result = true;
        for (int i = 2; i < number; i++)
        {
            if (number%i==0)
            {
                result = false; 
                break;
            }
        }
        return result;
    }

}

