using System;

namespace BlackJackGame.Models
{
    public class Card
    {
        #region Propreties
        public FaceValue FaceValue { get; set; }
        public Suit Suit { get; }
        #endregion

        #region Constructor
        public Card(Suit suit, FaceValue faceValue)
        {
            this.FaceValue = faceValue;
            this.Suit = suit;
        }
        #endregion
    }
}
