using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// Holds the Key Value Dictionary of the Effect Names and Effects.
/// These effects are now accessible to cards which hold only the name.
/// </summary>
public static class EffectDictionary {
    public static Dictionary<CardEffectName, Effect> effects = new Dictionary<CardEffectName, Effect>();
}
