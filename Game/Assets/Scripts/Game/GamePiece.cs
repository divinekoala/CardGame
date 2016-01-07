using UnityEngine;
using System.Collections;

/// <summary>
/// This is part of a wrapper class for cards while they are in play.
/// This is the base class for all Cards on the board.
/// Provides values that are required by all Cards on the board.
/// </summary>
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