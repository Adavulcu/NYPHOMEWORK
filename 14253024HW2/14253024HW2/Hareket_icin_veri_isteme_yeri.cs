using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14253024HW2
{
    class Hareket_icin_veri_isteme_yeri
    {
        //Temel_islemler clasinin icinde gerek komutları istedim.
        //ayrıca aracın yonunu, fırcanın durumunu ve araacanın konumunu tutacak x ve y degiskenlerini referans olarak gönderdim ki
        //bu degiskenler uzerinde degisklik yatigimda ve bu degiskenleri farklı bir class icinde kullanacagım zaman yeniden cagirma 
        //ihtiyaci duymadan aynı icerigi kullanabileyim.
        //Bunun yaninda aracin ilk yonunu,fircanin ilk durmununu ve aracin ilk konmunu Temel_islemlr clasi icinde belirledim.
     
       
        public void Temel_islemler()
        {
            string aracin_yonu = "dogu";
            string firca_yonu = "yukari";
            int x = 0;//x sutunlar
            int y = 0;//y satırlar
            Hareket_belirleme_islemleri Hareket = new Hareket_belirleme_islemleri();//yapilicak islemler icin olusturdugum nesne
            char[] ayirma = { '+', '_' };//ilk girilen komutları "split" komutuyla ayirmak icin char dizi olusturum icerigini direk verdim
            Console.WriteLine("komutlari giriniz");
            string tum_komutlar = Console.ReadLine();
            string[] Yapilacak_hareket_komutu = tum_komutlar.Split(ayirma);
            int dizi_boyutu = Int32.Parse(Yapilacak_hareket_komutu[0]);//girilen ilk deger dizi boyutu olacagi icin dizinin ilk indisi integer e cevirip dizi boyutu olarak belirledim
            int[,] boyut = new int[dizi_boyutu, dizi_boyutu];
           
                             
            Hareket.Hareket_sec(Yapilacak_hareket_komutu, boyut, ref aracin_yonu, ref x, ref y, ref firca_yonu,dizi_boyutu);
            
           
          
        }
    }
}
