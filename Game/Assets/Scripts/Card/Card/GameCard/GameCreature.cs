using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// Wrapper class for creature cards when they are on the field.
/// This inherits from GameCard for the composition and uses the AttackAndHealth interface so it has all modifying behaviours necessary
/// </summary>
public class GameCreature : GameCard, AttackAndHealth {

	private int currentAttack;
	private int currentHealth;

	public void DoAttack () {
		//ToDo
	}

	public void TakeAttack () {
		//ToDo
	}

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
