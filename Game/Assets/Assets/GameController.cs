using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	private Player player;
	private EffectHandler effectHandler;
	private TurnHandler turnHandler;
	private Game game;
	public CardFactory cardFactory;

	public CreatureCard c0;
	public CreatureCard c1;
	public CreatureCard c2;
	public CreatureCard c3;
	public CreatureCard c4;


	void Awake() {
		player = new Player(20, 5);
		effectHandler = EffectHandler();
		turnHandler = TurnHandler();
		game = Game(player, player, effectHandler, turnHandler);
	}

	public void Start () {

		CreatureCard c0 = new CreatureCard(3, 2, "Knight", 3, CardType.Creature, null, 0);
		CreatureCard c1 = new CreatureCard(3, 3, "Horse", 3, CardType.Creature, null, 0);
		CreatureCard c2 = new CreatureCard(1, 2, "Spearman", 1, CardType.Creature, null, 0);
		CreatureCard c3 = new CreatureCard(2, 1, "Bishop", 2, CardType.Creature, null, 0);
		CreatureCard c4 = new CreatureCard(2, 5, "King", 4, CardType.Creature, null, 0);

		cardFactory = GameObject.FindGameObjectWithTag("GameController").GetComponent<CardFactory>();
		game = GetComponent("Game") as Game;
		CreateDeck(game.GetPlayer1());
		ShuffleDeck(game.GetPlayer1());
	}

	public void CreateDeck(Player player) {
		player.AddCardToDeck(c0);
		player.AddCardToDeck(c1);
		player.AddCardToDeck(c2);
		player.AddCardToDeck(c3);
		player.AddCardToDeck(c4);
		player.AddCardToDeck(c0);
		player.AddCardToDeck(c1);
		player.AddCardToDeck(c2);
		player.AddCardToDeck(c3);


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
