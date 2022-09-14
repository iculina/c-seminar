using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHseminar
{
    public class AllCards
    {
        private const int Max = 52;
        //private Random rn;
        public List<Card> deck2 = new List<Card>();

        public Card choosen;


        public AllCards()  
        {
            string[] broj = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            string[] simbol1 = { "Hearts", "Clubs", "Diamonds", "Spades" }; 
            string[] simbol = { "\u2660", "\u2663", "\u2665", "\u2666" };

          
            for (int i = 0; i < 13; i++)
            {
                for (int z = 0; z < 4; z++)
                {
                    deck2.Add(new Card(broj[i], simbol[z]));
                }
            }



        }



        public int CardsLeftNum => deck2.Count;
        
        public string Choose()
        {
            //random pozicija
            Random rn = new Random();
            int positionInDeck = rn.Next(CardsLeftNum);

            Card choosen = deck2[positionInDeck];
            deck2.RemoveAt(positionInDeck);

            

            return choosen.Rez();
            
        }

        


    }

    

}
