using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//opis
//GUI program, pritiskom na tipku,jednu ili dvije karte od 54, samo jednom se moze izvuci jedna karta
// U2660 U2663 U2665 U2666 ili cards.dll
namespace CSHseminar
{
    public class Card
    {
        private string broj;
        private string simbol;

        public Card (string kartaBroj, string kartaSimbol)
        {
            broj = kartaBroj;
            simbol = kartaSimbol;
        }

        public override string ToString()
        {
            
            return broj + " " + simbol;

        }

        public string Rez()
        {
            return broj + " " + simbol;
        }
    }
}
