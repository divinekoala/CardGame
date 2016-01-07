using UnityEngine;
using System.Collections;

public abstract class Effect  {
    private ValidTarget validTarget;
	private ResolveTiming resolveTiming;
	private TargetType targetType;

    public abstract void ActivateEffect(GamePiece target);

    public ValidTarget GetValidTarget () {
    	return validTarget;
    }

    public void SetValidTarget (ValidTarget vt) {
    	validTarget = vt;
    }

    public ResolveTiming GetResolveTiming () {
    	return resolveTiming;
    }

    public void SetResolveTiming (ResolveTiming rt) {
    	resolveTiming = rt;
    }

    public TargetType GetTargetType () {
    	return targetType;
    }

    public void SetTargetType (TargetType tt) {
    	targetType = tt;
    }
}
