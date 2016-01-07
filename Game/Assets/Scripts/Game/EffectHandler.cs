using UnityEngine;
using System.Collections.Generic;

public class EffectHandler {

	private List<Effect> registeredEffects = new List<Effect>();

	public List<Effect> GetRegisteredEffects () {
		return registeredEffects;
	}

	public void RegisterCardEffect(CardEffectName cen) {
		Effect eff = EffectMap.effects[cen];
    	registeredEffects.Add(eff);
    }

	public void DeregisterEffect (CardEffectName cen) {
		Effect eff = EffectMap.effects[cen];
    	registeredEffects.Remove(eff);
    }

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
