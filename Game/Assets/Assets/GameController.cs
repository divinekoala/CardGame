using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public Game game;

	public CreatureCard c0;
	public CreatureCard c1;
	public CreatureCard c2;
	public CreatureCard c3;
	public CreatureCard c4;


	public void Start () {

		Card c0 = new CreatureCard(3, 2, "Knight", 3, CardType.Creature, null, 0);
		Card c1 = new CreatureCard(3, 3, "Horse", 3, CardType.Creature, null, 0);
		Card c2 = new CreatureCard(1, 2, "Spearman", 1, CardType.Creature, null, 0);
		Card c3 = new CreatureCard(2, 1, "Bishop", 2, CardType.Creature, null, 0);
		Card c4 = new CreatureCard(2, 5, "King", 4, CardType.Creature, null, 0);

		Player p1 = new Player(20, 5);
		Player p2 = new Player(20, 2);
		Game game = new Game(p1, p2);
		CreateDeck(game.GetPlayer1());
//		ShuffleDeck(game.GetPlayer1());
	}

//	public void InitPlayer() {
//		game.GetPlayer1().Initialise(20, 5);
//	}

	public void CreateDeck(Player player) {
		player.AddCardToDeck(c0);
//		player.AddCardToDeck(c1);
//		player.AddCardToDeck(c2);
//		player.AddCardToDeck(c3);
//		player.AddCardToDeck(c4);
//		player.AddCardToDeck(c0);
//		player.AddCardToDeck(c1);
//		player.AddCardToDeck(c2);
//		player.AddCardToDeck(c3);
		Debug.Log("Added Cards");
		Debug.Log(game.player1.maxhealth);
	}

	public void ShuffleDeck(Player player) {
		player.ShuffleDeck();
		Debug.Log("Shuffle Deck");
		foreach (Card c in player.deck){
			Debug.Log(c.name);
		}
	}

	public void OnClickDrawCard (GameObject go) {
		Debug.Log("Try Draw");
		if (go.name == "P1_Deck"){
			Debug.Log("In Player 1");
			Card c = game.GetPlayer1().DrawCardFromDeck();
			CardFactory.Instance.CreateHandCard(c);
			Debug.Log("P1 Draw");
		}
		else {
			Card c = game.GetPlayer2().DrawCardFromDeck();
			Debug.Log("P2 Draw");
		}
	}
		
}
