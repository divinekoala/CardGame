﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class HandCard : MonoBehaviour {

	private Card card {get; set;}

	private int currentCooldown;
	private int remainingCooldown;
	private int currentManaCost;


	public Text ManaText;
	public Text CoolDownTxt;

	public HandCard (Card card) {
		this.card = card;
		this.currentCooldown = card.cooldown;
		this.remainingCooldown = card.cooldown;
		this.currentManaCost = card.manaCost;
	} 

	public void SetCard (Card card) {
		this.card = card;
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

	public void GetManaCDField (Text mana, Text cooldown) {
		ManaText = mana;
		CoolDownTxt = cooldown;
	}

	public void SetText () {
		ManaText.text = currentManaCost.ToString();
		CoolDownTxt.text = currentCooldown.ToString();
	}
}
