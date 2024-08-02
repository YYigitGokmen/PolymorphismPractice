using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPractice
{
    public abstract class BaseGeometrikSekil
    {

        public double Witdh {  get; set; }
        public double Height {  get; set; }

        public abstract double AlanHesapla();
        
            


    }

    //Classlarımızı ortak bir çatı altında toplayarak BaseGeometrikSekil classından türetebiliriz.
    public class Square : BaseGeometrikSekil 
    { 

        public Square(double witdh,double height) 

        {
            Witdh = witdh;
            Height = height;
        
        }


        public override double AlanHesapla()
        {
            return Witdh * Height;
        }

    }

    public class Rectangle : BaseGeometrikSekil
    {
        public Rectangle(double witdh, double height)

        {
            Witdh = witdh;
            Height = height;

        }

        public override double AlanHesapla()
        {
            return Witdh * Height;

        }


    }

    public class RightTriangle : BaseGeometrikSekil
    {

        public RightTriangle(double witdh, double height)

        {
            Witdh = witdh;
            Height = height;

        }

        public override double AlanHesapla()
        {
            return (Witdh * Height)/2;

        }





    }

















}
