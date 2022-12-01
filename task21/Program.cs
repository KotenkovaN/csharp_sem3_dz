Console.Clear(); 
Console.Write("Введите координату X1: "); 
double X1 = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Введите координату Y1: "); 
double Y1 = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Введите координату Z1: "); 
double Z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату X2: "); 
double X2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y2: "); 
double Y2 = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Введите координату Z2: "); 
double Z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Math.Sqrt(Math.Pow(X1-X2,2) +  Math.Pow(Y1-Y2,2) + Math.Pow(Z1-Z2,2))); 
