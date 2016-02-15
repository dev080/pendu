using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pendu2
{
    class Program
    {
        static void Main(string[] args)
        {

            string essai = "";


            Console.WriteLine("Quel est le mot à faire découvrir");  //enregistrement du mot secret
            String secret = Console.ReadLine();


            string[] decouverte2 = new string[secret.Length];
            for (int i = 0; i < secret.Length; i++)  //  
            {
                decouverte2[i] = "_";
            }



            int fault = 10;
            int gagne = 0;

            while (fault > 0 && gagne<secret.Length)
            {

                Console.WriteLine(fault + " chances");
                Console.WriteLine("Quelle est la lettre que vous proposez?");
                char caract = Convert.ToChar(Console.ReadLine());

                if (essai.IndexOf(caract) != -1)
                {
                    Console.WriteLine("lettre déjà proposée");
                }
                else
                {
                    essai = essai + caract;

                    if (secret.IndexOf(caract) == -1)
                    {
                        Console.WriteLine(caract + " n'est pas présent");
                        fault--;

                    }
                    else
                    {
                        //Console.WriteLine("passage découverte");
                        decouverte2 = recherche(secret, essai, decouverte2);
                    }

                }
               
                gagne = 0;
                for (int k = 0; k < decouverte2.Length; k++)
                {
                    Console.Write(decouverte2[k]);
                    if (secret[k] == Convert.ToChar(decouverte2[k]))
                    {
                        gagne++;

                    }


                }
                Console.WriteLine();
               
            }
            if (fault == 0)
            {

                Console.WriteLine("vous avez perdu");
            }
            else
            {
                Console.WriteLine("vous avez gagné");
            }
            Console.ReadKey();

        }



        static string[] recherche(string secret, string essai2, string[] result)
        {


            for (int i = 0; i < secret.Length; i++)
            {
                for (int j = 0; j < essai2.Length; j++)
                {
                    if (secret[i] == essai2[j])
                    {
                        result[i] = Convert.ToString(secret[i]);

                    }

                }
            }
            return result;
        }
    }
}
