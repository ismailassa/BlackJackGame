using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackGame.Models
{
    public class Card
    {
        #region Propreties
        public bool FacuUp { get; set; }
        public int Value { get; }
        #endregion

        #region Constructor
        public Card(Suit suit, FaceValue faceValue)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
