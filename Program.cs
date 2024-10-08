// See https://aka.ms/new-console-template for more information
//string ,int ,float,double,bool;



using System.ComponentModel;

string isim1; string cep1; string ogrno1;string not1;

string isim2; string cep2; string ogrno2;string not2;

Console.WriteLine("Ad soyadınızı giriniz.");
isim1 = Console.ReadLine();
Console.WriteLine("Öğrenci numaranızı giriniz.");
ogrno1 = Console.ReadLine();
Console.WriteLine("Cep telefon numaranızı giriniz.");
cep1 = Console.ReadLine();

Console.WriteLine("Ad soyadınızı giriniz.");
isim2 = Console.ReadLine();
Console.WriteLine("Öğrenci numaranızı giriniz.");
ogrno2 = Console.ReadLine();
Console.WriteLine("Cep telefon numaranızı giriniz.");
cep2 = Console.ReadLine();


Console.WriteLine("Birinci Kişinin bilgileri");
Console.WriteLine($"İsmi             :{isim1}");
Console.WriteLine($"Telefon numarası :{cep1}");
Console.WriteLine("Öğrenci numarası  :"+ogrno1);

Console.WriteLine("İkinci Kişinin bilgileri");
Console.WriteLine($"İsmi             : {isim2}");
Console.WriteLine("Telefon numarası  :"+cep2);
Console.WriteLine("Öğrenci numarası  :"+ogrno2);