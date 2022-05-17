using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PlayerRandomNum;
            int AiRandomNum;

            int playerponits = 0;
            int aipoints = 0;

            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("zar atmak için herhangi bir tuşa basın");
                Console.ReadKey();

                PlayerRandomNum = random.Next(1, 20);
                Console.WriteLine(PlayerRandomNum + " Attın kardeş");

                Console.WriteLine("....");
                System.Threading.Thread.Sleep(1000);

                AiRandomNum = random.Next(1, 20);
                Console.WriteLine("Ai {0} attı kardeş", AiRandomNum);

                if (PlayerRandomNum > AiRandomNum)
                {
                    playerponits++;
                    Console.WriteLine("KAZANDIN GARDAŞ");
                    Console.ReadKey();
                }
                else if (PlayerRandomNum < AiRandomNum)
                {
                    aipoints++;
                    Console.WriteLine("ELİNE ALDIN GARDAŞ");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("BERABERLİK UNLUCKY");
                    Console.ReadKey();
                }
                Console.WriteLine("Puanın gardaş:" + playerponits + "  --- Ai puanı:" + aipoints);
            }
            if (playerponits > aipoints)
            {
                Console.WriteLine("\nKazandın lan tirrek helal");
                Console.ReadKey();
            }
            else if (playerponits < aipoints)
            {
                Console.WriteLine("\nKaybettin kardeşim ağlayabilirsin");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\nNasıl başardıysan berabere yeteneksiz");
                Console.ReadKey();
            }
            }
    }
}
