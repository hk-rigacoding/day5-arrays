using System;

namespace day5_arrays
{
    class Program
    {




        static void Main(string[] args)
        {

            //uzdodam vērtības
            int[] skaitlju_masiivs = {1,2,3,4,5 };

            //skaitlju_masiivs.Length;

            //int tipa masīvs ar izmēru [3456]
            int[] skaitlju_masiivs1 = new int[3456];

            //bool tipa masīvs
            bool[] bool_masiivs1 = new bool[10];

            //Boolean[] bool_masiivs2 = new Boolean[10];



            //klase Boolean, lietojam bool !!!
            //Boolean b1 = true;
            //bool b2 = true;



            //piešķiram vērtībbool_masiivs1u
            skaitlju_masiivs1[0] = 8;
            skaitlju_masiivs1[1] = 5;
            skaitlju_masiivs1[2] = 5;
            skaitlju_masiivs1[3] = 5;
            skaitlju_masiivs1[4] = 5;
            skaitlju_masiivs1[5] = 5;
            skaitlju_masiivs1[6] = 5;


            //nolasam vērtību
            int sk = skaitlju_masiivs1[0];



            //reference uz masīvu
            //kad ņemam mas2[1], tad patiesībā ņemam skaitlju_masiivs1[1]
            int[] mas2 = skaitlju_masiivs1;

            skaitlju_masiivs1[1] = 3;
            mas2[1] = 5;

            //datu kopija
            //int[] mas3 = (int[])skaitlju_masiivs1.Clone();

            int[] mas3 = new int[skaitlju_masiivs1.Length];



            int[] iisaaks = { 9, 8, 7 };

            //int i = 0;
            //foreach (int elements in skaitlju_masiivs1)
            //  mas3[i++] = elements;

            //kopija
            //raksta pa virsu datiem !
            //skaitlju_masiivs1.CopyTo(mas3, 0);


            //iisaaks.CopyTo(skaitlju_masiivs1,0);


            //uz kuru masīvu kopēt un sākot destinācijas ar [indeksu]
            iisaaks.CopyTo(skaitlju_masiivs1, 10);



            //datu kopija
            int[] mas5 = (int[])skaitlju_masiivs1.Clone();




            skaitlju_masiivs1[2] = 33;

            //klase darbībām ar masīviem
            Array.Sort(skaitlju_masiivs1);

            //
            Array.Reverse(skaitlju_masiivs1);


            //1. izveidojiet skaitļu masīvu ar izmēru jūsu dz. gads
            //2. piešķiriet vērtības augošā secībā ciklā
            //3. Reversēt un sakārtot


            //kods1
            /*
            int[] dz_gada_masivs = new int[2002];

            for (int i = 0; i < dz_gada_masivs.Length; i++)
            {
                dz_gada_masivs[i] = i;
            }

            Array.Reverse(dz_gada_masivs);
            foreach (var item in dz_gada_masivs)
            {
                Console.WriteLine(item);
            }

            Array.Sort(dz_gada_masivs);
            foreach (var item in dz_gada_masivs)
            {
                Console.WriteLine(item);
            }
            */


            //kods2
            /*
            int[] mas = new int[2003];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = i;

            }
            Array.Sort(mas);
            foreach (var item in mas)
            {
                Console.WriteLine(mas);
            }
            Array.Reverse(mas);
            foreach (var item in mas)
            {
                Console.WriteLine(mas);
            }
            */


            //kā mainīt izmērus masīviem ???
            int[] iisaaks_2 = { 3, 4, 5 };

            //pievienot vēlvienu elementu masīvam iisaaks_2 ?!
            int[] iisaaks_3 = new int[iisaaks_2.Length + 1];
            iisaaks_2.CopyTo(iisaaks_3, 0);

            //kā nodot masīvus metodēm ???

            int[] mas = new int[2003];

            //metodēm nododam referenci uz masīvu
           // Apstraade(mas);
           // Izvade(mas);


            //inicializē masīvu
            Array.Clear(mas, 0, mas.Length);


            //ievadīt masīva izmēru

 


            /*
            int izm = 0;
            while (izm == 0)
            {
                try
                {
                    Console.WriteLine("Ievadi izmēru ...");
                    string izm_str = Console.ReadLine();
                    izm = Int32.Parse(izm_str);
                    //kods
                    //kods
                    //kods
                }
                catch (Exception e)
                {
                    Console.WriteLine("Kļūdains izmērs, ievadi skaitli vēlreiz ...");
                    izm = 0;
                    //Console.WriteLine(e.Message);
                    //izm = 5;
                    //kods bla bla
                }
            }

            Console.WriteLine("Masīva izmērs " + izm);

            string[] nedelja = new string[izm];


            Console.WriteLine("Savadi Datus ...");
            //ciklu, kurā savadam masīvā datus

            //izm
            for (int i = 0; i < nedelja.Length; i++)
                nedelja[i] = Console.ReadLine();


            Izvade(nedelja);
            */


            //ierakstīt 7 temperatūras un izrēķināt vidējo temp


            double[] temperatura = new double[7];

            Console.WriteLine("Ievadi temperatūras ...");

            double avg = 0;

            for (int i = 0; i < temperatura.Length; i++)
            {

                temperatura[i] = temp();
                //avg += temperatura[i] = temp();
                avg += temperatura[i];
            }

            //temperatura satur korektus datus

            Console.WriteLine("Vidējā temp " + avg / temperatura.Length);








            Console.WriteLine("Hello World!");
        }


        static double temp ()
        {
            double ret = 0;

          while (ret == 0)
           try
            {
                Console.WriteLine("Ievadi datus ...");
                string izm_str = Console.ReadLine();
                    ret =  Double.Parse(izm_str);
                //kods
                //kods
                //kods
            }
            catch (Exception e)
            {
                Console.WriteLine("Kļūdaini dati, ievadi skaitli vēlreiz ...");
                    ret = 0;
                //Console.WriteLine(e.Message);
                //izm = 5;
                //kods bla bla
            }


            return ret;
        }

        static void Apstraade (int[] m)
        {
            for (int i = 0; i < m.Length; i++)
                m[i] = i;

        }


        static void Izvade(string[] mas)
        {
            Array.Sort(mas);
            foreach (var item in mas)
            {
                Console.WriteLine(item);
            }
            Array.Reverse(mas);
            foreach (var item in mas)
            {
                Console.WriteLine(item);
            }
        }



        static void Izvade(double[] mas)
        {
            Array.Sort(mas);
            foreach (var item in mas)
            {
                Console.WriteLine(item);
            }
            Array.Reverse(mas);
            foreach (var item in mas)
            {
                Console.WriteLine(item);
            }
        }



        static void Izvade (int[] mas)
        {
            Array.Sort(mas);
            foreach (var item in mas)
            {
                Console.WriteLine(item);
            }
            Array.Reverse(mas);
            foreach (var item in mas)
            {
                Console.WriteLine(item);
            }
        }

    }
}
