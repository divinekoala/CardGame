using UnityEngine;
using System.Collections;
using System;

public class BuffAttackEffect : Effect {

	public int durationInTurns { get; set; }
	public int changeAttack { get; set; }
	public int changeHealth { get; set; }

	public override void ActivateEffect (GamePiece target) {
		EffectCommands.BuffAttack (target, changeAttack);
	}
}
