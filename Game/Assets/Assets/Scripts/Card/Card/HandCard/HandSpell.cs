using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HandSpell : HandCard {

	private SpellCard sCard;

	public HandSpell (SpellCard card): base (card) {
		this.sCard = card;
	}

	public void Initialise (SpellCard card) {
		SetCard(card);
		this.sCard = card;
		SetCurrentCooldown(card.cooldown);
		GoOnCooldown();
		SetCurrentManaCost(card.manaCost);
	}

	public void Start() {
		SetText();
	}
}
