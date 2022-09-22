Console.WriteLine("Skriv 1 för att räkna på en rektangel eller kvadrat och skriv 2 för att räkna på en rätvinklig triangel");
Shape shape = null;
int menyval = int.Parse(Console.ReadLine());
if (menyval == 1)
{
    Console.WriteLine("Ge värderna till en Rektagel eller Kvadrat");
    Console.WriteLine("Bred först i cm");
    int widthR = int.Parse(Console.ReadLine());
    Console.WriteLine("Höjd nu i cm");
    int heightR = int.Parse(Console.ReadLine());
    shape = new Rec(widthR, heightR);
    if(widthR == heightR)
    {
        Console.WriteLine("Detta är en Kvadrat");
    }
    else 
    {
        Console.WriteLine("Detta är en Rektangel");
    }
}
else if (menyval == 2)
{
    Console.WriteLine("Ge värderna till en Triangel");
    Console.WriteLine("Ge bred först i cm");
    int widthT = int.Parse(Console.ReadLine());
    Console.WriteLine("Höjd nu i cm");
    int heightT = int.Parse(Console.ReadLine());
    shape  = new Tri(widthT, heightT);
}
else
{
    Console.WriteLine("Fel starta om programmet och skriv ett gilltigt tal :)");
}
if (shape != null)
{
    Console.WriteLine("Omkretsen av ditt objekt är   :" + shape.Circumference());
    Console.WriteLine("Arean av ditt objekt är   :" + shape.Area());
}