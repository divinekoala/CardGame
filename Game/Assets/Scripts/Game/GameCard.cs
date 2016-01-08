using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// This is class which wraps the Card class using composition to be used by the Game.
/// This inherits from GamePiece.
/// </summary>
public class GameCard : GamePiece {
	public Card card { get{return card;} }

    private List<CardEffectName> cardEffectName = new List<CardEffectName>();

    public GameCard (Card card) {
        this.cardEffectName = card.cardEffectName;

        if(card.cardType == CardType.Creature) {
            CreatureCard convertedCard = card as CreatureCard;
            if(convertedCard != null) {
				SetCurrentAttack(convertedCard.attack);
                SetCurrentHealth(convertedCard.health);
            }
        }

    }
    public List<CardEffectName> GetCardEffect() {
    	return cardEffectName;
    }

    public void RemoveCardEffect() {
    	cardEffectName.Clear();
    }
}
