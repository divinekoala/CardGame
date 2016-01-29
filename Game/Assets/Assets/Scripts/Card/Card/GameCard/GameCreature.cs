using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

/// <summary>
/// Wrapper class for creature cards when they are on the field.
/// This inherits from GameCard for the composition and uses the AttackAndHealth interface so it has all modifying behaviours necessary
/// </summary>
public class GameCreature : GameCard, AttackAndHealth {

	public Text AttackTxt;
	public Text HealthTxt;

	private int currentAttack;
	private int currentHealth;
	private CardEffectName cardEffectName;

	public GameCreature (Card card): base(card) {
		CreatureCard gc = (CreatureCard)card;
		currentAttack = gc.attack;
		currentHealth = gc.health;


	}

	public void DoAttack () {
		//ToDo
	}

	public void TakeAttack () {
		//ToDo
	}

	public int GetCurrentAttack() {
		return currentAttack;
	}

	public CardEffectName GetCardEffectName () {
		return cardEffectName;
	}

	public void SetCardEffectName(CardEffectName cen) {
		cardEffectName = cen;
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

	public void Start() {
		AttackTxt.text = currentAttack.ToString();
		HealthTxt.text = currentHealth.ToString();
	}

	public void Initialise (Card card) {
		SetCard(card);
		CreatureCard gc = (CreatureCard)card;
		currentAttack = gc.attack;
		currentHealth = gc.health;

	}
}
