using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackGame.Models
{
    public class BlackJackCard : Card
    {

        #region Propreties
        public bool FaceUp { get; set; }
        public int Value { get; }
        #endregion

        #region Constructor
        public BlackJackCard(Suit suit, FaceValue faceValue) : base(suit,faceValue)
        {
            this.FaceUp = false;
            this.Value = FaceUp ? (int)faceValue : 0;
        }
        #endregion

        #region Methodes
        public void TurnCard()
        {
            this.FaceUp = true;
        } 
        #endregion

    }
}
