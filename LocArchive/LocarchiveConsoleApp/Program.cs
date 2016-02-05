namespace LocarchiveConsoleApp
{
    using System;
    using Locarchive;
    using Properties;

    class Program
    {
        static void Main()
        {
            var fichier = Settings.Default.fichier;
            var locarchive = new Locarchive(fichier);

            Console.WriteLine(Settings.Default.MSG000);
            locarchive.VerifierEnteteFichier(fichier);

            Console.WriteLine(Settings.Default.MSG001);

            locarchive.InjecterFichier();


            Console.ReadLine();
        }
    }
}
