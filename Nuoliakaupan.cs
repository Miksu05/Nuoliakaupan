using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

Nuolet nuoli = null;


Console.Write($"Tervetuloa Nuoli kauppaan haluatko valita meidän valmis pohjista nuolista vai tehdä oman (Kyllä vai Ei)?");
string vastaus = Console.ReadLine();

if (vastaus == "Kyllä")
{
    Console.WriteLine($"Haluatko (Eliittinuolen, Aloittelijanuolen vai Perusnuolen");
    string Valmis = Console.ReadLine();
    if(Valmis == "Eliittinuoli")
    {
        nuoli = Nuolet.LuoEliittiNuoli();
    }
    if (Valmis == "Aloittelijanuoli")
    {
        nuoli = Nuolet.Aloittelijanuoli();
    }
    if (Valmis == "Perusnuoli")
    {
        nuoli = Nuolet.PerusNuoli();
        

    }
}
if (vastaus == "Ei")
{
    Console.Write($"Minkälainen kärki ({Kärjet.Puu}, {Kärjet.Timantti} vai {Kärjet.Teräs}): ");
    string kärki = Console.ReadLine();
    Console.Write($"Minkälaiset sulat ({Perät.Lehti}, {Perät.kanansulka} vai {Perät.kotkansulka}): ");
    string perät = Console.ReadLine();
    Console.Write($"Nuolen pituus (60-100cm): ");
    double pituus = Convert.ToDouble(Console.ReadLine());
    nuoli = new Nuolet(new Kärjet(), new Perät(), pituus *= 0.05);
}
if (nuoli != null)
{
    Console.WriteLine($"Tämän nuolen hinta on {nuoli.Palautahinta()} kultaa");
}



// Nuolet aloittelijanNuoli = new Nuolet(Kärjet.Puu, Perä.Lehti, 60.0);

// nuoli.PalautaHinta();

// Console.WriteLine(nuoli.perät);




class Nuolet
{
    public Kärjet Kärki { get; set; }

    public Perät perät { get; set; }

    private double pituus;
    

    public Nuolet(Kärjet kärki, Perät perät, double pituus)
    {
        this.Kärki = kärki;
        this.perät = perät;
        this.pituus = pituus;
        
    }
    public static Nuolet LuoEliittiNuoli()
    {
        return new Nuolet(Kärjet.Timantti, Perät.kotkansulka, 100 * 0.05);
    }
    public static Nuolet Aloittelijanuoli()
    {
        return new Nuolet(Kärjet.Puu, Perät.kanansulka, 70 * 0.05);
    }
    public static Nuolet PerusNuoli()
    {
        return new Nuolet(Kärjet.Teräs, Perät.kanansulka, 85 * 0.05 );
    }
    

    //public void SetPituus(double pituus)
    //{
        //this.pituus = pituus;
    //}
    //public double GetPituus()
    //{
        //return pituus;
    //}
    //public void SetKärjet(Kärjet kärki)
    //{
        //this.kärki = kärki;
    //}



    //public Kärjet GetKärki()
    //{
        //return kärki;     
    //}

    //public void SetPerät(Perät perät)
    //{
        //this.perät = perät;
    //}
    //public Perät GetPerä()
    //{
        //return perät;
    //}


    public double Palautahinta()

    {
        double Kvastaus = 0;
        double Pvastaus = 0;


        if (Kärki == Kärjet.Puu)
        {
            Kvastaus = 3;
        }
        if (Kärki == Kärjet.Timantti)
        {
            Kvastaus = 50;
        }
        if (Kärki == Kärjet.Teräs)
        {
            Kvastaus = 5;
        }
        if (perät == Perät.Lehti)
        {
            Pvastaus = 0;
        }
        if (perät == Perät.kanansulka)
        {
            Pvastaus = 1;
        }
        if (perät == Perät.kotkansulka)
        {
            Pvastaus = 5;
        }
        

        return Kvastaus + Pvastaus + pituus;
    }

}
enum Kärjet
{
    Puu,
    Timantti,
    Teräs,
    Hiilikuitu,
    Tulikivi
}
enum Perät
{
    Lehti,
    kanansulka,
    kotkansulka
}

enum Boolean { True, False, Maybe }



