using System;
class Geometria
{
    static void Main(string[] args)
    {
        //Crear objetos de Circunferencia
        Circunferencia c1 = new Circunferencia();
        c1.Calcular_Area(4);
        c1.Calcular_Perimetro(4);
        //Crear objetos de  Esfera
        Esfera e1 = new Esfera();
        e1.Calcular_Volumen(3);
        //Crear objetos de Tariangulo
        Triangulo t1 = new Triangulo();
        t1.Calcular_Area(2,3);
        t1.Calcular_Permitro(2,2,2);
    }

    public class Circunferencia
    {
        public int radio;
        public double pi = 3.14;

        public void Calcular_Area(int radio)
        {
            double totalArea = radio * radio * pi;
            Console.WriteLine("El area del circulo es : " + totalArea);
        }
        public void Calcular_Perimetro(int radio)
        {
            double totalPerimetro = 2 * pi * radio;
            Console.WriteLine("EL perimetro del circulo es: " + totalPerimetro);   
        }
    }

    public class Esfera
    {
        public int radio;
        public double pi = 3.14;

        public void Calcular_Volumen(int radio)
        {
            double totalVolumen = (double)4.0/3 * pi * radio * radio * radio;
            Console.WriteLine("El Volumen de la esfera es: " + Math.Round(totalVolumen,2));
        }
    } 

    public class Triangulo
    {
        public int radio;
        
        public void Calcular_Area(int b, int a)
        {
            double totalArea = (b*a)/2;
            Console.WriteLine("El Area del triangulo es: " + Math.Round(totalArea,2));
        }

        public void Calcular_Permitro(int l1, int l2, int l3)
        {
            double totalPerimetro = l1+l2+l3;
            Console.WriteLine("El Permitro del triangulo es: " + Math.Round(totalPerimetro,2));
        }
    }  
}

