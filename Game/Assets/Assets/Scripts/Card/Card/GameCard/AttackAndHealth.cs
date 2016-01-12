using System.Collections;

/// <summary>
/// This is an interface for pieces which require attack and health values and their required modifier functions
/// </summary>
public interface AttackAndHealth {

	int GetCurrentAttack();

	void ModifyCurrentAttack(int value);

	void SetCurrentAttack(int value);

	int GetCurrentHealth();

	void ModifyCurrentHealth(int value);

	void SetCurrentHealth(int value);
}
