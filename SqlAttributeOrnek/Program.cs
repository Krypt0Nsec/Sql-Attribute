namespace SqlAttributeOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {

            UrunEntity urn = new UrunEntity();
            urn.UrunAdi = "Pentium CPU";
            urn.Fiyat = 9000;
            urn.SonSatisTarihi = DateTime.Now.AddDays(30);
            urn.Insert();
        }
    }
}