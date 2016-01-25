using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HandCreature : HandCard {

	private CreatureCard cCard;

	private int currentAttack;
	private int currentHealth;

	public Text AttackTxt;
	public Text HealthTxt;

	public HandCreature (Card card): base (card) {
		cCard = (CreatureCard)card;
		this.currentAttack = cCard.attack;
		this.currentHealth = cCard.health;
	}

	public void Initialise (Card card) {
		SetCard(card);
		this.cCard = (CreatureCard)card;
		SetCurrentCooldown(card.cooldown);
		GoOnCooldown();
		SetCurrentManaCost(card.manaCost);
		this.currentAttack = cCard.attack;
		this.currentHealth = cCard.health;

	} 

	public void Start() {
		SetText();

		AttackTxt.text = currentAttack.ToString();
		HealthTxt.text = currentHealth.ToString();
	}
}
