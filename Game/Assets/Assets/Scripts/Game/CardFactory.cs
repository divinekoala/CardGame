using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class CardFactory : MonoBehaviour {

	public static CardFactory Instance;

	public GameObject handCard;
	public GameObject handCreature;
	public GameObject creature;

	void Awake () {
		if (Instance != null  && Instance != this){
			Destroy(gameObject);
		}
		Instance = this;
	}

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

	public HandCreature CreateHandCreature (CreatureCard card) {
		GameObject go = Instantiate(handCreature);
		go.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
		HandCreature hc = go.GetComponent<HandCreature>();
		hc.Initialise(card);
		return hc;
	}
}
