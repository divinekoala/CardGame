using UnityEngine;
using System.Collections;

public class HandCard : MonoBehaviour {

	private Card card;

	private int currentCooldown;
	private int remainingCooldown;

	private int currentManaCost;

	public HandCard (Card card) {
		this.card = card;
		this.currentCooldown = card.cooldown;
		this.remainingCooldown = card.cooldown;
	}

	public Card Card {
		get {
			return this.card;
		}
	}

	public int GetCurrentCooldown () {
		return currentCooldown;
	}

	public void ModifyCurrentCooldown (int value) {
		currentCooldown += value;
	}

	public void SetCurrentCooldown (int value){
		currentCooldown = value;
	}

	public void GoOnCooldown(){
		remainingCooldown = currentCooldown;
	}

	public void GoOffCooldown() {
		remainingCooldown = 0;
	}

	public int GetCurrentManaCost() {
		return currentManaCost;
	}

	public void ModifyCurrentManaCost (int value) {
		currentManaCost += value;
	}

	public void SetCurrentManaCost (int value) {
		currentManaCost = value;
	}
}
