using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// This class holds the information of the Player and is useable by the Game to perform actions.
/// This inherits from GamePiece.
/// </summary>
public class Player : MonoBehaviour {
    private int maxhealth;
    private bool isHuman;
    private int maxMana;
    private int currentMana;
    private int remainingMana;

	public GameObject CardPrefab;

	public List<HandCard> hand = new List<HandCard>();
	public List<GameCard> board = new List<GameCard>();
	public List<Card> discardPile = new List<Card>();
	public List<Card> deck = new List<Card>();



    public void UseMana(int cost) {
        if(remainingMana >= cost)
            remainingMana -= cost;
    }

    public bool CheckMana(int cost) {
        if(remainingMana >= cost)
            return true;
        return false;
    }

    public void GainMana(int value) {
    	if(remainingMana + value <= currentMana){
    		remainingMana += value;
    	} else {
    		remainingMana = currentMana;
    	}
    }

    public void StartTurnMana() {
    	if (currentMana < maxMana){
    		currentMana += 1;
    	}
    	remainingMana = currentMana;
    }

	public void StartTurnCardCoolDown() {
		foreach (HandCard hc in hand){
			hc.ModifyCurrentCooldown(-1);
		}
	}

	public void AddCardFromHand (HandCard card) {
		hand.Add(card);
	}
		
	public void RemoveCardFromHand (HandCard card) {
		hand.Remove(card);
	}

	public List<GameCard> GetBoard () {
		return board;
	}

	public void AddToBoard (GameCard card) {
		board.Add(card);
	}

	public void RemoveFromBoard (GameCard card) {
		board.Remove(card);
	}

	public void DrawCardFromDeck () {
		Card card = deck[0];
		hand.Add(new HandCard(card));
		deck.Remove(card);
	}

	public void PutCardInGraveyard (Card card) {
		discardPile.Add(card);
	}


}
