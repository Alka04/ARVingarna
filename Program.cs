Console.WriteLine("Skriv 1 för att räkna på en rektangel eller kvadrat och skriv 2 för att räkna på en rätvinklig triangel");
int menyval = int.Parse(Console.ReadLine());
if (menyval == 1)
{
    Console.WriteLine("Ge värderna till en Rektagel eller Kvadrat");
    Console.WriteLine("Bred först i cm");
    int widthR = int.Parse(Console.ReadLine());
    Console.WriteLine("Höjd nu i cm");
    int heightR = int.Parse(Console.ReadLine());
    Rec rec = new Rec(widthR, heightR);
    if(widthR == heightR)
    {
        Console.WriteLine("Detta är en Kvadrat");
        Console.WriteLine("Omkretsen av Kvadraten är   :" + rec.RO());
        Console.WriteLine("Arean av Kvadraten är   :" + rec.RA());
    }
    else 
    {
        Console.WriteLine("Detta är en Rektangel");
        Console.WriteLine("Omkretsen av Rektangeln är   :" + rec.RO());
        Console.WriteLine("Arean av Rektangeln är   :" + rec.RA());
    }
}
else if (menyval == 2)
{
    Console.WriteLine("Ge värderna till en Triangel");
    Console.WriteLine("Ge bred först i cm");
    int widthT = int.Parse(Console.ReadLine());
    Console.WriteLine("Höjd nu i cm");
    int heightT = int.Parse(Console.ReadLine());
    Tri tri = new Tri(widthT, heightT);
    Console.WriteLine("Omkretsen av Trianglen är   :" + tri.TO());
    Console.WriteLine("Arean av Trianglen är   :" + tri.TA());
}
else
{
    Console.WriteLine("Fel starta om programmet och skriv ett gilltigt tal :)");
}