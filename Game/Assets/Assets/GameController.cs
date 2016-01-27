using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public Game game;
	public Player p1 = new Player(20, 5);
	public Player p2 = new Player(20, 2);

	public CreatureCard c0;
	public CreatureCard c1;
	public CreatureCard c2;
	public CreatureCard c3;
	public CreatureCard c4;


	public void Start () {

		CreatureCard c0 = new CreatureCard(3, 2, "Knight", 3, CardType.Creature, null, 0);
		CreatureCard c1 = new CreatureCard(3, 3, "Horse", 3, CardType.Creature, null, 0);
		CreatureCard c2 = new CreatureCard(1, 2, "Spearman", 1, CardType.Creature, null, 0);
		CreatureCard c3 = new CreatureCard(2, 1, "Bishop", 2, CardType.Creature, null, 0);
		CreatureCard c4 = new CreatureCard(2, 5, "King", 4, CardType.Creature, null, 0);




		Game game = new Game(p1, p2);
		Debug.Log("Player 1 health :" + p1.GetHealth());


		p1.deck.Add(c1);
		p1.deck.Add(c0);
		p1.deck.Add(c2);
		p1.deck.Add(c3);
		p1.deck.Add(c4);
		Debug.Log(p1.GetDeck()[1].name);

//		ShuffleDeck(game.GetPlayer1());
	}


	public void ShuffleDeck(Player player) {
		player.ShuffleDeck();
		Debug.Log("Shuffle Deck");
		foreach (Card c in player.GetDeck()){
			Debug.Log(c.name);
		}
	}

	public void OnClickDrawCard (GameObject go) {
		Debug.Log("Try Draw");
		if (go.name == "P1_Deck"){
			Debug.Log("In Player 1");
			Card c = p1.DrawCardFromDeck();
			CardFactory.Instance.CreateHandCard(c);
			Debug.Log("P1 Draw");
		}
		else {
			Card c = game.GetPlayer2().DrawCardFromDeck();
			Debug.Log("P2 Draw");
		}
	}
		
}
