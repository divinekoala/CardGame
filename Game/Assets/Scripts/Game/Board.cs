using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// This class is the board, where players will play copies of cards from their hand.
/// This also holds the Players's Characters (aka the Player)
/// </summary>
public class Board {

	private Player player1;
	private Player player2;
    private List<GameCard> player1Board;
    private List<GameCard> player2Board;

    public Board() {
        player1Board = new List<GameCard>();
        player2Board = new List<GameCard>();
		player1 = new Player();
		player2 = new Player();
    }

	public List<GameCard> GetPlayer1Board () {
   		return player1Board;
	}

	public Player GetPlayer1 () {
		return player1;
	}

	public Player GetPlayer2 () {
		return player2;
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
