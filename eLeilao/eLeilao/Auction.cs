using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLeilao
{
    public class Auction
    {
        public string Description { get; set; }
        public IList<Offer> Offers { get; set; }

        public Auction(string description)
        {
            this.Description = description;
            this.Offers = new List<Offer>();
        }

        public void Proposal(Offer offer)
        {
            Offers.Add(offer);
        }
    }
}
