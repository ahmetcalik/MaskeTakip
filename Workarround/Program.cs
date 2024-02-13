using Business.Concrete;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
        //Degiskenler();
        //Vatandas vatandas1 = new Vatandas();

        //SelamVer(isim: "Ahmet");
        //SelamVer(isim: "Selçuk");
        //SelamVer(isim: "Engin");
        //SelamVer();

        //int sonuc = Topla(3, 5);

        //string ogreci1 = "Ali";
        //string ogreci2 = "Ahmet";
        //string ogreci3 = "Mehmet";

        //Console.WriteLine(ogreci1);
        //Console.WriteLine(ogreci2);
        //Console.WriteLine(ogreci3);

        //string[] ogrenciler = new string[3];

        //ogrenciler[0] = "Elif";
        //ogrenciler[1] = "Ayşe";
        //ogrenciler[2] = "Fatma";

        //ogrenciler = new string[4];

        //ogrenciler[3] = "Gamze";

        //for (int i = 0; i < ogrenciler.Length; i++)
        //{
        //    Console.WriteLine(ogrenciler[i]);
        //}

        //string[] sehirler1 = new string[] { "Ankara 1", "İstanbul 2", "İzmir 3" };
        //string[] sehirler2 = new string[] { "Bursa", "Antalya", "Diyarbakır" };

        //sehirler2 = sehirler1;
        //sehirler1[0] = "Erzurum";
        //Console.WriteLine(sehirler2[0]);

        Person person1 = new Person();
        person1.FirstName = "Ahmet";
        person1.LastName = "Çalık";
        person1.DateOfBirthYear = 1996;
        person1.NationalIdentity = 123;

        //Person person2 = new Person();
        //person2.FirstName = "Mehmet";

        //List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 2", "İzmir 3" };
        //yeniSehirler1.Add("Gümüshane");

        //foreach (var sehir in yeniSehirler1)
        //{
        //    Console.WriteLine(sehir);
        //}

        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person1);

        Console.ReadLine();
    }

    //static void SelamVer(string isim="isimsiz")
    //{
    //    Console.WriteLine("Merhaba" + " " + isim);
    //}

    //static int Topla(int sayi1 = 5, int sayi2 = 10) 
    //{
    //    int sonuc = sayi1 + sayi2;
    //    Console.WriteLine("Toplam: " + sonuc.ToString());
    //    return sonuc;
    //}


    //private static void Degiskenler()
    //{
    //    string message = "Hi there!";
    //    double amount = 100000.0;
    //    int number = 0;
    //    bool isAuthenticated = false;

    //    string ad = "Ahmet";
    //    string soyad = "Çalık";
    //    int dogumYili = 1996;
    //    long tcNo = 1234567890;


    //    Console.WriteLine(amount * 1.18);
    //    Console.WriteLine(message);
    //}

    //public class Vatandas
    //{
    //    public string Ad { get; set; }
    //    public string Soyad { get; set; }
    //    public int DogumYili { get; set; }
    //    public long TcNo { get; set; }
    //}
}