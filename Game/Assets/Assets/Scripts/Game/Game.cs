using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// This class controls the game.
/// It handles interactions between other classes.
/// </summary>
public class Game : MonoBehaviour {
    private Player player1;
    private Player player2;

    private EffectHandler effectHandler;
	private TurnHandler turnHandler;

	public Game (Player p1, Player p2, EffectHandler effHandle, TurnHandler turnHandle) {

		this.player1 = p1;
		this.player2 = p2;
		this.effectHandler = effHandle;
		this.turnHandler = turnHandle;
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

	// Once validated plays card and passes on the effects
	public void PlayCardFromHand (HandCard card, Player currentPlayer) {
		// Check for Mana / Cooldown
		// Use Mana
		// Remove Card From Players Hand
		// Create the card and Place on board
		// Add effect to EffectHandler

		if (ValidateCardPlay(card, currentPlayer)) {
			currentPlayer.UseMana(card.GetCurrentManaCost());

			currentPlayer.RemoveCardFromHand(card);
			currentPlayer.AddToBoard(CreateCard(card));
		}

	}

	// Checks if player has enough mana and card is not on cooldown
	public bool ValidateCardPlay (HandCard card, Player currentPlayer) {
		if (currentPlayer.CheckMana(card.GetCurrentManaCost()) && card.GetCurrentCooldown() == 0){
			return true;
		} else {
			return false;
		}
	}

	//Creates the GameCard as a GameObject
	public GameCard CreateCard (HandCard card){
		//ToDo
		return new GameCard();
	}

	public void MoveCardToGraveyard (GameCard card, Player currentPlayer) {
		currentPlayer.RemoveFromBoard(card);
		currentPlayer.PutCardInGraveyard(card.card);
	}
		
}
