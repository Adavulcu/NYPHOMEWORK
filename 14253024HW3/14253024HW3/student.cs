using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace _14253024HW3
{
    class student//student class dizisinden faydalanarak genel oratalamaya göre yaptırdıgın sıralamayı textbox a yazdırdıgım sınıf
    {
        public int number;
        string name, lesson,str="";
        double average, grade;
        
        public student(int number, string name, string lesson, double grade,double average)
        {
            this.number = number;
            this.name = name;
            this.lesson = lesson;
            this.grade = grade;
            this.average = average;
        }      
        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2,-30}{3,-40}{4,-20}",str,number,name,lesson,grade);
        }
    }
}
