using UnityEngine;
using System.Collections;

/// <summary>
/// Enum of all possible targets for effects and attacks.
/// This is one part to the ValidTarget class.
/// </summary>
public enum Target {
	AlliedFollowers,
	You,
	YouAndAliedFollowers,
	EnemyFollowers,
	Enemy,
	EnemyAndEnemyFollowers,
	AllFollowers,
	YouAndEnemy,
	All
}
