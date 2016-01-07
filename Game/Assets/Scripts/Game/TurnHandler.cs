using UnityEngine;
using System.Collections;

/// <summary>
/// This class handles the turns, progression through each phase and through the game.
/// This dictates what actions are able to be taken and what player is able to do them.
/// </summary>
public class TurnHandler {

	private int gameTurn;
    private bool player1Turn;
    private TurnPhase currentPhase;

    public int GetTurn (){
    	return gameTurn;
    }

    public bool GetIsPlayer1Turn () {
    	return player1Turn;
    }

    public void ProgressTurn() {
    	if(player1Turn == true){
    		player1Turn = false;
    		currentPhase = TurnPhase.Start;
    		return;
   		}
   		else {
			gameTurn ++;
			player1Turn = true;
			currentPhase = TurnPhase.Start;
   		}
    }

    public TurnPhase GetPhase() {
    	return currentPhase;
    }

    public void NextPhase() {
    	if (currentPhase == TurnPhase.Start)
    		currentPhase = TurnPhase.Main;
    	else if (currentPhase == TurnPhase.Main){
    		currentPhase = TurnPhase.End;
    	}
    }


}
