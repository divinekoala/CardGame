using UnityEngine;
using System.Collections;

public class TestScript : MonoBehaviour {

	// Use this for initialization
	void Start () {		
		CardFactory cf = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CardFactory>();
		CreatureCard cc = new CreatureCard(3, 2, "Knight", 3, CardType.Creature, null, 0);
		cf.CreateGameCreature(cc);

	}
	

}
