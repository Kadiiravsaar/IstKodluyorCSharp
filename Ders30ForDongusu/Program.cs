for (int i =1000; i >=0; i = i-2)
{
    Console.WriteLine(i);
}
Console.WriteLine("Finished");


#region Ders31 While

int number = 100;
while (number>=0)
{
    Console.WriteLine(number); // şuan sürekli döner bu yüzden number'ı küçültmek gerek
    number--;
}

#endregion


#region Ders 32 do While

int num1 = 10;
do
{
    Console.WriteLine(num1);
    num1--;
} while (num1>=11);


#endregion



#region Ders 33 Foreach

string[] students = new string[] { "Kadir", "Engin" };

foreach (var student in students)
{
    Console.WriteLine(student);
}


#endregion