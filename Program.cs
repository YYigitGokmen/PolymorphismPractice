


using PolymorphismPractice;

public class Program
{

    public static void Main(string[] args)
    {


        Square kare = new Square(3,5);


        Rectangle dikdörtgen = new Rectangle(10, 20);


        RightTriangle diküçgen = new RightTriangle(5, 30);


        Console.WriteLine($"Karenin alanı {kare.AlanHesapla()}");
        Console.WriteLine($"DikDörtgenin alanı {dikdörtgen.AlanHesapla()}");
        Console.WriteLine($"Diküçgenin alanı {diküçgen.AlanHesapla()}");


      

    }
}


