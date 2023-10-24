string city = "Ankara";
foreach (var item in city)
{
    Console.WriteLine(item);
}
string city2 = "Istanbul";
string result = city + city2;
Console.WriteLine(result);
Console.WriteLine(String.Format("{0} {1}", city, city2));


// ***************************************** //*****************************


#region Ders 36 String metodlarıyla çalışmak

string sentence = "My name is Kadir Avsar";
var result2 = sentence.Length;

var result3 = sentence.Clone(); // bir referansını daha oluşturmaya yarar

var result4 = sentence.EndsWith("G"); // cümle sonucu bool döner

var result5 = sentence.StartsWith("G"); // cümle sonucu bool döner

var result6 = sentence.IndexOf("namee"); // kaçıncı sırada başlar eğer bulamazsa -1 döner

var result7 = sentence.IndexOf(" "); 

var result8 = sentence.LastIndexOf("G"); // aramaya sondan başlar

var result9 = sentence.Insert(0,"G"); //bir ifadeye başka bir metin yerleştirir - 0. karakterden itibaren bunu ekle

var result10 = sentence.Substring(3); // metni parçalamak için kullanılır. 3. karakterden itibaren al

var result11 = sentence.ToLower(); // bütün karakterleri küçüğe çevirir

var result12 = sentence.ToUpper(); // bütün karakterleri büyüğe çevirir

var result13 = sentence.Replace("","-"); // ilk verilenleri ikinci verilene değiştirir

var result14 = sentence.Remove(2); // belli karakterden sonrasını siler





Console.WriteLine(result2);






#endregion