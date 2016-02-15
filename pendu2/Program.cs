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

            while (fault > 0)
            {
                Console.WriteLine(fault + " chances");
                Console.WriteLine("Quel est la lettre que vous proposez?");
                char caract = Convert.ToChar(Console.ReadLine());

                if (essai.IndexOf(caract) != -1)
                {
                    Console.WriteLine("lettre déjà proposée");
                }
                else
                {
                    essai = essai + caract;

                    decouverte2 = recherche(secret, essai, decouverte2, ref fault);
                }

                for (int k = 0; k < decouverte2.Length; k++)
                {
                    Console.WriteLine(decouverte2[k]);

                }

            }

        }


        static string[] recherche(string secret, string essai2, string[] result, ref int fault)
        {
            //bool flag = false;

            for (int i = 0; i < secret.Length; i++)
            {
                for (int j = 0; j < essai2.Length; j++)
                {
                    if (secret[i] == essai2[j])
                    {
                        result[i] = Convert.ToString(secret[i]);
                        //flag = true;

                    }

                }
            }



            //if(flag==false)
            //{
            //    fault--;
            //    Console.WriteLine("inconnu");
            //}



            return result;
        }
    }
}
