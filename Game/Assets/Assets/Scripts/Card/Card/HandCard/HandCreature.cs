using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HandCreature : HandCard {

	private CreatureCard cCard;

	private int currentAttack;
	private int currentHealth;

	public Text AttackTxt;
	public Text HealthTxt;

	public HandCreature (CreatureCard card): base (card) {
		this.cCard = card;
		this.currentAttack = cCard.attack;
		this.currentHealth = cCard.health;
	}

	public void Initialise (CreatureCard card) {
		SetCard(card);
		this.cCard = card;
		SetCurrentCooldown(card.cooldown);
		GoOnCooldown();
		SetCurrentManaCost(card.manaCost);
		this.currentAttack = cCard.attack;
		this.currentHealth = cCard.health;

	} 

	public void GetTextFields (Text mana, Text cooldown, Text attack, Text health) {
		ManaText = mana;
		CoolDownTxt = cooldown;
		AttackTxt = attack;
		HealthTxt = health;
	}

	public void Start() {
		SetText();

		AttackTxt.text = currentAttack.ToString();
		HealthTxt.text = currentHealth.ToString();
	}
}
