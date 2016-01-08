using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// This class controls the game.
/// It handles interactions between other classes.
/// </summary>
public class Game {
    private Board board;
    private Player player1;
    private Player player2;

    private EffectHandler effectHandler;
	private TurnHandler turnHandler;

	public Game (Board board, Player p1, Player p2, EffectHandler effHandle, TurnHandler turnHandle) {
		this.board = board;
		this.player1 = p1;
		this.player2 = p2;
		this.effectHandler = effHandle;
		this.turnHandler = turnHandle;
	}

	public Board GetBoard(){
		return board;
	}

	public Player GetPlayer1 () {
		return player1;
	}

	public Player GetPlayer2 () {
		return player2;
	}

	public Player CurrentPlayer() {
		if (turnHandler.GetIsPlayer1Turn())
			return player1;
		else 
			return player2;
	}

	/// <summary>
	/// Starts the turn. and resets mana, cd and untaps cards
	/// </summary>
	public void StartTurn(){
		Player cp = CurrentPlayer();
		cp.StartTurnCardCoolDown();
		cp.StartTurnMana();
		turnHandler.NextPhase();
	}

	/// <summary>
	/// Gets Card, checks to see if it is a valid play
	/// Put the effects in the EffectHandler and Puts the card on the board.
	/// </summary>
	/// <param name="card">Card.</param>
	public void PlayCard(HandCard card) {
		Player cp = CurrentPlayer();
		if(cp.CheckMana(card.GetCurrentManaCost())){
			if (card.Card.cardEffectName.Count > 0){
				foreach (CardEffectName cen in card.Card.cardEffectName) {
					effectHandler.RegisterCardEffect(cen);
				}
			}
				PutCardOnBoard(card, cp);
		}
	}

	//TOFIX
	public void PutCardOnBoard (GameCard card, Player currentPlayer) {
		currentPlayer.UseMana(.GetCurrentManaCost);
		board.AddCardToPlayer(card, turnHandler.GetIsPlayer1Turn());
	}
		
}
