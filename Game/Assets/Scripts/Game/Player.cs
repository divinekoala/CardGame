using UnityEngine;
using System.Collections;

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
