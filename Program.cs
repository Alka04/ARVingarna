Console.WriteLine("Ge värderna till en rectangel");
Console.WriteLine("Bred först i cm");
int widthR = int.Parse(Console.ReadLine());
Console.WriteLine("Höjd nu i cm");
int heightR = int.Parse(Console.ReadLine());
Rec rec = new Rec(widthR, heightR);
Console.WriteLine("Omkretsen av rectangeln är   :" + rec.RO());
Console.WriteLine("Arean av rectangeln är   :" + rec.RA());

Console.WriteLine("Ge värderna till en Triangel");
Console.WriteLine("Ge bred först i cm");
int widthT = int.Parse(Console.ReadLine());
Console.WriteLine("Höjd nu i cm");
int heightT = int.Parse(Console.ReadLine());
Tri tri = new Tri(widthT, heightT);
Console.WriteLine("Omkretsen av Trianglen är   :" + tri.TO());
Console.WriteLine("Arean av Trianglen är   :" + tri.TA());
