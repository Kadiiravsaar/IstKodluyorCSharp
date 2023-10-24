static void Add()
{
    Console.WriteLine("Added!!");
}
Add();

// ********************************************************//

#region Ders 22 (parametreli)

static int Add2(int num1, int num2)
{
    var result = num1 + num2;
    return result;
}
Console.WriteLine(Add2(12, 13));
// ya da 

var result = Add2(12, 13);
Console.WriteLine(result);

#endregion

// ********************************************************//

#region Ders 23 (Default parametre)

// default değerler son metotda olmalı
static int Add3(int num1, int num2=30)
{
    var result = num1 + num2;
    return result;
}
Console.WriteLine(Add3(12, 13));
// ya da 

var result2 = Add3(12);
Console.WriteLine(result2);

#endregion