namespace asdasdasd
{
    internal class Program
    {
        static int[] emberek = new int[12];
        static double[] Uthossz= new double[12];
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Beugro();
        }

        static void Beugro()
        {
            int[] RandomSzamTMB = new int[12];
            int generalt;
            int csere;
            int asd = 0;
            while(asd < 12)
            {
                generalt= rnd.Next(100,300);
                
                    if(generalt % 8 ==0)
                    {
                        RandomSzamTMB[asd] = generalt;
                        asd++;
                    }
                
            }
            for(int i = 0; i<RandomSzamTMB.Length; i++)
            {
                for(int j = 0; j<RandomSzamTMB.Length-1; j++)
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
            for(int i = 0;i<RandomSzamTMB.Length; i++)
            {
                if (szamlalo < 8)
                {
                    Console.Write($"{RandomSzamTMB[i]}; ");
                    
                }
                else
                {
                    Console.WriteLine("");
                    Console.Write($"{RandomSzamTMB[i]}; ");
                    szamlalo=0;
                }
                szamlalo++;
            }
        }
    }


}