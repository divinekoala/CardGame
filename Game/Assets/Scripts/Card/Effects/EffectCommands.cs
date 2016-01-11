using UnityEngine;
using System.Collections;

/// <summary>
/// Calls the functions that should be called when an Effect occurs.
/// </summary>
public static class EffectCommands {

	public static void BuffAttack(GameCreature target, int value) {
        target.ModifyCurrentAttack(value);
    }

	public static void BuffHealth(GameCreature target, int value) {
        target.ModifyCurrentHealth(value);
    }

	public static void SetHealth(GameCreature target, int value) {
        target.SetCurrentHealth(value);
    }

	public static void SetAttack(GameCreature target, int value) {
        target.SetCurrentAttack(value);
    }
}
