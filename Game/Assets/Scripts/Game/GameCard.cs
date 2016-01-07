﻿using UnityEngine;
using System.Collections.Generic;

public class GameCard : GamePiece {
    private Card card;

    private int currentCooldown;
    private int remainingCooldown;
    private int currentManaCost;
    private CardType cardType;
    private List<CardEffectName> cardEffectName = new List<CardEffectName>();

    public GameCard (Card card) {
        this.currentCooldown = card.cooldown;
        this.remainingCooldown = card.cooldown;
        this.currentManaCost = card.manaCost;
        this.cardEffectName = card.cardEffectName;

        if(card.cardType == CardType.Follower) {
            FollowerCard convertedCard = card as FollowerCard;
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

    public int GetCurrentCooldown () {
    	return currentCooldown;
    }

    public void ModifyCurrentCooldown (int value) {
    	currentCooldown += value;
    }

    public void SetCurrentCooldown (int value){
    	currentCooldown = value;
    }

    public int GetCurrentManaCost() {
    	return currentManaCost;
    }

	public void ModifyCurrentManaCost (int value) {
		currentManaCost += value;
	}

	public void SetCurrentManaCost (int value) {
		currentManaCost = value;
	}

	public CardType GetCardType () {
		return cardType;
	}

	public void GoOnCooldown(){
		remainingCooldown = currentCooldown;
	}

	public void GoOffCooldown() {
		remainingCooldown = 0;
	}
}
