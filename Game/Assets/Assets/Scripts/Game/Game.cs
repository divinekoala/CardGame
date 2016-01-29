using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// This class controls the game.
/// It handles interactions between other classes.
/// </summary>
public class Game {
    public Player player1;
	public Player player2;

    private EffectHandler effectHandler;
	private TurnHandler turnHandler;

	public Game (Player p1, Player p2) {

		this.player1 = p1;
		this.player2 = p2;
		this.effectHandler = new EffectHandler();
		this.turnHandler = new TurnHandler();
	}
		

	public Player GetPlayer1 () {
		return player1;
	}

	public Player GetPlayer2 () {
		return player2;
	}

	public Player GetCurrentPlayer() {
		if (turnHandler.GetIsPlayer1Turn())
			return player1;
		else 
			return player2;
	}

	/// <summary>
	/// Starts the turn. and resets mana, cd and untaps cards
	/// </summary>
	public void StartTurn(){
		Player cp = GetCurrentPlayer();
		cp.StartTurnCardCoolDown();
		cp.StartTurnMana();
		turnHandler.NextPhase();
	}

	// Checks if player has enough mana and card is not on cooldown
	public bool ValidateCardPlay (HandCard card, Player currentPlayer) {
		if (currentPlayer.CheckMana(card.GetCurrentManaCost()) && card.GetCurrentCooldown() == 0){
			return true;
		} else {
			return false;
		}
	}

	public void MoveCardToGraveyard (GameCard card, Player currentPlayer) {
		currentPlayer.RemoveFromBoard(card);
		currentPlayer.PutCardInGraveyard(card.GetCard());
	}
		
}
