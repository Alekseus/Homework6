//Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, если b1, k1, b2 и k2 заданы

 
int b1 = new Random().Next(-20, 20);
int b2 = new Random().Next(-20, 20);
int k1 = new Random().Next(-20, 20);
int k2 = new Random().Next(-20, 20);
 
 int x= (b2 - b1)/(k1 - k2);
 int y = (b2-b1)/(k1-k2) * k1 + b1;
 
 Console.WriteLine();
 Console.WriteLine($"Точка пересечения: (x: {x}, y: {y})");


