using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// This is the base class for all Cards.
/// Provides values that are required by all Cards.
/// </summary>
public abstract class Card {
	public string name { get; set; }
    public int manaCost { get; set; }
    public CardType cardType { get; set; }
    public List<CardEffectName> cardEffectName { get; set; }
    public int cooldown { get; set; }

	public Card (string name, int manaCost, CardType cardType, List<CardEffectName> cardEffectName, int coolDown) {
		this.name = name;
		this.manaCost = manaCost;
		this.cardType = cardType;
		this.cardEffectName = cardEffectName;
		this.cooldown = cooldown;
	}

}
