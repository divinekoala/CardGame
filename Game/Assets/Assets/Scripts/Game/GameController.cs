using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public Game game;
	public Player p1 = new Player(20, 5, true);
	public Player p2 = new Player(20, 2, false);

	public CreatureCard c0;
	public CreatureCard c1;
	public CreatureCard c2;
	public CreatureCard c3;
	public CreatureCard c4;


	void Start () {

		CreatureCard c0 = new CreatureCard(3, 2, "Knight", 3, CardType.Creature, CardEffectName.Effect1, 0);
		SpellCard c1 = new SpellCard("Horse", 3, CardType.Spell, CardEffectName.Effect1, 1);
		SpellCard c2 = new SpellCard("Spearman", 1, CardType.Spell, CardEffectName.Effect1, 1);
		CreatureCard c3 = new CreatureCard(2, 1, "Bishop", 2, CardType.Creature, CardEffectName.Effect1, 0);
		CreatureCard c4 = new CreatureCard(2, 5, "King", 4, CardType.Creature, CardEffectName.Effect1, 0);

		Game game = new Game(p1, p2);

		p1.deck.Add(c1);
		p1.deck.Add(c0);
		p1.deck.Add(c2);
		p1.deck.Add(c3);
		p1.deck.Add(c4);
		p1.deck.Add(c1);
		p1.deck.Add(c0);
		p1.deck.Add(c2);
		p1.deck.Add(c3);

		p2.deck.Add(c1);
		p2.deck.Add(c0);
		p2.deck.Add(c2);
		p2.deck.Add(c3);
		p2.deck.Add(c4);
		p2.deck.Add(c1);
		p2.deck.Add(c0);
		p2.deck.Add(c2);
		p2.deck.Add(c3);

		ShuffleDeck(p1);
		ShuffleDeck(p2);
	}

	public void ShuffleDeck(Player player) {
		player.ShuffleDeck();
		Debug.Log("Shuffle Deck");
	}

	public void OnClickDrawCard (GameObject go) {
		if (go.name == "P1_Deck"){
			Debug.Log("In Player 1");
			Card c = p1.DrawCardFromDeck();
			CardFactory.Instance.CreateHandCard(c, p1);
			Debug.Log("P1 Draw");
		}
		else if (go.name == "P2_Deck"){
			Debug.Log("In Player 2");
			Card c = p2.DrawCardFromDeck();
			CardFactory.Instance.CreateHandCard(c, p2);
			Debug.Log("P2 Draw");
		}
	}

	public void OnClickPlayFromHand () {
		
	}
		
}
