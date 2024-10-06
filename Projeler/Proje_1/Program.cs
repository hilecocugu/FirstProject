int kalmasüresi;
double ucret;
Console.WriteLine("-----------Oto Park-----------");
Console.Write("Kaç Dakika Duracaksın: ");
kalmasüresi = Convert.ToInt32(Console.ReadLine());

if (kalmasüresi <= 180)
{
    Console.WriteLine((kalmasüresi / 60) + "Saat " + (kalmasüresi % 60) + " Dakika kaldın " + "Ücret 7 Tl");
}
else if (kalmasüresi <= 420)
{
    ucret = 7 + ((kalmasüresi / 60 - 3) * 2);
    Console.WriteLine((kalmasüresi / 60) + "Saat " + (kalmasüresi % 60) + " Dakika kaldın " + "Ücretin " + (ucret) + "Tl");
}
else if (kalmasüresi <= 720)
{
    ucret = 7 + (4 * 2) + (kalmasüresi / 60 - 7) * 1.5;
    Console.WriteLine((kalmasüresi / 60) + "Saat " + (kalmasüresi % 60) + " Dakika kaldın " + "Ücretin " + (ucret) + "Tl");
}
else if (kalmasüresi > 720)
{
    ucret = 7 + (4 * 2) + (5 * 1.5) + (kalmasüresi / 60 - 12) * 1;
    Console.WriteLine((kalmasüresi / 60) + "Saat " + (kalmasüresi % 60) + " Dakika kaldın " + "Ücretin " + (ucret) + "Tl");
}

Console.Read();