using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// This is a class which handles active effects which require a certain timing to play.
/// </summary>
public class EffectHandler {

	private List<Effect> registeredEffects = new List<Effect>();

	public List<Effect> GetRegisteredEffects () {
		return registeredEffects;
	}

	public void RegisterCardEffect(CardEffectName cen) {
		Effect eff = EffectDictionary.effects[cen];
    	registeredEffects.Add(eff);
    }

	public void DeregisterEffect (CardEffectName cen) {
		Effect eff = EffectDictionary.effects[cen];
    	registeredEffects.Remove(eff);
    }

	public bool IsThereRegisteredEffect () {
		if(registeredEffects.Count > 0)
			return true;
		else 
			return false;
	}

	// This will be called whenever an action if there are any registered effects.
    public List<Effect> GetActiveEffects (ResolveTiming rt) {
		List<Effect> e = new List<Effect>();
    	foreach(Effect re in registeredEffects) {
    		if(re.GetResolveTiming() == rt) {
    			e.Add(re);
    		}
    	}
    	return e;
    }
}
