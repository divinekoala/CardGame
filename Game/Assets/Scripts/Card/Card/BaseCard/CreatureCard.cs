using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

/// <summary>
/// This is the base class for all Creature cards.
/// </summary>
public class CreatureCard : Card {
    public int attack { get; set; }
    public int health { get; set; }
	public bool isTapped { get; set; }
}
