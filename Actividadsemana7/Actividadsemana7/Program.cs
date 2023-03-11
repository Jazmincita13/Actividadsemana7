using System; 

Console.WriteLine("▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲");
Console.WriteLine("FIGURA TRIANGULO RECTANGULO");
Console.WriteLine("▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲");


class For
{ 
    
    static void Main(string[] args)
    {
        Console.Write("Favor ingresar un numero entero");
        int variable = int.Parse(Console.ReadLine());

        for (int i = 1; i <= variable; i++) 
        { 
            for(int j = 1; j <= 1; j++) 
            { 
               Console.Write("*");
            }
            Console.WriteLine();
        }       
    }
}