using UnityEngine;
using System.Collections;

/// <summary>
/// This is the enum of all possible timings where Effects can occur.
/// This is part of the Effect class.
/// </summary>
public enum ResolveTiming {

	OnPlay,
	OnAlliedFollowerPlay,
	OnEnemyFollowerPlay,
	OnAllFollowerPlay,
	OnAlliedSpellPlay,
	OnEnemySpellPlay,
	OnAllSpellPlay,
	OnAlliedFollowerAttack,
	OnSelfAttack,
	OnEnemyAttack,
	OnAllAttack
}

