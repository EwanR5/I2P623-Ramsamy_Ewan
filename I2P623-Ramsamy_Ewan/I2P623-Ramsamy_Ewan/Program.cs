using Animaux;
using I2P623_Ramsamy_Ewan;

internal class Program
{
    private static void Main(string[] args)
    {

        FeuDeSignalisation Feu1 = new FeuDeSignalisation("1001", 1, true);
        FeuDeSignalisation Feu2 = new FeuDeSignalisation("007", 1, false);

        Console.WriteLine(Feu1.AfficherCara());
        Console.WriteLine(Feu2.AfficherCara());
        Console.ReadLine();

        FeuDeSignalisation[] mesFeux = new FeuDeSignalisation[2];

        mesFeux[0] = Feu1;
        mesFeux[1] = Feu2;

        Console.WriteLine(mesFeux);
        Console.ReadLine();
    }
}