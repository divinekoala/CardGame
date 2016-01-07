using UnityEngine;
using System.Collections;

public class ValidTarget {

    public Target target { get; set; }
    public Conditional conditional { get; set; }

    public ValidTarget(Target targ, Conditional condi) {
        target = targ;
        conditional = condi;
    }
}
