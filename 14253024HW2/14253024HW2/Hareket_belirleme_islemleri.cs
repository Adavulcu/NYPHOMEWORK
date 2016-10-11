using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14253024HW2
{
    class Hareket_belirleme_islemleri
    {
       //"Hareket_sec" methotun da "split" komutuyla ayirdigim tek tek ayiridigim komutlaru "komut" dizisine aktardım ve for dongusu icerisinne "switch case" yapısı kurarak okuna degere göre hangi islemleri yapilacagi yada "Hareket_islemleri "clasından hangi methotlarin cagirilacagini belirledim
        public void Hareket_sec(string[] komut,int[,] dizi,ref string yon,ref int x, ref int y,ref string firca_yonu,int boyut)
        {
            Hareket_islemleri Hareket = new Hareket_islemleri();         
            int hareket_miktari=0;
            for (int i = 1; i <komut.Length; i++)
            {
                if (komut[i] == "0")//burada eger okuna deger "0" olursa program sonlanacaktir
                    break;
                if (komut[i] == "5")
                {                
                   hareket_miktari = Int32.Parse(komut[i + 1]);
                    //burada okunan deger "5" oldugunda ve bu hareket ettirme komutu oldugu icin bundan hemen sonraki indis degeri ne kadar hareket edilecegini belirleycegi icin (i+1) indisini integere cevirip "hareket_miktari" degiskenine atadim
                }             
                switch (komut[i])
                {
                    case "1": //firca asagi  
                        firca_yonu = "asagi";
                        break;
                    case "2"://firca yukari
                        firca_yonu = "yukari";
                        break;
                    case "3"://saga don komutu
                        yon = Hareket.Saga_don(ref yon);
                        break;
                    case "4"://sola don komutu
                        yon = Hareket.Sola_don(ref yon);
                        break;
                    case "5"://hareket komutu
                        Hareket.Hareket_et(dizi, yon, ref x, ref y, ref firca_yonu,hareket_miktari,boyut);
                        i = i + 1;
                    //burada for un icindeki indis artirma haricinde indis artirmamim sebebi ornegin 5_5 komutunda ikinci "5" i gorgunde bunuda hareket komutu zannedecek ve o "5" ten sonra gelecek herhangi bir degeri hareket miktari zannedecektir. mesela "5_5+6" burda islem yaparken ilk "5" i gorecek ve 5 adim  hareket edecektir, hemen ardindan yeni indis yine "5" e geldigi icin 6 adim daha hareket edecektir. bunu omlemek icin indis degerini buradan 1 artirdigimda ikinci "5" i gormeden direk "6" yı okuyarak isleme devam edecektir
                        break;
                    case "6"://zipla komutu
                        Hareket.Ziplama(ref x, ref y,ref yon,boyut);
                        firca_yonu = "yukari";
                        break;
                    case "7"://geri don
                        Hareket.Geri_donme(ref yon);
                        break;
                    case "8"://diziyi görüntüle
                        Hareket.Yazdirma(dizi);
                        break;
                   
                }
            }
        }
    }
}
