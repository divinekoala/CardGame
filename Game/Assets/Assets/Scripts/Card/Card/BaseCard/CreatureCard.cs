using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

/// <summary>
/// This is the base class for all Creature cards.
/// </summary>
public class CreatureCard : Card {
    public int attack { get; set; }
    public int health { get; set; }
	public bool isTapped { get; set; }

	public CreatureCard (int attack, int health, string name, int manaCost, CardType cardType, List<CardEffectName> cfn, int coolDown) : base(name, manaCost, cardType, cfn, coolDown) {
		this.attack = attack;
		this.health = health;
		isTapped = false;
	}

	public void Initialise (int _attack, int _health, string _name, int _manaCost, CardType _cardType, List<CardEffectName> _cfn, int _coolDown) {
		attack = _attack;
		health = _health;
		name = _name;
		manaCost = _manaCost;
		cardType = _cardType;
		cardEffectName = _cfn;
		cooldown = _coolDown;
	}
}