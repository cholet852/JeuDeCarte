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

            for (int i = 0; i < 13; i++)
            {
                if (i ==0)
                {
                    Cartes[i] = "As de Coeur";
                }
                else if (i == 10)
                {
                    Cartes[i] = "Valet de Coeur";
                }
                else if (i == 11)
                {
                    Cartes[i] = "Dame de Coeur";
                }
                else if (i == 12)
                {
                    Cartes[i] = "Roi de Coeur";
                }
                else
                {
                    Cartes[i] = string.Format("{0} de Coeur", i + 1);
                }
            }

            for (int i = 13; i < 26; i++)
            {
                if (i == 13)
                {
                    Cartes[i] = "As de Carreau";
                }
                else if (i == 23)
                {
                    Cartes[i] = "Valet de Carreau";
                }
                else if (i == 24)
                {
                    Cartes[i] = "Dame de Carreau";
                }
                else if (i == 25)
                {
                    Cartes[i] = "Roi de Carreau";
                }
                else
                {
                    Cartes[i] = string.Format("{0} de Carreau", i - 12);
                }
            }

            for (int i = 26; i < 39; i++)
            {
                if (i == 26)
                {
                    Cartes[i] = "As de Piques";
                }
                else if (i == 36)
                {
                    Cartes[i] = "Valet de Piques";
                }
                else if (i == 37)
                {
                    Cartes[i] = "Dame de Piques";
                }
                else if (i == 38)
                {
                    Cartes[i] = "Roi de Piques";
                }
                else
                {
                    Cartes[i] = string.Format("{0} de Piques", i - 25);
                }
            }

            for (int i = 39; i < 52; i++)
            {
                if (i == 39)
                {
                    Cartes[i] = "As de Trèfle";
                }
                else if (i == 49)
                {
                    Cartes[i] = "Valet de Trèfle";
                }
                else if (i == 50)
                {
                    Cartes[i] = "Dame de Trèfle";
                }
                else if (i == 51)
                {
                    Cartes[i] = "Roi de Trèfle";
                }
                else
                {
                    Cartes[i] = string.Format("{0} de Trèfle", i - 38);
                }
            }

            for (int i = 0 ; i < 52 ; i++ )
            {
                Console.WriteLine(Cartes[i]);
                Console.ReadLine();
            }
        }
    
    
    }
}
