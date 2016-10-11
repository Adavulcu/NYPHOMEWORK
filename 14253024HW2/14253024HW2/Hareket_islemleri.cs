using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14253024HW2
{
    class Hareket_islemleri
    {            
        //Bu classin icerisinde verilen komuta gore gerekli islemleri yapacak methotlar mevcuttur
        public string Saga_don(ref string  aracin_yonu)//saga donme
        {

            if (aracin_yonu == "guney")
                aracin_yonu = "bati";
            else if (aracin_yonu == "bati")
                aracin_yonu = "kuzey";
            else if (aracin_yonu == "kuzey")
                aracin_yonu = "dogu";
            else
                aracin_yonu = "guney";
            return aracin_yonu;
        }
        public string Sola_don(ref string aracin_yonu)//sola donme
        {
            if (aracin_yonu == "guney")
                aracin_yonu = "dogu";
            else if (aracin_yonu == "bati")
                aracin_yonu = "guney";
            else if (aracin_yonu == "kuzey")
                aracin_yonu = "bati";
            else
                aracin_yonu = "kuzey";
            return aracin_yonu;
        }
        //"Hareket_et" methotudunun icerisinde her yon icin ayri bir islem yapilacagindan tum yonler icin ayri ayri donguler olusturup o yonlere göre yapilacak islemleri belirledim
        
        public void Hareket_et(int[,] dizi,string arac_yonu,ref int x,ref int y,ref string firca_yonu,int hareket_miktari,int boyut)//hareket etme methotu
        {
            //her yon icin gerekli olan hareket islemlerinin satir sayisi fazla oldugu icin yeni bir class ve nesne olusturup yapilacak hareketlerin yonune gore switch case yapısı olusturup dogru methotlari ayri ayri cagirdim
            Yonlere_gore_hareket yon = new Yonlere_gore_hareket();
            switch(arac_yonu)
            {
                case "dogu":// dogu tarafina dogru hareket
                    yon.dogu( dizi, ref x,ref  y, firca_yonu, hareket_miktari, boyut);
                                  
                    break;
                case "bati":// bati tarafina dogru hareket
                    yon.bati(dizi, ref x, ref  y, firca_yonu, hareket_miktari, boyut);                                  
                    break;
                case "guney"://guney tarafina dogru hareket
                    yon.guney(dizi, ref x, ref  y, firca_yonu, hareket_miktari, boyut);                                   
                    break;
                case "kuzey":// kuzey tarafina dogru hareket
                    yon.kuzey(dizi, ref x, ref  y, firca_yonu, hareket_miktari, boyut);                 
                    break;
            }
        }
        public void Ziplama(ref int x,ref int y,ref string arac_yonu,int boyut)//burada ziplama islemlerini yone gore belirledim
        {
            switch(arac_yonu)
            {
                case "kuzey":
                    x = x - 3;
                    if (x - 3 <= 0)
                        x = (boyut - 1) - ((boyut - 1) % (3 - x));                  
                    break;
                case "guney":
                    x = x + 3;
                    if (x + 3 >= (boyut - 1))
                        x = 0 + (boyut-1)%(3 + x);
                    break;
                case "bati":
                    y = y - 3;
                    if(y-3<=0)
                        y = (boyut - 1) - ((boyut - 1) % (3 - y));
                    break;               
                case "dogu":
                    y = y + 3;
                    if ((y + 3) >= (boyut - 1))
                        y = 0 + (boyut - 1) % (3 + y);
                    break;
            }
        }
        public void Geri_donme(ref string arac_yonu)//geri donme
        {
            switch(arac_yonu)
            {
                case "kuzey":
                    arac_yonu = "guney";
                    break;
                case "guney":
                    arac_yonu = "kuzey";
                    break;
                case "dogu":
                    arac_yonu = "bati";
                    break;
                case "bati":
                    arac_yonu = "dogu";
                    break;
            }
        }
        public void Yazdirma(int[,] dizi)//"8" komutu girildiginde burada diziti bastan sona okuyarak "1" olan yerileri "*" yaptim
        {
            for (int i = 0; i < dizi.GetLength(0); i++)
            {
                for (int j = 0; j < dizi.GetLength(1); j++)
                {
                    if(dizi[i,j]==1)
                    Console.Write(" *");
                    else
                        Console.Write(" 0");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine();
            System.Threading.Thread.Sleep(1000);
        }
        public string firca_yonu { get; set; }
    }
}
