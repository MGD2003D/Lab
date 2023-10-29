namespace OOP_ICT.Models
{
    public class Dealer
    {
        private CardDeck deck;

        // Эксклюзивное право на создание колоды
        public Dealer()
        {
            deck = new CardDeck();
            PerfectShuffle();
        }

        // Реализация алгоритма Perfect Shuffle (пока пустая)
        private void PerfectShuffle()
        {
                List<Card> tempDeck = new List<Card>();
                int half = deck.Cards.Count / 2;

                for (int i = 0; i < half; i++)
                {
                    tempDeck.Add(deck.Cards[i + half]);
                    tempDeck.Add(deck.Cards[i]);
                }

    deck.SetCards(tempDeck);

        }

        // Метод, который предоставляет карту сверху из колоды
        public Card DealCard()
        {
            return deck.DrawCard();
        }

        // Метод для получения текущего состояния колоды (без возможности модификации)
        public string ShowDeck()
        {
            return deck.ToString();
        }
    }
}
