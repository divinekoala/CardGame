using UnityEngine;
using System.Collections;

/// <summary>
/// This class allows Effects and Attack to find Valid Targets for thier Action.
/// </summary>
public class ValidTarget {

    public Target target { get; set; }
    public Conditional conditional { get; set; }

    public ValidTarget(Target targ, Conditional condi) {
        target = targ;
        conditional = condi;
    }
}
