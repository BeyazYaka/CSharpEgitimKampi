using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //Foreach(1;2;3;4)

            //1:Değişken türü
            //2:Değişken adı
            //3:In
            //4:Liste, Koleksiyon, Dizi

            //string[] cities = {"milano", "roma", "budapeşte", "ankara", "istanbul", "varşova"};

            //foreach(string x in cities) 
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //Array.Sort(numbers);    

            //foreach (int x in numbers) 
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int x in numbers)
            //{
            //    if (x % 2 == 0)
            //    {
            //        Console.WriteLine(x);
            //    }
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //int total = 0;

            //foreach (int x in numbers)
            //{
            //    total += x;
            //}

            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{ 
            //    1,2,3,4,5,8
            //};

            //foreach (int x in numbers) 
            //{
            //    Console.WriteLine(x);
            //}

            //string word = "Merhaba";

            //foreach (char s in word) 
            //{
            //    Console.WriteLine(s);
            //}

            #endregion

            #region Örnek Sınav Sistemi Uygulaması Kendim

            //Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            //Console.WriteLine();
            //Console.WriteLine();

            ////Sınıftaki öğrenci sayısını kullanıcıdan alma
            //Console.WriteLine("-----------------------------");
            //Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine();

            //string[] studentNames = new string[studentCount];
            //int[] studentVize = new int[studentCount];
            //int[] studentFinal = new int[studentCount];

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine("-----------------------------");

            //    Console.Write($"{i + 1}.öğrenci isimini giriniz: ");
            //    studentNames[i] = Console.ReadLine();

            //    Console.Write($"{i + 1}.öğrenci vize notunu giriniz: ");
            //    studentVize[i] = int.Parse(Console.ReadLine());

            //    Console.Write($"{i + 1}.öğrenci final notunu giriniz: ");
            //    studentFinal[i] = int.Parse(Console.ReadLine());

            //    Console.WriteLine("-----------------------------");

            //}

            //Console.WriteLine();

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine($"{i + 1}.öğrenci isim: {studentNames[i]}, Vize Notu: {studentVize[i]}, Final Notu: {studentVize[i]}, Not Ortalması: {(studentVize[i] + studentFinal[i]) / 2}");
            //}

            #endregion

            #region Örnek Sınav Sistemi Uygulaması Hoca

            //Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            ////Sınıftaki öğrenci sayısını kullanıcıdan alma
            //Console.WriteLine("-----------------------------");
            //Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("-----------------------------");

            ////Öğrenci isimleri ve not ortalamalarını saklayacak diziler
            //string[] studentNames = new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];


            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"{i + 1}.öğrenci isimini giriniz: ");
            //    studentNames[i] = Console.ReadLine();

            //    double totalExamResult = 0;

            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz: ");
            //        double value = double.Parse(Console.ReadLine());
            //        totalExamResult += value;//notları topluyoruz.
            //    }
            //    Console.WriteLine();
            //    studentExamAvg[i] = totalExamResult / 3;
            //}

            ////Sınav ortalamaları
            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine("-----------------------------");

            //    Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

            //    //Öğrencilerin ortalaması ve geçip kalma durumları 
            //    if (studentExamAvg[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı.");
            //    }

            //    Console.WriteLine("-----------------------------");

            //}

            #endregion

            Console.Read();
        }
    }
}
