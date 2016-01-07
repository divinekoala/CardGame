using UnityEngine;
using System.Collections;
using System;

/// <summary>
/// Buff Effect to change the Attack value of a Creature Card.
/// This inherits from the Effect class to get the values that this Effect require.
/// </summary>
public class ModifyAttackEffect : Effect {

	public int changeAttack { get; set; }

	public ModifyAttackEffect (int changeAttack) {
		this.changeAttack = changeAttack;
	}

	public override void ActivateEffect (GamePiece target) {
		EffectCommands.BuffAttack (target, changeAttack);
	}
}
	
