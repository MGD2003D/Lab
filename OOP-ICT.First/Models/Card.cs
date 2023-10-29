﻿namespace OOP_ICT.Models
{
    public class Card
    {
        public enum Suit
        {
            Hearts,
            Clubs,
            Diamonds,
            Spades
        }

        public enum Rank
        {
            Ace, 
            Two, 
            Three, 
            Four, 
            Five, 
            Six, 
            Seven, 
            Eight, 
            Nine, 
            Ten, 
            Jack, 
            Queen, 
            King
        }

        public Suit CardSuit { get; set; }
        public Rank CardRank { get; set; }

        public Card(Suit suit, Rank rank)
        {
            CardSuit = suit;
            CardRank = rank;
        }

        public override string ToString()
        {
            return $"{CardRank} of {CardSuit}";
        }
    }
}