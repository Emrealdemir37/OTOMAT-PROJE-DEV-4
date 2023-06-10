using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace OTOMAT_PROJE_ÖDEVİ4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


            // Null İçi Boş değere denir                        
            //Array.Resize = Dizi içerisine eleman ekleme 



            String ad = "Emre"; 

            int Sifre = 123;

            string[] ürünler = new string[] { "Çikolata", "Bisküvi", "Su" };
            int[] fiyatlar = new int[] { 5, 4, 3 };

            while (true)
            {
                Console.WriteLine("1-) Admin Girişi İçin (1)\n2-)Müşteri Girişi için (2)");
                string sec = Console.ReadLine();
                Console.Clear();

                while (sec == "1")
                {

                    Console.WriteLine("Kullanıcı Adınızı Giriniz");
                    string KullanıcıAdı = Console.ReadLine();
                    Console.WriteLine("Şifrenizi Giriniz..");
                    int KullanıcıSifre = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    if (KullanıcıAdı == ad && KullanıcıSifre == Sifre)
                    {
                        Console.WriteLine("1-)Ürün Ekleme\n2-)Ürün Silme\n3-)Fiyat Güncelleme");
                        int seç = Convert.ToInt32(Console.ReadLine());
                        if (seç == 1)
                        {
                            Console.WriteLine("Kaç Ürün Ekliyeceğinizi Girin");
                            int ekleme = Convert.ToInt32(Console.ReadLine());

                            Array.Resize(ref ürünler, ürünler.Length + ekleme);

                        

                            for (int i = Array.IndexOf(ürünler, null); i < ürünler.Length; i++)
                            {
                                Console.WriteLine("Yeni Ürün Giriniz:" + i);

                                ürünler[i] = Console.ReadLine();

                            }
                            
                            Console.WriteLine("Yeni Ürünlerin Fiyatlarını Giriniz");
                            Array.Resize(ref fiyatlar, fiyatlar.Length + ekleme);

                          

                            for (int a = Array.IndexOf(fiyatlar, 0); a < fiyatlar.Length; a++)
                            {
                                Console.WriteLine("Yeni Ürünlerin Bir Fiyat Giriniz" + a);
                                fiyatlar[a] = Convert.ToInt32(Console.ReadLine());
                            }

                            Console.WriteLine("Güncel Ürün Ve Fiyat Listesi:");

                            for (int i = 0; i < ürünler.Length; i++)
                            {

                                Console.WriteLine("ÜRÜN ADI : " + ürünler[i] + " ==> " + "ÜRÜN FİYATI:" + fiyatlar[i]);

                            }
                        }
                        if (seç == 2)
                        {
                            Console.WriteLine("ÜRÜN SİLME MENÜSE HOŞ GELDİNİZ");
                            Console.WriteLine("ÜRÜNLERİMİZ");
                            for (int i = 0; i < ürünler.Length; i++)
                            {
                                Console.WriteLine(i + ". Ürünler:" + ürünler[i]);

                            }
                            Console.WriteLine("Silmek İstediğiniz Ürünü Seçiniz");
                            int sil = Convert.ToInt32(Console.ReadLine());

                            //for (int i = 0; i < ürünler.Length; i++) // Burda Ürünler içerisinde sil index içerisie null atamış olduk boş değer
                            //{

                            //    ürünler[sil] = null;
                            //}
                            //foreach (var item in ürünler)
                            //{
                            //    Console.WriteLine(item);
                            //}

                            Array.Clear(ürünler, sil, 0);// ARRAY.CLEAR= İlk başladığı İndex yazılıyor sonraki yazılan uzunluğu kadr sildirmiş oluruz


                            foreach (var item in ürünler)
                            {
                                Console.WriteLine(item);
                            }



                        }
                        if (seç == 3)
                        {
                            Console.WriteLine("FİYAT GÜNCELLEME MENÜSÜ");

                            for (int i = 0; i < ürünler.Length; i++)
                            {
                                Console.WriteLine(i + ".Ürün adı :" + ürünler[i] + "===>" + "Ürün Fiyatı:" + fiyatlar[i]);

                            }
                            Console.WriteLine("Kaç Adet Ürün Fiyatı Güncelliyiceksiniz");
                            int sec1 = Convert.ToInt32(Console.ReadLine());
                            int e = 0;
                            while (e < sec1)
                            {
                                Console.WriteLine(" Fiyatını Güncellemek İstediğiniz Ürünü Seçiniz");
                                int güncelle = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Yeni Fiyatı Giriniz");
                                fiyatlar[güncelle] = Convert.ToInt32(Console.ReadLine());
                                e++;
                            }
                            Console.WriteLine("Güncel Fiyatlar:");
                            for (int i = 0; i < ürünler.Length; i++)
                            {
                                Console.WriteLine(i + ".Ürün adı :" + ürünler[i] + "===>" + "Ürün Fiyatı:" + fiyatlar[i]);

                            }
                        }

                    }
                    else
                    {
                        Console.WriteLine("Hatalı Şifre yada İsim Girişi Yaptınız Ana Menüye Yönlendiriliyorsunuz..");
                        break;
                    }

                }






                while (sec == "2")
                {
                    Console.WriteLine("******HOŞGELDİNİZ*****");
                    Console.WriteLine("1-)Ürünlerimiz İçin (1)'E Basınız\n2-)Satış İçin (2)");
                    string seç = Console.ReadLine();
                    if (seç == "1")
                    {
                        Console.WriteLine("**************ÜRÜNLERİMİZ*********");

                        for (int i = 0; i < ürünler.Length; i++)
                        {
                            //Console.WriteLine("{0}."+ ürünler[i],i+1);

                            Console.WriteLine("{0}." + ürünler[i] + "=" + fiyatlar[i], i + 1);

                        }
                        Console.WriteLine("Para Giriniz");
                        int bakiye = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Almak İstediğiniz Ürünü Seçiniz.");

                        int seç1 = Convert.ToInt32(Console.ReadLine());
                        if (seç1 == 1)
                        {
                            if (fiyatlar[0] <= bakiye)
                            {

                                Console.WriteLine("ürünü alınız");

                                int kalanbakiye = bakiye - fiyatlar[0];
                                Console.WriteLine("Kalan Bakiyeniz:" + kalanbakiye);
                            }
                            else
                                Console.WriteLine("Yetersiz Bakiye İşlem İptal Edildi");

                        }
                        else if (seç1 == 2)
                        {
                            if (fiyatlar[1] <= bakiye)
                            {

                                Console.WriteLine("ürünü alınız");

                                int kalanbakiye = bakiye - fiyatlar[1];
                                Console.WriteLine("Kalan Bakiyeniz:" + kalanbakiye);
                            }
                            else
                                Console.WriteLine("Yetersiz Bakiye İşlem İptal Edildi");
                        }
                        else if (seç1 == 3)
                        {
                            if (fiyatlar[2] <= bakiye)
                            {

                                Console.WriteLine("ürünü alınız");

                                int kalanbakiye = bakiye - fiyatlar[2];
                                Console.WriteLine("Kalan Bakiyeniz:" + kalanbakiye);
                            }
                            else
                                Console.WriteLine("Yetersiz Bakiye İşlem İptal Edildi");
                        }
                        else
                            Console.WriteLine("Geçersiz Ürün Numarası");
                    }
                }


            }
            Console.ReadLine();
        }


    }
}

