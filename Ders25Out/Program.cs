static int Add(int num1, int num2)
{
    num1 = 30;
    return num1 + num2;
}

int num1 = 20;
int num2 = 100;

var result = Add(num1, num2);
Console.WriteLine(result);
Console.WriteLine(num1);

// mantık olarak aynıdır
// farkı ref de number1e set etmek gerek değer olması gerek fakat out da böyle bir gerek yok (satır 23)

static int Add2(out int num1, int num2)
{
    num1 = 30;
    return num1 + num2;
}

int number1;
int number2 = 100;

var result2 = Add2(out num1, num2);
Console.WriteLine(result);
Console.WriteLine(num1);


