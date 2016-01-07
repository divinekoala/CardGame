using UnityEngine;
using System.Collections.Generic;

public class Board {

    private List<GameCard> player1Board;
    private List<GameCard> player2Board;

    public Board() {
        player1Board = new List<GameCard>();
        player2Board = new List<GameCard>();
    }

	public List<GameCard> GetPlayer1Board () {
   		return player1Board;
	}

	public List<GameCard> GetPlayer2Board () {
   		return player2Board;
	}

	public void AddCardToPlayer (GameCard card, bool isPlayer1) {
		if(isPlayer1)
   			player1Board.Add(card);
   		else
			player2Board.Add(card);
	}

   	public void RemoveCardFromPlayer (GameCard card, bool isPlayer1) {
   		if (isPlayer1)
   			player1Board.Remove(card);
   		else
   			player2Board.Remove(card);
   	}

}
