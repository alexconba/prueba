//ejercicio1
Console.WriteLine("cual es tu nombre?");
string name = Console.ReadLine();

Console.WriteLine("cual es tu apellido?");
string lastName = Console.ReadLine();

Console.WriteLine("que edad tienes?");
string strAge = Console.ReadLine();
int age = Int32.Parse(strAge);

Console.WriteLine("sabes programar?  y/n");
char skillDeveloper = (char)Console.Read();

Console.WriteLine("Hola " + name + ", de la familia " + lastName + ", tu edad es " + age + " años.");

//Ejercicio2
//Coche
int puertas = 4;
int ruedas = 4;
string marca = "toyota";
long itv = 7384723987923;

//Mesa
string material = "madera";
double peso = 79.3;
double largo = 120.34;
string color = "verde";

//ejercicio3

// comparar numero mayor 18

int a = 12;
int b = 18;
Console.WriteLine(a >= b);

// es char "a"

char r = 'a';
Console.WriteLine(r== 'a');

// dos condiciones true

Console.WriteLine(r== 'a' && a >= b);

// una true otra false

Console.WriteLine(r == 'a' || a == b);