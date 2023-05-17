//// Ejercio 1 While

//Console.WriteLine("que tabla de multiplicar quieres?");
//string n =Console.ReadLine();
//int numero = Convert.ToInt32(n);
//int x = 1;
//while(x <= 10)
//{
//    int result = x * numero;
//    Console.WriteLine(x + " x " + numero +  " = " +result);
//    x++;
//}

//// Ejercicio 2 Do while

//Console.WriteLine("escribe un numero entero del 100 al -100: ");
//int y = Convert.ToInt32(Console.ReadLine());

//while (y < 0)
//{
//    Console.WriteLine(y + " es negativo");
//    break;
//}
//while(y >0)
//{
//    Console.WriteLine(y + " es positivo");
//    break;
//} while (y == 0)
//{
//    Console.WriteLine(y + " el zero es neutral");
//    break;
//}

// Ejecicio3 For
Console.WriteLine("dibujemos una figura!");
Console.WriteLine("dame el ancho");
int ancho = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("dame la altura");
int alto = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("si quieres rellenar escribe r, si  no escribe n");
string relleno = Console.ReadLine();
if(relleno == "r")
{
   
    for ( int i= 0 ; i < alto; i++)
    {
        for (int e = 0; e < ancho; e++)
        {
            string d = "*";
            Console.Write(d);
        }
        Console.WriteLine("\n");
    }
}else
{
    for (int e = 0; e < ancho; e++)
    {
        string d = "*";
        Console.Write(d);
    }
    for (int i = 0; i < alto; i++)
    {
        Console.Write("*");
        Console.WriteLine("\n");
    }
    for (int e = 0; e < ancho; e++)
    {
        string d = "*";
        Console.Write(d);
    }
}