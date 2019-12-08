using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatMeatBehaviour : EatBehaviour
{
    protected override void EatFood()
    {
        Debug.Log("I eat meat");
    }
}
