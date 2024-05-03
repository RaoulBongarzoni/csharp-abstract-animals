using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{

    //calsse astratta del primo esercizio
    public abstract class Animale
    {

        public void Dormi()
        {
            Console.WriteLine("Zzz");
        }

        public abstract void Mangia();


        public abstract void Verso();


    }


    //interfacce del secondo esercizo

    public interface IVolante
    {
        public void Vola();
    }

    public interface INuotante
    {
        public void Nuota();
    }
    //************************


    //classi degli animali *****
    public class Cane : Animale
    {
        public override void Mangia()
        {
            Console.WriteLine("Carne");
        }

        public override void Verso()
        {
            Console.WriteLine("Bau Bau");
        }

    }
    public class Delfino : Animale, INuotante //interfaccia inserita in corrispondenza del secondo esercizio
    {
        public override void Mangia()
        {
            Console.WriteLine("Pesce");
        }

        public override void Verso()
        {
            Console.WriteLine("*Ultrasuoni*");
        }
        
        public void Nuota()//INuotante
        {
            Console.WriteLine("Sto Nuotandooo!!");
        }



    }
    public class Aquila : Animale, IVolante //interfaccia inserita in corrispondenza del secondo esercizio
    {
        public override void Mangia()
        {
            Console.WriteLine("Piccoli roditori");
        }

        public override void Verso()
        {
            Console.WriteLine("*Stride*");
        }

        public void Vola() //IVolante 
        {
            Console.WriteLine("Sto Volandoo!!");
        }

    }
    public class Passerotto : Animale, IVolante //interfaccia inserita in corrispondenza del secondo esercizio
    {
        public override void Mangia()
        {
            Console.WriteLine("Semi e bacche");
        }

        public override void Verso()
        {
            Console.WriteLine("*Cirp Cirp*");
        }
        public void Vola()//IVolante
        {
            Console.WriteLine("Sto Volandoo!!");
        }

    }
}
