//static int Multiply(int num1, int num2) // (int num1,int num2) metodun imzasızıdr
//{
//    return num1 * num2;
//}

//static int Multiply(int num1, int num2, int num3)
//{
//    return num1 * num2 * num3;
//}

//Console.WriteLine(Multiply(2, 4));
//Console.WriteLine(Multiply(2, 4, 7));


#region Metot overload
Overload overload = new Overload();
Console.WriteLine(overload.AddNumbers(10, 20));



#endregion



#region Params
Console.WriteLine(ParamsOver.Add(120, 30, 45));

#endregion


// params parametrenin son parametresi olmak zorundadır

public class Overload
{
    public int AddNumbers(int num1, int num2)
    {
        return num1 + num2;
    }

    public double AddNumbers(int num1, int num2, int num3)
    {
        return num1 + num2 + num3;
    }
}


#region Ders 27 params




public class ParamsOver
{
    public static int Add(params int[] numbers)
    {
        return numbers.Sum();
    }

    
}

#endregion