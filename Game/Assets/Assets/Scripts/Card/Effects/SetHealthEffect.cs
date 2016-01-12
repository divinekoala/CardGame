using UnityEngine;
using System.Collections;
using System;

/// <summary>
/// Buff Effect to change the Health value of a Creature Card.
/// This inherits from the Effect class to get the values that this Effect require.
/// </summary>
public class SetHealthEffect : Effect {

    public int newHealthValue { get; set; }

    public SetHealthEffect(int newHealthValue) {
        this.newHealthValue = newHealthValue;
    }

	public override void ActivateEffect(GameCreature target) {
		EffectCommands.SetHealth (target, newHealthValue);
    }
}
