using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class CardFactory : MonoBehaviour {

	public static CardFactory Instance;

	public GameObject manaCooldownCard;
	public GameObject allStatsCard;
	public GameObject attackHealthCard;

	public Text attackTxt;
	public Text healthTxt;
	public Text manaTxt;
	public Text cooldownTxt;

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

		else if (card.cardType == CardType.Spell){
			Debug.Log("Am a Spell");
			SpellCard sCard = (SpellCard)card;
			CreateHandSpell(sCard);
		}
			
	}

	public void CreateGameCreature (Card card) {
		GameObject go = Instantiate(attackHealthCard);
		go.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
		GameCreature gc = go.AddComponent<GameCreature>() as GameCreature;
		GetText(attackHealthCard);
//		hs.GetTextFields(manaTxt, cooldownTxt);
		gc.Initialise(card);
	}

	public void CreateGameSpell (Card card) {
		GameObject go = Instantiate(manaCooldownCard);
		go.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
		GameSpell gs = go.AddComponent<GameSpell>() as GameSpell;
		GetText(manaCooldownCard);
//		gs.GetTextFields(manaTxt, cooldownTxt);
		gs.Initialise(card);
	}


	public void CreateHandCreature (CreatureCard card) {
		GameObject go = Instantiate(allStatsCard);
		go.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
		HandCreature hc = go.AddComponent<HandCreature>() as HandCreature;
		GetText(allStatsCard);
		hc.GetTextFields(manaTxt, cooldownTxt, attackTxt, healthTxt);
		hc.Initialise(card);
	}

	public void CreateHandSpell (SpellCard card) {
		GameObject go = Instantiate(manaCooldownCard);
		go.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
		HandSpell hs = go.AddComponent<HandSpell>() as HandSpell;
		GetText(manaCooldownCard);
		hs.GetTextFields(manaTxt, cooldownTxt);
		hs.Initialise(card);
	}

	public void GetText (GameObject go) {
		Component[] textGO = go.GetComponentsInChildren<Text>();
		foreach ( Text t in textGO) {
			
			if (t.name == "attack"){
				attackTxt = t.GetComponent<Text>();
			}
			if (t.name == "health"){
				healthTxt = t.GetComponent<Text>();
			}
			if (t.name == "mana"){
				manaTxt = t.GetComponent<Text>();
			}
			if (t.name == "cooldown"){
				cooldownTxt = t.GetComponent<Text>();
			}
		}
	}
}
