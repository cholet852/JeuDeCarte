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
                switch (i)
                {
                    case 0: { Cartes[i] = "As de Coeur"; }
                        break;
                    case 10: { Cartes[i] = "Valet de Coeur"; }
                        break;
                    case 11: { Cartes[i] = "Dame de Coeur"; }
                        break;
                    case 12: { Cartes[i] = "Roi de Coeur"; }
                        break;
                    default: { Cartes[i] = string.Format("{0} de Coeur", i + 1); }
                        break;
                }
            }

            for (int i = 13; i < 26; i++)
            {
                switch (i)
                {
                    case 13: { Cartes[i] = "As de Carreau"; }
                        break;
                    case 23: { Cartes[i] = "Valet de Carreau"; }
                        break;
                    case 24: { Cartes[i] = "Dame de Carreau"; }
                        break;
                    case 25: { Cartes[i] = "Roi de Carreau"; }
                        break;
                    default: { Cartes[i] = string.Format("{0} de Carreau", i - 12); }
                        break;
                }
            }

            for (int i = 26; i < 39; i++)
            {
                switch (i)
                {
                    case 26: { Cartes[i] = "As de Piques"; }
                        break;
                    case 36: { Cartes[i] = "Valet de Piques"; }
                        break;
                    case 37: { Cartes[i] = "Dame de Piques"; }
                        break;
                    case 38: { Cartes[i] = "Roi de Piques"; }
                        break;
                    default: { Cartes[i] = string.Format("{0} de Piques", i -25); }
                        break;
                }
            }

            for (int i = 39; i < 52; i++)
            {
                switch (i)
                {
                    case 39: { Cartes[i] = "As de Trèfle"; }
                        break;
                    case 49: { Cartes[i] = "Valet de Trèfle"; }
                        break;
                    case 50: { Cartes[i] = "Dame de Trèfles"; }
                        break;
                    case 51: { Cartes[i] = "Roi de Trèfle"; }
                        break;
                    default: { Cartes[i] = string.Format("{0} de Trèfle", i - 38); }
                        break;
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
