﻿using System.Runtime.CompilerServices;

namespace HomeWorkWeek8
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Employee it = new Employee("Hasan", 28,"İTÜ - Bilgisayar Mühandisliği", 2, 32.500);
            Employee ik = new Employee("Zeynep", 32,"Okan Üniversitesi - İnsan Kaynakları Yönetimi", 4, 28.300);
            Employee accounting = new Employee("Selim", 40,"Hacettepe Üniversitesi - Muhasebe ve Vergi Uygulamaları (2 Yıllık) (2 Yıllık)", 9, 24.500);
            Employee salesman = new Employee("Zeki", 25,"Dokuz Eylül Üniversitesi Pazarlama (2 Yıllık) (4 Yıllık)", 2, 22.000);

            Employee[] employees = {it, ik, accounting, salesman};

            Manager ceo = new Manager("Mustafa", 52, "Boğaziçi Üniversitesi", 14, 52.356, employees);

            Console.WriteLine("Yönetici Bilgileri: \n\t" + "İsim: " + ceo.Name + " Yaş: " + ceo.Age + " Mezuniyet: " +  ceo.Graduation + " Tecrübe: " + ceo.Experience + " Maaş: " + ceo.Salary + " Çalışan sayısı: " + ceo.employees.Length);
            
            Console.ReadLine();
        }
    }
}