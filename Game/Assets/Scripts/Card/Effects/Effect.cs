using System.Collections;

/// <summary>
/// This is the base class for all Effects.
/// Provides values that are required by all Effects.
/// </summary>
public abstract class Effect  {
    private ValidTarget validTarget;
	private ResolveTiming resolveTiming;
	private TargetType targetType;

	//Must be implemented in specific effect using EffectCommands
	public abstract void ActivateEffect(GameCard target);

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
