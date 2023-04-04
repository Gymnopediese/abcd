//J'ai utilisé visual studio 2019 avec l'extention c#, voici le code en question si le fichier ne marche toujour pas : 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abcdcare
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;
            double c = 0;
            double d = 0;
            double gauche = (a * a) + (b * b);
            double droite = (c * c) + (d * d);

            //tous les inconnues a,b,c,d commence avec la valeur 0.
            //le code prend l'inconnue a et lui ajoute 1 perpétuellement.
            //ainsi à chaque fois que la valeur a atteint la valeur maximal souhaité(ici 100), il repart a 0 et ajoute 1 à l'inconnue b, quand b atteint 100 il ajoute 1 à c et quand c atteint 100 il ajoute 1 a d.
            //ceci nous permet d'obtenir toutes les combinaisons possible de nombre.
            //l'inconnue "gauche" est égale à : a^3 + b^3 et l'inconnue "droite" est égale à : c^3 + d^3.
            //nous cherchons à ce que gauche soit égale à droite, ainsi a chaque fois que ces deux variable sont égales le programme affiche la valeur de a,b,c,d necessaire et le resultat de gauche et droite.
            
            while (a <= 100) //insérer à la place de 100 la valeur la plus haute des inconnues a,b,c,d désiré.
            {
                a++;
                gauche = (a * a) + (b * b);
                droite = (c * c) + (d * d);
                  if (a == 100)//insérer à la place de 100 la valeur la plus haute des inconnues a,b,c,d désiré.
                {
                    b++;
                    a = 0;
                }
                if (b == 100)//insérer à la place de 100 la valeur la plus haute des inconnues a,b,c,d désiré.
                {
                    c++;
                    b = 0;
                }
                if (c == 100)//insérer à la place de 100 la valeur la plus haute des inconnues a,b,c,d désiré.
                {
                    d++;
                    c = 0;
                }
                if (gauche == droite && a != b && a != c && a != d && b != c && b != d && c != d && a != 0 && b != 0 && c != 0 && d != 0) //ici le code empeche que les nombre a b c d soit egaux entre eux ou bien egaux a 0.
                {
                    Console.WriteLine("a = " + a + ", b = " + b + ", ce qui fait " + gauche + " et c = " + c + ", d = " + d + ", ce qui fait " + droite);
                    Console.WriteLine();
                }

            }
         
            Console.ReadLine();

        }
    }
}

