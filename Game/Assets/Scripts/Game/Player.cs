using UnityEngine;
using System.Collections;

/// <summary>
/// This class holds the information of the Player and is useable by the Game to perform actions.
/// This inherits from GamePiece.
/// </summary>
public class Player : GamePiece {
    private int maxhealth;
    private bool isHuman;
    private int maxMana;
    private int currentMana;
    private int remainingMana;

    public GameCard[] hand = new GameCard[6];

    public void UseMana(int cost) {
        if(remainingMana >= cost)
            remainingMana -= cost;
    }

    public bool CheckMana(int cost) {
        if(remainingMana >= cost)
            return true;
        return false;
    }

    public void GainMana(int value) {
    	if(remainingMana + value <= currentMana){
    		remainingMana += value;
    	} else {
    		remainingMana = currentMana;
    	}
    }

    public void StartTurnMana() {
    	if (currentMana < maxMana){
    		currentMana += 1;
    	}
    	remainingMana = currentMana;
    }

	public void StartTurnCardCoolDown() {
		foreach (GameCard gc in hand){
			gc.ModifyCurrentCooldown(-1);
		}
	}
}
