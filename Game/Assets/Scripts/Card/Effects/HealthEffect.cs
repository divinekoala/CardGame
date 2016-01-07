using UnityEngine;
using System.Collections;
using System;

public class HealthEffect : Effect {

    public int healthChange { get; set; }

    public HealthEffect(int healthChange) {
        this.healthChange = healthChange;
    }

    public override void ActivateEffect(GamePiece target) {
        throw new NotImplementedException();
    }
}
