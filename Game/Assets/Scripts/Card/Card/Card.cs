using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// This is the base class for all Cards.
/// Provides values that are required by all Cards.
/// </summary>
public class Card {
	public string name { get; set; }
    public int manaCost { get; set; }
    public CardType cardType { get; set; }
    public List<CardEffectName> cardEffectName { get; set; }
    public int cooldown { get; set; }
}
