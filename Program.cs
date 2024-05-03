using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text.RegularExpressions;
using System;
using System.Security.Cryptography.X509Certificates;

namespace csharp_abstract_animals
{
    internal class Program
    {
        static void Main(string[] args)
        {




            /**Esercizio 1 : classi astratte**
            Dobbiamo realizzare un programma che rappresenti il regno animale.
            Creiamo quindi una classe astratta Animale e delle classi che la estendono : Cane, Passerotto, Aquila, Delfino
            Vogliamo che gli animali abbiano i seguenti metodi
            - void Dormi()(mostra a video “Zzz”)
            - void Verso()(mostra a video il verso fatto dall'animale specifico)
            - void Mangia()(mostra a video quello che mangia: erba, carne, ...?)
            Quali di questi metodi devono essere implementati nella classe astratta e quali devono essere lasciati astratti e implementati dalle classi che la estendono ?
            Una volta create le classi, nel programma istanziare alcuni animali e utilizzare i metodi implementati.*/

            Console.WriteLine("istanzio qualche animale");


            List<Animale> animali = new List<Animale>{
                new Aquila(),
                new Cane(),
                new Delfino(),
                new Passerotto()


            };


            foreach (Animale animale in animali)
            {
                Console.WriteLine($"{animale.GetType().Name}");
                Console.WriteLine("\nil verso che fa è:\n ");
                animale.Verso();
                Console.WriteLine("\ne mangia:\n");
                animale.Mangia();
                Console.WriteLine("\n***************************** \n \n");
            }


            /*
               **Esercizio 2 : interfacce**
               Alcuni degli animali che abbiamo creato volano, altri nuotano.
               Gli animali che volano hanno il seguente metodo :
               - void Vola() (mostra a video “Sto volando!!!”)
               Gli animali che nuotano hanno il seguente metodo :
               - void Nuota() (mostra a video “Sto nuotando!!!”)
               Scrivere un programma avente 2 metodi :
               - void FaiVolare(IVolante animale)
               - void FaiNuotare(INuotante animale)
               Questi metodi prendono come parametro un animale che può o volare / nuotare e richiamano il corrispondente metodo Vola() / Nuota().
               Scrivere un programma che istanzi animali che volano o nuotano e richiamare i metodi FaiVolare / FaiNuotare passandoglieli come parametro.*/

            Console.WriteLine("istanzio qu" +
                "alche animale");
            List<Animale> animali2 = new List<Animale>{
                new Aquila(),
                new Cane(),
                new Delfino(),
                new Passerotto(),
                new Passerotto()

            };




            foreach (Animale animale in animali2)
            {
                Console.WriteLine($"\n{animale.GetType().Name} dice :" );
                if (animale is IVolante) //controllo l'interfaccia
                {
                    FaiVolare((IVolante)animale);
                }else if (animale is INuotante)
                {
                    FaiNuotare((INuotante)animale);
                }else
                {
                    Console.WriteLine("eh io non volo ne nuoto...Mi metterò a dormire..");
                    animale.Dormi();
                }

                

            }




            //funzioni per far volare e per far nuotare
            void FaiNuotare(INuotante elem)
            {
                elem.Nuota();

            }

            void FaiVolare(IVolante elem)
            {
                elem.Vola();

            }
        }
    }
}
