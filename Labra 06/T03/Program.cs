/* Kurssi: TTOS0200 Olio-ohjelmointi
 * Tehtävä: Labra 06 - Tehtävä 3
 * Tekijä: Niia Neuvonen K8863
 * Pvm: 25.1.2017
 * Kuvaus: 
 *          Toteuta ohjelma, joka tallentaa kaikki korttipelin kortit (hertta, ruutu, risti ja pata. Numerot 1-52.) 
 *          valitsemaasi tietorakenteeseen ja tulostaa tietorakenteen sisällön. 
 *          Bonustehtävä: kuinka voisit toteuttaa korttipakan sekoittamisen? */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03
{
    class Card
    {
        public string CardSuite { get; set; }
        public int CardValue { get; set; }
        public string PrintCard()
        { return CardSuite + " " + CardValue; }
        public Card(string cardsuite, int cardvalue)
        { CardSuite = cardsuite; CardValue = cardvalue; }
    }
    class Deck
    {
        public List<Card> Cards = new List<Card>();
        public List<Card> CardPack()
        {
            for (int i = 1; i < 14; i++)
            {
                Cards.Add(new Card("Clubs", i));
            }
            for (int i = 1; i < 14; i++)
            {
                Cards.Add(new Card("Diamonds", i));
            }
            for (int i = 1; i < 14; i++)
            {
                Cards.Add(new Card("Hearts", i));
            }
            for (int i = 1; i < 14; i++)
            {
                Cards.Add(new Card("Spades", i));
            }
            return Cards;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PrintCards();
        }
        static void PrintCards()
        {
            Deck deck = new Deck();
            deck.CardPack();

            Console.WriteLine("Cards in the deck:\n");
            for (int i = 0; i < deck.Cards.Count; i++)
            {
                Console.WriteLine(deck.Cards[i].PrintCard());
            }
        }
    }
}
