using UnityEngine;
using System.Collections;

public static class EffectCommands {

    public static void BuffAttack(GamePiece target, int value) {
        target.ModifyCurrentAttack(value);
    }

    public static void BuffHealth(GamePiece target, int value) {
        target.ModifyCurrentHealth(value);
    }

    public static void SetHealth(GamePiece target, int value) {
        target.SetCurrentHealth(value);
    }

    public static void SetAttack(GamePiece target, int value) {
        target.SetCurrentAttack(value);
    }
}
