using System;

namespace lab3ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Arpsod adoră două lucruri: matematica și clătitele bunicii sale. Într-o zi, aceasta s-a apucat să
            prepare clătite. Arpsod mănâncă toate clătitele începând de la a N-a clătită preparată, până
            la a M-a clătită preparată (inclusiv N și M). Pentru că el vrea să mănânce clătite cu diferite
            umpluturi și-a făcut următoarea regulă:
            - Dacă numărul de ordine al clătitei este prim atunci aceasta va fi cu ciocolată.
            - Dacă numărul de ordine este pătrat perfect sau cub perfect aceasta va fi cu gem.
            - Dacă suma divizorilor numărului este egală cu însuși numărul de ordine atunci aceasta va fi cu
            înghețată. (se iau în considerare toți divizorii în afară de numărul în sine, inclusiv 1).
            - Dacă niciuna dintre condițiile de mai sus nu este îndeplinită, pentru cele cu numărul de ordine
            par, clătita va fi cu zahar, iar pentru numărul de ordine impar, clătita va fi simplă.”
            • Cerința
            - Cunoscându-se N și M, numere naturale, să se determine câte clătite a mâncat Arpsod în total și
            numărul de clătite din fiecare tip. A */

            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int total = 0, ciocolata = 0, gem = 0, inghetata = 0, zahar = 0, simpla = 0 ;
            bool esteZahar = true;

            for(int i=N; i<=M; i++)
            {
                total++;
                if(Prim(i))
                {
                    ciocolata++;
                    esteZahar = false;
                }
                else if(PatratPerfect(i))
                {
                    gem++;
                    esteZahar = false;
                }
                else if(SumaDivizori(i))
                {
                    inghetata++;
                    esteZahar = false;
                }

                if(i%2 == 0 && esteZahar)
                {
                    zahar++;
                }
                else if(i % 2 == 1 && esteZahar)
                {
                    simpla++;
                }
                else
                {
                    zahar = 0;
                    simpla = 0;
                }
            }
            Console.WriteLine("Arpsod a mancat " + total + " de clatite.  " + ciocolata + " au fost cu ciocolata,  " + gem + " au fost cu gem,  "
                + inghetata + " au fost cu inghetata,  " + zahar + " au fost cu zahar si  " + simpla + " au fost simple  ");



            static bool Prim(int numar)
            {
                int div = 0;
                for(int i = 1; i<=numar; i++)
                {
                    if(numar % i == 0)
                    {
                        div++;
                    }
                }
                if(div == 2)
                {
                    return true;
                }
                
                return false;
            }

            static bool PatratPerfect(int numar)
            {
                for (int i = 0; i <= numar; i++)
                {
                    if (i*i == numar || i*i*i == numar)
                    {
                        return true;
                    }
                }
                return false;
            }

            static bool SumaDivizori(int numar)
            {
                int suma = 0;
                for (int i = 1; i < numar; i++)
                {
                    if (numar % i == 0)
                    {
                        suma += i;
                    }
                }
                if(suma == numar)
                {
                    return true;
                }

                return false;
            }

        }
    }
}
