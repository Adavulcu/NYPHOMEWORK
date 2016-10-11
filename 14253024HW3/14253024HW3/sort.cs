using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace _14253024HW3
{
    class sort_and_max//genel ortalamaya göre sırlama yapmak ve en yüksek notu hesaplatmak için olsutdugum sınıf
    {         
        public void sort(ArrayList average1,ArrayList number1,ArrayList name1,ArrayList lesson1,ArrayList grade1)//genel oratalamaya göre sıralama methodu
        {
            int min, yedek;
            double yedek2;
            string yedek1;
            for (int i = 0; i < grade1.Count - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < grade1.Count; j++)
                {
                    if (Convert.ToDouble(average1[j]) < Convert.ToDouble(average1[min]))
                    {
                        min = j;
                    }

                }
                yedek2 = Convert.ToDouble(average1[i]);
                average1[i] = average1[min];
                average1[min] = yedek2;

                yedek = Convert.ToInt32(grade1[i]);
                grade1[i] = grade1[min];
                grade1[min] = yedek;

                yedek1 = Convert.ToString(name1[i]);
                name1[i] = name1[min];
                name1[min] = yedek1;

                yedek1 = Convert.ToString(lesson1[i]);
                lesson1[i] = lesson1[min];
                lesson1[min] = yedek1;

                yedek = Convert.ToInt32(number1[i]);
                number1[i] = number1[min];
                number1[min] = yedek;
            }
        }
        public void max(ArrayList data,ArrayList algo,ArrayList obje,ArrayList paint,ArrayList computer)//en yüksek notu tespit eden methot
        {
            int max, yedek;
            for (int i = 0; i < algo.Count - 1; i++)
            {
                max = i;
                for (int j = i + 1; j < algo.Count; j++)
                {
                    if (Convert.ToInt32(algo[j]) > Convert.ToInt32(algo[max]))
                    {
                        max = j;
                    }

                }
                yedek = Convert.ToInt32(algo[i]);
                algo[i] = algo[max];
                algo[max] = yedek;
            }
            for (int i = 0; i < data.Count - 1; i++)
            {
                max = i;
                for (int j = i + 1; j < data.Count; j++)
                {
                    if (Convert.ToInt32(data[j]) > Convert.ToInt32(data[max]))
                    {
                        max = j;
                    }

                }
                yedek = Convert.ToInt32(data[i]);
                data[i] = data[max];
                data[max] = yedek;
            }
            for (int i = 0; i < computer.Count - 1; i++)
            {
                max = i;
                for (int j = i + 1; j < computer.Count; j++)
                {
                    if (Convert.ToInt32(computer[j]) > Convert.ToInt32(computer[max]))
                    {
                        max = j;
                    }

                }
                yedek = Convert.ToInt32(computer[i]);
                computer[i] = computer[max];
                computer[max] = yedek;
            }
            for (int i = 0; i < paint.Count - 1; i++)
            {
                max = i;
                for (int j = i + 1; j < paint.Count; j++)
                {
                    if (Convert.ToInt32(paint[j]) > Convert.ToInt32(paint[max]))
                    {
                        max = j;
                    }

                }
                yedek = Convert.ToInt32(paint[i]);
                paint[i] = paint[max];
                paint[max] = yedek;
            }
            for (int i = 0; i < obje.Count - 1; i++)
            {
                max = i;
                for (int j = i + 1; j < obje.Count; j++)
                {
                    if (Convert.ToInt32(obje[j]) > Convert.ToInt32(obje[max]))
                    {
                        max = j;
                    }

                }
                yedek = Convert.ToInt32(obje[i]);
                obje[i] = obje[max];
                obje[max] = yedek;
            }
        }
    }
}
