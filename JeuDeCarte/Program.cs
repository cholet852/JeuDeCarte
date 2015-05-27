using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JeuDeCarte
{
    public class Program
    {
        static void Main(string[] args)
        {

            MoteurDeCartes moteur = new MoteurDeCartes();

            List<Carte> Cartes = moteur.RetournerNouveauPaquet();

           // List<Carte> CartesBrassees = moteur.BrasseCarte(Cartes);
            Carte carte = new Carte();

            for (int i = 0; i < 52; i++)
            {
                Console.WriteLine(string.Format("Valeur: {0}", Cartes[i].Valeur));
                Console.WriteLine(string.Format("Type: {0}", carte.RetourneTypeCarteTexte(Cartes[i].TypeCarte)));
                Console.WriteLine(string.Format("Valeur: {0}", Cartes[i].Nom));
                Console.ReadLine();
            }

        }
    }
}
