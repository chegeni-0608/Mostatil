using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostatil
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("^^^^^^^^^^^^^^^Rectangle Area^^^^^^^^^^^^^^^^");

            Console.WriteLine("Enter Rectangle Width : ");
            float witdth=float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Rectangle Length : ");
            float length=float.Parse(Console.ReadLine());

            float rectanglArea = witdth * length;
            Console.WriteLine("Rectangel Area :{0}",rectanglArea);

            Console.WriteLine("###########################################################################################################");

            Console.WriteLine("^^^^^^^^^^^^^^^Rectangle Circumference^^^^^^^^^^^^^^^^");

            Console.WriteLine("Enter Rectangle Width : ");
            float Witdth = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Rectangle Length : ");
            float Length = float.Parse(Console.ReadLine());

            float rectangleCircumference = (Witdth + Length)*2;
            Console.WriteLine("Rectangle  Circumference :{0}", rectangleCircumference);

            Console.ReadKey();
        }
    }
}
