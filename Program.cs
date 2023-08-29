using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Toplama için:+");
            Console.WriteLine("Çıkarma için:-");
            Console.WriteLine("Bölme için:/");
            Console.WriteLine("Çarpma için:*");

            Console.Write("Sembol Giriniz:");
            var Secilen_isaret=Console.ReadLine();
            Console.Write("İlk sayıyı giriniz:");
            var Alınan_1Sayı =Convert.ToInt32(Console.ReadLine());
            Console.Write("ikinci sayıyı giriniz:");
            var Alınan_2Sayı =Convert.ToInt32(Console.ReadLine());
           

           if(Secilen_isaret=="+"){
            var sonuc=Alınan_1Sayı+Alınan_2Sayı;
            Console.WriteLine(sonuc);
           }else if(Secilen_isaret=="-"){
            var sonuc=Alınan_1Sayı-Alınan_2Sayı;
            Console.WriteLine(sonuc);
           }else if(Secilen_isaret=="/"){
            var sonuc=Alınan_1Sayı/Alınan_2Sayı;
            Console.WriteLine(sonuc);
           }else if(Secilen_isaret=="*"){
            var sonuc=Alınan_1Sayı*Alınan_2Sayı;
            Console.WriteLine(sonuc);
           }



           Console.WriteLine("1.Yazılı Notunuzu Giriniz.");
           var yazılıNotu1=Convert.ToInt16(Console.ReadLine()) ;  
           Console.WriteLine("2.Yazılı Notunuzu Giriniz.");
           var yazılıNotu2=Convert.ToInt16(Console.ReadLine()) ; 
           Console.WriteLine("Sözlü Notunuzu Giriniz.");
           var sozluNotu=Convert.ToInt16(Console.ReadLine()) ;

            var ortalama=(yazılıNotu1+yazılıNotu2+sozluNotu)/3;
            int not=-1;
            bool ok =true;

            if(ortalama>0 && ortalama<=24){
                not=0;
            }else if(ortalama>=25 && ortalama<=44){
                not=1;
            }else if(ortalama>=45 && ortalama<=54){
                not=2;
            }else if(ortalama>=55 && ortalama<=69){
                not=3;
            }else if(ortalama>=70 && ortalama<=84){
                not=4;
            }else if(ortalama>=85 && ortalama<=100){
                not=5;
            }else {
                 ok =false;
                Console.WriteLine("Yanlış Sayı Girdiniz.");
                
            }

            if(ok){
                Console.WriteLine($"Ortalmanız {ortalama} ve Notunuz {not}");
            }
            



            Console.WriteLine("1.Sayıyı Giriniz:");
            int sayı1=Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("2.Sayıyı Giriniz:");
            int sayı2=Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("3.Sayıyı Giriniz:");
            int sayı3=Convert.ToInt16(Console.ReadLine());
            int enbuyuk=0;  

            if(sayı1>sayı2 && sayı1>sayı3){
                enbuyuk=sayı1;
            }else if(sayı2>sayı3){
                enbuyuk=sayı2;
            }else{
                enbuyuk=sayı3;
            }
            Console.WriteLine($" En büyük sayı:{enbuyuk} ");

           
            
















        }
    }
}
