using UnityEngine;
using System.Collections.Generic;

public class Card {
	public string name { get; set; }
    public int manaCost { get; set; }
    public CardType cardType { get; set; }
    public List<CardEffectName> cardEffectName { get; set; }
    public int cooldown { get; set; }
}
