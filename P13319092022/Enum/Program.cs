using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Heftenin Gunun Daxil Et Qarsisindaki Reqemi Daxil Et");
            //foreach (var item in System.Enum.GetValues(typeof(WeekDay)))
            //{
            //    Console.WriteLine($"{(byte)item} {item}");
            //}

            //Console.WriteLine((byte)WeekDay.Monday);

            //string dayStr = Console.ReadLine();
            //byte.TryParse(dayStr, out byte day);

            //if (day < 10 || day > 70)
            //{
            //    Console.WriteLine("Duzgun Daxil");
            //}

            //byte day;
            //while (!byte.TryParse(dayStr, out day) || day < 10 || day > 70)
            //{
            //    Console.WriteLine("Duzgun Daxil Et");
            //    dayStr = Console.ReadLine();
            //}

            //Console.WriteLine((WeekDay)day);

            //switch (day)
            //{
            //    case 10:
            //        Console.WriteLine(WeekDay.Monday);
            //        break;
            //    case 20:
            //        Console.WriteLine(WeekDay.Thuesday);
            //        break;
            //    case 30:
            //        Console.WriteLine(WeekDay.Wednesday);
            //        break;
            //    case 40:
            //        Console.WriteLine(WeekDay.Thusday);
            //        break;
            //    case 50:
            //        Console.WriteLine(WeekDay.Friday);
            //        break;
            //    case 60:
            //        Console.WriteLine(WeekDay.Saturday);
            //        break;
            //    case 70:
            //        Console.WriteLine(WeekDay.Sunday);
            //        break;
            //    default:
            //        break;
            //}


            Object object1 = new Object();

            Studnet studnet = new Studnet();
            studnet.Name = "Hamid";
            studnet.SurName = "Mammadov";


            Console.WriteLine(studnet);
        }
    }
}
