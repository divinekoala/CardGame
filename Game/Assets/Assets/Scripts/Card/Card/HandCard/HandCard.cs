using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class HandCard : MonoBehaviour {

	private Card card;

	private int currentCooldown;
	private int remainingCooldown;
	private int currentManaCost;
	private int currentAttack;
	private int currentHealth;

	public Text ManaText;
	public Text CoolDownTxt;

	public HandCard (Card card) {
		this.card = card;
		this.currentCooldown = card.cooldown;
		this.remainingCooldown = card.cooldown;
		this.currentManaCost = card.manaCost;
	}

	public void Initialise (Card card) {
		this.card = card;
		this.currentCooldown = card.cooldown;
		this.remainingCooldown = card.cooldown;
		this.currentManaCost = card.manaCost;
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

	public List<CardEffectName> GetEffects () {
		return card.cardEffectName;
	}

	public void Start() {
		ManaText.text = currentAttack.ToString();
		CoolDownTxt.text = currentHealth.ToString();
	}
}
