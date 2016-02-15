using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pendu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quel est le mot à faire découvrir");
            String secret = Console.ReadLine();


            string[] decouverte = new string[secret.Length];
           


            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Quel est la lettre que vous proposez?");
                char caract = Convert.ToChar(Console.ReadLine());

                if (secret.IndexOf(caract) != 0)
                {


                }
                else
                {
                    Console.WriteLine("lettre déjà proposée");

                }

                decouverte = recherche(secret, caract, decouverte);

                // Console.WriteLine(decouverte);
                //String resultat="" ;


                //for (int k = 0; k < decouverte.Length; k++)
                //{
                //    resultat = resultat + (decouverte[k]);

                //}

                //Console.Write(resultat);


            }

        }
        static string[] recherche(string abc, char lettre, string[] result)
        {
            //string presence="solution: ";
            int j = 0;

            while (j < abc.Length)
            {
                if (abc[j] == lettre)
                {
                    //presence = presence + lettre;
                    result[j] = Convert.ToString(lettre);

                }
                else
                {
                    result[j] = "_";
                }
                // Console.WriteLine(result[j]);
                j++;
            }
            return result;
        }
    }
}
