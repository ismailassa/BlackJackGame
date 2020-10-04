using System;

namespace BlackJackGame.Models
{
    public class Card
    {
        #region Propreties
        public FaceValue FaceValue { get; set; }
        public int Suit { get; }
        #endregion

        #region Constructor
        public Card(Suit suit, FaceValue faceValue)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
