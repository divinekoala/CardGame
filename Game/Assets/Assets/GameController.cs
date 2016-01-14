using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public Game game;
	public CardFactory cardFactory;

	public void Start () {
		cardFactory = GameObject.FindGameObjectWithTag("GameController").GetComponent<CardFactory>();
		game = GetComponent("Game") as Game;
		CreateDeck();
		ShuffleDeck(game.GetPlayer1());
	}

	public void CreateDeck() {
		CreatureCard c0 = new CreatureCard(3, 2, "Knight", 3, CardType.Creature, null, 0);
		CreatureCard c1 = new CreatureCard(3, 3, "Horse", 3, CardType.Creature, null, 0);
		CreatureCard c2 = new CreatureCard(1, 2, "Spearman", 1, CardType.Creature, null, 0);
		CreatureCard c3 = new CreatureCard(2, 1, "Bishop", 2, CardType.Creature, null, 0);
		CreatureCard c4 = new CreatureCard(2, 5, "King", 4, CardType.Creature, null, 0);

		game.GetPlayer1().AddCardToDeck(c0);
		game.GetPlayer1().AddCardToDeck(c1);
		game.GetPlayer1().AddCardToDeck(c2);
		game.GetPlayer1().AddCardToDeck(c3);
		game.GetPlayer1().AddCardToDeck(c4);
		game.GetPlayer1().AddCardToDeck(c0);
		game.GetPlayer1().AddCardToDeck(c1);
		game.GetPlayer1().AddCardToDeck(c2);
		game.GetPlayer1().AddCardToDeck(c3);


	}

	public void ShuffleDeck(Player player) {
		player.ShuffleDeck();
	}

	public void OnClickDrawCard (GameObject go) {
		if (go.name == "P1_Deck"){
			Card c = game.GetPlayer1().DrawCardFromDeck();
		}
		else {
			Card c = game.GetPlayer2().DrawCardFromDeck();
		}
	}
		
}
