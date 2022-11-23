namespace asdasdasd
{
    internal class Program
    {
        static int[] emberek = new int[18];
        static double[] Uthossz = new double[18];
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Beugro1();
            Beugro2();
            Feladat1();
            Feladat2();
            Feladat3();
            Feladat4();
            Feladat5();
            Feladat6();
            Feladat7();
            Feladat8();
            Feladat9();
        }

        static void Feladat9()
        {
            Console.WriteLine("\n9. Feladat: ");
            int db = 0;
            double CelUt = 0;
            while (CelUt < 305)
            {
                CelUt += Uthossz[db];
                db++;
            }
            Console.WriteLine($"A célmagassághoz ennyi nap kell minimum: {db}. Út hossza: {CelUt}");
        }

        static void Feladat8()
        {
            Console.WriteLine("\n8. Feladat: ");
            int CsereDolgozo;
            double CsereUthossz;
            for (int i = 0; i < Uthossz.Length; i++)
            {
                for (int j = 0; j < Uthossz.Length-1; j++)
                {
                    if (Uthossz[j]>Uthossz[j+1])
                    {
                        CsereUthossz= Uthossz[j];
                        CsereDolgozo= emberek[j];
                        Uthossz[j]=Uthossz[j + 1];
                        emberek[j]=emberek[j + 1];
                        Uthossz[j + 1]=CsereUthossz;
                        emberek[j + 1]=CsereDolgozo;
                    }
                }
            }
            for (int i = 0; i< 18; i++)
            {
                Console.WriteLine($"{i+1}. nap -> Dolgozó száma: {emberek[i]}, Úthossza: {Uthossz[i]}");
            }
        }

        static void Feladat7()
        {
            Console.WriteLine("\n7. Feladat: ");
            bool VanE = false;
            Console.WriteLine($"Kérem adjon meg egy számot 8 és 12 között");
            int KeresSzam = int.Parse(Console.ReadLine()!);
            for (int i = 0; i<emberek.Length; i++)
            {
                if (KeresSzam==emberek[i])
                {
                    VanE=true;
                    break;
                }
            }
            if (VanE==true) { Console.WriteLine("Igen volt ilyen nap"); }
            else { Console.WriteLine("Nem,  nem volt ilyen nap"); }
        }

        private static void Feladat6()
        {
            Console.WriteLine("\n6. Feladat: ");
            int db65 = 0;
            for (int i = 0; i<Uthossz.Length; i++)
            {
                if (db65<Uthossz[i])
                {
                    db65++;
                }
            }
            Console.WriteLine($"{db65} alkalommal volt 65 méter feletti");
        }

        private static void Feladat5()
        {
            Console.WriteLine("\n5. Feladat:(Nem kötelező feladat) ");
            int MinDolgozok = int.MaxValue;
            int MinHely = 0;
            for (int i = 0; i<emberek.Length; i++)
            {
                if (MinDolgozok>emberek[i])
                {
                    MinDolgozok=emberek[i];
                }
            }
            Console.WriteLine($"Min dolgozók száma: {MinDolgozok}");
        }

        static void Feladat4()
        {
            Console.WriteLine("\n4. Feladat: ");
            double MaxHossz = double.MinValue;
            int MaxHely = 0;
            int DolgozokSzama = 0;
            for (int i = 0; i<Uthossz.Length; i++)
            {
                if (MaxHossz<Uthossz[i])
                {
                    MaxHossz= Uthossz[i];
                    DolgozokSzama=emberek[i];
                }
            }
            Console.WriteLine($"Max út hossza: {MaxHossz}, dolgozók száma: {DolgozokSzama}");
        }
        static void Feladat3()
        {
            Console.WriteLine();
            int eszam = 0;
            double uszam = 0;
            for(int i=0;i<emberek.Length;i++)
            {
                eszam+= emberek[i];
                uszam+= Uthossz[i];
            }
            int eosszeg = eszam/emberek.Length;
            double uosszeg = (double)uszam/Uthossz.Length;
            Console.WriteLine($"18 nap alatt átlagos dolgozók: {eosszeg} és az átlagosan megépített úthossz: {uosszeg:0.00}");
        }

        static void Feladat2()
        {
            Console.WriteLine();
            for(int i=0;i<18;i++)
            {
                Console.WriteLine($"{i+1}.nap -> dolgozók száma: {emberek[i]} -> {Uthossz[i]:0.00}");
            }
        }

        static void Feladat1()
        {
            for(int i = 0; i< emberek.Length; i++)
            {
                emberek[i]=rnd.Next(8, 12);
                Uthossz[i]=rnd.Next(5055, 7555)/100.00;
            }
        }

        static void Beugro1()
        {
            int[] FeltoltTMB = { 23, 52, 62, 42, 73, 45, 32, 25, 36, 58, 39, 42, 12, 40 };
            int CsereSzam;
            for (int i = 0; i<FeltoltTMB.Length; i++)
            {
                for (int j = 0; j<FeltoltTMB.Length-1; j++)
                {
                    if (FeltoltTMB[i]<FeltoltTMB[j+1])
                    {
                        CsereSzam = FeltoltTMB[j];
                        FeltoltTMB[j] = FeltoltTMB[j + 1];
                        FeltoltTMB[j + 1] = CsereSzam;
                    }
                }
            }
            for (int i = 0; i<FeltoltTMB.Length; i++)
            {
                Console.Write($"{FeltoltTMB[i]}, ");
            }
        }

        static void Beugro2()
        {
            int[] RandomSzamTMB = new int[12];
            int generalt;
            int csere;
            int asd = 0;
            while (asd < 12)
            {
                generalt= rnd.Next(100, 300);

                if (generalt % 8 ==0)
                {
                    RandomSzamTMB[asd] = generalt;
                    asd++;
                }

            }
            for (int i = 0; i<RandomSzamTMB.Length; i++)
            {
                for (int j = 0; j<RandomSzamTMB.Length-1; j++)
                {
                    if (RandomSzamTMB[j] < RandomSzamTMB[j + 1])
                    {
                        csere = RandomSzamTMB[j];
                        RandomSzamTMB[j] = RandomSzamTMB[j + 1];
                        RandomSzamTMB[j + 1] = csere;
                    }
                }
            }
            int szamlalo = 0;

            Console.WriteLine("\n");

            for (int i = 0; i<RandomSzamTMB.Length; i++)
            {
                if (szamlalo < 8)
                {
                    Console.Write($"{RandomSzamTMB[i]}; ");

                }
                else
                {
                    Console.WriteLine();
                    Console.Write($"{RandomSzamTMB[i]}; ");
                    szamlalo=0;
                }
                szamlalo++;
            }
        }
    }
}