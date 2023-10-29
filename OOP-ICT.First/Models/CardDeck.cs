using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_ICT.Models
{
    public class CardDeck
    {
        private List<Card> cards;
        public IReadOnlyList<Card> Cards => cards.AsReadOnly();
        public void SetCards(List<Card> newCards)
        {
            cards = newCards;
        }

        public CardDeck()
        {
            cards = new List<Card>();
            foreach (Card.Suit suit in Enum.GetValues(typeof(Card.Suit)))
            {
                foreach (Card.Rank rank in GetOrderedRanks())
                {
                    cards.Add(new Card(suit, rank));
                }
            }
        }

        private IEnumerable<Card.Rank> GetOrderedRanks()
        {
            return new List<Card.Rank>
            {
                Card.Rank.Ace,
                Card.Rank.King,
                Card.Rank.Queen,
                Card.Rank.Jack,
                Card.Rank.Ten,
                Card.Rank.Nine,
                Card.Rank.Eight,
                Card.Rank.Seven,
                Card.Rank.Six,
                Card.Rank.Five,
                Card.Rank.Four,
                Card.Rank.Three,
                Card.Rank.Two
            };
        }

        public void Shuffle()
        {
            Random rng = new Random();
            cards = cards.OrderBy(x => rng.Next()).ToList();
        }

        public Card DrawCard()
        {
            if (cards.Count == 0) throw new InvalidOperationException("Deck is empty.");

            var drawnCard = cards[0];
            cards.RemoveAt(0);
            return drawnCard;
        }

        public int Count => cards.Count;

        public override string ToString()
        {
            return string.Join(", ", cards);
        }
    }
}
