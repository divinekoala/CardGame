using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HandCreature : HandCard {

	private Card card;
	private CreatureCard cCard;

	private int currentCooldown;
	private int remainingCooldown;
	private int currentManaCost;

	private int currentAttack;
	private int currentHealth;

	public Text AttackTxt;
	public Text HealthTxt;

	public HandCreature (Card card): base (card) {
		this.card = card;
		cCard = (CreatureCard)card;
		this.currentAttack = cCard.attack;
		this.currentHealth = cCard.health;
	}

	public void Initialise (Card card) {
		this.card = card;
		this.cCard = (CreatureCard)card;
		this.currentCooldown = card.cooldown;
		this.remainingCooldown = card.cooldown;
		this.currentManaCost = card.manaCost;
		this.currentAttack = cCard.attack;
		this.currentHealth = cCard.health;

	} 

	public void Start() {
		ManaText.text = currentManaCost.ToString();
		CoolDownTxt.text = currentCooldown.ToString();

		AttackTxt.text = currentAttack.ToString();
		HealthTxt.text = currentHealth.ToString();
	}
}
