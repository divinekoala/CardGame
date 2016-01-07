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

	public void StartTurn(){
		Player cp = CurrentPlayer();
		cp.StartTurnCardCoolDown();
		cp.StartTurnMana();
		turnHandler.NextPhase();
	}

	public void PlayCard(GameCard card) {
		Player cp = CurrentPlayer();
		if(cp.CheckMana(card.GetCurrentManaCost())){
			if (card.GetCardEffect().Count > 0){
				//Do Effect
				List<Effect> effList = new List<Effect>();
				foreach (CardEffectName cen in card.GetCardEffect()) {
					Effect eff = EffectDictionary.effects[cen];
					effList.Add(eff);
				}
				//Get Targety stuff

			} else
				PutCardOnField(card, cp);
		}
	}

	public void PutCardOnField (GameCard card, Player currentPlayer) {
		currentPlayer.UseMana(card.GetCurrentManaCost());
		board.AddCardToPlayer(card, turnHandler.GetIsPlayer1Turn());
		card.GoOnCooldown();
	}


}
