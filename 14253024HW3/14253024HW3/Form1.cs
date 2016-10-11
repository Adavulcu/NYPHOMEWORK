using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace _14253024HW3
{
    public partial class Form1 : Form
    {
        int a = 0, b = 0, c = 0, d = 0, f = 0;//tüm veriler dogru girildiginden emin olmak icin olusturdugum kontrol degişkenleri
        int lesson_counter = 1;

        int number;
         double grade;
       
        ArrayList std_number = new ArrayList();
        ArrayList std_name = new ArrayList();
        ArrayList std_lesson = new ArrayList();
        ArrayList std_departman = new ArrayList();
        ArrayList std_grade = new ArrayList();
        ArrayList average1 = new ArrayList();
        ArrayList average5 = new ArrayList();
        sort_and_max stdu = new sort_and_max();
        
        public Form1()//combobox a atama yaptıgım yer
        {
            InitializeComponent();
            Process_combobox.Items.Add("Lesson search");
            Process_combobox.Items.Add("Student search");
            Process_combobox.Items.Add("Average and Sort");
            Process_combobox.Items.Add("Determine low grades");
            Process_combobox.Items.Add("Determine maximun grades");
            Process_combobox.Items.Add("Departman search");
            Lessons_box.Items.Add("Computer Science");
            Lessons_box.Items.Add("Object Oriented Programming");
            Lessons_box.Items.Add("Algorithim and Programming");
            Lessons_box.Items.Add("Data Structure");
            Lessons_box.Items.Add("Painting");
            Lessons_box1.Items.Add("Computer Science");
            Lessons_box1.Items.Add("Object Oriented Programming");
            Lessons_box1.Items.Add("Algorithim and Programming");
            Lessons_box1.Items.Add("Data Structure");
            Lessons_box1.Items.Add("Painting");
             Lesson_combox.Items.Add("Computer Science");
            Lesson_combox.Items.Add("Object Oriented Programming");
             Lesson_combox.Items.Add("Algorithim and Programming");
             Lesson_combox.Items.Add("Data Structure");
             Lesson_combox.Items.Add("Painting");
           
        
            display.ReadOnly = true;            
            this.contunie_button.Enabled = false;
            AcceptButton = button_sign;
          
                      
        }
        public void combobox_lesson_add()//kullanıcıya ders sectiriken en başta atadıgım dersleri comboboxtan sildigim icin bu methotta yeniden atama yaptım
        {
            Lessons_box.Items.Clear();
            Lessons_box.Items.Add("Computer Science");
            Lessons_box.Items.Add("Object Oriented Programming");
            Lessons_box.Items.Add("Algorithim and Programming");
            Lessons_box.Items.Add("Data Structure");
            Lessons_box.Items.Add("Painting");
        }
        private void button_kaydet_Click(object sender, EventArgs e)//kullanıcıdan alınan verleri burada kaydettim
        {
            int counter = 0;
      
            
            if (lesson_counter < 4)
            {              
              
                try
                {
                    for (int i = 0; i < std_number.Count; i++)
                    {
                    if(Convert.ToInt32( student_number_box.Text)==Convert.ToInt32(std_number[i]))                   
                    counter++;
		        	}
                    number = Convert.ToInt32(student_number_box.Text);
                      if(counter>2)
                    {
                        MessageBox.Show(student_number_box.Text + "\t" + "Has Been Registered You Have To Enter Different Student Number");
                        student_number_box.Clear();
                        this.number_control_label.Visible = true;
                        counter = 0;
                    }
                      else
                    {
                        a = 1;
                        this.number_control_label.Visible = false;
                        counter = 0;
                    }
                      counter = 0;
                   
                }
                catch (Exception)
                {
                    MessageBox.Show("Student Number Must Be Integer");
                    this.number_control_label.Visible = true;
                    
                }
                try
                {
                    grade = Convert.ToDouble(student_grades_box.Text);
                    if (grade >= 0 && grade <= 100)
                    {
                       
                        b = 1;
                        this.grades_control_label.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Student Grade Must Be In Among 0 and 100");
                        this.grades_control_label.Visible = true;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Student Grade Must Be Double");
                    this.grades_control_label.Visible = true;
                }
                if (student_departman_box.Text != "")
                {
                    c = 1;
                    this.departman_control_label.Visible = false;
                }
                else
                {
                    MessageBox.Show("You Have To Enter Departman");
                    this.departman_control_label.Visible = true;
                }
                if (Lessons_box.Text == "Computer Science" || Lessons_box.Text == "Object Oriented Programming" || Lessons_box.Text == "Algorithim and Programming" || Lessons_box.Text == "Data Structure" || Lessons_box.Text == "Painting")
                {
                    d = 1;               
                    this.lesson_control_label.Visible = false;
                }
                else
                {
                    this.lesson_control_label.Visible = true;
                    MessageBox.Show("You Have To Choose Lesson");
                }
                if (student_name_box.Text != "")
                {
                    f = 1;
                    this.name_control_label.Visible = false;
                }
                else
                {
                    this.name_control_label.Visible = true;
                    MessageBox.Show("You Have To Enter name");
                }
                if(a==1&&b==1&&c==1&&d==1&&f==1)//tüm degerlerin dogru olarak girildiginde arrayliste atama yaptıgım yer
                {

                    std_number.Add(student_number_box.Text);
                    std_name.Add(student_name_box.Text);                
                    std_departman.Add(student_departman_box.Text);
                    std_lesson.Add(Lessons_box.Text);
                    Lessons_box.Items.RemoveAt(Lessons_box.SelectedIndex);
                    std_grade.Add(student_grades_box.Text);
                    student_grades_box.Clear();
                    contunie_button.BackColor = Color.Crimson;
                    this.succes_label.Visible = true;
                    this.fail_label.Visible = false;
                    this.contunie_button.Enabled = false;
                    this.student_name_box.Enabled = false;
                    this.student_departman_box.Enabled = false;
                    this.student_number_box.Enabled = false;
                    a = 0; b = 0; c = 0; d = 0; f = 0;                
                    lesson_counter++;                                
                }
                else
                {
                    this.succes_label.Visible = false;
                    this.fail_label.Visible = true;
                }
               
               if(lesson_counter==4)//kullanıcı yeni ilk ve ya yeni bir ögrenci kaydı yaptıgında, her ögrenci icin 3 ders secmek zorunlugundan dolayı, 3 tane ders secmeden mevcut verileri degiştirmemesi ve ya işlem yapmaya kalkaması icin bazı textbox ve buttonların kullanmını kaptattım
               {                                
                                                
                   student_grades_box.Clear();
                   student_departman_box.Clear();
                   student_name_box.Clear();
                   student_number_box.Clear();
                   this.contunie_button.Enabled = true;
                   contunie_button.BackColor = Color.DarkSeaGreen;
                   this.student_name_box.Enabled = true;
                   this.student_departman_box.Enabled = true;
                   this.student_number_box.Enabled = true;
                   lesson_counter = 1;
                   combobox_lesson_add();               
               }              
            }                  
                                    
        }

         private void Process_button_Click(object sender, EventArgs e)
        {

            if (Process_combobox.Text == "Lesson search")            
                processes.SelectedTab = lesson_searching;                                   
            else if (Process_combobox.Text == "Departman search")
                processes.SelectedTab = departman_searching;
            else if (Process_combobox.Text == "Student search")
                processes.SelectedTab = student_searching;
            else if (Process_combobox.Text == "Average and Sort")
                average_and_sort();
            else if (Process_combobox.Text == "Determine low grades")
                processes.SelectedTab = low_grades_tab;
            else if (Process_combobox.Text == "Determine maximun grades")
                max_grade();
            else
                MessageBox.Show("Invalid Input");
           
        }            
        private void low_grade_display()//60 tan düşük notların belirlendigin methot
        {
            display.Clear();
            int control=0;
            for (int i = 0; i < std_lesson.Count; i++)
            {
                if (Lesson_combox.Text == Convert.ToString(std_lesson[i]))
                    control = 1;
            }
            if (control == 1)
            {
                display.Text += ("Student Grades\tStudent Name\tStudent Number\n");
                for (int i = 0; i < std_grade.Count; i++)
                {
                    if (Lesson_combox.Text == Convert.ToString(std_lesson[i]))
                    {

                        if (Convert.ToInt32(std_grade[i]) < 60)
                        {
                            display.Text += string.Format("{0,12} {1,25} {2,30}\n", std_grade[i], std_name[i], std_number[i]);
                        }
                    }
                }
            }
            else
                MessageBox.Show("Invalid Input");
        }
        public void average_and_sort()//genel ortalamaya göre sıralama yapılan methot
        {
            student[] stdu1 = new student[std_grade.Count];
            display.Clear();

            double[] average2 = new double[std_number.Count];
            double[] average3 = new double[std_number.Count];
            double[] average4 = new double[std_number.Count];
            double total = 0, average = 0;
            for (int i = 0; i < std_grade.Count; i++)
            {
                total += Convert.ToDouble(std_grade[i]);
                if (i % 3 == 2)
                {
                    average = Math.Round((total / 3), 2);
                    total = 0;
                    average1.Add(average);
                }            
                average = 0;
            }
            for (int i = 0; i < std_number.Count/3; i++)
            {
                average2[i] = Convert.ToDouble(average1[i]);
                average3[i] = Convert.ToDouble(average1[i]);
                average4[i] = Convert.ToDouble(average1[i]);
            }
            for (int i = 0; i < std_number.Count; i++)
            {
                average5.Add(average2[i]);
                average5.Add(average3[i]);
                average5.Add(average4[i]);

            }
            stdu.sort(average5, std_number, std_name, std_lesson, std_grade);   
            for (int i = 0; i <std_grade.Count; i++)
            {
                stdu1[i] = new student(Convert.ToInt32(std_number[i]), Convert.ToString(std_name[i]), Convert.ToString(std_lesson[i]), Convert.ToDouble(std_grade[i]), Convert.ToDouble(average5[i]));
            }
            display.Text += ("Studetent Number\tStudent Name\tStudent Lessons\t\tlesson Grades\n");
            display.Text += "****************************************************************************************************************************\n";
            for (int i = 0; i < stdu1.Length; i++)
            {
                if (i > 0 && i % 3 == 0)
                    display.Text += "****************************************************************************************************************************\n";
                display.Text += (stdu1[i])+"\n";
                if (i % 3 == 2)
                    display.Text +="average:\t"+ average5[i]+"\n";
               
            }
                                       
        }
        private void search_button_Click(object sender, EventArgs e)//derlere göre arama yaplıan methot
        {
            display.Clear();
            int dersi_alan_ogrenci_sayisi = 0, kontrol = 0;
            double not_toplami = 0;
            for (int i = 0; i < std_number.Count; i++)
            {
                if (Convert.ToString(std_lesson[i]) == Lessons_box1.Text)
                {
                    dersi_alan_ogrenci_sayisi++;
                    not_toplami += Convert.ToDouble(std_grade[i]);
                    kontrol = 1;
                }
            }
            if (kontrol == 0)
                MessageBox.Show("Unmatched lesson");
            else
            {
                display.Text += "Number of Student\tLesson Average\n";
                display.Text += (dersi_alan_ogrenci_sayisi + "\t\t" + (not_toplami / dersi_alan_ogrenci_sayisi) + "\n");
            }
        }
        private void Student_Search_Button_Click(object sender, EventArgs e)//bir ögrenciyi o ögrencinin numarasına ya da adına göre arama yapılan metot
        {
            int kontrol = 0, name_control=0; //name_control ,  farklı işlemlerde bilgileri yazdırgım icin  bilgilerin hangi ögrenciye ait oldugunu tespit ettirmek icin kullandım      
            double not_toplami = 0;
            double average = 0;
            display.Clear();
            display.Text += ("Name\t\tLessons\t\t\t\tGrades\n");
                try
                {
                    for (int i = 0; i < std_number.Count; i++)
                    {
                        if (Convert.ToInt32(student_number_searching_textbox.Text) == Convert.ToInt32(std_number[i])&&Convert.ToString(std_name[i])==Student_name_search_textBox.Text)
                        {
                            name_control = i;
                            display.Text += (std_name[i] + "\t\t" + std_lesson[i] + "\t\t" + std_grade[i] + "\n");
                            kontrol = 1;
                            not_toplami += Convert.ToDouble(std_grade[i]);
                        }
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Student Is not Found");
                }
                average = not_toplami / 3;
                display.Text += (std_name[name_control]+"'s"+"\t\t"+"Average:\t" + (average));
                average = 0;
                if (kontrol == 0)
                {
                    display.Clear();
                    MessageBox.Show("Student Is not Found");
                }       
        }

    
      
      private void departman_search_button_Click(object sender, EventArgs e)//bölüme göre arama yapan metotu cagırdıgım yer
      {
          display.Clear();
          departman_search();
      }

      public void departman_search()//bölüme göre arama yapan metot
      {
          int sayac = 0, control = 0;
          double total = 0;
          for (int i = 0; i < std_departman.Count; i++)
          {
              if (departman_search_box.Text == Convert.ToString(std_departman[i]))
              {
                  sayac++;
                  total += Convert.ToDouble(std_grade[i]);
                  control = 1;
              }
          }
          if (control == 0)
              MessageBox.Show("Invalid Input");
          display.Text = "student number" + "\t" + "departman average\n";
          display.Text += (sayac / 3 + "\t\t" + (total / sayac));
      }
        public void max_grade()//en yüksek notu hesaplayan metot
      {
          display.Clear();
          ArrayList algo = new ArrayList();
          ArrayList obje = new ArrayList();
          ArrayList paint = new ArrayList();
          ArrayList data = new ArrayList();
          ArrayList computer = new ArrayList();
          int com_control = 0, algo_control = 0, pa_control = 0, obje_control = 0, data_control = 0;
          for (int i = 0; i < std_grade.Count; i++)
          {
              if ("Computer Science" == Convert.ToString(std_lesson[i]))
              {
                  computer.Add(std_grade[i]);
                  com_control = 1;
              }
              else if ("Object Oriented Programming" == Convert.ToString(std_lesson[i]))
              {
                  obje.Add(std_grade[i]);
                  obje_control = 1;
              }
              else if ("Algorithim and Programming" == Convert.ToString(std_lesson[i]))
              {
                  algo.Add(std_grade[i]);
                  algo_control = 1;
              }
              else if ("Data Structure" == Convert.ToString(std_lesson[i]))
              {
                  data.Add(std_grade[i]);
                  data_control = 1;
              }
              else if ("Painting" == Convert.ToString(std_lesson[i]))
              {
                  paint.Add(std_grade[i]);
                  pa_control = 1;
              }
          }
          stdu.max(data, algo, obje, paint, computer);
          if (algo_control == 1)
          {
              display.Text += "Algorithim and Programming maximun grades\t: ";
              for (int i = 0; i < algo.Count; i++)
              {
                  if(algo[i]==algo[0])
                  display.Text += Convert.ToString(algo[i]) + "\t";
              }
              display.Text += "\n\n";
          }
          if (data_control == 1)
          {
              display.Text += "Data Structure maximun grades\t: ";
              for (int i = 0; i < data.Count; i++)
              {
                  if (data[i] == data[0])
                  display.Text += Convert.ToString(data[i]) + " \t";
              }
              display.Text += "\n\n";
          }
          if (pa_control == 1)
          {
              display.Text += "Painting maximun grades \t: ";
              for (int i = 0; i < paint.Count; i++)
              {
                  if (paint[i] == paint[0])
                  display.Text += Convert.ToString(paint[i]) + " \t";
              }
              display.Text += "\n\n";
          }
           if (obje_control == 1)
          {
              display.Text += "Object Oriented Programming maximun grades \t: ";
              for (int i = 0; i < obje.Count; i++)
              {
                  if (obje[i] ==obje[0])
                  display.Text += Convert.ToString(obje[i]) + "\t";
              }
              display.Text += "\n\n";
          }
           if (com_control==1)
          {
              display.Text += "Computer Science maximun grades \t: ";
              for (int i = 0; i < computer.Count; i++)
              {
                  if (computer[i] == computer[0])
                  display.Text += Convert.ToString(computer[i]) + "\t";
              }
              display.Text += "\n\n";
          }
      }

        private void button1_Click(object sender, EventArgs e)
        {
           
           DialogResult dialog=MessageBox.Show("Are You Sure Now! You Will Not Enter New Inputs ","Warning",MessageBoxButtons.YesNo);
           if (dialog == DialogResult.Yes)
           {
               processes.SelectedTab = process_tab;
               this.label1.Visible = false;
               this.label2.Visible = false;
               this.label3.Visible = false;
               this.label4.Visible = false;
               this.label5.Visible = false;
               this.label7.Visible = false;
               this.fail_label.Visible = false;
               this.succes_label.Visible = false;
               this.number_control_label.Visible = false;
               this.name_control_label.Visible = false;
               this.lesson_control_label.Visible = false;
               this.departman_control_label.Visible = false;
               this.grades_control_label.Visible = false;
               
               this.button_sign.Visible = false;
               this.contunie_button.Visible = false;
               this.student_departman_box.Visible = false;
               this.student_grades_box.Visible = false;
               this.student_name_box.Visible = false;
               this.student_number_box.Visible = false;
               this.Lessons_box.Visible = false;
               this.warning.Visible = true;

               this.process_groupBox1.Visible = true;             
               this.lesson_groupBox1.Visible = true;
               this.departman_groupBox2.Visible = true;
               this.student_search_groupBox3.Visible = true;
               this.low_grade_groupBox4.Visible = true;
               this.process_label.Visible = false;
               this.low_grade_label15.Visible = false;
               this.student_search_label14.Visible = false;
               this.departman_search_label13.Visible = false;
               this.lesson_search_label12.Visible = false;
           }                     
        }

        private void low_grades_button_Click(object sender, EventArgs e)
        {
            low_grade_display();
        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            processes.SelectedTab = process_tab;
        }
    }
}
