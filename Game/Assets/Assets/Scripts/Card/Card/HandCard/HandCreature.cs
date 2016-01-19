using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HandCreature : HandCard {

	private Card card;

	private int currentCooldown;
	private int remainingCooldown;
	private int currentManaCost;

	private int currentAttack;
	private int currentHealth;

	public Text AttackTxt;
	public Text HealthTxt;

	public HandCreature (CreatureCard card): base (card) {
		this.currentAttack = card.attack;
		this.currentHealth = card.health;
	}

	public void Initialise (CreatureCard card) {
		this.card = card;
		this.currentCooldown = card.cooldown;
		this.remainingCooldown = card.cooldown;
		this.currentManaCost = card.manaCost;
		this.currentAttack = card.attack;
		this.currentHealth = card.health;

	} 

	public void Start() {
		ManaText.text = currentManaCost.ToString();
		CoolDownTxt.text = currentCooldown.ToString();

		AttackTxt.text = currentAttack.ToString();
		HealthTxt.text = currentHealth.ToString();
	}
}
