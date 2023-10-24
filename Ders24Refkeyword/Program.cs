static int Add(int num1,int num2)
{
    num1 = 30;
    return num1 + num2;
}

int num1 = 20;
int num2 = 100;

var result = Add(num1,num2);
Console.WriteLine(result);
Console.WriteLine(num1);

// Neden num1 30 değil de 20 yazar ? => çünkü değer tipler ile çalışıyoruz 


static int Add2(ref int num1, int num2)
{
    num1 = 30;
    return num1 + num2;
}

int number1 = 20;
int number2 = 100;

var result2 = Add2(ref num1, num2);
Console.WriteLine(result);
Console.WriteLine(num1);

// ben number1 de değişsin istersem ref keywordü kullanırım artık içeride değişikliğie gitti ve 30 oldu

