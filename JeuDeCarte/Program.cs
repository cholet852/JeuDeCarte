using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeCarte
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Cartes = new string[52];

            string[] typesCartes = new string[4] {"coeur", "carreau","pique","trèfle"};

            int index = 0;

            for (int typesCarte = 0; typesCarte < 4; typesCarte++)
            {
                Cartes[index] = string.Format("As de {0}", typesCartes[typesCarte]);
                index++;

                for(int i = 2; i<11; i++)
                {
                    Cartes[index] = string.Format("{0} de {1}", i, typesCartes[typesCarte]);
                    index++;
                }
                Cartes[index] = string.Format("valet de {0}", typesCartes[typesCarte]);
                index++;

                Cartes[index] = string.Format("dame de {0}", typesCartes[typesCarte]);
                index++;

                Cartes[index] = string.Format("roi de {0}", typesCartes[typesCarte]);
                index++;
            }

            string[] CartesBrassees = new string[52];

            Random rnd = new Random();

            for (int i = 0; i < 52; i++)
            {
                bool cartePlacee = false;
                while(!cartePlacee)
                {
                    int j = rnd.Next(0, 52);
                    if(CartesBrassees[j] == null)
                    {
                        CartesBrassees[j] = Cartes[i];
                        cartePlacee = true;
                    }
                }
            }

                for (int i = 0; i < 52; i++)
                {
                    Console.WriteLine(CartesBrassees[i]);
                    Console.ReadLine();
                }
        }
    }
}
