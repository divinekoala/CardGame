using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class CardFactory : MonoBehaviour {

	public GameObject handCard;
	public GameObject creature;

//	public CreatureCard CreateCreatureCard (int attack, int health, string name, int manaCost, CardType cardType, List<CardEffectName> cfn, int coolDown){
//		CreatureCard cc = Instantiate(handCard).GetComponent<CreatureCard>();
//		cc.Initialise(attack, health, name, manaCost, cardType, cfn, coolDown);
//		return cc;
//	}

	public GameCreature CreateGameCreature (CreatureCard card) {
		GameCreature gc = Instantiate(creature).GetComponent<GameCreature>();
//		gc.transform.parent = GameObject.FindGameObjectWithTag("Canvas");
		gc.Initialise(card);
		return gc;
	}
}
