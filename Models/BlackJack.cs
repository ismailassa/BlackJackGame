using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackGame.Models
{
    public class BlackJack
    {

        private Deck _deck;
        public bool FaceDown;
        public bool FaceUp;


        public GameState GameState { get; set; }
        public Hand PlayerHand { get; set; }
        public Hand DealerHand { get; set; }

        public void AddCardToHand(Hand hand, bool faceUp)
        {
            throw new NotImplementedException();
        }

        public void AdjustGameState(GameState? gameState = null) 
        {
            throw new NotImplementedException();
        }

        #region Constructor
        public BlackJack()
        {

        }

        public BlackJack(Deck deck)
        {

        } 
        #endregion

        #region Methodes
        public void Deal()
        {

        }

        public String GameSummary()
        {
            throw new NotImplementedException();
        }

        public void GivePlayerAnotherCard()
        {
            throw new NotImplementedException();
        }

        public void LetDealerFinalize()
        {
            throw new NotImplementedException();
        }

        public void PassToDealer()
        {
            throw new NotImplementedException();
        } 
        #endregion

    }
}
