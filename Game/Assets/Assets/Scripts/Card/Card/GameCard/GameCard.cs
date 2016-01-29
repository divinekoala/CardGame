using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// This is the base class for all Game Cards. (While they are on the board).
/// This is for wrapping cards to give them extra functionaility while they are on the board through composition.
/// </summary>
public class GameCard : MonoBehaviour {
	
	private Card card { get; set; }

	public GameCard (Card card) {
		this.card = card;
	}

	public void SetCard (Card card){
		this.card = card;
	}

	public Card GetCard () {
		return card;
	}

}
