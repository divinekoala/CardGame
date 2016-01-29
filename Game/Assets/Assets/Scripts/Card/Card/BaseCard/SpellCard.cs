
public class SpellCard : Card {


	public CardEffectName cardEffectName { get; set;}

	public SpellCard (CardEffectName _cardEffectName, string name, int manaCost, CardType cardType, CardEffectName cfn, int coolDown) : base(name, manaCost, cardType, coolDown) {
		this.cardEffectName = _cardEffectName;
	}

	public void Initialise (CardEffectName _cardEffectName, string _name, int _manaCost, CardType _cardType, CardEffectName _cfn, int _coolDown) {
		this.cardEffectName = _cardEffectName;
		name = _name;
		manaCost = _manaCost;
		cardType = _cardType;
		cooldown = _coolDown;
	}
}
