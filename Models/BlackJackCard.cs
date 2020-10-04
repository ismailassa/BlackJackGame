using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackGame.Models
{
    public class BlackJackCard : Card
    {

        private List<BlackJackCard> _cards;

        #region Propreties
        public bool FaceUp { get; set; }
        public int Value { get; }
        #endregion

        #region Constructor
        public BlackJackCard(Suit suit, FaceValue faceValue) : base(suit, faceValue)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Methodes
        public void TurnCard()
        {

        } 
        #endregion

    }
}
