Console.WriteLine("-----MS----");
Console.WriteLine(VitaSentimentale.MS == null ? "NON SI CAPISCE UN CAZZO" : VitaSentimentale.MS.ToString());
Console.WriteLine("-----CD----");
Console.WriteLine(VitaSentimentale.CD);
Console.WriteLine("-----CM----");
for (var x = 1; x <= 12; x++)
{
    Console.WriteLine("Mese :" + x);
    Console.WriteLine(VitaSentimentale.CM);
}

public class VitaSentimentale
{


    public static bool? MS
    {
        get { return null; }
        set { }
    }

    public static bool CD
    {
        get { return false; }
        set { }
    }


    private static int count = 0;
    private static bool currentStatus = false;
    public static bool CM
    {
        get
        {
            if (count % 4 == 0)
                currentStatus = !currentStatus;
            count++;
            return currentStatus;
        }
        set { }
    }
}



