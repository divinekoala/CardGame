using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class CardFactory : MonoBehaviour {

	public GameObject handCard;
	public GameObject creature;

	public HandCard CreateHandCard (Card card){
		GameObject go = Instantiate(handCard);
		go.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
		HandCard hc = go.GetComponent<HandCard>();
		hc.Initialise(card);
		return hc;
	}

	public GameCreature CreateGameCreature (CreatureCard card) {
		GameObject go = Instantiate(creature);
		go.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
		GameCreature gc = go.GetComponent<GameCreature>();
		gc.Initialise(card);
		return gc;
	}
}
