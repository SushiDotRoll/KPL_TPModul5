using System;
class Program
{
    static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser("Irsyad");

        DataGeneric<string> data = new DataGeneric<string>("103082400030");
        data.PrintData();
    }
}