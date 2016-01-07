using UnityEngine;
using System.Collections;

/// <summary>
/// This is the enum of conditions to be met by Card Effects for finding Valid Targets.
/// This is part of the ValidTarget class.
/// </summary>
public enum Conditional {
	None,
	FullHealth,
	Damaged,
	Buffed
}
