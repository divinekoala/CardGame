using UnityEngine;
using System.Collections;

public class TestScript : MonoBehaviour {

	// Use this for initialization
	void Start () {		
		CreatureCard cc = new CreatureCard(3, 2, "Knight", 3, CardType.Creature, null, 0);
		CardFactory.Instance.CreateGameCreature(cc);

	}
	

}
