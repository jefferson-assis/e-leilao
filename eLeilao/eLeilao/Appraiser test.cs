using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLeilao
{
    class Appraiser_test
    {
        static void Main(string[] args)
        {
            User Davi = new User("Davi");// Criar os usuarios
            User JonatasFlash = new User("JonatasFlash");
            User Isaque = new User("Isaque");

            Auction auction = new Auction("Cubo do Matheus"); // Alimentar com os valores
            auction.Proposal(new Offer(Davi, 280.0));
            auction.Proposal(new Offer(JonatasFlash, 400.0));
            auction.Proposal(new Offer(Isaque, 500.0));
                Evaluator auctioneer = new Evaluator();
                auctioneer.Evaluation(auction);

                Console.WriteLine(auctioneer.MaxValue); //Mostra o console da tela os valores
                Console.WriteLine(auctioneer.MinValue);

                Console.ReadLine();
        }
    }
}
