using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Uygulama_9
    {
        static void Main(string[] args)
        {
            string soru , userneam;
            int password, sayac1 = 0, sayac2 = 0;
            int giris1, sayac = 1;

            do
            {
                Console.WriteLine("*******************************************************************************************************");
                Console.WriteLine("Hoş Geldiniz Hangi Soru İstiyorsunuz Seçeniz ^_^ ");
                Console.WriteLine("*******************************************************************************************************");

                Console.WriteLine("(0).Çıkış.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                Console.WriteLine("(1).Kullanıcının sınırlı denemelerle \"ahmet\" kullanıcı adını girmesi gereken bir kod parçasıdır.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                Console.WriteLine("(2).Kullanıcının sınırlı denemelerle belirli bir şifreyi doğru girmeye çalıştığı bir yapıdır.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                Console.WriteLine("(3).Kullanıcının sınırlı denemelerle rastgele belirlenen bir sayıyı doğru tahmin etmeye çalıştığı kod parçası.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                Console.Write("Sorunuz Numarası Giriniz : ");
                soru = Console.ReadLine();
                Console.Clear();


                //****************************************************************************************************//

                if (soru == "1")
                {
                    do
                    {
                        if (sayac1 < 3)
                        {
                            Console.Write("Adınız Giriniz : ");
                            userneam = Console.ReadLine();
                            sayac1++;
                            if (userneam != "ahmet")
                            {
                                Console.WriteLine("Yanliş Giriş Yaptınız!!");
                                Console.WriteLine("Ana Menu Donmek İçin (0) Giriniz.");
                            }
                        }
                        else
                        {
                            break;
                        }
                    } while (userneam != "ahmet" && userneam != "0");
                      Console.WriteLine("Doğru Giriş Yaptınız :)");                          
                }



                //***********************************************************************//

                else if (soru == "2")
                {
                    do
                    {
                        if (sayac2 < 3)
                        {
                            Console.Write("şifriniz Giriniz:");
                            password = int.Parse(Console.ReadLine());
                            sayac2++;
                            if (password != 123456)
                            {
                                Console.WriteLine("Yanliş Şifriniz Giridiniz!!");
                                Console.WriteLine("Ana Menu Donmek İçin (0) Giriniz.");
                            }
                        }
                        else
                        {
                            break;
                        }
                    } while (password != 123456 && password != 0);
                    Console.WriteLine("Doğru Giriş Yaptınız :)");
                }



                //***********************************************************************//

                else if (soru == "3")
                {
                    Random restgelsayi = new Random();
                    int giris = restgelsayi.Next(0, 100);
                    do
                    {
                        Console.Write("Sayının Giriniz : ");
                        giris1 = int.Parse(Console.ReadLine());
                        if (giris1 < giris)
                        {
                            Console.WriteLine("Girdiniz Sayı Daha Büyük Olması");
                        }
                        else if (giris1 > giris)
                        {
                            Console.WriteLine("Girdiniz Sayı Daha Küçük Olması");
                        }
                        else
                        {
                            Console.WriteLine("Giridiniz Sayı Doğru Sayı Buldunuz Tebrikler :)");
                            break;
                        }
                        sayac++;
                    } while (giris1 != giris && sayac <= 10);
                }
                //***********************************************************************//


            } while (soru != "0");
            Console.WriteLine("Programdan Çıkılıyor...");
            Console.ReadKey();
        }
    }
}
