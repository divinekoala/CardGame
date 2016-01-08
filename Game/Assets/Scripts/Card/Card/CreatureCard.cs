using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

/// <summary>
/// This is the class for all Creature cards.
/// Inheriting from the Card class.
/// </summary>
public class CreatureCard : Card {
    public int attack { get; set; }
    public int health { get; set; }
	public bool isTapped { get; set; }
}
