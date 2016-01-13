using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class CardFactory : MonoBehaviour {

//	public GameObject handCard;
	public GameObject creature;

//	public CreatureCard CreateCreatureCard (int attack, int health, string name, int manaCost, CardType cardType, List<CardEffectName> cfn, int coolDown){
//		CreatureCard cc = Instantiate(handCard).GetComponent<CreatureCard>();
//		cc.Initialise(attack, health, name, manaCost, cardType, cfn, coolDown);
//		return cc;
//	}

	public GameCreature CreateGameCreature (CreatureCard card) {
		GameObject go = Instantiate(creature);
		go.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
		GameCreature gc = go.GetComponent<GameCreature>();
		gc.Initialise(card);
		return gc;
	}
}
