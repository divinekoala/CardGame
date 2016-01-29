using UnityEngine;
using System.Collections;

public class HandSpell : MonoBehaviour {

	public HandSpell (SpellCard card): base (card) {
		
	}

	public void Initialise (SpellCard card) {
		SetCard(card);
		this.cCard = card;
		SetCurrentCooldown(card.cooldown);
		GoOnCooldown();
		SetCurrentManaCost(card.manaCost);

}
