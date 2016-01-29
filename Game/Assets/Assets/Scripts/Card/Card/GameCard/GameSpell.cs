using UnityEngine;
using System.Collections;

public class GameSpell : GameCard {

	private CardEffectName cardEffectName;

	public GameSpell (Card card): base(card) {
		SpellCard sc = (SpellCard)card;
		cardEffectName = sc.cardEffectName;
	}

	public void Initialise (Card card){
		SetCard(card);
		SpellCard sc = (SpellCard)card;
		cardEffectName = sc.cardEffectName;
	}
}
