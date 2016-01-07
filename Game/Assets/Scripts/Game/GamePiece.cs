using UnityEngine;
using System.Collections;

public abstract class GamePiece {

    private int currentAttack;
    private int currentHealth;

    public int GetCurrentAttack() {
    	return currentAttack;
    }

	public void ModifyCurrentAttack(int value){
    	currentAttack += value;
    }

    public void SetCurrentAttack(int value) {
    	currentAttack = value;
    }

    public int GetCurrentHealth () {
    	return currentHealth;
    }

	public void ModifyCurrentHealth(int value) {
    	currentHealth += value;
    }

    public void SetCurrentHealth(int value) {
    	currentHealth = value;
    }
}