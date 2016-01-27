using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// This class holds the information of the Player and is useable by the Game to perform actions.
/// This inherits from GamePiece.
/// </summary>
public class Player {
    public int maxhealth;
	public int currentHealth;
    private bool isHuman;
    private int maxMana;
    private int currentMana;
    private int remainingMana;


	private List<HandCard> hand = new List<HandCard>();
	private List<GameCard> board = new List<GameCard>();
	private List<Card> discardPile = new List<Card>();
	public List<Card> deck = new List<Card>();

	public Player (int maxHealth, int maxMana){
		this.maxhealth = maxHealth;
		this.currentHealth = maxHealth;
		this.isHuman = true;
		this.maxMana = maxMana;
		this.currentMana = maxMana;
		this.remainingMana = maxMana;
		deck = new List<Card>();
		discardPile = new List<Card>();
		board = new List<GameCard>();
		hand = new List<HandCard>();
	}

	public void Initialise (int maxHealth, int maxMana){
		this.maxMana = maxHealth;
		this.currentHealth = maxHealth;
		this.isHuman = true;
		this.maxMana = maxMana;
		this.currentMana = maxMana;
		this.remainingMana = maxMana;
		deck = new List<Card>();
		discardPile = new List<Card>();
		board = new List<GameCard>();
		hand = new List<HandCard>();
	}
		
	public int GetHealth() {
		return maxhealth;
	}

	public List<Card> GetDeck(){
		return deck;
	}

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

	public void AddCardToHand (HandCard card) {
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

	public Card DrawCardFromDeck () {
		Card card  = deck[0];
		deck.RemoveAt(0);
		return card;
	}

	public void PutCardInGraveyard (Card card) {
		discardPile.Add(card);
	}

	public void AddCardToDeck (Card card) {
		deck.Add(card);
	}

	public void ShuffleDeck () {
		for (int i = deck.Count -1; i > 0; i--) {
			int k = Random.Range(0, i);
			Card temp = deck[k];
			deck[k] = deck[i];
			deck[i] = temp;
		}
	}

}
