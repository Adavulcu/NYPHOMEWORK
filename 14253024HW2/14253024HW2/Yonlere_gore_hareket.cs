using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14253024HW2
{
    class Yonlere_gore_hareket
    {
        public void dogu(int[,] dizi,ref int x,ref int y,string firca_yonu,int hareket_miktari,int boyut)
        {
            for (int i = x; i <= x; i++)
            {
                for (int j = y; j < y + (hareket_miktari + 1); j++)
                {
                    if (j == boyut)//burada indis sona geldigin icin aracin diger tarafinde cikmasi gerektiginden yeni dongu kurdum ve kosulu(j==boyut) yapmamin sebebi eger "boyut-1" a esitleseydim(yani son indise) direk ikinci donguye girecek ve diger tarafa gecektir. Ve bu ikinci dongunun sonunda "break oldugu icin dıs dongude sonlancak ve "boyut-1" indisini "1" yapacak komutu gormeyecegi icin "boyut-1" indisi icin islem yapmayacaktir
                    {
                        if (hareket_miktari >= (boyut))//eger hareket miktari boyuta esit veya fazlaysa butun stunları "1" yapıyorum
                        {
                            for (int k = x; k <= x; k++)
                            {
                                for (int l = 0; l < dizi.GetLength(1); l++)
                                {
                                    if (firca_yonu == "asagi")
                                        dizi[k, l] = 1;
                                }
                            }
                            break;
                        }
                        for (int k = x; k <= x; k++)//hareket miktari boyuttan buyuk olmadıgı halde dizide tasma oluyorsa bu donguyu kullanıyorum
                        {
                            for (int l = 0; l < (y + hareket_miktari) % (boyut - 1); l++)
                            {
                                if (firca_yonu == "asagi")
                                    dizi[k, l] = 1;
                            }
                        }
                        break;
                    }
                    if (firca_yonu == "asagi")
                        dizi[i, j] = 1;
                }
            }
            //Asagida aracin son yerini tespit etmek icin if ve else yapisi kullandim sebebiyse eger arac boyutun sinirlerini asarsa son geldigi noktalar farkli olacaktir. Bu durmua göre 2 ayri islem yaptirdim
            if ((y + hareket_miktari) > (boyut - 1))
                y = ((y + hareket_miktari) % (boyut));
            else
                y = y + (hareket_miktari);
                   
        }
        public void bati(int[,] dizi, ref int x, ref int y, string firca_yonu, int hareket_miktari, int boyut)
        {
            for (int i = x; i <= x; i++)
            {
                for (int j = y; j > y - (hareket_miktari + 1); j--)
                {
                    //burada indis sona geldigin icin aracin diger tarafinde cikmasi gerektiginden yeni dongu kurdum ve kosulu(j==-1) yapmamin sebebi eger "0" a esitleseydim direk ikinci donguye girecek ve diger tarafa gecektir. Ve bu ikinci dongunun sonunda "break oldugu icin dıs dongude sonlancak ve "0" indisini "1" yapacak komutu gormeyecegi icin "0" indisi icin islem yapmayacaktir
                    if (j == -1)
                    {
                        if (hareket_miktari >= (boyut))//eger hareket miktari boyuta esit veya fazlaysa butun stunları "1" yapıyorum
                        {
                            for (int k = x; k <= x; k++)
                            {
                                for (int l = 0; l < dizi.GetLength(1); l++)
                                {
                                    if (firca_yonu == "asagi")
                                        dizi[k, l] = 1;
                                }
                            }
                            break;
                        }
                        for (int k = x; k <= x; k++)//hareket miktari boyuttan buyuk olmadıgı halde dizide tasma oluyorsa bu donguyu kullanıyorum
                        {
                            for (int l = (boyut - 1); l > ((boyut - 1) - (hareket_miktari - y) % (boyut - 1)); l--)
                            {
                                if (firca_yonu == "asagi")
                                    dizi[k, l] = 1;
                            }
                        }

                        break;
                    }
                    if (firca_yonu == "asagi")
                        dizi[i, j] = 1;
                }
            }
            //Asagida aracin son yerini tespit etmek icin if ve else yapisi kullandim sebebiyse eger arac boyutun sinirlerini asarsa son geldigi noktalar farkli olacaktir. Bu durmua göre 2 ayri islem yaptirdim
            if ((y - hareket_miktari) <= 0)
                y = (boyut) - ((hareket_miktari - y) % (boyut - 1));
            else
                y = y - (hareket_miktari);
                   
        }
        public void guney(int[,] dizi, ref int x, ref int y, string firca_yonu, int hareket_miktari, int boyut)
        {
            for (int i = x; i < x + (hareket_miktari + 1); i++)
            {
                if (i == (boyut))//burada indis sona geldigin icin aracin diger tarafinde cikmasi gerektiginden yeni dongu kurdum ve kosulu(j==boyut) yapmamin sebebi eger "boyut-1" a esitleseydim(yani son indise) direk ikinci donguye girecek ve diger tarafa gecektir. Ve bu ikinci dongunun sonunda "break oldugu icin dıs dongude sonlancak ve "boyut-1" indisini "1" yapacak komutu gormeyecegi icin "boyut-1" indisi icin islem yapmayacaktir
                {
                    if (hareket_miktari >= (boyut))//eger hareket miktari boyuta esit veya fazlaysa butun satirlari "1" yapıyorum
                    {
                        for (int k = 0; k < dizi.GetLength(0); k++)
                        {
                            for (int l = y; l <= y; l++)
                            {
                                if (firca_yonu == "asagi")
                                    dizi[k, l] = 1;
                            }
                        }
                        break;
                    }
                    for (int k = 0; k < (x + hareket_miktari) % (boyut - 1); k++)//hareket miktari boyuttan buyuk olmadıgı halde dizide tasma oluyorsa bu donguyu kullanıyorum
                    {
                        for (int l = y; l <= y; l++)
                        {
                            if (firca_yonu == "asagi")
                                dizi[k, l] = 1;
                        }
                    }
                    break;
                }
                for (int j = y; j <= y; j++)
                {
                    if (firca_yonu == "asagi")
                        dizi[i, j] = 1;
                }
            }
            //Asagida aracin son yerini tespit etmek icin if ve else yapisi kullandim sebebiyse eger arac boyutun sinirlerini asarsa son geldigi noktalar farkli olacaktir. Bu durmua göre 2 ayri islem yaptirdim
            if ((x + hareket_miktari) > (boyut - 1))
            {
                x = (x + hareket_miktari) % (boyut);
            }
            else
                x = x + ((hareket_miktari));
                   
        }
        public void kuzey(int[,] dizi, ref int x, ref int y, string firca_yonu, int hareket_miktari, int boyut)
        {
            for (int i = x; i > x - (hareket_miktari + 1); i--)
            {
                if (i == -1)//burada indis sona geldigin icin aracin diger tarafinde cikmasi gerektiginden yeni dongu kurdum ve kosulu(j==-1) yapmamin sebebi eger "0" a esitleseydim direk ikinci donguye girecek ve diger tarafa gecektir. Ve bu ikinci dongunun sonunda "break oldugu icin dıs dongude sonlancak ve "0" indisini "1" yapacak komutu gormeyecegi icin "0" indisi icin islem yapmayacaktir
                {
                    if (hareket_miktari >= (boyut))//eger hareket miktari boyuta esit veya fazlaysa butun satirlari "1" yapıyorum
                    {
                        for (int k = 0; k < dizi.GetLength(0); k++)
                        {
                            for (int l = y; l <= y; l++)
                            {
                                if (firca_yonu == "asagi")
                                    dizi[k, l] = 1;
                            }
                        }
                        break;
                    }
                    for (int k = (boyut - 1); k > (boyut - 1) - ((hareket_miktari - x) % (boyut - 1)); k--)//hareket miktari boyuttan buyuk olmadıgı halde dizide tasma oluyorsa bu donguyu kullanıyorum
                    {
                        for (int l = y; l <= y; l++)
                        {
                            if (firca_yonu == "asagi")
                                dizi[k, l] = 1;
                        }
                    }

                    break;
                }
                //Asagida aracin son yerini tespit etmek icin if ve else yapisi kullandim sebebiyse eger arac boyutun sinirlerini asarsa son geldigi noktalar farkli olacaktir. Bu durmua göre 2 ayri islem yaptirdim
                for (int j = y; j <= y; j++)
                {
                    if (firca_yonu == "asagi")
                        dizi[i, j] = 1;
                }
            }
            if (x - hareket_miktari <= 0)
                x = (boyut) - ((hareket_miktari - x) % (boyut - 1));
            else
                x = x - (hareket_miktari);
        }
    }
}
