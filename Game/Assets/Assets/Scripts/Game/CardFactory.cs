using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class CardFactory : MonoBehaviour {

	public static CardFactory Instance;

	public GameObject handSpell;
	public GameObject handCreature;
	public GameObject creature;
	public GameObject spell;

	void Awake () {
		if (Instance != null  && Instance != this){
			Destroy(gameObject);
		}
		Instance = this;
	}

	public void CreateHandCard (Card card){

		if (card.cardType == CardType.Creature){
			Debug.Log("Am a Creature");
			CreatureCard cCard = (CreatureCard)card;
			CreateHandCreature(cCard);
		}
			
	}

	public void CreateGameCreature (CreatureCard card) {
		GameObject go = Instantiate(creature);
		go.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
		GameCreature gc = go.GetComponent<GameCreature>();
		gc.Initialise(card);
	}

	public void CreateHandCreature (CreatureCard card) {
		GameObject go = Instantiate(handCreature);
		go.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
		HandCreature hc = go.GetComponent<HandCreature>();
		hc.Initialise(card);
	}

	public void CreateGameSpell (GameSpell card) {
		GameObject go = Instantiate(spell);
		go.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
		GameSpell gs = go.GetComponent<GameSpell>();
		gs.Initialise(card);
	}

	public void CreateHandSpell (GameSpell card) {
		GameObject go = Instantiate(spell);
		go.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
		HandSpell hs = go.GetComponent<HandSpell>();
		hs.Initialise(card);
	}
}
